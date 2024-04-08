using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.SQLite;

namespace KütüphaneSistemi1
{
    public partial class UyeEkle : Form
    {
        private UyeListesi uyeListesi;

        public UyeEkle()
        {
            InitializeComponent();
            uyeListesi = LoadUyeListesi();
          
        }

        private void SaveUyeListesi()
        {
            string dosyaYolu = "uyeler.json";
            string json = JsonConvert.SerializeObject(uyeListesi);
            File.WriteAllText(dosyaYolu, json);
        }

        private UyeListesi LoadUyeListesi()
        {
            string dosyaYolu = "uyeler.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                return JsonConvert.DeserializeObject<UyeListesi>(json);
            }
            else
            {
                return new UyeListesi();
            }
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                dataGridView1.Columns.Add("UyeIdColumn", "Üye ID");
                dataGridView1.Columns.Add("AdColumn", "Üye İsmi");
                dataGridView1.Columns.Add("SoyadColumn", "Üye Soyad");

                // SQLite veritabanından verileri yükle
                LoadUyelerFromSQLite();

                RefreshDataGridView(); // DataGridView'i güncelle
            }
        }

        private void LoadUyelerFromSQLite()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\aliha\\source\\repos\\KütüphaneSistemi1\\KütüphaneSistemi1\\f\\kutuphanesistemidatabase.db;Version=3;"))
                {
                    connection.Open();

                    string query = "SELECT * FROM Uye";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int uyeId = reader.GetInt32(reader.GetOrdinal("UyeId"));
                                string ad = reader.GetString(reader.GetOrdinal("Ad"));
                                string soyad = reader.GetString(reader.GetOrdinal("Soyad"));

                                // Yüklenen verileri UyeListesi'ne ekle
                                uyeListesi.Add(new Uye(ad, soyad, uyeId));
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // SQLite veritabanına kayıt ekle
            KayitEkle(ad, soyad);

            // Formu kapat
            this.Close();
        }
        private void KayitEkle(string ad, string soyad)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=C:\\Users\\aliha\\source\\repos\\KütüphaneSistemi1\\KütüphaneSistemi1\\f\\kutuphanesistemidatabase.db;Version=3;"))
                {
                    connection.Open();

                    string query = "INSERT INTO Uye (Ad, Soyad) VALUES (@ad, @soyad)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ad", ad);
                        command.Parameters.AddWithValue("@soyad", soyad);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt eklenirken bir hata oluştu: " + ex.Message);
            }

        }


        internal void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var uye in uyeListesi)
            {
                dataGridView1.Rows.Add(uye.UyeId, uye.Ad, uye.Soyad);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // UyeListesi'nden seçili satıra karşılık gelen üyeyi kaldır
                uyeListesi.RemoveAt(rowIndex);

                // DataGridView'i güncelle
                RefreshDataGridView();

                // JSON dosyasına kaydet
                SaveUyeListesi();
            }
            
        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satıra karşılık gelen Uye nesnesini al
                Uye seciliUye = uyeListesi[rowIndex];

                // UyeDuzenle formunu oluştur ve aç
                UyeDuzenle duzenleForm = new UyeDuzenle(seciliUye);
                duzenleForm.Owner = this; // UyeEkle formunu Owner olarak ayarla
                duzenleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir üye seçin.");
            }
        }
    }
}
