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
    public partial class KitapDuzenle : Form
    {
        private Kitap duzenlenecekKitap;

        public KitapDuzenle(Kitap kitap)
        {
            InitializeComponent();
            duzenlenecekKitap = kitap;

            // Kitap bilgilerini form kontrollerine yükle
            LoadKitapInfo();
        }
        private void LoadKitapInfo()
        {
            // Kitap bilgilerini TextBox'lara yükle
            kitapIdTextBox.Text = duzenlenecekKitap.KitapId.ToString();
            kitapIsimTextBox.Text = duzenlenecekKitap.KitapIsim;
            YazarBox.Text = duzenlenecekKitap.Yazar;
        }
        private void YazarBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapIsimTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            string yeniIsim = kitapIsimTextBox.Text;
            string yeniYazar = YazarBox.Text;

            // Kitap bilgilerini güncelle
            duzenlenecekKitap.KitapIsim = yeniIsim;
            duzenlenecekKitap.Yazar = yeniYazar;

            // Ana formu güncelle
            ((KitapEkle)this.Owner).RefreshDataGridView();

            // Düzenleme formunu kapat
            this.Close();

        }

        private void KitapDuzenle_Load(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
