using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Taxonomic_NCBI
{
    public partial class RenameColumns : Form
    {

        List<string> headers = new List<string>();
        FilterData fd;

        public RenameColumns(FilterData FD, List<string> Headers)
        {
            InitializeComponent();

            headers = new List<string>(Headers);
            fd = FD;
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            if (headers.Count == 0)
            {
                MessageBox.Show("No headers to export.", "Error");
                return;
            }

            string fileName = FileString.SaveAs("Save headers as", "Text files (*.txt)|*.txt");
            if (fileName == "Cancel") { return; }

            System.IO.StreamWriter sw = null;

            try
            {
                sw = new System.IO.StreamWriter(fileName);
                sw.Write("Edit the second instance of the current name, and leave the first instance the same.\n" + 
                    "If a line contains ':/' it indicates this name appears more than once and is used to identify which instance to change.\n");
                
                List<string> names = new List<string>();
                foreach (string header in headers)
                {
                    if (names.Contains(header) == true)
                    {
                        int count = names.Count(n => n == header);
                        names.Add(header);
                        sw.Write(header + ":/" + count.ToString() + "\t" + header + "\n");
                    }
                    else
                    {
                        names.Add(header);
                        sw.Write(header + "\t" + header + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting headers: " + ex.Message, "Error");
                return;
            }
            finally
            { sw?.Close(); }

        }

        public List<string> Headers { get { return headers; } }

        private void btnImportList_Click(object sender, EventArgs e)
        {
            string fileName = FileString.OpenAs("Select the file with the edited names", "Text files (*.txt)|*.txt");
            if (System.IO.File.Exists(fileName) == false) { return; }

            Dictionary<string, string> oldnewnames = new Dictionary<string, string>();

            System.IO.StreamReader sf = null;

            try 
            {
                sf = new System.IO.StreamReader(fileName);

                while (sf.Peek() > 0)
                {
                    string line = sf.ReadLine();
                    string[] items = line.Split('\t');
                    if (items.Length == 2)
                    {
                        if (oldnewnames.ContainsKey(items[0]) == false)
                        { oldnewnames[items[0]] = items[1]; }
                    }
                }
                
                int changed = 0;
                List<string> newheaders = new List<string>();
                List<string> names = new List<string>();
                foreach (string header in headers)
                {                    
                    string key = header;
                    if (names.Contains(header) == true)
                    {
                        int count = names.Count(n => n == header);
                        names.Add(header);
                        key = header + ":/" + count.ToString();
                    }
                    else { names.Add(header); }

                    if (oldnewnames.ContainsKey(key) == false)
                    { 
                        newheaders.Add(header); 
                    }
                    else if (key != oldnewnames[key])
                    { 
                        newheaders.Add(oldnewnames[key]);
                        changed++;
                    }
                    else { newheaders.Add(header); }
                }

                if (MessageBox.Show("Renaming complete. Of " + headers.Count.ToString() + " columns , " + changed.ToString() + " were changed, from a list of " + oldnewnames.Count.ToString("N0") + " names in the file\nDo you want to keep the annotation ?", "Editing complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    headers = newheaders;
                    btnAccept.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing headers: " + ex.Message, "Error");
                return;
            }
            finally
            {
                sf?.Close();
            }


        }

        private void AcitviteEdit()
        { 
            if (txtSearchterm.Text.Trim().Length == 0)
            {
                btnEditNames.Enabled = false;
                cboNewNames.Text = "";
                cboNewNames.Items.Clear();
            }
            else
            {
                int count = 0;
                foreach(string header in headers)
                {
                    if (header.ToLower().Contains(txtSearchterm.Text.Trim().ToLower()) == true)
                    { count++; }
                }

                List<string> newheader = MakeNewheaders();
                if (newheader.Count > 0)
                { 
                    int index = cboNewNames.SelectedIndex;
                    if (index < 0) { index = 0; }
                    cboNewNames.Items.Clear();
                    cboNewNames.Items.AddRange(newheader.ToArray()); 
                    if (cboNewNames.Items.Count > index)
                    { cboNewNames.SelectedIndex = index; }
                    else { cboNewNames.SelectedIndex = 0; }
                }
                else 
                {
                    cboNewNames.Text = "";
                    cboNewNames.Items.Clear(); 
                }

                lblmatches.Text = count.ToString() + " matches";
                if (count > 0) 
                {
                    if (rdoOnly.Checked == true || rboPrefix.Checked == true || rdoSuffix.Checked == true)
                    { btnEditNames.Enabled = true; }
                    else { btnEditNames.Enabled = false; }
                }
                else { btnEditNames.Enabled = false; }
            }
        
        }

        private List<string> MakeNewheaders()
        {
            string text = txtSearchterm.Text.Trim().ToLower();
            List<string> newheader = new List<string>();

            int hits = 0;
            foreach (string name in headers)
            {
                int index = name.ToLower().IndexOf(text);
                if (index > -1)
                {
                    if (rdoOnly.Checked == true)
                    {
                        int theStart = index;
                        int theEnd = index + text.Length;
                        string newName = "";
                        if (theStart > -1)
                        { newName = name.Substring(0, theStart); }
                        if (theEnd < name.Length)
                        { newName += name.Substring(theEnd); }
                        if (newName.Length > 0)
                        { newheader.Add(newName); }
                        else { newheader.Add(name); }
                        hits++;
                    }
                    else if (rboPrefix.Checked == true)
                    { newheader.Add(name.Substring(index + text.Length)); hits++; }
                    else if (rdoSuffix.Enabled == true)
                    { newheader.Add(name.Substring(0, index)); hits++; }
                }
                else { newheader.Add(name); }
            }
            return newheader;
        }

        private void txtSearchterm_TextChanged(object sender, EventArgs e)
        {
            AcitviteEdit();
        }

        private void rboPrefix_CheckedChanged(object sender, EventArgs e)
        {
            AcitviteEdit();
        }

        private void rdoOnly_CheckedChanged(object sender, EventArgs e)
        {
            AcitviteEdit();
        }

        private void rdoSuffix_CheckedChanged(object sender, EventArgs e)
        {
            AcitviteEdit();
        }

        private void btnEditNames_Click(object sender, EventArgs e)
        {
            int hits = 0;
            List<string> newheader = MakeNewheaders();
            foreach(string name in newheader)
            {
                if (Headers.Contains(name) == false)
                { hits++; }
            }            

            if (MessageBox.Show("Renaming complete. Of " + headers.Count.ToString() + " columns , " + hits.ToString() + " were changed.\nDo you want to keep the annotation ?", "Editing complete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                headers = newheader;
                btnAccept.Enabled = true;
                AcitviteEdit();
            }

            
        }
    }
}
