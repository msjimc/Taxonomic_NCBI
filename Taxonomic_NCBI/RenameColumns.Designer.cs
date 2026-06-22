namespace Taxonomic_NCBI
{
    partial class RenameColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameColumns));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportList = new System.Windows.Forms.Button();
            this.btnImportList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmatches = new System.Windows.Forms.Label();
            this.txtSearchterm = new System.Windows.Forms.TextBox();
            this.rboPrefix = new System.Windows.Forms.RadioButton();
            this.rdoOnly = new System.Windows.Forms.RadioButton();
            this.rdoSuffix = new System.Windows.Forms.RadioButton();
            this.btnEditNames = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNewNames = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(475, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(391, 300);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cboNewNames);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnEditNames);
            this.groupBox4.Controls.Add(this.rdoSuffix);
            this.groupBox4.Controls.Add(this.rdoOnly);
            this.groupBox4.Controls.Add(this.rboPrefix);
            this.groupBox4.Controls.Add(this.txtSearchterm);
            this.groupBox4.Controls.Add(this.lblmatches);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnImportList);
            this.groupBox4.Controls.Add(this.btnExportList);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(16, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 274);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit column names";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(528, 31);
            this.label11.TabIndex = 0;
            this.label11.Tag = "";
            this.label11.Text = "Column names can be renamed either by importing a file containing the old  name n" +
    "ext to the new name, or by removing a common text from a series of columns";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "To rename the columns by importing a file with the new names, first press \'Make\' " +
    "to export the current names, modify the file and then press\'Change\' to import th" +
    "e file and change the titles";
            // 
            // btnExportList
            // 
            this.btnExportList.Location = new System.Drawing.Point(375, 95);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(75, 23);
            this.btnExportList.TabIndex = 2;
            this.btnExportList.Text = "Make";
            this.btnExportList.UseVisualStyleBackColor = true;
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // btnImportList
            // 
            this.btnImportList.Location = new System.Drawing.Point(459, 95);
            this.btnImportList.Name = "btnImportList";
            this.btnImportList.Size = new System.Drawing.Size(75, 23);
            this.btnImportList.TabIndex = 3;
            this.btnImportList.Text = "Change";
            this.btnImportList.UseVisualStyleBackColor = true;
            this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "To rename the titles by deleting or replacing text in the title(s), enter the tex" +
    "t in the text area, select how to process before or after the match and then pre" +
    "ss \'Edit\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text to remove";
            // 
            // lblmatches
            // 
            this.lblmatches.AutoSize = true;
            this.lblmatches.Location = new System.Drawing.Point(84, 245);
            this.lblmatches.Name = "lblmatches";
            this.lblmatches.Size = new System.Drawing.Size(65, 13);
            this.lblmatches.TabIndex = 6;
            this.lblmatches.Text = "No changes";
            // 
            // txtSearchterm
            // 
            this.txtSearchterm.Location = new System.Drawing.Point(375, 164);
            this.txtSearchterm.Name = "txtSearchterm";
            this.txtSearchterm.Size = new System.Drawing.Size(159, 20);
            this.txtSearchterm.TabIndex = 7;
            this.txtSearchterm.TextChanged += new System.EventHandler(this.txtSearchterm_TextChanged);
            // 
            // rboPrefix
            // 
            this.rboPrefix.AutoSize = true;
            this.rboPrefix.Location = new System.Drawing.Point(9, 195);
            this.rboPrefix.Name = "rboPrefix";
            this.rboPrefix.Size = new System.Drawing.Size(168, 17);
            this.rboPrefix.TabIndex = 8;
            this.rboPrefix.Text = "Also remove text before match";
            this.rboPrefix.UseVisualStyleBackColor = true;
            this.rboPrefix.CheckedChanged += new System.EventHandler(this.rboPrefix_CheckedChanged);
            // 
            // rdoOnly
            // 
            this.rdoOnly.AutoSize = true;
            this.rdoOnly.Location = new System.Drawing.Point(183, 195);
            this.rdoOnly.Name = "rdoOnly";
            this.rdoOnly.Size = new System.Drawing.Size(168, 17);
            this.rdoOnly.TabIndex = 9;
            this.rdoOnly.Text = "Remove just the matching text";
            this.rdoOnly.UseVisualStyleBackColor = true;
            this.rdoOnly.CheckedChanged += new System.EventHandler(this.rdoOnly_CheckedChanged);
            // 
            // rdoSuffix
            // 
            this.rdoSuffix.AutoSize = true;
            this.rdoSuffix.Checked = true;
            this.rdoSuffix.Location = new System.Drawing.Point(375, 195);
            this.rdoSuffix.Name = "rdoSuffix";
            this.rdoSuffix.Size = new System.Drawing.Size(159, 17);
            this.rdoSuffix.TabIndex = 10;
            this.rdoSuffix.TabStop = true;
            this.rdoSuffix.Text = "Also remove text after match";
            this.rdoSuffix.UseVisualStyleBackColor = true;
            this.rdoSuffix.CheckedChanged += new System.EventHandler(this.rdoSuffix_CheckedChanged);
            // 
            // btnEditNames
            // 
            this.btnEditNames.Enabled = false;
            this.btnEditNames.Location = new System.Drawing.Point(459, 215);
            this.btnEditNames.Name = "btnEditNames";
            this.btnEditNames.Size = new System.Drawing.Size(75, 23);
            this.btnEditNames.TabIndex = 11;
            this.btnEditNames.Text = "Edit";
            this.btnEditNames.UseVisualStyleBackColor = true;
            this.btnEditNames.Click += new System.EventHandler(this.btnEditNames_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "New names - ";
            // 
            // cboNewNames
            // 
            this.cboNewNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewNames.FormattingEnabled = true;
            this.cboNewNames.Location = new System.Drawing.Point(183, 242);
            this.cboNewNames.Name = "cboNewNames";
            this.cboNewNames.Size = new System.Drawing.Size(351, 21);
            this.cboNewNames.TabIndex = 13;
            // 
            // RenameColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 335);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RenameColumns";
            this.Text = "Rename columns";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImportList;
        private System.Windows.Forms.Button btnExportList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditNames;
        private System.Windows.Forms.RadioButton rdoSuffix;
        private System.Windows.Forms.RadioButton rdoOnly;
        private System.Windows.Forms.RadioButton rboPrefix;
        private System.Windows.Forms.TextBox txtSearchterm;
        private System.Windows.Forms.Label lblmatches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNewNames;
        private System.Windows.Forms.Label label4;
    }
}