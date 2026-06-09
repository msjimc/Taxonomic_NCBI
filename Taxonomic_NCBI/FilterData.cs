using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Taxonomic_NCBI
{
    public partial class FilterData : Form
    {
        private List<List<string>> data = new List<List<string>>();
        private List<string> headers = new List<string>();
        private int currentAggregateLineIndex = -1;
        public FilterData()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectDataFile_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select data file", "tab delimited Text file (*.txt;*.csv:*.xls)|*.txt;*.csv:*.xls");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader sf = null;

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
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

                int maxlength = headers.Count;
                while (sf.Peek() > 0)
                {
                    line = sf.ReadLine();
                    line = line.Replace("\"", "");
                    items = line.Split(new char[] { splitOn });
                    if (items.Length > maxlength) { maxlength = items.Length; }
                    List<string> itemList = items.ToList();
                    data.Add(itemList);
                }

                setDataToMaxLength(maxlength);
                setHeaderListToDataLength(maxlength);
                setComboboxes();

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                return;
            }
            finally
            { sf?.Close(); }

            SetGroupBoxActivity();

        }
        private void cboDataStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGroupBoxActivity();
        }

        private void cboDataEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGroupBoxActivity();
        }

        private void SetGroupBoxActivity()
        {
            int answer = 0;
            if (data.Count > 0) { answer++; }
            if (cboDataStart.SelectedIndex != 0) { answer++; }
            if (cboDataEnd.SelectedIndex != 0) { answer++; }

            if (answer == 3)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
            }
        }

        private void setComboboxes()
        {
            setCboLists(cboAggregateVlaues, headers);
            setCboLists(cboDataStart, headers);
            setCboLists(cboDataEnd, headers);
            setCboLists(cboColumnToFilter, headers);
            setCboLists(cboSpeciesfilter, headers);
        }

        private void setDataToMaxLength(int maxlength)
        {
            for (int index = 0; index < data.Count; index++)
            {
                List<string> line = data[index];
                while (line.Count < maxlength)
                { line.Add(""); }
            }
        }

        private void setHeaderListToDataLength(int maxlength)
        {
            int counter1 = 0;
            int counter2 = -1;
            List<string> nextLine = data[0];
            for (int index = 0; index < maxlength; index++)
            {
                if (headers.Count - 1 < index)
                {

                    string name = ((char)(65 + counter1)).ToString();
                    if (counter2 > -1) { name = ((char)(65 + counter2)).ToString() + name; }
                    headers.Add(name);
                }
                else
                {
                    if (headers[index] == "")
                    {
                        string name = ((char)(65 + counter1)).ToString();
                        if (counter2 > 0)
                        { name = ((char)(65 + counter1)).ToString() + name; }
                        headers[index] = name;
                    }
                }

                counter1++;
                if (counter1 > 25)
                {
                    counter1 = 0;
                    counter2++;
                }
            }
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

        private void setBtnAggregateActivity()
        {
            int answer = 0;
            if (cboAggregateVlaues.SelectedIndex != 0) { answer++; }
            if (cboDataStart.SelectedIndex != 0) { answer++; }
            if (cboDataEnd.SelectedIndex != 0) { answer++; }
            btnCombine.Enabled = (answer == 3);
        }
        private void cboAggregateVlaues_SelectedIndexChanged(object sender, EventArgs e)
        {
            setBtnAggregateActivity();
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> dataByAggregatevalue = new Dictionary<string, List<string>>();
            int startIndex = cboDataStart.SelectedIndex - 1;
            int endIndex = cboDataEnd.SelectedIndex - 1;

            int index = cboAggregateVlaues.SelectedIndex - 1;
            foreach (List<string> values in data)
            {
                string name = values[index];
                if (dataByAggregatevalue.ContainsKey(name) == false)
                { dataByAggregatevalue[name] = values.GetRange(0, index + 1); }
                else
                {
                    List<string> combined = combineTwoRows(values, dataByAggregatevalue[name], startIndex, endIndex, index);
                    dataByAggregatevalue[name] = combined;
                }
            }

            if (MessageBox.Show("Aggregation complete. " + dataByAggregatevalue.Count.ToString() + " rows in new list, " + data.Count.ToString() + " rows in original list.", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> newheaders = new List<string>();
                for(int indexheader = 0; indexheader < index; indexheader++)
                { newheaders.Add(headers[indexheader]); }

                List<List<string>> newList = new List<List<string>>();
                foreach (List<string> values in dataByAggregatevalue.Values)
                { newList.Add(values); }
                data = newList;
                headers = newheaders;
                setComboboxes();
                groupBox4.Enabled = false;
                btnSave.Enabled = true;
            }

        }

        private List<string> combineTwoRows(List<string> row1, List<string> row2, int startIndex, int endIndex, int aggregateIndex)
        {
            List<string> combined = new List<string>();
            combined.AddRange(row1.GetRange(0, aggregateIndex));
            for (int index = startIndex; index < endIndex + 1; index++)
            {
                string value1 = row1[index];
                string value2 = row2[index];
                double v1 = 0; double v2 = 0;
                if (double.TryParse(value1, out v1) && double.TryParse(value2, out v2))
                { combined[index] = (v1 + v2).ToString(); }
                else
                { combined[index] = "error"; }
            }
            return combined;
        }

        private void cboColumnToFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
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
                setbtnFilterActivity();
            }
        }

        private void setbtnFilterActivity()
        {
            int answer = 0;
            if (cboColumnToFilter.SelectedIndex != 0) { answer++; }
            if (rdoLowerThanCutOff.Checked || rdoHigherThanCutOff.Checked) { answer++; }
            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue)) { answer++; }
            btnFilter.Enabled = (answer == 3);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            double cutoffValue;
            if (double.TryParse(txtCutOff.Text, out cutoffValue) == false)
            {
                MessageBox.Show("Invalid cutoff value entered/nThe value has to be any whole or decimal number.", "Error, not a number");
                return;
            }

            int removed = 0;
            List<List<string>> newdata = new List<List<string>>();
            int index = cboColumnToFilter.SelectedIndex - 1;
            foreach (List<string> dataRow in data)
            {
                if (dataRow.Count > index)
                {
                    double value;
                    if (double.TryParse(dataRow[index], out value) == true)
                    {
                        if (rdoLowerThanCutOff.Checked == true)
                        { if (value <= cutoffValue) { newdata.Add(dataRow); } else { removed++; } }
                        else
                        { if (value >= cutoffValue) { newdata.Add(dataRow); } else { removed++; } }
                    }
                    else { removed++; }
                }
            }

            if (MessageBox.Show("Filtering complete. " + newdata.Count.ToString() + " rows remaining, " + removed.ToString() + " rows removed.", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                data = newdata;
                btnSave.Enabled = true;
            }

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
                    specieslist.Add(line.Trim());
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
            if (rboFlagInList.Checked== true)
            { FlagIfInList(); }
            else
            { RemoveKeepIfInList(); }

            SetBtnCOmpareActivity();
        }

        private void FlagIfInList()
        {
            int index = cboSpeciesfilter.SelectedIndex - 1;
            List<List<string>> newdata = new List<List<string>>();

            int InList = 0;int NotInList = 0;

            foreach (List<string> dataRow in data)
            {
                if (dataRow.Count > index)
                {
                    string value = dataRow[index].Trim();
                    List<string> newDataRow = new List<string>();
                    newDataRow.AddRange(dataRow);
                    
                    if (specieslist.Contains(value))
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
                setComboboxes();
                btnSave.Enabled = true;
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
                setComboboxes();
                data = newdata;
                btnSave.Enabled = true;
            }

        }

        private void txtMinimumReadCount_TextChanged(object sender, EventArgs e)
        {
            SetBtnFilterMinimumReadCountActivity();
        }

        private void cboDataStartAtMinimumReadCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBtnFilterMinimumReadCountActivity();
        }

        private void cboDataEndAtMinimumReadCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBtnFilterMinimumReadCountActivity();
        }

        private void SetBtnFilterMinimumReadCountActivity()
        {
            int answer = 0;
            double cutoffValue;
            if (double.TryParse(txtMinimumReadCount.Text, out cutoffValue)) { answer++; }
            if (cboDataStart.SelectedIndex != 0) { answer++; }
            if (cboDataEnd.SelectedIndex != 0) { answer++; }
            btnFilterMinimumReadCount.Enabled = (answer == 3);
        }

        private void btnFilterMinimumReadCount_Click(object sender, EventArgs e)
        {
            double cutoffValue;
            if (double.TryParse(txtMinimumReadCount.Text, out cutoffValue) == false)
            {
                MessageBox.Show("Invalid cutoff value entered/nThe value has to be any whole or decimal number.", "Error, not a number");
                return;
            }

            int startIndex = cboDataStart.SelectedIndex - 1;
            int endIndex = cboDataEnd.SelectedIndex - 1;

            int removed = 0;
            List<List<string>> newdata = new List<List<string>>();

            foreach (List<string> dataRow in data)
            {
                double totalReads = 0.0d;
                for (int index = startIndex; index < endIndex + 1; index++)
                {
                    double value;
                    if (double.TryParse(dataRow[index], out value))
                    { totalReads += value; }
                }
                if (totalReads >= cutoffValue)
                { newdata.Add(dataRow); }
                else
                { removed++; }
            }

            if (MessageBox.Show("Filtering complete. " + newdata.Count.ToString() + " rows remaining, " + removed.ToString() + " rows removed.", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                data = newdata;
                btnSave.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename = FileString.SaveAs("Save filtered data", "tab delimited Text file (*.txt)|*.txt");
            if (filename == "Cancel") { return; }

            System.IO.StreamWriter sw = null;

            try
            {
                sw = new System.IO.StreamWriter(filename);
                sw.WriteLine(string.Join("\t", headers));
                foreach (List<string> dataRow in data)
                { sw.WriteLine(string.Join("\t", dataRow)); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
                return;
            }
            finally
            { sw?.Close(); }
        }
    }
}
