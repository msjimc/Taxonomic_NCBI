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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFlag = new System.Windows.Forms.CheckBox();
            this.chkKeep = new System.Windows.Forms.CheckBox();
            this.chbRemove = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectSpeciesList = new System.Windows.Forms.Button();
            this.btnNextLine = new System.Windows.Forms.Button();
            this.txtFlaggedColoumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAggregateVlaues = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboColumnToFilter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboDataStart = new System.Windows.Forms.ComboBox();
            this.cboDataEnd = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectDataFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File selection";
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
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDataFile.Location = new System.Drawing.Point(459, 21);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDataFile.TabIndex = 1;
            this.btnSelectDataFile.Text = "Select";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the data file to process by pressing the \'Select\' button";
            // 
            // chkFlag
            // 
            this.chkFlag.AutoSize = true;
            this.chkFlag.Location = new System.Drawing.Point(9, 79);
            this.chkFlag.Name = "chkFlag";
            this.chkFlag.Size = new System.Drawing.Size(326, 17);
            this.chkFlag.TabIndex = 15;
            this.chkFlag.Text = "Flag sequences in list using name in text area as column header";
            this.chkFlag.UseVisualStyleBackColor = true;
            // 
            // chkKeep
            // 
            this.chkKeep.AutoSize = true;
            this.chkKeep.Location = new System.Drawing.Point(164, 56);
            this.chkKeep.Name = "chkKeep";
            this.chkKeep.Size = new System.Drawing.Size(116, 17);
            this.chkKeep.TabIndex = 14;
            this.chkKeep.Text = "Keep species in list";
            this.chkKeep.UseVisualStyleBackColor = true;
            // 
            // chbRemove
            // 
            this.chbRemove.AutoSize = true;
            this.chbRemove.Location = new System.Drawing.Point(9, 56);
            this.chbRemove.Name = "chbRemove";
            this.chbRemove.Size = new System.Drawing.Size(149, 17);
            this.chbRemove.TabIndex = 13;
            this.chbRemove.Text = "Remove species not in list";
            this.chbRemove.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Press next to view values from the next data line.";
            // 
            // btnSelectSpeciesList
            // 
            this.btnSelectSpeciesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSpeciesList.Location = new System.Drawing.Point(459, 52);
            this.btnSelectSpeciesList.Name = "btnSelectSpeciesList";
            this.btnSelectSpeciesList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSpeciesList.TabIndex = 9;
            this.btnSelectSpeciesList.Text = "Select";
            this.btnSelectSpeciesList.UseVisualStyleBackColor = true;
            // 
            // btnNextLine
            // 
            this.btnNextLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextLine.Location = new System.Drawing.Point(459, 60);
            this.btnNextLine.Name = "btnNextLine";
            this.btnNextLine.Size = new System.Drawing.Size(75, 23);
            this.btnNextLine.TabIndex = 8;
            this.btnNextLine.Text = "Next";
            this.btnNextLine.UseVisualStyleBackColor = true;
            this.btnNextLine.Click += new System.EventHandler(this.btnNextLine_Click);
            // 
            // txtFlaggedColoumnName
            // 
            this.txtFlaggedColoumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlaggedColoumnName.Location = new System.Drawing.Point(384, 77);
            this.txtFlaggedColoumnName.Name = "txtFlaggedColoumnName";
            this.txtFlaggedColoumnName.Size = new System.Drawing.Size(150, 20);
            this.txtFlaggedColoumnName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(528, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "To flag species whose name appear in a list of species names, first select the fi" +
    "le of names by pressing the \'Select\' button and set the desired action using the" +
    " options below.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select an example of the phylogenetic class to which you want to aggregate the da" +
    "ta.";
            // 
            // cboAggregateVlaues
            // 
            this.cboAggregateVlaues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAggregateVlaues.FormattingEnabled = true;
            this.cboAggregateVlaues.Location = new System.Drawing.Point(384, 89);
            this.cboAggregateVlaues.Name = "cboAggregateVlaues";
            this.cboAggregateVlaues.Size = new System.Drawing.Size(150, 21);
            this.cboAggregateVlaues.TabIndex = 3;
            this.cboAggregateVlaues.SelectedIndexChanged += new System.EventHandler(this.cboAggregateVlaues_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cboDataEnd);
            this.groupBox2.Controls.Add(this.cboDataStart);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCombine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnNextLine);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboAggregateVlaues);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggregate read at taxomomic level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Press \'Combine\' to aggragate read counts";
            // 
            // btnCombine
            // 
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(459, 159);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 11;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnCompare);
            this.groupBox3.Controls.Add(this.txtFlaggedColoumnName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chkFlag);
            this.groupBox3.Controls.Add(this.btnSelectSpeciesList);
            this.groupBox3.Controls.Add(this.chkKeep);
            this.groupBox3.Controls.Add(this.chbRemove);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 136);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter species in a list";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Press \'Compare\' to process species names";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(459, 103);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 16;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboColumnToFilter);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 160);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter data by numeric value in a column";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(395, 126);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Pree filter to filter data rows";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Enter the cut off value";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(320, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lower then cut off";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(195, 77);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Higher than cut off";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Should retained data be equal or  ";
            // 
            // cboColumnToFilter
            // 
            this.cboColumnToFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnToFilter.FormattingEnabled = true;
            this.cboColumnToFilter.Location = new System.Drawing.Point(320, 50);
            this.cboColumnToFilter.Name = "cboColumnToFilter";
            this.cboColumnToFilter.Size = new System.Drawing.Size(150, 21);
            this.cboColumnToFilter.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select the column";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(464, 31);
            this.label11.TabIndex = 0;
            this.label11.Tag = "";
            this.label11.Text = "To filter data by value in a column, first select the column, select whether the " +
    "value should be above or below the cutoff and the enter the cutoff.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Read count values start at:";
            // 
            // cboDataStart
            // 
            this.cboDataStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataStart.FormattingEnabled = true;
            this.cboDataStart.Location = new System.Drawing.Point(193, 116);
            this.cboDataStart.Name = "cboDataStart";
            this.cboDataStart.Size = new System.Drawing.Size(121, 21);
            this.cboDataStart.TabIndex = 14;
            this.cboDataStart.SelectedIndexChanged += new System.EventHandler(this.cboDataStart_SelectedIndexChanged);
            // 
            // cboDataEnd
            // 
            this.cboDataEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataEnd.FormattingEnabled = true;
            this.cboDataEnd.Location = new System.Drawing.Point(384, 116);
            this.cboDataEnd.Name = "cboDataEnd";
            this.cboDataEnd.Size = new System.Drawing.Size(150, 21);
            this.cboDataEnd.TabIndex = 15;
            this.cboDataEnd.SelectedIndexChanged += new System.EventHandler(this.cboDataEnd_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "and end at";
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FilterData";
            this.Text = "Filter and aggregate data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectSpeciesList;
        private System.Windows.Forms.Button btnNextLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlaggedColoumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAggregateVlaues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFlag;
        private System.Windows.Forms.CheckBox chkKeep;
        private System.Windows.Forms.CheckBox chbRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboColumnToFilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDataEnd;
        private System.Windows.Forms.ComboBox cboDataStart;
        private System.Windows.Forms.Label label15;
    }
}