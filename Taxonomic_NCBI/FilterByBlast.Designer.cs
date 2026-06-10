namespace Taxonomic_NCBI
{
    partial class FilterByBlast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterByBlast));
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox4.Location = new System.Drawing.Point(16, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 160);
            this.groupBox4.TabIndex = 3;
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
            this.rdoLowerThanCutOff.CheckedChanged += new System.EventHandler(this.rdoLowerThanCutOff_CheckedChanged);
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
            this.rdoHigherThanCutOff.CheckedChanged += new System.EventHandler(this.rdoHigherThanCutOff_CheckedChanged);
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(475, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(394, 178);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // FilterByBlast
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(568, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FilterByBlast";
            this.Text = "FilterByBlast";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFilterCutOff;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtCutOff;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdoLowerThanCutOff;
        private System.Windows.Forms.RadioButton rdoHigherThanCutOff;
        private System.Windows.Forms.ComboBox cboColumnToFilter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}