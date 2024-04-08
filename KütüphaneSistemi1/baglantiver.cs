using System;
using System.Data.SQLite;

namespace KutuphaneSistemi1
{
    public class baglantiver
    {
        public SQLiteConnection baglanti;

        public baglantiver()
        {
            baglanti = new SQLiteConnection("Data Source=C:\\Users\\aliha\\source\\repos\\KütüphaneSistemi1\\KütüphaneSistemi1\\f\\kutuphanesistemidatabase.db;Version=3;");
        }

        public void Baglan()
        {
            try
            {
                baglanti.Open();
                Console.WriteLine("Veritabanı bağlantısı başarıyla açıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı açılamadı: " + ex.Message);
            }
        }

        public void BaglantiyiKapat()
        {
            try
            {
                baglanti.Close();
                Console.WriteLine("Veritabanı bağlantısı başarıyla kapatıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritabanı bağlantısı kapatılamadı: " + ex.Message);
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        baglantiver baglanti = new baglantiver();
    //        baglanti.Baglan();
    //        // İşlemleriniz
    //        baglanti.BaglantiyiKapat();
    //    }
    //}
}