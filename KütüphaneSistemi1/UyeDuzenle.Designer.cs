namespace KütüphaneSistemi1
{
    partial class UyeDuzenle
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
            this.uyeIdTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeIdTextBox
            // 
            this.uyeIdTextBox.HideSelection = false;
            this.uyeIdTextBox.Location = new System.Drawing.Point(106, 53);
            this.uyeIdTextBox.Name = "uyeIdTextBox";
            this.uyeIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.uyeIdTextBox.TabIndex = 0;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(106, 102);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 22);
            this.adTextBox.TabIndex = 1;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(106, 151);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadTextBox.TabIndex = 2;
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(106, 231);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(75, 23);
            this.KaydetButton.TabIndex = 3;
            this.KaydetButton.Text = "button1";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // UyeDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.uyeIdTextBox);
            this.Name = "UyeDuzenle";
            this.Text = "UyeDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uyeIdTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.Button KaydetButton;
    }
}