namespace KütüphaneSistemi1
{
    partial class KitapDuzenle
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
            this.kitapIdTextBox = new System.Windows.Forms.TextBox();
            this.kitapIsimTextBox = new System.Windows.Forms.TextBox();
            this.YazarBox = new System.Windows.Forms.TextBox();
            this.KaydetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapIdTextBox
            // 
            this.kitapIdTextBox.Location = new System.Drawing.Point(47, 71);
            this.kitapIdTextBox.Name = "kitapIdTextBox";
            this.kitapIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapIdTextBox.TabIndex = 0;
            this.kitapIdTextBox.TextChanged += new System.EventHandler(this.kitapIdTextBox_TextChanged);
            // 
            // kitapIsimTextBox
            // 
            this.kitapIsimTextBox.Location = new System.Drawing.Point(47, 118);
            this.kitapIsimTextBox.Name = "kitapIsimTextBox";
            this.kitapIsimTextBox.Size = new System.Drawing.Size(100, 22);
            this.kitapIsimTextBox.TabIndex = 1;
            this.kitapIsimTextBox.TextChanged += new System.EventHandler(this.kitapIsimTextBox_TextChanged);
            // 
            // YazarBox
            // 
            this.YazarBox.Location = new System.Drawing.Point(47, 164);
            this.YazarBox.Name = "YazarBox";
            this.YazarBox.Size = new System.Drawing.Size(100, 22);
            this.YazarBox.TabIndex = 2;
            this.YazarBox.TextChanged += new System.EventHandler(this.YazarBox_TextChanged);
            // 
            // KaydetButton
            // 
            this.KaydetButton.Location = new System.Drawing.Point(72, 241);
            this.KaydetButton.Name = "KaydetButton";
            this.KaydetButton.Size = new System.Drawing.Size(75, 23);
            this.KaydetButton.TabIndex = 3;
            this.KaydetButton.Text = "Kaydet";
            this.KaydetButton.UseVisualStyleBackColor = true;
            this.KaydetButton.Click += new System.EventHandler(this.KaydetButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KitapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KaydetButton);
            this.Controls.Add(this.YazarBox);
            this.Controls.Add(this.kitapIsimTextBox);
            this.Controls.Add(this.kitapIdTextBox);
            this.Name = "KitapDuzenle";
            this.Text = "KitapDuzenle";
            this.Load += new System.EventHandler(this.KitapDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kitapIdTextBox;
        private System.Windows.Forms.TextBox kitapIsimTextBox;
        private System.Windows.Forms.TextBox YazarBox;
        private System.Windows.Forms.Button KaydetButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}