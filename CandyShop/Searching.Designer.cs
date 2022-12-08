namespace CandyShop
{
    partial class Searching
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
            this.SearchOption = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchOption
            // 
            this.SearchOption.Location = new System.Drawing.Point(285, 132);
            this.SearchOption.Name = "SearchOption";
            this.SearchOption.Size = new System.Drawing.Size(121, 59);
            this.SearchOption.TabIndex = 0;
            this.SearchOption.Text = "Confirm";
            this.SearchOption.UseVisualStyleBackColor = true;
            this.SearchOption.Click += new System.EventHandler(this.SearchOption_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Пошук за ціною",
            "Пошук за найменуванням",
            "Пошук за країною походження"});
            this.SearchComboBox.Location = new System.Drawing.Point(268, 86);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(152, 24);
            this.SearchComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please pick what category of search you want to perform";
            // 
            // Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SearchOption);
            this.Name = "Searching";
            this.Text = "Searching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchOption;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label1;
    }
}