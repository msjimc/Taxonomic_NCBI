namespace Taxonomic_NCBI
{
    partial class columnSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(columnSelection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIgnoreNones = new System.Windows.Forms.CheckBox();
            this.chkReverseOrder = new System.Windows.Forms.CheckBox();
            this.chkCombinefields = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPervious = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.chkSecondFromEnd = new System.Windows.Forms.CheckBox();
            this.chkFirstFromEnd = new System.Windows.Forms.CheckBox();
            this.nudSecondSecondColumn = new System.Windows.Forms.NumericUpDown();
            this.nudSecondFirstColumn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFirstSecondColumn = new System.Windows.Forms.NumericUpDown();
            this.nudFirstFirstColumn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondSplit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstSplit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondSecondColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondFirstColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstSecondColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstFirstColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkIgnoreNones);
            this.groupBox1.Controls.Add(this.chkReverseOrder);
            this.groupBox1.Controls.Add(this.chkCombinefields);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLine);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPervious);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSelected);
            this.groupBox1.Controls.Add(this.chkSecondFromEnd);
            this.groupBox1.Controls.Add(this.chkFirstFromEnd);
            this.groupBox1.Controls.Add(this.nudSecondSecondColumn);
            this.groupBox1.Controls.Add(this.nudSecondFirstColumn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudFirstSecondColumn);
            this.groupBox1.Controls.Add(this.nudFirstFirstColumn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSecondSplit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstSplit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(611, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name field select";
            // 
            // chkIgnoreNones
            // 
            this.chkIgnoreNones.AutoSize = true;
            this.chkIgnoreNones.Location = new System.Drawing.Point(156, 190);
            this.chkIgnoreNones.Margin = new System.Windows.Forms.Padding(2);
            this.chkIgnoreNones.Name = "chkIgnoreNones";
            this.chkIgnoreNones.Size = new System.Drawing.Size(122, 17);
            this.chkIgnoreNones.TabIndex = 10;
            this.chkIgnoreNones.Text = "Ignore \"None\" items";
            this.chkIgnoreNones.UseVisualStyleBackColor = true;
            this.chkIgnoreNones.CheckedChanged += new System.EventHandler(this.chkIgnoreNones_CheckedChanged);
            // 
            // chkReverseOrder
            // 
            this.chkReverseOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkReverseOrder.Location = new System.Drawing.Point(9, 243);
            this.chkReverseOrder.Name = "chkReverseOrder";
            this.chkReverseOrder.Size = new System.Drawing.Size(600, 17);
            this.chkReverseOrder.TabIndex = 15;
            this.chkReverseOrder.Text = "Reverse the order of the terms in the list: items at the start of the list are pr" +
    "ocessed first.";
            this.chkReverseOrder.UseVisualStyleBackColor = true;
            this.chkReverseOrder.CheckedChanged += new System.EventHandler(this.chkReverseOrder_CheckedChanged);
            // 
            // chkCombinefields
            // 
            this.chkCombinefields.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCombinefields.Location = new System.Drawing.Point(9, 212);
            this.chkCombinefields.Name = "chkCombinefields";
            this.chkCombinefields.Size = new System.Drawing.Size(600, 25);
            this.chkCombinefields.TabIndex = 14;
            this.chkCombinefields.Text = "If a field is split on a space, it may divide a name into two parts. Check this o" +
    "ption to combine two fields during the search.";
            this.chkCombinefields.UseVisualStyleBackColor = true;
            this.chkCombinefields.CheckedChanged += new System.EventHandler(this.chkCombinefields_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Selected indexes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Selected line";
            // 
            // txtLine
            // 
            this.txtLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLine.Location = new System.Drawing.Point(9, 325);
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(596, 51);
            this.txtLine.TabIndex = 20;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(530, 268);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPervious
            // 
            this.btnPervious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPervious.Location = new System.Drawing.Point(451, 268);
            this.btnPervious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPervious.Name = "btnPervious";
            this.btnPervious.Size = new System.Drawing.Size(75, 23);
            this.btnPervious.TabIndex = 17;
            this.btnPervious.Text = "Previous";
            this.btnPervious.UseVisualStyleBackColor = true;
            this.btnPervious.Click += new System.EventHandler(this.btnPervious_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "The selected data terms will appear below. Use the Next and Previous buttons to c" +
    "ycle through the first twenty lines.";
            // 
            // txtSelected
            // 
            this.txtSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelected.Location = new System.Drawing.Point(9, 395);
            this.txtSelected.Multiline = true;
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(596, 48);
            this.txtSelected.TabIndex = 22;
            this.txtSelected.TextChanged += new System.EventHandler(this.txtSelected_TextChanged);
            // 
            // chkSecondFromEnd
            // 
            this.chkSecondFromEnd.AutoSize = true;
            this.chkSecondFromEnd.Location = new System.Drawing.Point(282, 190);
            this.chkSecondFromEnd.Margin = new System.Windows.Forms.Padding(2);
            this.chkSecondFromEnd.Name = "chkSecondFromEnd";
            this.chkSecondFromEnd.Size = new System.Drawing.Size(165, 17);
            this.chkSecondFromEnd.TabIndex = 11;
            this.chkSecondFromEnd.Text = "Count from the end of the line";
            this.chkSecondFromEnd.UseVisualStyleBackColor = true;
            this.chkSecondFromEnd.CheckedChanged += new System.EventHandler(this.chkSecondFromEnd_CheckedChanged);
            // 
            // chkFirstFromEnd
            // 
            this.chkFirstFromEnd.AutoSize = true;
            this.chkFirstFromEnd.Location = new System.Drawing.Point(282, 146);
            this.chkFirstFromEnd.Margin = new System.Windows.Forms.Padding(2);
            this.chkFirstFromEnd.Name = "chkFirstFromEnd";
            this.chkFirstFromEnd.Size = new System.Drawing.Size(165, 17);
            this.chkFirstFromEnd.TabIndex = 6;
            this.chkFirstFromEnd.Text = "Count from the end of the line";
            this.chkFirstFromEnd.UseVisualStyleBackColor = true;
            this.chkFirstFromEnd.CheckedChanged += new System.EventHandler(this.chkFirstFromEnd_CheckedChanged);
            // 
            // nudSecondSecondColumn
            // 
            this.nudSecondSecondColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSecondSecondColumn.Location = new System.Drawing.Point(530, 187);
            this.nudSecondSecondColumn.Margin = new System.Windows.Forms.Padding(2);
            this.nudSecondSecondColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSecondSecondColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondSecondColumn.Name = "nudSecondSecondColumn";
            this.nudSecondSecondColumn.Size = new System.Drawing.Size(75, 20);
            this.nudSecondSecondColumn.TabIndex = 13;
            this.nudSecondSecondColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondSecondColumn.ValueChanged += new System.EventHandler(this.nudSecondSecondColumn_ValueChanged);
            // 
            // nudSecondFirstColumn
            // 
            this.nudSecondFirstColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSecondFirstColumn.Location = new System.Drawing.Point(451, 187);
            this.nudSecondFirstColumn.Margin = new System.Windows.Forms.Padding(2);
            this.nudSecondFirstColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSecondFirstColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondFirstColumn.Name = "nudSecondFirstColumn";
            this.nudSecondFirstColumn.Size = new System.Drawing.Size(75, 20);
            this.nudSecondFirstColumn.TabIndex = 12;
            this.nudSecondFirstColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondFirstColumn.ValueChanged += new System.EventHandler(this.nudSecondFirstColumn_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select the range of the values to be used in the selected column";
            // 
            // nudFirstSecondColumn
            // 
            this.nudFirstSecondColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFirstSecondColumn.Location = new System.Drawing.Point(530, 145);
            this.nudFirstSecondColumn.Margin = new System.Windows.Forms.Padding(2);
            this.nudFirstSecondColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFirstSecondColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstSecondColumn.Name = "nudFirstSecondColumn";
            this.nudFirstSecondColumn.Size = new System.Drawing.Size(75, 20);
            this.nudFirstSecondColumn.TabIndex = 8;
            this.nudFirstSecondColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstSecondColumn.ValueChanged += new System.EventHandler(this.nudFirstSecondColumn_ValueChanged);
            // 
            // nudFirstFirstColumn
            // 
            this.nudFirstFirstColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFirstFirstColumn.Location = new System.Drawing.Point(451, 144);
            this.nudFirstFirstColumn.Margin = new System.Windows.Forms.Padding(2);
            this.nudFirstFirstColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFirstFirstColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstFirstColumn.Name = "nudFirstFirstColumn";
            this.nudFirstFirstColumn.Size = new System.Drawing.Size(75, 20);
            this.nudFirstFirstColumn.TabIndex = 7;
            this.nudFirstFirstColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstFirstColumn.ValueChanged += new System.EventHandler(this.nudFirstFirstColumn_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select the range of columns to use. If the selected column is split, only one fie" +
    "ld can be chosen.";
            // 
            // txtSecondSplit
            // 
            this.txtSecondSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondSplit.Location = new System.Drawing.Point(530, 103);
            this.txtSecondSplit.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondSplit.Name = "txtSecondSplit";
            this.txtSecondSplit.Size = new System.Drawing.Size(75, 20);
            this.txtSecondSplit.TabIndex = 4;
            this.txtSecondSplit.TextChanged += new System.EventHandler(this.txtSecondSplit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Split the selected column using this character (leave empty to use the whole fiel" +
    "d). For a tab enter \'\\t\'";
            // 
            // txtFirstSplit
            // 
            this.txtFirstSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstSplit.Location = new System.Drawing.Point(530, 79);
            this.txtFirstSplit.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstSplit.Name = "txtFirstSplit";
            this.txtFirstSplit.Size = new System.Drawing.Size(75, 20);
            this.txtFirstSplit.TabIndex = 2;
            this.txtFirstSplit.TextChanged += new System.EventHandler(this.txtFirstSplit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Split the data line using this character (leave empty to use the whole line). For" +
    " a tab, enter \\t.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(463, 465);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(542, 465);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // columnSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 502);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(651, 541);
            this.Name = "columnSelection";
            this.Text = "BLAST hit file annotation";
            this.Load += new System.EventHandler(this.columnSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondSecondColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondFirstColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstSecondColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstFirstColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPervious;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.CheckBox chkSecondFromEnd;
        private System.Windows.Forms.CheckBox chkFirstFromEnd;
        private System.Windows.Forms.NumericUpDown nudSecondSecondColumn;
        private System.Windows.Forms.NumericUpDown nudSecondFirstColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFirstSecondColumn;
        private System.Windows.Forms.NumericUpDown nudFirstFirstColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondSplit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.CheckBox chkCombinefields;
        private System.Windows.Forms.CheckBox chkReverseOrder;
        private System.Windows.Forms.CheckBox chkIgnoreNones;
    }
}