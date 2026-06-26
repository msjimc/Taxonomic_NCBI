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
    public partial class GetNames : Form
    {
        List<List<string>> data = new List<List<string>>();

        public GetNames()
        {
            InitializeComponent();
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBLASTDataFile_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select the file annotated BLAST hits file", "BLAST hits text file (*.txt)|*.txt");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader fs = null;

            try 
            { 
                fs = new System.IO.StreamReader(filename);
                string line = "";
                string[] items = null;

                while(fs.Peek() > 0)
                {
                    line = fs.ReadLine();
                    items = line.Split('\t');
                    if (items.Length > 0)
                    {
                        data.Add(items.ToList());
                    }
                }


                if (data.Count == 0) 
                {
                    MessageBox.Show("Could split data rows in to individal items, is the file a Tab delimited file?", "Error");
                    return; 
                }
                cboColumns.Items.Clear();
                cboColumns.Items.Add("Select");
                cboColumns.Items.AddRange(data[0].ToArray());
                cboColumns.Enabled = true;
                cboColumns.SelectedIndex = 0;
                
            }
            catch (Exception ex) 
            { MessageBox.Show("Could not process file: " + ex.Message, "Error"); }
            finally { fs?.Close();  }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = FileString.SaveAs("Enter the name of the file to save the names in", "Text file (*.txt)|*.txt");
            if (filename == "Cancel") { return; }



            int index = cboColumns.SelectedIndex - 1;

            List<string> columns = new List<string>();
            foreach (List<string> item in data)
            {
                if (item.Count > index)
                {
                    string name = item[index];
                    if (columns.Contains(name) == false)
                    { columns.Add(name); }
                }
            }

            columns.Sort();

            System.IO.StreamWriter fw = null;
            try
            {
                fw = new System.IO.StreamWriter(filename);

                foreach(string item in columns)
                { fw.Write(item + "\n"); }
            }
            catch (Exception ex)
            { MessageBox.Show("Write data to the file: " + ex.Message, "Error"); }
            finally { fw?.Close(); }
        }

        private void cboColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = (cboColumns.SelectedIndex > 0);
        }
    }
}
