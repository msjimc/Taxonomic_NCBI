using System;
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
                setCboLists(cboAggregateVlaues, headers);
                setCboLists(cboDataStart, headers);
                setCboLists(cboDataEnd, headers);

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message);
                return;
            }
            finally
            { sf?.Close(); }
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
            cbo.Items.Clear();
            cbo.Items.Add("Select");
            cbo.Items.AddRange(values.ToArray());
            cbo.SelectedIndex = 0;
        }

        private void btnNextLine_Click(object sender, EventArgs e)
        {
            if (currentAggregateLineIndex < data.Count - 2)
            {
                currentAggregateLineIndex++;
                if (currentAggregateLineIndex == data.Count)
                {
                    currentAggregateLineIndex = -1;
                    setCboLists(cboAggregateVlaues, headers);
                    setCboLists(cboDataEnd, headers);
                    setCboLists(cboDataStart, headers);
                }
                else
                {
                    setCboLists(cboAggregateVlaues, data[currentAggregateLineIndex]);
                    setCboLists(cboDataStart, data[currentAggregateLineIndex]);
                    setCboLists(cboDataEnd, data[currentAggregateLineIndex]);
                }
            }
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

        private void cboDataStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            setBtnAggregateActivity();
        }

        private void cboDataEnd_SelectedIndexChanged(object sender, EventArgs e)
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
                { dataByAggregatevalue[name] = values.GetRange(0,index + 1); }
                else
                {
                    List<string> combined = combineTwoRows(values, dataByAggregatevalue[name], startIndex, endIndex, index);
                    dataByAggregatevalue[name] = combined;
                }
            }

            throw new Exception("save data to file");

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
                {  combined[index] = "error"; }                                 
            }
            return combined;
        }
    }
}
