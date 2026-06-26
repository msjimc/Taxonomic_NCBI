using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Taxonomic_NCBI
{
    public partial class SwitchToxonomiclineage : Form
    {
        private leaf[] leafs;
        private fieldsToSearch fts;
        private Dictionary<int, node> nodes = null;
        private Form1 parent = null;
        private Dictionary<string, string> fields = new Dictionary<string, string>();
        private List<List<string>> data = new List<List<string>>();
        public SwitchToxonomiclineage(leaf[] Leafs, fieldsToSearch FTS, Dictionary<int, node> Nodes, Form1 Parent)
        {
            InitializeComponent();

            leafs = Leafs;
            fts =FTS;
            nodes = Nodes;
            parent = Parent;
        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select the file annotated BLAST hits file", "BLAST hits text file (*.txt)|*.txt");
            if (System.IO.File.Exists(filename) == false) { return; }

            System.IO.StreamReader fs = null;
            List<string> headers = new List<string>();
            data = new List<List<string>>();

            try
            {
                fs = new System.IO.StreamReader(filename);

                if (fs.Peek() < 1) { return; }
                string line = fs.ReadLine();
                string[] items = line.Split('\t');
                if (items.Length == 0) { return; }

                headers.AddRange(items);
                headers.Add("Changed");

                while (fs.Peek() > 0)
                {
                    line = fs.ReadLine();
                    items = line.Split('\t');
                    if (items.Length > 0)
                    {
                        List<string> datum = items.ToList();
                        
                        string name = items[items.Length -1].ToLower();
                        if (fields.ContainsKey(name) == true)
                        {
                            string newData = fields[name];
                            if (newData == "No infomation")
                            { datum.Add(name + ": not found"); }
                            else
                            {
                                List<string> newTaxonomy = newData.Split('\t').ToList();
                                int index = datum.Count - newTaxonomy.Count;
                                if (index > 0)
                                {
                                    int count = 0;
                                    for (int place = index; place < datum.Count; place++)
                                    {
                                        datum[place] = newTaxonomy[count]; 
                                        count++; 
                                    }
                                    datum.Add("Original name: " + name);
                                }
                            }
                        }
                        else { datum.Add("No change"); }
                        
                        data.Add(datum);
                    }
                }


                if (data.Count == 0)
                {
                    MessageBox.Show("Could not process file, is the file a Tab delimited file?", "Error");
                    return;
                }               

            }
            catch (Exception ex)
            { MessageBox.Show("Could not process file: " + ex.Message, "Error"); }
            finally { fs?.Close(); }


            string newName = filename.Substring(0, filename.LastIndexOf(".")) + "_names_switched.txt";
            System.IO.StreamWriter fw = null;

            try 
            {
                fw = new System.IO.StreamWriter(newName);
                fw.Write(string.Join("\t", headers) + "\n");

                foreach(List<string> row in data)
                {
                    fw.Write(string.Join("\t", row) + "\n");
                }
            
            }
            catch(Exception ex) { MessageBox.Show("Could not save data to file: " + ex.Message, "Error"); }
            { fw?.Close(); }
        }

        private void btnPairednamesFile_Click(object sender, EventArgs e)
        {
            string filename = FileString.OpenAs("Select the file of paired names", "Text file (*.txt)|*.txt");
            if (System.IO.File.Exists(filename) == false) { return; }
            
            btnCreate.Enabled = false;
            
            System.IO.StreamReader fs = null;
            fields = new Dictionary<string, string>();
            try
            {
                fs = new System.IO.StreamReader(filename);
                string line = "";
                string[] items = null;

                leafBinarySearch lbs = new leafBinarySearch();

                while (fs.Peek() > 0)
                {
                    line = fs.ReadLine();
                    items = line.Split('\t');
                    if (items.Length == 2)
                    {
                        string wrong = items[0].Trim().ToLower();
                        string right = items[1].Trim().ToLower();

                        if (fields.ContainsKey(wrong) == true) { continue; }

                        string taxonomyLineage = parent.GetTaxonomicData(right);
                        fields[wrong] = taxonomyLineage;
                    }
                }
                btnCreate.Enabled = true;
            }
            catch (Exception ex)
            { MessageBox.Show("Could not process file: " + ex.Message, "Error"); }
            finally { fs?.Close(); }
        }
    }
}
