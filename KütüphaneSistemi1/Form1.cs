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
            UyelikIslemleri uyelikIslemleri = new UyelikIslemleri();
            uyelikIslemleri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmanetIslemleri EmanetIslemleri = new EmanetIslemleri();
            EmanetIslemleri.ShowDialog();
        }
    }
}
