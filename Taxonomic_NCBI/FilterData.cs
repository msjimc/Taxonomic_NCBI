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

                SetGroupBoxActivity();
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
            if (data.Count > 0) 
            {
                btnAppend.Enabled = true;
                btnBlast.Enabled = true;
                btnList.Enabled = true;
                btnRemoveColumns.Enabled = true;
                btnRename.Enabled = true;
                answer++; 
            }
            if (cboDataStart.SelectedIndex != 0) { answer++; }
            if (cboDataEnd.SelectedIndex != 0) { answer++; }

            if (answer == 3)
            {
                btnCombine.Enabled = true;
                btnCounts.Enabled = true;
            }
            else
            {
                btnCombine.Enabled = false;
                btnCounts.Enabled = false;
            }
        }

        private void setComboboxes()
        {
            setCboLists(cboDataStart, headers);
            setCboLists(cboDataEnd, headers);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
                return;
            }
            finally
            { sw?.Close(); }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FilterWithList fwl = new FilterWithList(this, headers, data);
            if (fwl.ShowDialog() == DialogResult.OK)
            {
                data = fwl.FIlteredData;
                headers = fwl.Headers; setComboboxes();
                btnSave.Enabled = true;
            }
        }

        private void btnBlast_Click(object sender, EventArgs e)
        {
            FilterByBlast fb = new FilterByBlast(this, headers, data);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                data = fb.FilteredData;
                headers = fb.Headers;
                setComboboxes();
                btnSave.Enabled = true;
            }
        }

        private void btnCounts_Click(object sender, EventArgs e)
        {
            FilterByReadCount fbrc = new FilterByReadCount(this, headers, data, cboDataStart.SelectedIndex, cboDataEnd.SelectedIndex);
            if (fbrc.ShowDialog() == DialogResult.OK)
            {
                data = fbrc.FilteredData;
                headers = fbrc.Headers;
                setComboboxes();
                btnSave.Enabled = true;
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            AggregateByTaxonomy abt = new AggregateByTaxonomy(this, headers, data, cboDataStart.SelectedIndex, cboDataEnd.SelectedIndex);
            if (abt.ShowDialog() == DialogResult.OK)
            {
                data = abt.FilteredData;
                headers = abt.Headers;
                setComboboxes();
                btnSave.Enabled = true;
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            AppendTaxonomicData atd = new AppendTaxonomicData(this, headers, data);
            if (atd.ShowDialog() == DialogResult.OK)
            {
                data = atd.FilteredData;
                headers = atd.Headers;
                setComboboxes();
                btnSave.Enabled = true;
            }
        }

        private void btnRemoveColumns_Click(object sender, EventArgs e)
        {
            RemoveColumns rc = new RemoveColumns(this, headers, data);
            if (rc.ShowDialog() == DialogResult.OK)
            {
                data = rc.FilteredData;
                headers = rc.Headers;
                setComboboxes();
                cboDataEnd.SelectedIndex = 0;
                cboDataStart.SelectedIndex = 0;
                btnSave.Enabled = true;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            RenameColumns rc = new RenameColumns(this, headers);
            if (rc.ShowDialog() == DialogResult.OK)
            {
                headers = rc.Headers;
                setComboboxes();
                btnSave.Enabled = true;
            }

        }

        private void btnSwithcNames_Click(object sender, EventArgs e)
        {

        }
    }
}
