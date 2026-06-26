namespace Taxonomic_NCBI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetNodes = new System.Windows.Forms.Button();
            this.btnGetNames = new System.Windows.Forms.Button();
            this.btnTaxoIDSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnAnnotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilterBlastHitsFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNames = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetNodes
            // 
            this.btnGetNodes.Location = new System.Drawing.Point(192, 23);
            this.btnGetNodes.Name = "btnGetNodes";
            this.btnGetNodes.Size = new System.Drawing.Size(75, 23);
            this.btnGetNodes.TabIndex = 1;
            this.btnGetNodes.Text = "Nodes";
            this.btnGetNodes.UseVisualStyleBackColor = true;
            this.btnGetNodes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetNames
            // 
            this.btnGetNames.Enabled = false;
            this.btnGetNames.Location = new System.Drawing.Point(273, 23);
            this.btnGetNames.Name = "btnGetNames";
            this.btnGetNames.Size = new System.Drawing.Size(75, 23);
            this.btnGetNames.TabIndex = 2;
            this.btnGetNames.Text = "Names";
            this.btnGetNames.UseVisualStyleBackColor = true;
            this.btnGetNames.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTaxoIDSearch
            // 
            this.btnTaxoIDSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaxoIDSearch.Enabled = false;
            this.btnTaxoIDSearch.Location = new System.Drawing.Point(648, 17);
            this.btnTaxoIDSearch.Name = "btnTaxoIDSearch";
            this.btnTaxoIDSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTaxoIDSearch.TabIndex = 1;
            this.btnTaxoIDSearch.Text = "Taxo ID";
            this.btnTaxoIDSearch.UseVisualStyleBackColor = true;
            this.btnTaxoIDSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(161, 241);
            this.textBox1.TabIndex = 3;
            this.textBox1.WordWrap = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(173, 46);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(626, 241);
            this.txtData.TabIndex = 4;
            this.txtData.WordWrap = false;
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameSearch.Enabled = false;
            this.btnNameSearch.Location = new System.Drawing.Point(729, 17);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNameSearch.TabIndex = 2;
            this.btnNameSearch.Text = "Name";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnName_Click);
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
            this.btnAnnotate.Click += new System.EventHandler(this.btnNamesFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import from NCBI taxonomy data files:";
            // 
            // btnCombine
            // 
            this.btnCombine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombine.Location = new System.Drawing.Point(720, 14);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 1;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnTaxoIDSearch);
            this.groupBox1.Controls.Add(this.btnNameSearch);
            this.groupBox1.Location = new System.Drawing.Point(17, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual search";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the species name or NCBI taxonomic ID in the first text box, then press the" +
    " relevant button on the right to search for the species tree.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSwitch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnNames);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnFilterBlastHitsFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.chkFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAnnotate);
            this.groupBox2.Location = new System.Drawing.Point(17, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automated analysis";
            // 
            // btnFilterBlastHitsFile
            // 
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
            this.label8.Size = new System.Drawing.Size(435, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "To filter a Blast Hits file that contains multiple hits for each sequence press t" +
    "he \'Filter\' button";
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
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGetNodes);
            this.groupBox3.Controls.Add(this.btnGetNames);
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 57);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import taxomoic data";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(723, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Re-Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(564, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Import data from saved session";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(483, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(421, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Save data";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnCombine);
            this.groupBox4.Location = new System.Drawing.Point(17, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(804, 44);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Combine annotation file with read count matrix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "To combine annotations with counts matrix press the Combine button.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFilter);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(17, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(804, 44);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter and aggregate species data";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(720, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Process";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(339, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "To filter, annotate, or edit an annotated read count file press the \'Filter\' ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "To get list of species names in annotated BLAST hit file press the \'Names\' button" +
    "";
            // 
            // btnNames
            // 
            this.btnNames.Location = new System.Drawing.Point(720, 44);
            this.btnNames.Name = "btnNames";
            this.btnNames.Size = new System.Drawing.Size(75, 23);
            this.btnNames.TabIndex = 4;
            this.btnNames.Text = "Names";
            this.btnNames.UseVisualStyleBackColor = true;
            this.btnNames.Click += new System.EventHandler(this.btnNames_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(424, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "To swith names and taxonomic lineage data in a BLAST hits file press the \'Switch\'" +
    " button";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Enabled = false;
            this.btnSwitch.Location = new System.Drawing.Point(720, 73);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 6;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 617);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(855, 656);
            this.Name = "Form1";
            this.Text = "NCBI Taxonomic data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetNodes;
        private System.Windows.Forms.Button btnGetNames;
        private System.Windows.Forms.Button btnTaxoIDSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnAnnotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFilterBlastHitsFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNames;
        private System.Windows.Forms.Label label9;
    }
}


