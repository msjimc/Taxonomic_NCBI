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
    public partial class RemoveColumns : Form
    {

        List<string> headers = new List<string>();
        List<List<string>> data = new List<List<string>>();
        FilterData fd;

        public RemoveColumns(FilterData FD, List<string> Headers, List<List<string>> Data)
        {
            InitializeComponent();
            fd = FD;
            foreach (List<string> row in Data)
            { data.Add(new List<string>(row)); }
            headers = new List<string>(Headers);

            setChbLists(cblRemoveColumns, headers);
        }

        private void setChbLists(CheckedListBox cbl, List<string> list)
        {
            cbl.Items.Clear();
            foreach (string item in list)
            { cbl.Items.Add(item); }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cblRemoveColumns.CheckedIndices.Count == 0) { return; }
            List<List<string>> newData = new List<List<string>>();
            List<string> newHeaders = new List<string>();

            foreach (List<string> row in data)
            { newData.Add(new List<string>(row)); }
            newHeaders = new List<string>(headers);

            List<int> removeIndices = new List<int>();
            foreach (int index in cblRemoveColumns.CheckedIndices)
            { removeIndices.Add(index); }
            removeIndices.Sort();
            removeIndices.Reverse();

            foreach (int index in removeIndices)
            {
                if (newHeaders.Count <= index) { continue; }
                { newHeaders.RemoveAt(index); }
                foreach (List<string> row in newData)
                {
                    if (row.Count <= index) { continue; }
                    row.RemoveAt(index); 
                }
            }

            if (MessageBox.Show("Columns removed. Do you want to save the changes?", "Columns removed", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                data = newData;
                headers = newHeaders;

                setChbLists(cblRemoveColumns, headers);
                btnAccept.Enabled = true;
            }

            
        }

        public List<List<string>> FilteredData { get { return data; } }
        public List<string> Headers { get { return headers; } }

        private void cblRemoveColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                btnRemove.Enabled = cblRemoveColumns.CheckedIndices.Count > 0;                
            }));
        }
    }
}
