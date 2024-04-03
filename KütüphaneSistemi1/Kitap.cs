using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneSistemi1
{
    public class Kitap
    {
        private static int _nextId = 1;

        public int KitapId { get; private set; }
        public string KitapIsim { get; set; }
        public string Yazar { get; set; }

        public Kitap(string kitapIsim, string yazar)
        {
            KitapId = _nextId++;
            KitapIsim = kitapIsim;
            Yazar = yazar;
        }

        public override string ToString()
        {
            return $"{KitapIsim} - {Yazar}";
        }
    }
}
