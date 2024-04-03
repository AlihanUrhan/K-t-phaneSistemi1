using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KütüphaneSistemi1
{
    public class EmanetListesi : List<Emanet>
    {
        public void EmanetVer(Emanet yeniEmanet)
        {
            this.Add(yeniEmanet);
        }
    }
}
