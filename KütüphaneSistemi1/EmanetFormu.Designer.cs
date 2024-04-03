namespace KütüphaneSistemi1
{
    partial class EmanetFormu
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
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.listBoxUyeler = new System.Windows.Forms.ListBox();
            this.listBoxKitaplar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEmanetVer.Location = new System.Drawing.Point(54, 293);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(135, 59);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet İşlemini Onayla";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click_1);
            // 
            // listBoxUyeler
            // 
            this.listBoxUyeler.FormattingEnabled = true;
            this.listBoxUyeler.ItemHeight = 16;
            this.listBoxUyeler.Location = new System.Drawing.Point(54, 46);
            this.listBoxUyeler.Name = "listBoxUyeler";
            this.listBoxUyeler.Size = new System.Drawing.Size(274, 84);
            this.listBoxUyeler.TabIndex = 1;
            // 
            // listBoxKitaplar
            // 
            this.listBoxKitaplar.FormattingEnabled = true;
            this.listBoxKitaplar.ItemHeight = 16;
            this.listBoxKitaplar.Location = new System.Drawing.Point(386, 46);
            this.listBoxKitaplar.Name = "listBoxKitaplar";
            this.listBoxKitaplar.Size = new System.Drawing.Size(275, 84);
            this.listBoxKitaplar.TabIndex = 2;
            // 
            // EmanetFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxKitaplar);
            this.Controls.Add(this.listBoxUyeler);
            this.Controls.Add(this.btnEmanetVer);
            this.Name = "EmanetFormu";
            this.Text = "EmanetFormu";
            this.Load += new System.EventHandler(this.EmanetFormu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.ListBox listBoxUyeler;
        private System.Windows.Forms.ListBox listBoxKitaplar;
    }
}