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
    public partial class BlastHitTasks : Form
    {
        private bool hasTaxonomyData = false;
        private Form1 parent = null;

        public BlastHitTasks(Form1 Parent, bool HasTaxonomyData)
        {
            InitializeComponent();
            hasTaxonomyData = HasTaxonomyData;
            parent = Parent;
            btnAnnotate.Enabled = hasTaxonomyData;
            btnSwitch.Enabled = hasTaxonomyData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnnotate_Click(object sender, EventArgs e)
        {
            parent.NamesFile(chkFolder.Checked);
        }

        private void btnNames_Click(object sender, EventArgs e)
        {
            GetNames gn = new GetNames();
            gn.ShowDialog();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            parent.SwitchNames();
        }

        private void btnFilterBlastHitsFile_Click(object sender, EventArgs e)
        {
            SpeciesSequenceLinker ssl = new SpeciesSequenceLinker();
            if (ssl.ShowDialog() == DialogResult.OK)
            {
                //in case i need it
            }
        }
    }
}
