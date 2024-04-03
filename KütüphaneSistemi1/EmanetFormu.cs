using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KütüphaneSistemi1
{
    public partial class EmanetFormu : Form
    {
        private EmanetListesi emanetListesi;
        private KitapListesi kitapListesi;
        private UyeListesi uyeListesi;

        public EmanetFormu(EmanetListesi emanetListesi, KitapListesi kitapListesi, UyeListesi uyeListesi)
        {
            InitializeComponent();
            this.emanetListesi = emanetListesi;
            this.kitapListesi = kitapListesi;
            this.uyeListesi = uyeListesi;

            // Form yüklendiğinde Load metodu çağrılacak
            this.Load += new System.EventHandler(this.EmanetFormu_Load);
        }

        private void EmanetFormu_Load(object sender, EventArgs e)
        {
            // Kitapları ve üyeleri listbox'lara yükle
            LoadKitaplarFromJson();
            LoadUyelerFromJson();
        }

        private void LoadKitaplarFromJson()
        {
            listBoxKitaplar.Items.Clear();

            // Kitaplar.json dosyasından verileri oku
            string kitaplarDosyaYolu = "kitaplar.json";
            if (File.Exists(kitaplarDosyaYolu))
            {
                string json = File.ReadAllText(kitaplarDosyaYolu);
                kitapListesi = JsonConvert.DeserializeObject<KitapListesi>(json);
            }

            // KitapListesi'nde bulunan her kitabı ListBox'a ekle
            foreach (Kitap kitap in kitapListesi)
            {
                listBoxKitaplar.Items.Add(kitap);
            }
        }

        private void LoadUyelerFromJson()
        {
            listBoxUyeler.Items.Clear();

            // Uyeler.json dosyasından verileri oku
            string uyelerDosyaYolu = "uyeler.json";
            if (File.Exists(uyelerDosyaYolu))
            {
                string json = File.ReadAllText(uyelerDosyaYolu);
                uyeListesi = JsonConvert.DeserializeObject<UyeListesi>(json);
            }

            // UyeListesi'nde bulunan her üyeyi ListBox'a ekle
            foreach (Uye uye in uyeListesi)
            {
                listBoxUyeler.Items.Add(uye);
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İşlem yapılacak gerekli durumlar
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İşlem yapılacak gerekli durumlar
        }

        private void btnEmanetVer_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    // Emanet listesi null değilse devam et
                    if (emanetListesi != null)
                    {
                        // Eğer herhangi bir kitap veya üye seçilmemişse uyarı ver
                        if (listBoxKitaplar.SelectedItem == null || listBoxUyeler.SelectedItem == null)
                        {
                            MessageBox.Show("Lütfen bir kitap ve bir üye seçin.");
                            return;
                        }

                        // Seçili kitapı ve üyeyi al
                        Kitap seciliKitap = (Kitap)listBoxKitaplar.SelectedItem;
                        Uye seciliUye = (Uye)listBoxUyeler.SelectedItem;

                        // Emanet nesnesini oluştur
                        Emanet yeniEmanet = new Emanet
                        {
                            EmanetTarihi = DateTime.Now,
                            EmanetKitap = seciliKitap,
                            EmanetAlanUye = seciliUye
                        };

                        // Emanet listesine ekle
                        emanetListesi.EmanetVer(yeniEmanet); // EmanetListesi sınıfındaki EmanetVer metodu kullanılıyor

                        // Emanet listesini JSON dosyasına yaz
                        string emanetJson = JsonConvert.SerializeObject(emanetListesi);
                        File.WriteAllText("emanetler.json", emanetJson);

                        MessageBox.Show("Emanet işlemi başarıyla kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Emanet listesi null olduğu için işlem gerçekleştirilemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Emanet verme işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
