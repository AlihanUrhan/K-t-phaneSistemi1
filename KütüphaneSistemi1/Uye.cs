using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneSistemi1
{
    public class Uye
    {
        private static int _sonUyeId = 0;

        public int UyeId { get; private set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Uye(string ad, string soyad)
        {
            UyeId = ++_sonUyeId;
            Ad = ad;
            Soyad = soyad;
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
