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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.chkHitQuality = new System.Windows.Forms.CheckBox();
            this.cboSpeciesfilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilterCutOff = new System.Windows.Forms.Label();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoLowerThanCutOff = new System.Windows.Forms.RadioButton();
            this.rdoHigherThanCutOff = new System.Windows.Forms.RadioButton();
            this.cboColumnToFilter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFastaName = new System.Windows.Forms.ComboBox();
            this.cboSpeciesName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(485, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(404, 352);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSpeciesName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboFastaName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkList);
            this.groupBox1.Controls.Add(this.chkHitQuality);
            this.groupBox1.Controls.Add(this.cboSpeciesfilter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFilterCutOff);
            this.groupBox1.Controls.Add(this.txtCutOff);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rdoLowerThanCutOff);
            this.groupBox1.Controls.Add(this.rdoHigherThanCutOff);
            this.groupBox1.Controls.Add(this.cboColumnToFilter);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 334);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identify species linked to each sequence";
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Location = new System.Drawing.Point(9, 154);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(207, 17);
            this.chkList.TabIndex = 20;
            this.chkList.Text = "Compare hit to list of expected species";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.chkList_CheckedChanged);
            // 
            // chkHitQuality
            // 
            this.chkHitQuality.AutoSize = true;
            this.chkHitQuality.Location = new System.Drawing.Point(9, 58);
            this.chkHitQuality.Name = "chkHitQuality";
            this.chkHitQuality.Size = new System.Drawing.Size(109, 17);
            this.chkHitQuality.TabIndex = 13;
            this.chkHitQuality.Text = "Filter by hit quality";
            this.chkHitQuality.UseVisualStyleBackColor = true;
            this.chkHitQuality.CheckedChanged += new System.EventHandler(this.chkHitQuality_CheckedChanged);
            // 
            // cboSpeciesfilter
            // 
            this.cboSpeciesfilter.FormattingEnabled = true;
            this.cboSpeciesfilter.Location = new System.Drawing.Point(386, 171);
            this.cboSpeciesfilter.Name = "cboSpeciesfilter";
            this.cboSpeciesfilter.Size = new System.Drawing.Size(150, 21);
            this.cboSpeciesfilter.TabIndex = 19;
            this.cboSpeciesfilter.SelectedIndexChanged += new System.EventHandler(this.cboSpeciesfilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Select the taxonomic level to use for comparison.";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(461, 198);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 15;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select the file containing the list of expected species by pressing \'List\'";
            // 
            // lblFilterCutOff
            // 
            this.lblFilterCutOff.AutoSize = true;
            this.lblFilterCutOff.ForeColor = System.Drawing.Color.Red;
            this.lblFilterCutOff.Location = new System.Drawing.Point(313, 133);
            this.lblFilterCutOff.Name = "lblFilterCutOff";
            this.lblFilterCutOff.Size = new System.Drawing.Size(67, 13);
            this.lblFilterCutOff.TabIndex = 12;
            this.lblFilterCutOff.Text = "Invalid value";
            this.lblFilterCutOff.Visible = false;
            // 
            // txtCutOff
            // 
            this.txtCutOff.Location = new System.Drawing.Point(386, 130);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(150, 20);
            this.txtCutOff.TabIndex = 13;
            this.txtCutOff.TextChanged += new System.EventHandler(this.txtCutOff_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Enter the cut off value";
            // 
            // rdoLowerThanCutOff
            // 
            this.rdoLowerThanCutOff.AutoSize = true;
            this.rdoLowerThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoLowerThanCutOff.Location = new System.Drawing.Point(321, 101);
            this.rdoLowerThanCutOff.Name = "rdoLowerThanCutOff";
            this.rdoLowerThanCutOff.Size = new System.Drawing.Size(215, 17);
            this.rdoLowerThanCutOff.TabIndex = 10;
            this.rdoLowerThanCutOff.TabStop = true;
            this.rdoLowerThanCutOff.Text = "Retain data equal to or lower than cutoff";
            this.rdoLowerThanCutOff.UseVisualStyleBackColor = true;
            this.rdoLowerThanCutOff.CheckedChanged += new System.EventHandler(this.rdoLowerThanCutOff_CheckedChanged);
            // 
            // rdoHigherThanCutOff
            // 
            this.rdoHigherThanCutOff.AutoSize = true;
            this.rdoHigherThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoHigherThanCutOff.Location = new System.Drawing.Point(96, 101);
            this.rdoHigherThanCutOff.Name = "rdoHigherThanCutOff";
            this.rdoHigherThanCutOff.Size = new System.Drawing.Size(219, 17);
            this.rdoHigherThanCutOff.TabIndex = 9;
            this.rdoHigherThanCutOff.TabStop = true;
            this.rdoHigherThanCutOff.Text = "Retain data equal to or higher than cutoff";
            this.rdoHigherThanCutOff.UseVisualStyleBackColor = true;
            this.rdoHigherThanCutOff.CheckedChanged += new System.EventHandler(this.rdoHigherThanCutOff_CheckedChanged);
            // 
            // cboColumnToFilter
            // 
            this.cboColumnToFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnToFilter.FormattingEnabled = true;
            this.cboColumnToFilter.Location = new System.Drawing.Point(386, 70);
            this.cboColumnToFilter.Name = "cboColumnToFilter";
            this.cboColumnToFilter.Size = new System.Drawing.Size(150, 21);
            this.cboColumnToFilter.TabIndex = 8;
            this.cboColumnToFilter.SelectedIndexChanged += new System.EventHandler(this.cboColumnToFilter_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Select the column containing the alignment quality score";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(461, 305);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press the \'Create\' button to create file of species linked to each sequence";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select the column containing the sequence identifier";
            // 
            // cboFastaName
            // 
            this.cboFastaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFastaName.FormattingEnabled = true;
            this.cboFastaName.Location = new System.Drawing.Point(386, 278);
            this.cboFastaName.Name = "cboFastaName";
            this.cboFastaName.Size = new System.Drawing.Size(150, 21);
            this.cboFastaName.TabIndex = 22;
            this.cboFastaName.SelectedIndexChanged += new System.EventHandler(this.cboFastaName_SelectedIndexChanged);
            // 
            // cboSpeciesName
            // 
            this.cboSpeciesName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpeciesName.FormattingEnabled = true;
            this.cboSpeciesName.Location = new System.Drawing.Point(386, 251);
            this.cboSpeciesName.Name = "cboSpeciesName";
            this.cboSpeciesName.Size = new System.Drawing.Size(150, 21);
            this.cboSpeciesName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Select the column containing the species name";
            // 
            // SpeciesSequenceLinker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SpeciesSequenceLinker";
            this.Text = "Species linked to a sequence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
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
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSpeciesfilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkHitQuality;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.ComboBox cboFastaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSpeciesName;
        private System.Windows.Forms.Label label5;
    }
}