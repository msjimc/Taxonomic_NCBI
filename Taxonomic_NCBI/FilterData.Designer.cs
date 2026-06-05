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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAggregateVlaues = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlaggedColoumnName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNextLine = new System.Windows.Forms.Button();
            this.btnSelectSpeciesList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.chbRemove = new System.Windows.Forms.CheckBox();
            this.chkKeep = new System.Windows.Forms.CheckBox();
            this.chkFlag = new System.Windows.Forms.CheckBox();
            this.txteScore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txteScore);
            this.groupBox1.Controls.Add(this.chkFlag);
            this.groupBox1.Controls.Add(this.chkKeep);
            this.groupBox1.Controls.Add(this.chbRemove);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSelectSpeciesList);
            this.groupBox1.Controls.Add(this.btnNextLine);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFlaggedColoumnName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboAggregateVlaues);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSelectDataFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discard any data line where the hit eScore is higher than the value entered in th" +
    "e text area.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the data file to process by pressing the \'Select\' button";
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDataFile.Location = new System.Drawing.Point(359, 19);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDataFile.TabIndex = 1;
            this.btnSelectDataFile.Text = "Select";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // cboAggregateVlaues
            // 
            this.cboAggregateVlaues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAggregateVlaues.FormattingEnabled = true;
            this.cboAggregateVlaues.Location = new System.Drawing.Point(284, 145);
            this.cboAggregateVlaues.Name = "cboAggregateVlaues";
            this.cboAggregateVlaues.Size = new System.Drawing.Size(150, 21);
            this.cboAggregateVlaues.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select an example of the phylogenetic class to which you want to aggregate the da" +
    "ta.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "To flag species whose name appear in a list of species names, first select the fi" +
    "le of names by pressing the \'Select\' button and set the desired action using the" +
    " options below.";
            // 
            // txtFlaggedColoumnName
            // 
            this.txtFlaggedColoumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlaggedColoumnName.Location = new System.Drawing.Point(284, 276);
            this.txtFlaggedColoumnName.Name = "txtFlaggedColoumnName";
            this.txtFlaggedColoumnName.Size = new System.Drawing.Size(150, 20);
            this.txtFlaggedColoumnName.TabIndex = 6;
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
            // btnNextLine
            // 
            this.btnNextLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextLine.Location = new System.Drawing.Point(359, 116);
            this.btnNextLine.Name = "btnNextLine";
            this.btnNextLine.Size = new System.Drawing.Size(75, 23);
            this.btnNextLine.TabIndex = 8;
            this.btnNextLine.Text = "Next";
            this.btnNextLine.UseVisualStyleBackColor = true;
            // 
            // btnSelectSpeciesList
            // 
            this.btnSelectSpeciesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSpeciesList.Location = new System.Drawing.Point(359, 226);
            this.btnSelectSpeciesList.Name = "btnSelectSpeciesList";
            this.btnSelectSpeciesList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSpeciesList.TabIndex = 9;
            this.btnSelectSpeciesList.Text = "Select";
            this.btnSelectSpeciesList.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Press next to view values from the next data line.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Discard data lines whose hit eScore is below the value in the text area.";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(350, 384);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 12;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // chbRemove
            // 
            this.chbRemove.AutoSize = true;
            this.chbRemove.Location = new System.Drawing.Point(9, 230);
            this.chbRemove.Name = "chbRemove";
            this.chbRemove.Size = new System.Drawing.Size(149, 17);
            this.chbRemove.TabIndex = 13;
            this.chbRemove.Text = "Remove species not in list";
            this.chbRemove.UseVisualStyleBackColor = true;
            // 
            // chkKeep
            // 
            this.chkKeep.AutoSize = true;
            this.chkKeep.Location = new System.Drawing.Point(171, 230);
            this.chkKeep.Name = "chkKeep";
            this.chkKeep.Size = new System.Drawing.Size(116, 17);
            this.chkKeep.TabIndex = 14;
            this.chkKeep.Text = "Keep species in list";
            this.chkKeep.UseVisualStyleBackColor = true;
            // 
            // chkFlag
            // 
            this.chkFlag.AutoSize = true;
            this.chkFlag.Location = new System.Drawing.Point(9, 253);
            this.chkFlag.Name = "chkFlag";
            this.chkFlag.Size = new System.Drawing.Size(326, 17);
            this.chkFlag.TabIndex = 15;
            this.chkFlag.Text = "Flag sequences in list using name in text area as column header";
            this.chkFlag.UseVisualStyleBackColor = true;
            // 
            // txteScore
            // 
            this.txteScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txteScore.Location = new System.Drawing.Point(284, 329);
            this.txteScore.Name = "txteScore";
            this.txteScore.Size = new System.Drawing.Size(150, 20);
            this.txteScore.TabIndex = 16;
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 544);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FilterData";
            this.Text = "Filter and aggregate data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox txteScore;
    }
}