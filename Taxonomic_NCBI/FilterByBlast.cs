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
    public partial class FilterByBlast : Form
    {
        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;

        public FilterByBlast(FilterData FD, List<string> Headers, List<List<string>> Data)
        {
            InitializeComponent();
            data = Data;
            headers = Headers;
            setCboLists(cboColumnToFilter, headers);
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

        private void rdoHigherThanCutOff_CheckedChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void rdoLowerThanCutOff_CheckedChanged(object sender, EventArgs e)
        {
            setbtnFilterActivity();
        }

        private void cboColumnToFilter_SelectedIndexChanged(object sender, EventArgs e)
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

            if (MessageBox.Show("Filtering complete. " + newdata.Count.ToString() + " rows remaining, " + removed.ToString() + " rows removed./nDo you want to accept these results?", "Filtering complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = newdata;                
            }

        }
        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

    }
}
