using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace Taxonomic_NCBI
{
    public partial class SpeciesSequenceLinker : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;
        bool filterByHitQuality = false;
        private List<string> specieslist = new List<string>();
        bool filterByList = false;

        public SpeciesSequenceLinker(FilterData FD, List<string> Headers, List<List<string>> Data)
        {
            InitializeComponent();

            foreach (List<string> row in Data)
            { data.Add(new List<string>(row)); }
            headers = new List<string>(Headers);

            setCboLists(cboSpeciesName, headers);
            setCboLists(cboColumnToFilter, headers);
            setCboLists(cboSpeciesfilter, headers);
            setCboLists(cboFastaName,headers);
            fd = FD;
        }

        private void setCboLists(ComboBox cbo, List<string> values)
        {
            int index = 0;
            if (cbo.Items.Count > 0)
            { index = cbo.SelectedIndex; }
            if (index < 0) { index = 0; }
            cbo.Items.Clear();
            cbo.Items.Add("Select");
            cbo.Items.AddRange(values.ToArray());
            if (cbo.Items.Count > index)
            { cbo.SelectedIndex = index; }
            else { cbo.SelectedIndex = 0; }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select species list file", "Text file (*.txt;*.xls;*.csv)|*.txt;*.xls;*.csv");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader sf = null;
            specieslist = new List<string>();

            try
            {
                sf = new System.IO.StreamReader(filename);
                string line;
                while (sf.Peek() > 0)
                {
                    line = sf.ReadLine();
                    specieslist.Add(line.Trim().ToLower());
                }
                specieslist.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                specieslist = new List<string>();
            }
            finally { sf?.Close(); }
            setbtnFilterActivity();
        }

        private void txtCutOff_TextChanged(object sender, EventArgs e)
        {
            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue) == false)
            { lblFilterCutOff.Visible = true; }
            else
            {
                lblFilterCutOff.Visible = false;                
            }
            setbtnFilterActivity();
        }
        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

        private void chkHitQuality_CheckedChanged(object sender, EventArgs e)
        {

            cboColumnToFilter.Enabled = chkHitQuality.Checked;
            txtCutOff.Enabled = chkHitQuality.Checked;
            rdoHigherThanCutOff.Enabled = chkHitQuality.Checked;
            rdoLowerThanCutOff.Enabled = chkHitQuality.Checked;
            setbtnFilterActivity();
        }

        private void chkList_CheckedChanged(object sender, EventArgs e)
        {
            cboSpeciesfilter.Enabled = chkList.Checked;
            btnList.Enabled = chkList.Checked;
            setbtnFilterActivity();
        }

        private void setbtnFilterActivity()
        {
            int answerHit = 0;
            if (cboColumnToFilter.SelectedIndex != 0) { answerHit++; }
            if (rdoLowerThanCutOff.Checked || rdoHigherThanCutOff.Checked) { answerHit++; }
            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue)) { answerHit++; }
            filterByHitQuality = (answerHit == 3);

            int answerList = 0;
            if (specieslist.Count > 0) { answerList++; }
            if (cboSpeciesfilter.SelectedIndex > 0) { answerList++; }
            filterByList = (answerList == 3);

            btnCreate.Enabled = ((cboFastaName.SelectedIndex > 0) && (cboSpeciesName.SelectedIndex > 0));
            if (chkHitQuality.Checked == true && filterByHitQuality == false) { btnCreate.Enabled = false; }
            if (chkList.Checked == true && filterByList == false) { btnCreate.Enabled = false; }

        }

        private void rdoHigherThanCutOff_CheckedChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void cboColumnToFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void rdoLowerThanCutOff_CheckedChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void cboSpeciesfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void cboFastaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = FileString.SaveAs("Entar the name of the file to save the data to", "Text file (*.txt)|*.txt");
            if (filename == "Cancel") { return; }

            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue) == false) { return; }

            int idIndex = cboFastaName.SelectedIndex - 1;
            int blastIndex = cboColumnToFilter.SelectedIndex - 1;
            int speciesColumnIndex = cboSpeciesfilter.SelectedIndex - 1;
            int nameIndex = cboSpeciesName.SelectedIndex - 1;
            bool higher = rdoHigherThanCutOff.Checked; 
            Dictionary<string, SequenceHit> dataToProcess = new Dictionary<string, SequenceHit>();

            foreach(List<string> row in data)
            {
                double testValue = 0;
                string testValueString = "";
                if (filterByHitQuality == true)
                {
                    if (double.TryParse(row[blastIndex], out testValue) == false)
                    { continue; }
                    if (higher == true && cutoffValue > testValue) 
                    { continue; }
                    else if (higher == false && cutoffValue < testValue) 
                    { continue; }
                    testValueString = row[blastIndex];
                }
                
                string id = row[idIndex];
                if (dataToProcess.ContainsKey(id) == true)
                { dataToProcess[id].AddnewHit(row[nameIndex], testValue, testValueString); }
                else
                {
                    SequenceHit sh = new SequenceHit(id, row[nameIndex], testValue, testValueString, higher, filterByHitQuality, filterByList);
                    dataToProcess.Add(id, sh);
                }
            }

            List<string> keys = new List<string>();
            Dictionary<string, List<SequenceHit>> dataBySpecies = new Dictionary<string, List<SequenceHit>>();
            foreach (SequenceHit sh in dataToProcess.Values)
            {
                sh.SortData();
                string firstname = sh.FirstName();
                if (dataBySpecies.ContainsKey(firstname) == false)
                { 
                    dataBySpecies[firstname] = new List<SequenceHit>();
                    keys.Add(firstname);
                }
                dataBySpecies[firstname].Add(sh);
            }

            keys.Sort();


            System.IO.StreamWriter fs = null;

            try
            {
                fs = new System.IO.StreamWriter(filename);

                foreach (string key in keys)
                {
                    List<SequenceHit> shs = dataBySpecies[key];
                    foreach (SequenceHit sh in shs)
                    {
                        fs.Write(sh.ID + "\t");
                        foreach (NameHit nh in sh.Data)
                        {
                            fs.Write(nh.Name + ", " + nh.HitString + "\t");
                        }
                        fs.Write("\n");
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show("An error occured creating the file: " + ex.Message, "Error"); }
            finally { fs?.Close(); }

        }
    }
}
