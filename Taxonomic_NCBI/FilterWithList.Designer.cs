namespace Taxonomic_NCBI
{
    partial class FilterWithList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterWithList));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboSpeciesfilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rboFlagInList = new System.Windows.Forms.RadioButton();
            this.rdoKeepIfInList = new System.Windows.Forms.RadioButton();
            this.rdoRemoveIfInList = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtFlaggedColoumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectSpeciesList = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSpeciesfilter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rboFlagInList);
            this.groupBox3.Controls.Add(this.rdoKeepIfInList);
            this.groupBox3.Controls.Add(this.rdoRemoveIfInList);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnCompare);
            this.groupBox3.Controls.Add(this.txtFlaggedColoumnName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSelectSpeciesList);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter species in a list";
            // 
            // cboSpeciesfilter
            // 
            this.cboSpeciesfilter.FormattingEnabled = true;
            this.cboSpeciesfilter.Location = new System.Drawing.Point(384, 111);
            this.cboSpeciesfilter.Name = "cboSpeciesfilter";
            this.cboSpeciesfilter.Size = new System.Drawing.Size(150, 21);
            this.cboSpeciesfilter.TabIndex = 7;
            this.cboSpeciesfilter.SelectedIndexChanged += new System.EventHandler(this.cboSpeciesfilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Select the taxonomic level to use for comparison.";
            // 
            // rboFlagInList
            // 
            this.rboFlagInList.AutoSize = true;
            this.rboFlagInList.Location = new System.Drawing.Point(6, 86);
            this.rboFlagInList.Name = "rboFlagInList";
            this.rboFlagInList.Size = new System.Drawing.Size(325, 17);
            this.rboFlagInList.TabIndex = 4;
            this.rboFlagInList.TabStop = true;
            this.rboFlagInList.Text = "Flag sequences in list using name in text area as column header";
            this.rboFlagInList.UseVisualStyleBackColor = true;
            this.rboFlagInList.CheckedChanged += new System.EventHandler(this.rboFlagInList_CheckedChanged);
            // 
            // rdoKeepIfInList
            // 
            this.rdoKeepIfInList.AutoSize = true;
            this.rdoKeepIfInList.Location = new System.Drawing.Point(165, 63);
            this.rdoKeepIfInList.Name = "rdoKeepIfInList";
            this.rdoKeepIfInList.Size = new System.Drawing.Size(115, 17);
            this.rdoKeepIfInList.TabIndex = 3;
            this.rdoKeepIfInList.TabStop = true;
            this.rdoKeepIfInList.Text = "Keep species in list";
            this.rdoKeepIfInList.UseVisualStyleBackColor = true;
            this.rdoKeepIfInList.CheckedChanged += new System.EventHandler(this.rdoKeepIfInList_CheckedChanged);
            // 
            // rdoRemoveIfInList
            // 
            this.rdoRemoveIfInList.AutoSize = true;
            this.rdoRemoveIfInList.Location = new System.Drawing.Point(6, 63);
            this.rdoRemoveIfInList.Name = "rdoRemoveIfInList";
            this.rdoRemoveIfInList.Size = new System.Drawing.Size(130, 17);
            this.rdoRemoveIfInList.TabIndex = 2;
            this.rdoRemoveIfInList.TabStop = true;
            this.rdoRemoveIfInList.Text = "Remove species in list";
            this.rdoRemoveIfInList.UseVisualStyleBackColor = true;
            this.rdoRemoveIfInList.CheckedChanged += new System.EventHandler(this.rdoRemoveIfInList_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Press \'Compare\' to process species names";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(459, 138);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtFlaggedColoumnName
            // 
            this.txtFlaggedColoumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlaggedColoumnName.Enabled = false;
            this.txtFlaggedColoumnName.Location = new System.Drawing.Point(384, 85);
            this.txtFlaggedColoumnName.Name = "txtFlaggedColoumnName";
            this.txtFlaggedColoumnName.Size = new System.Drawing.Size(150, 20);
            this.txtFlaggedColoumnName.TabIndex = 5;
            this.txtFlaggedColoumnName.TextChanged += new System.EventHandler(this.txtFlaggedColoumnName_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // btnSelectSpeciesList
            // 
            this.btnSelectSpeciesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSpeciesList.Location = new System.Drawing.Point(459, 26);
            this.btnSelectSpeciesList.Name = "btnSelectSpeciesList";
            this.btnSelectSpeciesList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSpeciesList.TabIndex = 1;
            this.btnSelectSpeciesList.Text = "List";
            this.btnSelectSpeciesList.UseVisualStyleBackColor = true;
            this.btnSelectSpeciesList.Click += new System.EventHandler(this.btnSelectSpeciesList_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(394, 189);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(475, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FilterWithList
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(568, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FilterWithList";
            this.Text = "Filter data against list of names";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboSpeciesfilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rboFlagInList;
        private System.Windows.Forms.RadioButton rdoKeepIfInList;
        private System.Windows.Forms.RadioButton rdoRemoveIfInList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtFlaggedColoumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectSpeciesList;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}