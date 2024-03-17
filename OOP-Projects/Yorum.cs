using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects
{
    internal class Yorum
    {
        public string AdSoyad { get; set; }
        public DateTime Yazilmatarihi { get; set; }
        public string GoreceliZaman
        {
            get
            {
                TimeSpan sure = DateTime.Now - Yazilmatarihi;
                if(sure.TotalSeconds<20)
                {
                    return "Simdi";
                }
                else if(sure.TotalSeconds<60)
                {
                    return sure.Seconds + "sn once ";
                }
                else if (sure.TotalMinutes<60)
                {
                    return sure.TotalMinutes + "dk önce";
                }
                return sure.Days + "gun " + sure.Hours + "saat" + sure.Minutes + "dk önce ";
            }
            set
            {

            }
        }
        public Yorum()
        {
            Yazilmatarihi = DateTime.Now;
        }

    }
}
