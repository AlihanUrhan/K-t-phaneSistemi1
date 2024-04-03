using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            string yeniAd = adTextBox.Text;
            string yeniSoyad = soyadTextBox.Text;

            // Üye bilgilerini güncelle
            duzenlenecekUye.Ad = yeniAd;
            duzenlenecekUye.Soyad = yeniSoyad;

            // Ana formu güncelle
            ((UyeEkle)this.Owner).RefreshDataGridView();

            // Düzenleme formunu kapat
            this.Close();
        }
    }
}
