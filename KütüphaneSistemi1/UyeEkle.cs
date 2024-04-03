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
                RefreshDataGridView(); // DataGridView'i güncelle
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;

            // Yeni bir Uye nesnesi oluştur
            Uye yeniUye = new Uye(ad, soyad);

            // Uye listesine ekle
            uyeListesi.Add(yeniUye);

            // JSON dosyasına kaydet
            SaveUyeListesi();

            // Formu kapat
            this.Close();
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
