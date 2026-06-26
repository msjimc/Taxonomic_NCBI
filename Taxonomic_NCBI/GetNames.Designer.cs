namespace Taxonomic_NCBI
{
    partial class GetNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetNames));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBLASTDataFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboColumns = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloase = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnBLASTDataFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboColumns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List unique names";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Press \'Select\' to import the BLAST hit annotation file";
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(463, 102);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBLASTDataFile
            // 
            this.btnBLASTDataFile.Location = new System.Drawing.Point(463, 46);
            this.btnBLASTDataFile.Name = "btnBLASTDataFile";
            this.btnBLASTDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnBLASTDataFile.TabIndex = 4;
            this.btnBLASTDataFile.Text = "Select";
            this.btnBLASTDataFile.UseVisualStyleBackColor = true;
            this.btnBLASTDataFile.Click += new System.EventHandler(this.btnBLASTDataFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select the column contianing the taxonomic names you which to process";
            // 
            // cboColumns
            // 
            this.cboColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumns.Enabled = false;
            this.cboColumns.FormattingEnabled = true;
            this.cboColumns.Location = new System.Drawing.Point(382, 75);
            this.cboColumns.Name = "cboColumns";
            this.cboColumns.Size = new System.Drawing.Size(156, 21);
            this.cboColumns.TabIndex = 2;
            this.cboColumns.SelectedIndexChanged += new System.EventHandler(this.cboColumns_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Press \'Create\' to save the list to file";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "To get a list of names present in an annotated BLAST hits file, select the file a" +
    "nd the column containing the names and then press the \'Create\' button";
            // 
            // btnCloase
            // 
            this.btnCloase.Location = new System.Drawing.Point(12, 149);
            this.btnCloase.Name = "btnCloase";
            this.btnCloase.Size = new System.Drawing.Size(75, 23);
            this.btnCloase.TabIndex = 1;
            this.btnCloase.Text = "Close";
            this.btnCloase.UseVisualStyleBackColor = true;
            this.btnCloase.Click += new System.EventHandler(this.btnCloase_Click);
            // 
            // GetNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 184);
            this.Controls.Add(this.btnCloase);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetNames";
            this.Text = "Get names";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCloase;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBLASTDataFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}