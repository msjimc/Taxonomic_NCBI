namespace Taxonomic_NCBI
{
    partial class FilterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterData));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboDataStart = new System.Windows.Forms.ComboBox();
            this.cboDataEnd = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRemoveColumns = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCounts = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBlast = new System.Windows.Forms.Button();
            this.lblBlast = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectDataFile);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cboDataStart);
            this.groupBox1.Controls.Add(this.cboDataEnd);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File selection";
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDataFile.Location = new System.Drawing.Point(459, 43);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDataFile.TabIndex = 2;
            this.btnSelectDataFile.Text = "Select";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(526, 32);
            this.label19.TabIndex = 0;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(459, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "After filtering and combining read count data press \'Save\' to save the data.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the data file to process by pressing the \'Select\' button";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "and end at";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Read count values start at:";
            // 
            // cboDataStart
            // 
            this.cboDataStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataStart.FormattingEnabled = true;
            this.cboDataStart.Location = new System.Drawing.Point(193, 72);
            this.cboDataStart.Name = "cboDataStart";
            this.cboDataStart.Size = new System.Drawing.Size(121, 21);
            this.cboDataStart.TabIndex = 4;
            this.cboDataStart.SelectedIndexChanged += new System.EventHandler(this.cboDataStart_SelectedIndexChanged);
            // 
            // cboDataEnd
            // 
            this.cboDataEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataEnd.FormattingEnabled = true;
            this.cboDataEnd.Location = new System.Drawing.Point(384, 72);
            this.cboDataEnd.Name = "cboDataEnd";
            this.cboDataEnd.Size = new System.Drawing.Size(150, 21);
            this.cboDataEnd.TabIndex = 6;
            this.cboDataEnd.SelectedIndexChanged += new System.EventHandler(this.cboDataEnd_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbTasks
            // 
            this.gbTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTasks.Controls.Add(this.label9);
            this.gbTasks.Controls.Add(this.btnRename);
            this.gbTasks.Controls.Add(this.btnRemoveColumns);
            this.gbTasks.Controls.Add(this.label8);
            this.gbTasks.Controls.Add(this.btnAppend);
            this.gbTasks.Controls.Add(this.label2);
            this.gbTasks.Controls.Add(this.btnCombine);
            this.gbTasks.Controls.Add(this.label4);
            this.gbTasks.Controls.Add(this.btnCounts);
            this.gbTasks.Controls.Add(this.label7);
            this.gbTasks.Controls.Add(this.btnBlast);
            this.gbTasks.Controls.Add(this.lblBlast);
            this.gbTasks.Controls.Add(this.btnList);
            this.gbTasks.Controls.Add(this.label3);
            this.gbTasks.Location = new System.Drawing.Point(12, 143);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Size = new System.Drawing.Size(540, 223);
            this.gbTasks.TabIndex = 1;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Tasks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rename column headers";
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(459, 191);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 12;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnRemoveColumns
            // 
            this.btnRemoveColumns.Enabled = false;
            this.btnRemoveColumns.Location = new System.Drawing.Point(459, 162);
            this.btnRemoveColumns.Name = "btnRemoveColumns";
            this.btnRemoveColumns.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveColumns.TabIndex = 11;
            this.btnRemoveColumns.Text = "Remove";
            this.btnRemoveColumns.UseVisualStyleBackColor = true;
            this.btnRemoveColumns.Click += new System.EventHandler(this.btnRemoveColumns_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "To remove columns form annotated read-count matrix press \'Remove\'";
            // 
            // btnAppend
            // 
            this.btnAppend.Enabled = false;
            this.btnAppend.Location = new System.Drawing.Point(459, 133);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 9;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To append taxomomic data from a different source press \'Append\'";
            // 
            // btnCombine
            // 
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(459, 106);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 7;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "To aggregate reads count data at taxomomic level press \'Combine\'";
            // 
            // btnCounts
            // 
            this.btnCounts.Enabled = false;
            this.btnCounts.Location = new System.Drawing.Point(457, 77);
            this.btnCounts.Name = "btnCounts";
            this.btnCounts.Size = new System.Drawing.Size(75, 23);
            this.btnCounts.TabIndex = 5;
            this.btnCounts.Text = "Counts";
            this.btnCounts.UseVisualStyleBackColor = true;
            this.btnCounts.Click += new System.EventHandler(this.btnCounts_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "To excluded data row based on total read count press \'Counts\'";
            // 
            // btnBlast
            // 
            this.btnBlast.Enabled = false;
            this.btnBlast.Location = new System.Drawing.Point(457, 48);
            this.btnBlast.Name = "btnBlast";
            this.btnBlast.Size = new System.Drawing.Size(75, 23);
            this.btnBlast.TabIndex = 3;
            this.btnBlast.Text = "Number";
            this.btnBlast.UseVisualStyleBackColor = true;
            this.btnBlast.Click += new System.EventHandler(this.btnBlast_Click);
            // 
            // lblBlast
            // 
            this.lblBlast.AutoSize = true;
            this.lblBlast.Location = new System.Drawing.Point(6, 53);
            this.lblBlast.Name = "lblBlast";
            this.lblBlast.Size = new System.Drawing.Size(221, 13);
            this.lblBlast.TabIndex = 2;
            this.lblBlast.Text = "To filter data by numeric value press \'Number\'";
            // 
            // btnList
            // 
            this.btnList.Enabled = false;
            this.btnList.Location = new System.Drawing.Point(457, 19);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Names";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "To filter species by a list of taxonomic names press \'Names\'";
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 409);
            this.Controls.Add(this.gbTasks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FilterData";
            this.Text = "Edit annotated read count data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTasks.ResumeLayout(false);
            this.gbTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDataEnd;
        private System.Windows.Forms.ComboBox cboDataStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBlast;
        private System.Windows.Forms.Label lblBlast;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveColumns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRename;
    }
}