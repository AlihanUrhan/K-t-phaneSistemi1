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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.ShowDialog();
         }

        private void button2_Click(object sender, EventArgs e)
         { 
            UyeEkle uyelikIslemleri = new UyeEkle();
            uyelikIslemleri.ShowDialog();
         }

        private void button3_Click(object sender, EventArgs e)
         {
            EmanetListesi emanetListesi = new EmanetListesi(); // Emanet listesi nesnesi oluşturuluyor
            KitapListesi kitapListesi = new KitapListesi(); // Kitap listesi nesnesi oluşturuluyor
            UyeListesi uyeListesi = new UyeListesi(); // Üye listesi nesnesi oluşturuluyor

            EmanetFormu emanetIslemleri = new EmanetFormu(emanetListesi, kitapListesi, uyeListesi); // Emanet formu nesnesi oluşturuluyor ve parametreler geçiliyor
            emanetIslemleri.ShowDialog(); // Emanet işlemleri formu gösteriliyor
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
