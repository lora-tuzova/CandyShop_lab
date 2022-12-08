namespace CandyShop
{
    partial class Deletion
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
            this.DeleteCandy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteCandy
            // 
            this.DeleteCandy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DeleteCandy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCandy.Location = new System.Drawing.Point(158, 111);
            this.DeleteCandy.Name = "DeleteCandy";
            this.DeleteCandy.Size = new System.Drawing.Size(138, 50);
            this.DeleteCandy.TabIndex = 0;
            this.DeleteCandy.Text = "Delete";
            this.DeleteCandy.UseVisualStyleBackColor = true;
            this.DeleteCandy.Click += new System.EventHandler(this.DeleteCandy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name of candy you want to delete:";
            // 
            // Deletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteCandy);
            this.Name = "Deletion";
            this.Text = "Deletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteCandy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}