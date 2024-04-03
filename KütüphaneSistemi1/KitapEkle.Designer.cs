namespace KütüphaneSistemi1
{
    partial class KitapEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.kitapIsimTextBox = new System.Windows.Forms.TextBox();
            this.yazarTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SilButton = new System.Windows.Forms.Button();
            this.DuzenleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(415, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapIsimTextBox
            // 
            this.kitapIsimTextBox.Location = new System.Drawing.Point(33, 309);
            this.kitapIsimTextBox.Name = "kitapIsimTextBox";
            this.kitapIsimTextBox.Size = new System.Drawing.Size(216, 22);
            this.kitapIsimTextBox.TabIndex = 1;
            this.kitapIsimTextBox.Text = "KİTAP İSMİ";
            this.kitapIsimTextBox.TextChanged += new System.EventHandler(this.kitapIsimTextBox_TextChanged);
            // 
            // yazarTextBox
            // 
            this.yazarTextBox.Location = new System.Drawing.Point(33, 270);
            this.yazarTextBox.Name = "yazarTextBox";
            this.yazarTextBox.Size = new System.Drawing.Size(216, 22);
            this.yazarTextBox.TabIndex = 2;
            this.yazarTextBox.Text = "YAZAR İSMİ";
            this.yazarTextBox.TextChanged += new System.EventHandler(this.yazarTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 209);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SilButton
            // 
            this.SilButton.BackColor = System.Drawing.Color.Red;
            this.SilButton.Location = new System.Drawing.Point(415, 266);
            this.SilButton.Name = "SilButton";
            this.SilButton.Size = new System.Drawing.Size(89, 31);
            this.SilButton.TabIndex = 4;
            this.SilButton.Text = "SİL";
            this.SilButton.UseVisualStyleBackColor = false;
            this.SilButton.Click += new System.EventHandler(this.SilButton_Click);
            // 
            // DuzenleButton
            // 
            this.DuzenleButton.BackColor = System.Drawing.Color.Yellow;
            this.DuzenleButton.Location = new System.Drawing.Point(415, 337);
            this.DuzenleButton.Name = "DuzenleButton";
            this.DuzenleButton.Size = new System.Drawing.Size(89, 33);
            this.DuzenleButton.TabIndex = 5;
            this.DuzenleButton.Text = "DÜZENLE";
            this.DuzenleButton.UseVisualStyleBackColor = false;
            this.DuzenleButton.Click += new System.EventHandler(this.DuzenleButton_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DuzenleButton);
            this.Controls.Add(this.SilButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yazarTextBox);
            this.Controls.Add(this.kitapIsimTextBox);
            this.Controls.Add(this.button1);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kitapIsimTextBox;
        private System.Windows.Forms.TextBox yazarTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilButton;
        private System.Windows.Forms.Button DuzenleButton;
    }
}