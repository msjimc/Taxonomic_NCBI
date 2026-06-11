namespace Taxonomic_NCBI
{
    partial class FilterByReadCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterByReadCount));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFilterMinimumReadCount = new System.Windows.Forms.Button();
            this.lblLowerReadCountErrorMessage = new System.Windows.Forms.Label();
            this.txtMinimumReadCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.btnFilterMinimumReadCount);
            this.groupBox5.Controls.Add(this.lblLowerReadCountErrorMessage);
            this.groupBox5.Controls.Add(this.txtMinimumReadCount);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(540, 120);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Excluded data row based on total read count";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(251, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Press \'Filter\' to remove data row with low read count";
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(469, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(388, 138);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // FilterByReadCount
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(572, 169);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FilterByReadCount";
            this.Text = "Filter by total read count";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnFilterMinimumReadCount;
        private System.Windows.Forms.Label lblLowerReadCountErrorMessage;
        private System.Windows.Forms.TextBox txtMinimumReadCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}