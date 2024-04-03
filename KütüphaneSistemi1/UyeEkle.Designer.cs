namespace KütüphaneSistemi1
{
    partial class UyeEkle
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
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SilButton = new System.Windows.Forms.Button();
            this.DuzenleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(97, 271);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Kayıt";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(97, 60);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(97, 107);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(417, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SilButton
            // 
            this.SilButton.Location = new System.Drawing.Point(562, 270);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(75, 23);
            this.SilButton.TabIndex = 4;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = true;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // DuzenleButton
            // 
            this.DuzenleButton.Location = new System.Drawing.Point(448, 270);
            this.DuzenleButton.Name = "DuzenleButton";
            this.DuzenleButton.Size = new System.Drawing.Size(75, 23);
            this.DuzenleButton.TabIndex = 5;
            this.DuzenleButton.Text = "Düzenle";
            this.DuzenleButton.UseVisualStyleBackColor = true;
            this.DuzenleButton.Click += new System.EventHandler(this.DuzenleButton_Click);
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DuzenleButton);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnUyeEkle);
            this.Name = "UyeEkle";
            this.Text = "UyelikIslemleri";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button DuzenleButton;
    }
}