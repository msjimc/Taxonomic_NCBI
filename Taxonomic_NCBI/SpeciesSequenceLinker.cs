using System;
using System.Collections;
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
    struct blastLine
    {
        public List<string> lineData;
        public string ID;
        //public string speciedname;
        public double comparisonValue;
    }

    public partial class SpeciesSequenceLinker : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();

        bool filterByHitQuality = false;
        private List<string> specieslist = new List<string>();
        private List<string> specieslistNot = new List<string>();
        bool filterByList = false;


        public SpeciesSequenceLinker()
        {
            InitializeComponent();
            setActivity(false);
        }

        private void setActivity(bool state)
        {
            gbQuality.Enabled = state;
            gbList.Enabled = state;
            cboFastaName.Enabled = state;
            btnCreate.Enabled = state;
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
            string filename = FileString.OpenAs("Select expected species list file", "Text file (*.txt;*.xls;*.csv)|*.txt;*.xls;*.csv");
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

        private void btnListNotIn_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select expected species list file", "Text file (*.txt;*.xls;*.csv)|*.txt;*.xls;*.csv");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader sf = null;
            specieslistNot = new List<string>();

            try
            {
                sf = new System.IO.StreamReader(filename);
                string line;
                while (sf.Peek() > 0)
                {
                    line = sf.ReadLine();
                    specieslistNot.Add(line.Trim().ToLower());
                }
                specieslistNot.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                specieslistNot = new List<string>();
            }
            finally { sf?.Close(); }
            setbtnFilterActivity();
        }

        private void btnClearInList_Click(object sender, EventArgs e)
        {
            specieslist = new List<string>();
            setbtnFilterActivity();
        }

        private void btnNotInList_Click(object sender, EventArgs e)
        {
            specieslistNot = new List<string>();
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
            btnList.Enabled = chkList.Checked;
            btnListNotIn.Enabled = chkList.Checked;
            btnClearInList.Enabled = chkList.Checked;
            btnClearNotInList.Enabled = chkList.Checked;
            cboSpeciesName.Enabled = chkList.Checked;
            setbtnFilterActivity();
        }

        private void setbtnFilterActivity()
        {
            int answerHit = 0;
            if (cboColumnToFilter.SelectedIndex != 0) { answerHit++; }
            if (rdoLowerThanCutOff.Checked || rdoHigherThanCutOff.Checked) { answerHit++; }
            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue)) { answerHit++; }
            filterByHitQuality = ((answerHit == 3) && (chkHitQuality.Checked == true));

            int answerList = 0;
            if (specieslist.Count + specieslistNot.Count > 0) { answerList++; }
            if (cboSpeciesName.SelectedIndex > 0) { answerList++; }
            filterByList = ((answerList == 2) && (chkList.Checked == true));

            btnCreate.Enabled = (cboFastaName.SelectedIndex > 0);
            if (chkHitQuality.Checked == true && filterByHitQuality == false) { btnCreate.Enabled = false; }
            if (chkList.Checked == true && filterByList == false) { btnCreate.Enabled = false; }
            if (filterByList == false && filterByHitQuality == false) { btnCreate.Enabled = false; }
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

        private void cboSpeciesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = FileString.SaveAs("Enter the name of the file to save the data to", "Text file (*.txt)|*.txt");
            if (filename == "Cancel") { return; }

            double cutoffValue = 0;
            if (filterByHitQuality == true && double.TryParse(txtCutOff.Text, out cutoffValue) == false) { return; }

            int idIndex = cboFastaName.SelectedIndex - 1;
            int blastIndex = cboColumnToFilter.SelectedIndex - 1;
            int nameIndex = cboSpeciesName.SelectedIndex - 1;
            bool higher = !rdoLowerThanCutOff.Checked;

            Dictionary<string, blastLine> blastLines = new Dictionary<string, blastLine>();

            foreach (List<string> row in data)
            {
                string id = row[idIndex];
                double testValue = 0;

                if (filterByHitQuality == true)
                {
                    if (double.TryParse(row[blastIndex], out testValue) == false)
                    { continue; }
                    if (higher == true && cutoffValue > testValue)
                    { continue; }
                    else if (higher == false && cutoffValue < testValue)
                    { continue; }
                }

                string inList = "";
                if (filterByList == true)
                {
                    if (specieslist.Count > 0)
                    {
                        if (specieslist.Contains(row[nameIndex].ToLower()) == false)
                        { continue; }
                    }
                    if (specieslistNot.Contains(row[nameIndex].ToLower()) == true)
                    { continue; }
                }


                if (blastLines.ContainsKey(id) == true && filterByHitQuality == true)
                {
                    if (higher == true && blastLines[id].comparisonValue <= testValue)
                    { continue; }
                    else if (higher == false && blastLines[id].comparisonValue >= testValue)
                    { continue; }
                    blastLine bl = new blastLine();
                    bl.ID = id;
                    bl.lineData = row;
                    bl.comparisonValue = testValue;
                    blastLines[id] = bl;
                }
                else
                {
                    blastLine bl = new blastLine();
                    bl.ID = id;
                    bl.lineData = row;
                    bl.comparisonValue = testValue;
                    blastLines.Add(id, bl);
                }
            }

            System.IO.StreamWriter fs = null;

            try
            {
                fs = new System.IO.StreamWriter(filename);

                fs.Write(string.Join("\t", headers) + "\n");

                foreach (blastLine bl in blastLines.Values)
                {
                    string line = string.Join("\t", bl.lineData) + "\n";
                    fs.Write(line);
                }

            }
            catch (Exception ex) { MessageBox.Show("An error occured creating the file: " + ex.Message, "Error"); }
            finally { fs?.Close(); }

        }
        private void btnSelectDataFile_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select annotated BLAST hit file", "tab delimited Text file (*.txt;*.csv:*.xls)|*.txt;*.csv:*.xls");
            if (System.IO.File.Exists(filename) == false) { return; }


            setActivity(false);

            System.IO.StreamReader sf = null;

            data = new List<List<string>>();
            try
            {
                sf = new System.IO.StreamReader(filename);

                string line = sf.ReadLine();
                line = line.Replace("\"", "");
                string[] items;
                char splitOn = ',';
                string extension = filename.Substring(filename.LastIndexOf('.')).ToLower();
                if (extension == ".xls" || extension == ".txt")
                { splitOn = '\t'; }
                else
                { splitOn = ','; }

                items = line.Split(splitOn);
                headers = items.ToList();

                while (sf.Peek() > 0)
                {
                    line = sf.ReadLine();
                    line = line.Replace("\"", "");
                    items = line.Split(new char[] { splitOn });

                    List<string> itemList = items.ToList();
                    data.Add(itemList);
                }

                setActivity(data.Count > 0);

                setCboLists(cboSpeciesName, headers);
                setCboLists(cboColumnToFilter, headers);
                setCboLists(cboFastaName, headers);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                return;
            }
            finally
            { sf?.Close(); }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }       
}
