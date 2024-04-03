using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneSistemi1
{
    public class Emanet
    {
        public int EmanetId { get; set; }
        public DateTime EmanetTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }
        public Kitap EmanetKitap { get; set; }
        public Uye EmanetAlanUye { get; set; }
    }
}
