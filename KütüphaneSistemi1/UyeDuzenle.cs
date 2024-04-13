using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneSistemi1
{
    public partial class UyeDuzenle : Form
    {
        private Uye duzenlenecekUye;

        public UyeDuzenle(Uye uye)
        {
            InitializeComponent();
            duzenlenecekUye = uye;

            // Üye bilgilerini form kontrollerine yükle
            LoadUyeInfo();
        }

        private void LoadUyeInfo()
        {
            // Üye bilgilerini TextBox'lara yükle
            uyeIdTextBox.Text = duzenlenecekUye.UyeId.ToString();
            adTextBox.Text = duzenlenecekUye.Ad;
            soyadTextBox.Text = duzenlenecekUye.Soyad;
        }

        private void UpdateUyeInSQLite()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\aliha\\source\\repos\\KütüphaneSistemi1\\KütüphaneSistemi1\\f\\kutuphanesistemidatabase.db;Version=3;"))
                {
                    connection.Open();

                    string query = "UPDATE uye SET ad = @ad, soyad = @soyad WHERE UyeId = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ad", adTextBox.Text);
                        command.Parameters.AddWithValue("@soyad", soyadTextBox.Text);
                        command.Parameters.AddWithValue("@id", duzenlenecekUye.UyeId);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye bilgileri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
        private void KaydetButton_Click(object sender, EventArgs e)
        {
            string yeniAd = adTextBox.Text;
            string yeniSoyad = soyadTextBox.Text;

            // Üye bilgilerini güncelle
            duzenlenecekUye.Ad = yeniAd;
            duzenlenecekUye.Soyad = yeniSoyad;

            // SQLite veritabanında üye bilgilerini güncelle
            UpdateUyeInSQLite();

            // Ana formu güncelle
            ((UyeEkle)this.Owner).RefreshDataGridView();

            // Düzenleme formunu kapat
            this.Close();
        }

        private void UyeDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
