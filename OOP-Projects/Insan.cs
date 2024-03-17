using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects
{
    internal class Insan
    {
        public string AdSoyad { get; set; }

        public bool CanliMi { get; set; }
        public Insan()
        {
            CanliMi = true;
        }
        public Insan(string AdSoyAd)
        {
            AdSoyad = AdSoyAd;
            CanliMi = true;
        }
        public static string Selamver()
        {
            return "Merhaba";
             
        }
        public string Adinisoyle()
        {
            return "Benim adim " + AdSoyad;
        }
    }
}
