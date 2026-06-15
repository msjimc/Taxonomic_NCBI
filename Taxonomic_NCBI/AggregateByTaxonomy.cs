using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Taxonomic_NCBI
{
    public partial class AggregateByTaxonomy : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;
        private int dataStart;
        private int dataEnd;
        public AggregateByTaxonomy(FilterData FD, List<string> Headers, List<List<string>> Data, int DataStart, int DataEnd)
        {
            InitializeComponent();

            foreach(List<string> row in Data)
            { data.Add(new List<string>(row)); }
            headers = new List<string>(Headers);
            
            dataStart = DataStart;
            dataEnd = DataEnd;
            fd = FD;
            setCboLists(cboAggregateVlaues, headers);
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
             btnCombine.Enabled = (answer == 1);
        }
        private void cboAggregateVlaues_SelectedIndexChanged(object sender, EventArgs e)
        {
            setBtnAggregateActivity();
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> dataByAggregatevalue = new Dictionary<string, List<string>>();
            int startIndex = dataStart - 1;
            int endIndex = dataEnd - 1;

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

            if (MessageBox.Show("Aggregation complete. " + dataByAggregatevalue.Count.ToString() + " rows in new list, " + data.Count.ToString() + " rows in original list.\nDo you want to keep the aggregated dataset?", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> newheaders = new List<string>();
                for (int indexheader = 0; indexheader < index; indexheader++)
                { newheaders.Add(headers[indexheader]); }

                List<List<string>> newList = new List<List<string>>();
                foreach (List<string> values in dataByAggregatevalue.Values)
                { newList.Add(values); }
                data = newList;
                headers = newheaders;
                setCboLists(cboAggregateVlaues, headers);
                fd.DisableGroupBox4();
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

        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

    }
}
