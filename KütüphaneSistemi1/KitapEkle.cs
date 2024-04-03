using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace KütüphaneSistemi1
{
    public partial class KitapEkle : Form
    {
        private KitapListesi kitapListesi;

        public KitapEkle()
        {
            InitializeComponent();
            kitapListesi = LoadKitapListesi();
        }
        private void SaveKitapListesi()
        {
            string dosyaYolu = "kitaplar.json";
            string json = JsonConvert.SerializeObject(kitapListesi);
            File.WriteAllText(dosyaYolu, json);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kitapIsim = kitapIsimTextBox.Text;
            string yazar = yazarTextBox.Text;

            // Yeni bir Kitap nesnesi oluştur
            Kitap yeniKitap = new Kitap(kitapIsim, yazar);

            // Kitap listesine ekle
            kitapListesi.Add(yeniKitap);

            // JSON dosyasına kaydet
            SaveKitapListesi();

            // Formu kapat
            this.Close();
        }
        private KitapListesi LoadKitapListesi()
        {
            string dosyaYolu = "kitaplar.json";
            if (File.Exists(dosyaYolu))
            {
                string json = File.ReadAllText(dosyaYolu);
                return JsonConvert.DeserializeObject<KitapListesi>(json);
            }
            else
            {
                return new KitapListesi();
            }
        }
        private void kitapIsimTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yazarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("KitapIdColumn", "Kitap ID");
            dataGridView1.Columns.Add("KitapIsimColumn", "Kitap İsmi");
            dataGridView1.Columns.Add("YazarColumn", "Yazar");

            // DataGridView'i güncelle
            RefreshDataGridView();
        }

        internal void RefreshDataGridView()
        {
            // DataGridView'i temizle
            dataGridView1.Rows.Clear();

            // KitapListesi'nde bulunan her kitabı DataGridView'e ekle
            foreach (var kitap in kitapListesi)
            {
                dataGridView1.Rows.Add(kitap.KitapId, kitap.KitapIsim, kitap.Yazar);
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

                // KitapListesi'nden seçili satıra karşılık gelen kitabı kaldır
                kitapListesi.RemoveAt(rowIndex);

                // DataGridView'i güncelle
                RefreshDataGridView();

                // JSON dosyasına kaydet
                SaveKitapListesi();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satıra karşılık gelen Kitap nesnesini al
                Kitap seciliKitap = kitapListesi[rowIndex];

                // KitapDuzenle formunu oluştur ve aç
                KitapDuzenle duzenleForm = new KitapDuzenle(seciliKitap);
                duzenleForm.Owner = this; // KitapEkle formunu Owner olarak ayarla
                duzenleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir kitap seçin.");
            }
        }
    }
}
