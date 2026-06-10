using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxonomic_NCBI
{
    public partial class AppendTaxonomicData : Form
    {
        int longestheaterLine = 0;
        List<string> headers = new List<string>();
        string[] appendheaders;
        List<List<string>> data = new List<List<string>>();
        FilterData fd;
        Dictionary<string, string[]> taxonomicData = new Dictionary<string, string[]>();
        Dictionary<string, string> taxonomicDataBySelectedColumn = new Dictionary<string, string>();

        public AppendTaxonomicData(FilterData FD, List<string> Headers, List<List<string>> Data)
        {
            InitializeComponent();
            data = Data;
            headers = Headers;
            setCboLists(cboReadCountColumn, headers);
            cboImportedDataColumn.Enabled = false;
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

        private void btnSelectTaxonomyFile_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select species list file", "Text file (*.txt;*.xls;*.csv)|*.txt;*.xls;*.csv");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader sf = null;
            taxonomicData = new Dictionary<string, string[]>();

            try
            {
                sf = new System.IO.StreamReader(filename);
                string line = sf.ReadLine() ;
                string[] items = line.Split('\t');
                if (items.Length > 1)
                { 
                    appendheaders = items;                    
                }
                else { appendheaders = new string[] { " " }; }

                int maxStringlength = 0;
                while (sf.Peek() > 0)
                {
                    line = sf.ReadLine();
                    items = line.Split('\t');
                    if (items.Length > 1)
                    {
                        if (items.Length > maxStringlength) { maxStringlength = items.Length; }
                        string key = items[items.Length - 1];
                        if (taxonomicData.ContainsKey(key) == false)
                        { 
                            for (int index = 1; index < items.Length;index++)
                            {
                                if (items[index].Trim() == "" || items[index].Trim() == "None")
                                { items[index] = "." + items[index - 1]; }
                            }
                            taxonomicData.Add(key, items); 
                        }
                    }
                }
                appendheaders = setTitles(appendheaders, maxStringlength);
                setCboLists(cboImportedDataColumn, appendheaders.ToList());
                cboImportedDataColumn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                taxonomicData = new Dictionary<string, string[]>();
            }
            finally { sf?.Close(); }
            SetBtnCOmpareActivity();
        }

        private string[] setTitles(string[] appendHeaders, int maxlength)
        {
            List<string> list = new List<string>();           
            list.AddRange(appendHeaders);

            int counter1 = 0;int counter2 = -1;
            for(int index = 0; index < maxlength;index++)
            {
                if (list.Count > index)
                {
                    if (list[index].Trim() == "")
                    {
                        string name = ((char)(65 + counter1)).ToString();
                        if (counter2 > -1) { name = ((char)(65 + counter2)).ToString() + name; }
                        list[index] = name;
                    }                    
                }
                else
                {
                    string name = ((char)(65 + counter1)).ToString();
                    if (counter2 > -1) { name = ((char)(65 + counter2)).ToString() + name; }
                    list.Add(name);
                }
                counter1++;
                if (counter1 > 25)
                {
                    counter1 = 0;
                    counter2++;
                }
            }
            
            return list.ToArray();
        }

        private void cboReadCountColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
        }

        private void cboImportedDataColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBtnCOmpareActivity();
            if (cboImportedDataColumn.SelectedIndex > 2)
            {
                int limit = cboImportedDataColumn.SelectedIndex - 1;
                taxonomicDataBySelectedColumn = new Dictionary<string, string>();
                foreach (KeyValuePair<string, string[]> kvp in taxonomicData)
                {
                    string[] items = kvp.Value;
                    string key = items[limit].ToLower();
                    if (taxonomicDataBySelectedColumn.ContainsKey(key) == false)
                    {
                        if (items.Length > limit)
                        {                            
                            string newLine = string.Join("\t", items.Take(limit + 1));                            
                            taxonomicDataBySelectedColumn.Add(key, newLine);
                        }
                    }
                }
            } 
        }

        private void SetBtnCOmpareActivity()
        {
            int answer = 0;
            if (taxonomicData.Count > 0) { answer++; }
            if (cboImportedDataColumn.SelectedIndex > 1) { answer++; }
            if (cboReadCountColumn.SelectedIndex > 1) { answer++; }
            btnCombine.Enabled = (answer == 3);
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            if (cboReadCountColumn.SelectedIndex == 0)
            { return; }

            int limit = cboReadCountColumn.SelectedIndex - 1;

            int added = 0;int notAdded = 0;

            List<List<string>> newdata = new List<List<string>>();
            foreach (List<string> datarow in data)
            {
                if (datarow.Count > limit)
                {
                    List<string> extra = new List<string>();
                    extra.AddRange(datarow);
                    string key = datarow[limit].ToLower();
                    if (taxonomicDataBySelectedColumn.ContainsKey(key) == true)
                    {
                        added ++;
                        extra.Add("In List");
                        extra.AddRange(taxonomicDataBySelectedColumn[key].Split('\t').ToList()); 
                    }
                    else 
                    {
                        notAdded++;
                        extra.Add("Not in List");
                        extra.AddRange(Enumerable.Repeat("-", appendheaders.Length));
                    }
                    newdata.Add(extra);
                }
            }

            if (MessageBox.Show("Annotation complete. " + added.ToString() + " rows annotated, " + notAdded.ToString() + " rows not in list list.\nDo you want to keep the annotation?", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = newdata;
                string[] tempAppendedHeader = new string[headers.Count + appendheaders.Length + 1];
                Array.Copy(headers.ToArray(), tempAppendedHeader, headers.Count);
                string[] bit = new string[] { "Annotation" };
                Array.Copy(bit, 0, tempAppendedHeader, headers.Count, 1);
                Array.Copy(appendheaders,0, tempAppendedHeader, headers.Count + 1, cboImportedDataColumn.SelectedIndex);
                headers = tempAppendedHeader.ToList();
            }
        }


        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

    }
}
