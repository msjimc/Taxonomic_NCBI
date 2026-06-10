using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxonomic_NCBI
{
    public partial class FilterWithList : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;

        public FilterWithList(FilterData FD, List<string> Headers, List<List<string>> Data)
        {
            InitializeComponent();

            data = Data;
            headers = Headers;
            setCboLists(cboSpeciesfilter, headers);
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

        private void btnSelectSpeciesList_Click(object sender, EventArgs e)
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
            SetBtnCOmpareActivity();
        }

        private void rdoRemoveIfInList_CheckedChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
        }

        private void rdoKeepIfInList_CheckedChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
        }

        private void rboFlagInList_CheckedChanged(object sender, EventArgs e)
        {
            txtFlaggedColoumnName.Enabled = rboFlagInList.Checked;
            SetBtnCOmpareActivity();
        }

        private void txtFlaggedColoumnName_TextChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
        }
        private void cboSpeciesfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
        }

        private List<string> specieslist = new List<string>();
        private void SetBtnCOmpareActivity()
        {
            int answer = 0;
            if (specieslist.Count > 0) { answer++; }
            if (rdoRemoveIfInList.Checked || rdoKeepIfInList.Checked) { answer++; }
            else if (rboFlagInList.Checked && txtFlaggedColoumnName.Text.Trim() != "") { answer++; }
            if (cboSpeciesfilter.SelectedIndex > 0) { answer++; }
            btnCompare.Enabled = (answer == 3);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (rboFlagInList.Checked == true)
            { FlagIfInList(); }
            else
            { RemoveKeepIfInList(); }

            SetBtnCOmpareActivity();
        }

        private void FlagIfInList()
        {
            int index = cboSpeciesfilter.SelectedIndex - 1;
            List<List<string>> newdata = new List<List<string>>();

            int InList = 0; int NotInList = 0;

            foreach (List<string> dataRow in data)
            {
                if (dataRow.Count > index)
                {
                    string value = dataRow[index].Trim();
                    List<string> newDataRow = new List<string>();
                    newDataRow.AddRange(dataRow);

                    if (specieslist.Contains(value.ToLower()))
                    {
                        newDataRow.Add("In List");
                        InList++;
                    }
                    else
                    {
                        newDataRow.Add("Not in List");
                        NotInList++;
                    }
                    newdata.Add(newDataRow);
                }

            }

            if (MessageBox.Show("Filtering complete. " + NotInList.ToString() + " rows not in list, " + InList.ToString() + " rows in list.\nDo you want to keep this data set", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                headers.Add(txtFlaggedColoumnName.Text.Trim());
                data = newdata;
            }

        }
        private void RemoveKeepIfInList()
        {
            int index = cboSpeciesfilter.SelectedIndex - 1;
            List<List<string>> newdata = new List<List<string>>();

            int removed = 0;

            foreach (List<string> dataRow in data)
            {
                if (dataRow.Count > index)
                {
                    string value = dataRow[index].Trim();
                    if (specieslist.Contains(value))
                    {
                        if (rdoKeepIfInList.Checked == true)
                        { newdata.Add(dataRow); }
                    }
                    else
                    {
                        if (rdoRemoveIfInList.Checked == true)
                        { newdata.Add(dataRow); }
                    }
                }
            }
            if (MessageBox.Show("Filtering complete. " + newdata.Count.ToString() + " rows retained, " + (data.Count - newdata.Count).ToString() + " rows removed.", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                data = newdata;
            }
        }

        public List<List<string>>FIlteredData { get { return data; } }
        public List<string> Headers { get { return headers; } } 
        
    }
}
