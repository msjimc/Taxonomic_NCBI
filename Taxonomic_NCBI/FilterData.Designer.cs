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
            this.btnSelectSpeciesList = new System.Windows.Forms.Button();
            this.txtFlaggedColoumnName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAggregateVlaues = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboDataEnd = new System.Windows.Forms.ComboBox();
            this.cboDataStart = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboSpeciesfilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rboFlagInList = new System.Windows.Forms.RadioButton();
            this.rdoKeepIfInList = new System.Windows.Forms.RadioButton();
            this.rdoRemoveIfInList = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFilterCutOff = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoLowerThanCutOff = new System.Windows.Forms.RadioButton();
            this.rdoHigherThanCutOff = new System.Windows.Forms.RadioButton();
            this.cboColumnToFilter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblLowerReadCountErrorMessage = new System.Windows.Forms.Label();
            this.txtMinimumReadCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFilterMinimumReadCount = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.btnSelectDataFile.Location = new System.Drawing.Point(459, 43);
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
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the data file to process by pressing the \'Select\' button";
            // 
            // btnSelectSpeciesList
            // 
            this.btnSelectSpeciesList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSpeciesList.Location = new System.Drawing.Point(459, 26);
            this.btnSelectSpeciesList.Name = "btnSelectSpeciesList";
            this.btnSelectSpeciesList.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSpeciesList.TabIndex = 1;
            this.btnSelectSpeciesList.Text = "List";
            this.btnSelectSpeciesList.UseVisualStyleBackColor = true;
            this.btnSelectSpeciesList.Click += new System.EventHandler(this.btnSelectSpeciesList_Click);
            // 
            // txtFlaggedColoumnName
            // 
            this.txtFlaggedColoumnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlaggedColoumnName.Enabled = false;
            this.txtFlaggedColoumnName.Location = new System.Drawing.Point(384, 85);
            this.txtFlaggedColoumnName.Name = "txtFlaggedColoumnName";
            this.txtFlaggedColoumnName.Size = new System.Drawing.Size(150, 20);
            this.txtFlaggedColoumnName.TabIndex = 5;
            this.txtFlaggedColoumnName.TextChanged += new System.EventHandler(this.txtFlaggedColoumnName_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select an example of the phylogenetic class to which you want to aggregate the da" +
    "ta.";
            // 
            // cboAggregateVlaues
            // 
            this.cboAggregateVlaues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAggregateVlaues.FormattingEnabled = true;
            this.cboAggregateVlaues.Location = new System.Drawing.Point(384, 49);
            this.cboAggregateVlaues.Name = "cboAggregateVlaues";
            this.cboAggregateVlaues.Size = new System.Drawing.Size(150, 21);
            this.cboAggregateVlaues.TabIndex = 4;
            this.cboAggregateVlaues.SelectedIndexChanged += new System.EventHandler(this.cboAggregateVlaues_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "To aggregate read counts at a taxonomic level, select the taxonomic level name fr" +
    "om the dropdown list.\nThen select the first and last sample columns using the dr" +
    "opdown lists, and press Combine.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(12, 735);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCombine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboAggregateVlaues);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 612);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 118);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggregate reads count data at taxomomic level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "and end at";
            // 
            // cboDataEnd
            // 
            this.cboDataEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataEnd.FormattingEnabled = true;
            this.cboDataEnd.Location = new System.Drawing.Point(384, 72);
            this.cboDataEnd.Name = "cboDataEnd";
            this.cboDataEnd.Size = new System.Drawing.Size(150, 21);
            this.cboDataEnd.TabIndex = 8;
            this.cboDataEnd.SelectedIndexChanged += new System.EventHandler(this.cboDataEnd_SelectedIndexChanged);
            // 
            // cboDataStart
            // 
            this.cboDataStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataStart.FormattingEnabled = true;
            this.cboDataStart.Location = new System.Drawing.Point(193, 72);
            this.cboDataStart.Name = "cboDataStart";
            this.cboDataStart.Size = new System.Drawing.Size(121, 21);
            this.cboDataStart.TabIndex = 6;
            this.cboDataStart.SelectedIndexChanged += new System.EventHandler(this.cboDataStart_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Read count values start at:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Press \'Combine\' to aggragate read counts";
            // 
            // btnCombine
            // 
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(459, 81);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 10;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSpeciesfilter);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rboFlagInList);
            this.groupBox3.Controls.Add(this.rdoKeepIfInList);
            this.groupBox3.Controls.Add(this.rdoRemoveIfInList);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnCompare);
            this.groupBox3.Controls.Add(this.txtFlaggedColoumnName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSelectSpeciesList);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 171);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter species in a list";
            // 
            // cboSpeciesfilter
            // 
            this.cboSpeciesfilter.FormattingEnabled = true;
            this.cboSpeciesfilter.Location = new System.Drawing.Point(384, 111);
            this.cboSpeciesfilter.Name = "cboSpeciesfilter";
            this.cboSpeciesfilter.Size = new System.Drawing.Size(150, 21);
            this.cboSpeciesfilter.TabIndex = 7;
            this.cboSpeciesfilter.SelectedIndexChanged += new System.EventHandler(this.cboSpeciesfilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Select the taxonomic level to use for comparison.";
            // 
            // rboFlagInList
            // 
            this.rboFlagInList.AutoSize = true;
            this.rboFlagInList.Location = new System.Drawing.Point(6, 86);
            this.rboFlagInList.Name = "rboFlagInList";
            this.rboFlagInList.Size = new System.Drawing.Size(325, 17);
            this.rboFlagInList.TabIndex = 4;
            this.rboFlagInList.TabStop = true;
            this.rboFlagInList.Text = "Flag sequences in list using name in text area as column header";
            this.rboFlagInList.UseVisualStyleBackColor = true;
            this.rboFlagInList.CheckedChanged += new System.EventHandler(this.rboFlagInList_CheckedChanged);
            // 
            // rdoKeepIfInList
            // 
            this.rdoKeepIfInList.AutoSize = true;
            this.rdoKeepIfInList.Location = new System.Drawing.Point(165, 63);
            this.rdoKeepIfInList.Name = "rdoKeepIfInList";
            this.rdoKeepIfInList.Size = new System.Drawing.Size(115, 17);
            this.rdoKeepIfInList.TabIndex = 3;
            this.rdoKeepIfInList.TabStop = true;
            this.rdoKeepIfInList.Text = "Keep species in list";
            this.rdoKeepIfInList.UseVisualStyleBackColor = true;
            this.rdoKeepIfInList.CheckedChanged += new System.EventHandler(this.rdoKeepIfInList_CheckedChanged);
            // 
            // rdoRemoveIfInList
            // 
            this.rdoRemoveIfInList.AutoSize = true;
            this.rdoRemoveIfInList.Location = new System.Drawing.Point(6, 63);
            this.rdoRemoveIfInList.Name = "rdoRemoveIfInList";
            this.rdoRemoveIfInList.Size = new System.Drawing.Size(130, 17);
            this.rdoRemoveIfInList.TabIndex = 2;
            this.rdoRemoveIfInList.TabStop = true;
            this.rdoRemoveIfInList.Text = "Remove species in list";
            this.rdoRemoveIfInList.UseVisualStyleBackColor = true;
            this.rdoRemoveIfInList.CheckedChanged += new System.EventHandler(this.rdoRemoveIfInList_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Press \'Compare\' to process species names";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(459, 138);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblFilterCutOff);
            this.groupBox4.Controls.Add(this.btnFilter);
            this.groupBox4.Controls.Add(this.txtCutOff);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.rdoLowerThanCutOff);
            this.groupBox4.Controls.Add(this.rdoHigherThanCutOff);
            this.groupBox4.Controls.Add(this.cboColumnToFilter);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 160);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter data by BLAST hit value";
            // 
            // lblFilterCutOff
            // 
            this.lblFilterCutOff.AutoSize = true;
            this.lblFilterCutOff.ForeColor = System.Drawing.Color.Red;
            this.lblFilterCutOff.Location = new System.Drawing.Point(311, 103);
            this.lblFilterCutOff.Name = "lblFilterCutOff";
            this.lblFilterCutOff.Size = new System.Drawing.Size(67, 13);
            this.lblFilterCutOff.TabIndex = 7;
            this.lblFilterCutOff.Text = "Invalid value";
            this.lblFilterCutOff.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(459, 126);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtCutOff
            // 
            this.txtCutOff.Location = new System.Drawing.Point(384, 100);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(150, 20);
            this.txtCutOff.TabIndex = 8;
            this.txtCutOff.TextChanged += new System.EventHandler(this.txtCutOff_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Press \'Filter\' to process the data rows";
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
            // rdoLowerThanCutOff
            // 
            this.rdoLowerThanCutOff.AutoSize = true;
            this.rdoLowerThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoLowerThanCutOff.Location = new System.Drawing.Point(294, 76);
            this.rdoLowerThanCutOff.Name = "rdoLowerThanCutOff";
            this.rdoLowerThanCutOff.Size = new System.Drawing.Size(215, 17);
            this.rdoLowerThanCutOff.TabIndex = 5;
            this.rdoLowerThanCutOff.TabStop = true;
            this.rdoLowerThanCutOff.Text = "Retain data equal to or lower than cutoff";
            this.rdoLowerThanCutOff.UseVisualStyleBackColor = true;
            this.rdoLowerThanCutOff.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoHigherThanCutOff
            // 
            this.rdoHigherThanCutOff.AutoSize = true;
            this.rdoHigherThanCutOff.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoHigherThanCutOff.Location = new System.Drawing.Point(6, 76);
            this.rdoHigherThanCutOff.Name = "rdoHigherThanCutOff";
            this.rdoHigherThanCutOff.Size = new System.Drawing.Size(219, 17);
            this.rdoHigherThanCutOff.TabIndex = 4;
            this.rdoHigherThanCutOff.TabStop = true;
            this.rdoHigherThanCutOff.Text = "Retain data equal to or higher than cutoff";
            this.rdoHigherThanCutOff.UseVisualStyleBackColor = true;
            this.rdoHigherThanCutOff.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cboColumnToFilter
            // 
            this.cboColumnToFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnToFilter.FormattingEnabled = true;
            this.cboColumnToFilter.Location = new System.Drawing.Point(384, 50);
            this.cboColumnToFilter.Name = "cboColumnToFilter";
            this.cboColumnToFilter.Size = new System.Drawing.Size(150, 21);
            this.cboColumnToFilter.TabIndex = 2;
            this.cboColumnToFilter.SelectedIndexChanged += new System.EventHandler(this.cboColumnToFilter_SelectedIndexChanged);
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
            this.label11.Text = "To filter data by a value in a column, select the column, choose whether the valu" +
    "e should be above or below the cutoff, and then enter the cutoff.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.btnFilterMinimumReadCount);
            this.groupBox5.Controls.Add(this.lblLowerReadCountErrorMessage);
            this.groupBox5.Controls.Add(this.txtMinimumReadCount);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(12, 486);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(540, 120);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Excluded data row based on total read count";
            // 
            // lblLowerReadCountErrorMessage
            // 
            this.lblLowerReadCountErrorMessage.AutoSize = true;
            this.lblLowerReadCountErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLowerReadCountErrorMessage.Location = new System.Drawing.Point(311, 57);
            this.lblLowerReadCountErrorMessage.Name = "lblLowerReadCountErrorMessage";
            this.lblLowerReadCountErrorMessage.Size = new System.Drawing.Size(67, 13);
            this.lblLowerReadCountErrorMessage.TabIndex = 10;
            this.lblLowerReadCountErrorMessage.Text = "Invalid value";
            this.lblLowerReadCountErrorMessage.Visible = false;
            // 
            // txtMinimumReadCount
            // 
            this.txtMinimumReadCount.Location = new System.Drawing.Point(384, 54);
            this.txtMinimumReadCount.Name = "txtMinimumReadCount";
            this.txtMinimumReadCount.Size = new System.Drawing.Size(150, 20);
            this.txtMinimumReadCount.TabIndex = 11;
            this.txtMinimumReadCount.TextChanged += new System.EventHandler(this.txtMinimumReadCount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter the cut off value";
            // 
            // btnFilterMinimumReadCount
            // 
            this.btnFilterMinimumReadCount.Enabled = false;
            this.btnFilterMinimumReadCount.Location = new System.Drawing.Point(459, 80);
            this.btnFilterMinimumReadCount.Name = "btnFilterMinimumReadCount";
            this.btnFilterMinimumReadCount.Size = new System.Drawing.Size(75, 23);
            this.btnFilterMinimumReadCount.TabIndex = 12;
            this.btnFilterMinimumReadCount.Text = "Filter";
            this.btnFilterMinimumReadCount.UseVisualStyleBackColor = true;
            this.btnFilterMinimumReadCount.Click += new System.EventHandler(this.btnFilterMinimumReadCount_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Press \'Filter\' to remove data row with low read count";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(526, 36);
            this.label18.TabIndex = 14;
            this.label18.Text = "To filter rows by total read count, enter the minimum value, then use the dropdow" +
    "n lists to select the first and last data columns before pressing \'Filter\'.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "After filtering and combining read count data press \'Save\' to save the data.";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(459, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(526, 32);
            this.label19.TabIndex = 11;
            this.label19.Text = resources.GetString("label19.Text");
            // 
            // FilterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 770);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FilterData";
            this.Text = "Filter and aggregate species data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectSpeciesList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFlaggedColoumnName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAggregateVlaues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtCutOff;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoLowerThanCutOff;
        private System.Windows.Forms.RadioButton rdoHigherThanCutOff;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboDataEnd;
        private System.Windows.Forms.ComboBox cboDataStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFilterCutOff;
        private System.Windows.Forms.RadioButton rboFlagInList;
        private System.Windows.Forms.RadioButton rdoKeepIfInList;
        private System.Windows.Forms.RadioButton rdoRemoveIfInList;
        private System.Windows.Forms.ComboBox cboSpeciesfilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnFilterMinimumReadCount;
        private System.Windows.Forms.Label lblLowerReadCountErrorMessage;
        private System.Windows.Forms.TextBox txtMinimumReadCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
    }
}