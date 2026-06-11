namespace Taxonomic_NCBI
{
    partial class AppendTaxonomicData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendTaxonomicData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboImportedDataColumn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboReadCountColumn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectTaxonomyFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboImportedDataColumn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCombine);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboReadCountColumn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSelectTaxonomyFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Link taxonomic data via species name";
            // 
            // cboImportedDataColumn
            // 
            this.cboImportedDataColumn.FormattingEnabled = true;
            this.cboImportedDataColumn.Location = new System.Drawing.Point(388, 111);
            this.cboImportedDataColumn.Name = "cboImportedDataColumn";
            this.cboImportedDataColumn.Size = new System.Drawing.Size(150, 21);
            this.cboImportedDataColumn.TabIndex = 8;
            this.cboImportedDataColumn.SelectedIndexChanged += new System.EventHandler(this.cboImportedDataColumn_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select the column in the 3rd party taxonomy file to like to the read count data";
            // 
            // btnCombine
            // 
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(463, 138);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 6;
            this.btnCombine.Text = "Append";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Press \'Combie\' to append new taxonomy data";
            // 
            // cboReadCountColumn
            // 
            this.cboReadCountColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReadCountColumn.FormattingEnabled = true;
            this.cboReadCountColumn.Location = new System.Drawing.Point(388, 82);
            this.cboReadCountColumn.Name = "cboReadCountColumn";
            this.cboReadCountColumn.Size = new System.Drawing.Size(150, 21);
            this.cboReadCountColumn.TabIndex = 4;
            this.cboReadCountColumn.SelectedIndexChanged += new System.EventHandler(this.cboReadCountColumn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select the column in the read count file to link to the taxonomy data";
            // 
            // btnSelectTaxonomyFile
            // 
            this.btnSelectTaxonomyFile.Location = new System.Drawing.Point(463, 53);
            this.btnSelectTaxonomyFile.Name = "btnSelectTaxonomyFile";
            this.btnSelectTaxonomyFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTaxonomyFile.TabIndex = 2;
            this.btnSelectTaxonomyFile.Text = "Select";
            this.btnSelectTaxonomyFile.UseVisualStyleBackColor = true;
            this.btnSelectTaxonomyFile.Click += new System.EventHandler(this.btnSelectTaxonomyFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Press \'Select\' to import the 3rd party taxonomic data";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(475, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(394, 185);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // AppendTaxonomicData
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(568, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppendTaxonomicData";
            this.Text = "Append taxonomic data to file";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboReadCountColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectTaxonomyFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboImportedDataColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}