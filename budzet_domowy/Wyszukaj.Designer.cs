namespace budzet_domowy
{
    partial class Wyszukaj
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
            this.WyszukajTextBox = new System.Windows.Forms.TextBox();
            this.WyszukajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WyszukajTextBox
            // 
            this.WyszukajTextBox.Location = new System.Drawing.Point(24, 21);
            this.WyszukajTextBox.Name = "WyszukajTextBox";
            this.WyszukajTextBox.Size = new System.Drawing.Size(226, 22);
            this.WyszukajTextBox.TabIndex = 0;
            // 
            // WyszukajButton
            // 
            this.WyszukajButton.Location = new System.Drawing.Point(24, 59);
            this.WyszukajButton.Name = "WyszukajButton";
            this.WyszukajButton.Size = new System.Drawing.Size(226, 23);
            this.WyszukajButton.TabIndex = 1;
            this.WyszukajButton.Text = "WYSZUKAJ";
            this.WyszukajButton.UseVisualStyleBackColor = true;
            this.WyszukajButton.Click += new System.EventHandler(this.WyszukajButton_Click);
            // 
            // Wyszukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 103);
            this.Controls.Add(this.WyszukajButton);
            this.Controls.Add(this.WyszukajTextBox);
            this.Name = "Wyszukaj";
            this.Text = "FormWyszukaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WyszukajTextBox;
        private System.Windows.Forms.Button WyszukajButton;
    }
}