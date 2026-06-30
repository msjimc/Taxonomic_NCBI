namespace Taxonomic_NCBI
{
    partial class SpeciesSequenceLinker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeciesSequenceLinker));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.gbQuality = new System.Windows.Forms.GroupBox();
            this.chkHitQuality = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.rdoHigherThanCutOff = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFilterCutOff = new System.Windows.Forms.Label();
            this.rdoLowerThanCutOff = new System.Windows.Forms.RadioButton();
            this.cboColumnToFilter = new System.Windows.Forms.ComboBox();
            this.cboFastaName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.cboSpeciesName = new System.Windows.Forms.ComboBox();
            this.btnListNotIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearInList = new System.Windows.Forms.Button();
            this.btnClearNotInList = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbQuality.SuspendLayout();
            this.gbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSelectDataFile);
            this.groupBox1.Controls.Add(this.gbList);
            this.groupBox1.Controls.Add(this.gbQuality);
            this.groupBox1.Controls.Add(this.cboFastaName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 366);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter the annotated BLAST hit file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Select the data file to process by pressing the \'Select\' button";
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDataFile.Location = new System.Drawing.Point(519, 54);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDataFile.TabIndex = 27;
            this.btnSelectDataFile.Text = "Select";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // gbQuality
            // 
            this.gbQuality.Controls.Add(this.chkHitQuality);
            this.gbQuality.Controls.Add(this.label12);
            this.gbQuality.Controls.Add(this.txtCutOff);
            this.gbQuality.Controls.Add(this.rdoHigherThanCutOff);
            this.gbQuality.Controls.Add(this.label13);
            this.gbQuality.Controls.Add(this.lblFilterCutOff);
            this.gbQuality.Controls.Add(this.rdoLowerThanCutOff);
            this.gbQuality.Controls.Add(this.cboColumnToFilter);
            this.gbQuality.Location = new System.Drawing.Point(6, 83);
            this.gbQuality.Name = "gbQuality";
            this.gbQuality.Size = new System.Drawing.Size(594, 94);
            this.gbQuality.TabIndex = 25;
            this.gbQuality.TabStop = false;
            // 
            // chkHitQuality
            // 
            this.chkHitQuality.AutoSize = true;
            this.chkHitQuality.Location = new System.Drawing.Point(6, 0);
            this.chkHitQuality.Name = "chkHitQuality";
            this.chkHitQuality.Size = new System.Drawing.Size(109, 17);
            this.chkHitQuality.TabIndex = 13;
            this.chkHitQuality.Text = "Filter by hit quality";
            this.chkHitQuality.UseVisualStyleBackColor = true;
            this.chkHitQuality.CheckedChanged += new System.EventHandler(this.chkHitQuality_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Select the column containing the alignment quality score";
            // 
            // txtCutOff
            // 
            this.txtCutOff.Enabled = false;
            this.txtCutOff.Location = new System.Drawing.Point(432, 62);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(156, 20);
            this.txtCutOff.TabIndex = 13;
            this.txtCutOff.TextChanged += new System.EventHandler(this.txtCutOff_TextChanged);
            // 
            // rdoHigherThanCutOff
            // 
            this.rdoHigherThanCutOff.AutoSize = true;
            this.rdoHigherThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoHigherThanCutOff.Enabled = false;
            this.rdoHigherThanCutOff.Location = new System.Drawing.Point(84, 39);
            this.rdoHigherThanCutOff.Name = "rdoHigherThanCutOff";
            this.rdoHigherThanCutOff.Size = new System.Drawing.Size(219, 17);
            this.rdoHigherThanCutOff.TabIndex = 9;
            this.rdoHigherThanCutOff.TabStop = true;
            this.rdoHigherThanCutOff.Text = "Retain data equal to or higher than cutoff";
            this.rdoHigherThanCutOff.UseVisualStyleBackColor = true;
            this.rdoHigherThanCutOff.CheckedChanged += new System.EventHandler(this.rdoHigherThanCutOff_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Enter the cut off value";
            // 
            // lblFilterCutOff
            // 
            this.lblFilterCutOff.AutoSize = true;
            this.lblFilterCutOff.ForeColor = System.Drawing.Color.Red;
            this.lblFilterCutOff.Location = new System.Drawing.Point(356, 65);
            this.lblFilterCutOff.Name = "lblFilterCutOff";
            this.lblFilterCutOff.Size = new System.Drawing.Size(67, 13);
            this.lblFilterCutOff.TabIndex = 12;
            this.lblFilterCutOff.Text = "Invalid value";
            this.lblFilterCutOff.Visible = false;
            // 
            // rdoLowerThanCutOff
            // 
            this.rdoLowerThanCutOff.AutoSize = true;
            this.rdoLowerThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoLowerThanCutOff.Enabled = false;
            this.rdoLowerThanCutOff.Location = new System.Drawing.Point(373, 39);
            this.rdoLowerThanCutOff.Name = "rdoLowerThanCutOff";
            this.rdoLowerThanCutOff.Size = new System.Drawing.Size(215, 17);
            this.rdoLowerThanCutOff.TabIndex = 10;
            this.rdoLowerThanCutOff.TabStop = true;
            this.rdoLowerThanCutOff.Text = "Retain data equal to or lower than cutoff";
            this.rdoLowerThanCutOff.UseVisualStyleBackColor = true;
            this.rdoLowerThanCutOff.CheckedChanged += new System.EventHandler(this.rdoLowerThanCutOff_CheckedChanged);
            // 
            // cboColumnToFilter
            // 
            this.cboColumnToFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnToFilter.Enabled = false;
            this.cboColumnToFilter.FormattingEnabled = true;
            this.cboColumnToFilter.Location = new System.Drawing.Point(432, 12);
            this.cboColumnToFilter.Name = "cboColumnToFilter";
            this.cboColumnToFilter.Size = new System.Drawing.Size(156, 21);
            this.cboColumnToFilter.TabIndex = 8;
            this.cboColumnToFilter.SelectedIndexChanged += new System.EventHandler(this.cboColumnToFilter_SelectedIndexChanged);
            // 
            // cboFastaName
            // 
            this.cboFastaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboFastaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFastaName.FormattingEnabled = true;
            this.cboFastaName.Location = new System.Drawing.Point(438, 303);
            this.cboFastaName.Name = "cboFastaName";
            this.cboFastaName.Size = new System.Drawing.Size(156, 21);
            this.cboFastaName.TabIndex = 22;
            this.cboFastaName.SelectedIndexChanged += new System.EventHandler(this.cboFastaName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select the column containing the sequence identifier";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(519, 330);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press the \'Create\' button to create file of species linked to each sequence";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "To filter multiple hits to the same sequence, press the ‘Select’ button to import" +
    " a BLAST hits file and then enter the required data to exclude annotations based" +
    " on their hit quality and species name.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(24, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnList
            // 
            this.btnList.Enabled = false;
            this.btnList.Location = new System.Drawing.Point(432, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "In";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select the file containing the list of expected species by pressing \'In\'";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Select the taxonomic level to use for comparison.";
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Location = new System.Drawing.Point(6, 0);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(217, 17);
            this.chkList.TabIndex = 20;
            this.chkList.Text = "Compare hit to list(s) of taxonomic names";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.chkList_CheckedChanged);
            // 
            // cboSpeciesName
            // 
            this.cboSpeciesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpeciesName.Enabled = false;
            this.cboSpeciesName.FormattingEnabled = true;
            this.cboSpeciesName.Location = new System.Drawing.Point(432, 75);
            this.cboSpeciesName.Name = "cboSpeciesName";
            this.cboSpeciesName.Size = new System.Drawing.Size(156, 21);
            this.cboSpeciesName.TabIndex = 24;
            this.cboSpeciesName.SelectedIndexChanged += new System.EventHandler(this.cboSpeciesName_SelectedIndexChanged);
            // 
            // btnListNotIn
            // 
            this.btnListNotIn.Enabled = false;
            this.btnListNotIn.Location = new System.Drawing.Point(432, 47);
            this.btnListNotIn.Name = "btnListNotIn";
            this.btnListNotIn.Size = new System.Drawing.Size(75, 23);
            this.btnListNotIn.TabIndex = 22;
            this.btnListNotIn.Text = "Not in";
            this.btnListNotIn.UseVisualStyleBackColor = true;
            this.btnListNotIn.Click += new System.EventHandler(this.btnListNotIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Select a file containing the list of unexpected species by pressing \'Not in\'";
            // 
            // btnClearInList
            // 
            this.btnClearInList.Enabled = false;
            this.btnClearInList.Location = new System.Drawing.Point(513, 19);
            this.btnClearInList.Name = "btnClearInList";
            this.btnClearInList.Size = new System.Drawing.Size(75, 23);
            this.btnClearInList.TabIndex = 23;
            this.btnClearInList.Text = "Clear";
            this.btnClearInList.UseVisualStyleBackColor = true;
            this.btnClearInList.Click += new System.EventHandler(this.btnClearInList_Click);
            // 
            // btnClearNotInList
            // 
            this.btnClearNotInList.Enabled = false;
            this.btnClearNotInList.Location = new System.Drawing.Point(513, 48);
            this.btnClearNotInList.Name = "btnClearNotInList";
            this.btnClearNotInList.Size = new System.Drawing.Size(75, 23);
            this.btnClearNotInList.TabIndex = 24;
            this.btnClearNotInList.Text = "Clear";
            this.btnClearNotInList.UseVisualStyleBackColor = true;
            this.btnClearNotInList.Click += new System.EventHandler(this.btnNotInList_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnClearNotInList);
            this.gbList.Controls.Add(this.btnClearInList);
            this.gbList.Controls.Add(this.label7);
            this.gbList.Controls.Add(this.btnListNotIn);
            this.gbList.Controls.Add(this.cboSpeciesName);
            this.gbList.Controls.Add(this.chkList);
            this.gbList.Controls.Add(this.label8);
            this.gbList.Controls.Add(this.label3);
            this.gbList.Controls.Add(this.btnList);
            this.gbList.Location = new System.Drawing.Point(6, 183);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(594, 111);
            this.gbList.TabIndex = 26;
            this.gbList.TabStop = false;
            // 
            // SpeciesSequenceLinker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 416);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpeciesSequenceLinker";
            this.Text = "Filter the annotated BLAST hit file";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbQuality.ResumeLayout(false);
            this.gbQuality.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoLowerThanCutOff;
        private System.Windows.Forms.RadioButton rdoHigherThanCutOff;
        private System.Windows.Forms.ComboBox cboColumnToFilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilterCutOff;
        private System.Windows.Forms.TextBox txtCutOff;
        private System.Windows.Forms.CheckBox chkHitQuality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboFastaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbQuality;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnClearNotInList;
        private System.Windows.Forms.Button btnClearInList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListNotIn;
        private System.Windows.Forms.ComboBox cboSpeciesName;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnList;
    }
}