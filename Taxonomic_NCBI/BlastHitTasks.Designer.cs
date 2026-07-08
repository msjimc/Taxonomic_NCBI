namespace Taxonomic_NCBI
{
    partial class BlastHitTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlastHitTasks));
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNames = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFilterBlastHitsFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnnotate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSwitch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnNames);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnFilterBlastHitsFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAnnotate);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processing a BLAST hit file";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitch.Enabled = false;
            this.btnSwitch.Location = new System.Drawing.Point(720, 73);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 6;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "To swith names and taxonomic lineage data in an ANNOTATED BLAST hits file press t" +
    "he \'Switch\' button";
            // 
            // btnNames
            // 
            this.btnNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNames.Location = new System.Drawing.Point(720, 44);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(75, 23);
            this.btnNames.TabIndex = 4;
            this.btnNames.Text = "Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "To get list of species names in ANNOTATED BLAST hit file press the \'Names\' button" +
    "";
            // 
            // btnFilterBlastHitsFile
            // 
            this.btnFilterBlastHitsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterBlastHitsFile.Location = new System.Drawing.Point(720, 102);
            this.btnFilterBlastHitsFile.Name = "btnFilterBlastHitsFile";
            this.btnFilterBlastHitsFile.Size = new System.Drawing.Size(75, 23);
            this.btnFilterBlastHitsFile.TabIndex = 8;
            this.btnFilterBlastHitsFile.Text = "Filter";
            this.btnFilterBlastHitsFile.UseVisualStyleBackColor = true;
            this.btnFilterBlastHitsFile.Click += new System.EventHandler(this.btnFilterBlastHitsFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(511, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "To filter an ANNOTATED Blast Hits file that contains multiple hits for each seque" +
    "nce press the \'Filter\' button";
            // 
            // chkFolder
            // 
            this.chkFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFolder.AutoSize = true;
            this.chkFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFolder.Location = new System.Drawing.Point(559, 20);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(155, 17);
            this.chkFolder.TabIndex = 1;
            this.chkFolder.Text = "Process a folder of text files";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Press the Annotate button to identify the species name in the blast hit file.  To" +
    " combine and annotate a series of blast result files in the same folder tick the" +
    " box";
            // 
            // btnAnnotate
            // 
            this.btnAnnotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnotate.Enabled = false;
            this.btnAnnotate.Location = new System.Drawing.Point(720, 16);
            this.btnAnnotate.Name = "btnAnnotate";
            this.btnAnnotate.Size = new System.Drawing.Size(75, 23);
            this.btnAnnotate.TabIndex = 2;
            this.btnAnnotate.Text = "Annotate";
            this.btnAnnotate.UseVisualStyleBackColor = true;
            this.btnAnnotate.Click += new System.EventHandler(this.btnAnnotate_Click);
            // 
            // BlastHitTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 187);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "BlastHitTasks";
            this.Text = "Blast hit results  tasks";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFilterBlastHitsFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnotate;
    }
}