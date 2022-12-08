namespace CandyShop
{
    partial class DetailedSearch
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
            this.SearchConfirmation = new System.Windows.Forms.Button();
            this.SearchDetail = new System.Windows.Forms.TextBox();
            this.CheckSearchDetail = new System.Windows.Forms.Button();
            this.LocalRB = new System.Windows.Forms.RadioButton();
            this.ImportedRB = new System.Windows.Forms.RadioButton();
            this.Category = new System.Windows.Forms.Label();
            this.RadiobuttonsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchConfirmation
            // 
            this.SearchConfirmation.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SearchConfirmation.Enabled = false;
            this.SearchConfirmation.Location = new System.Drawing.Point(334, 139);
            this.SearchConfirmation.Name = "SearchConfirmation";
            this.SearchConfirmation.Size = new System.Drawing.Size(95, 55);
            this.SearchConfirmation.TabIndex = 0;
            this.SearchConfirmation.Text = "Confirm";
            this.SearchConfirmation.UseVisualStyleBackColor = true;
            this.SearchConfirmation.Click += new System.EventHandler(this.SearchConfirmation_Click);
            // 
            // SearchDetail
            // 
            this.SearchDetail.Location = new System.Drawing.Point(233, 73);
            this.SearchDetail.Name = "SearchDetail";
            this.SearchDetail.Size = new System.Drawing.Size(196, 22);
            this.SearchDetail.TabIndex = 1;
            // 
            // CheckSearchDetail
            // 
            this.CheckSearchDetail.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.CheckSearchDetail.Location = new System.Drawing.Point(233, 139);
            this.CheckSearchDetail.Name = "CheckSearchDetail";
            this.CheckSearchDetail.Size = new System.Drawing.Size(95, 55);
            this.CheckSearchDetail.TabIndex = 2;
            this.CheckSearchDetail.Text = "Check";
            this.CheckSearchDetail.UseVisualStyleBackColor = true;
            this.CheckSearchDetail.Click += new System.EventHandler(this.CheckSearchDetail_Click);
            // 
            // LocalRB
            // 
            this.LocalRB.AutoSize = true;
            this.LocalRB.Location = new System.Drawing.Point(233, 275);
            this.LocalRB.Name = "LocalRB";
            this.LocalRB.Size = new System.Drawing.Size(61, 20);
            this.LocalRB.TabIndex = 3;
            this.LocalRB.TabStop = true;
            this.LocalRB.Text = "Local";
            this.LocalRB.UseVisualStyleBackColor = true;
            this.LocalRB.Visible = false;
            // 
            // ImportedRB
            // 
            this.ImportedRB.AutoSize = true;
            this.ImportedRB.Location = new System.Drawing.Point(348, 275);
            this.ImportedRB.Name = "ImportedRB";
            this.ImportedRB.Size = new System.Drawing.Size(81, 20);
            this.ImportedRB.TabIndex = 4;
            this.ImportedRB.TabStop = true;
            this.ImportedRB.Text = "Imported";
            this.ImportedRB.UseVisualStyleBackColor = true;
            this.ImportedRB.Visible = false;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(192, 31);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(0, 16);
            this.Category.TabIndex = 8;
            // 
            // RadiobuttonsLabel
            // 
            this.RadiobuttonsLabel.AutoSize = true;
            this.RadiobuttonsLabel.Location = new System.Drawing.Point(192, 232);
            this.RadiobuttonsLabel.Name = "RadiobuttonsLabel";
            this.RadiobuttonsLabel.Size = new System.Drawing.Size(347, 16);
            this.RadiobuttonsLabel.TabIndex = 9;
            this.RadiobuttonsLabel.Text = "Would you want local or imported candy to be displayed?";
            this.RadiobuttonsLabel.Visible = false;
            // 
            // DetailedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RadiobuttonsLabel);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ImportedRB);
            this.Controls.Add(this.LocalRB);
            this.Controls.Add(this.CheckSearchDetail);
            this.Controls.Add(this.SearchDetail);
            this.Controls.Add(this.SearchConfirmation);
            this.Name = "DetailedSearch";
            this.Text = "DetailedSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button SearchConfirmation;
        protected System.Windows.Forms.TextBox SearchDetail;
        private System.Windows.Forms.Button CheckSearchDetail;
        private System.Windows.Forms.RadioButton LocalRB;
        private System.Windows.Forms.RadioButton ImportedRB;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label RadiobuttonsLabel;
    }
}