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
    public partial class FilterByReadCount : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;
        private int dataStart;
        private int dataEnd;

        public FilterByReadCount(FilterData FD, List<string> Headers, List<List<string>> Data, int DataStart, int DataEnd)
        {
            InitializeComponent();

            foreach (List<string> row in Data)
            { data.Add(new List<string>(row)); }
            headers = new List<string>(Headers);

            dataStart = DataStart;
            dataEnd = DataEnd;
            fd = FD;
        }
        
        private void txtMinimumReadCount_TextChanged(object sender, EventArgs e)
        {
            SetBtnFilterMinimumReadCountActivity();
        }

        private void SetBtnFilterMinimumReadCountActivity()
        {
            int answer = 0;
            double cutoffValue;
            if (double.TryParse(txtMinimumReadCount.Text, out cutoffValue)) { answer++; }            
            btnFilterMinimumReadCount.Enabled = (answer == 1);
            btnAccept.Enabled = false;
        }

        private void btnFilterMinimumReadCount_Click(object sender, EventArgs e)
        {
            double cutoffValue;
            if (double.TryParse(txtMinimumReadCount.Text, out cutoffValue) == false)
            {
                MessageBox.Show("Invalid cutoff value entered/nThe value has to be any whole or decimal number.", "Error, not a number");
                return;
            }

            int startIndex = dataStart - 1;
            int endIndex = dataEnd - 1;

            decimal retianedReads = 0; decimal deletedreads = 0; 

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
                { 
                    newdata.Add(dataRow);
                    retianedReads += (decimal)totalReads;
                }
                else
                { 
                    removed++; 
                    deletedreads += (decimal)totalReads;
                }
            }

            if (MessageBox.Show("Filtering complete. " + newdata.Count.ToString() + " rows remaining containing " + retianedReads.ToString("N0") +  " reads, and " +
                removed.ToString() + " rows removed containing " + deletedreads.ToString("N0") +  " reads.", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = newdata;
                btnAccept.Enabled = true;
            }

        }

        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

    }
}
