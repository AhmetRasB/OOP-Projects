using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects
{
    internal class TCVatandas
    {
        public long TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime SistemeGirisTarihi { get; set; }

        public TCVatandas()
        {
            SistemeGirisTarihi = DateTime.Now;
            
        }
        public string Vizeal() 
        {
            int yas = YasHesapla(DogumTarihi);
            if (yas >= 18)
                return "Başvurabilirsiniz";
            else
                return "Veli izni gerekmektedir";
        }

        private int YasHesapla(DateTime dogumTarihi)
        {
            return DateTime.Today.Year-dogumTarihi.Year;

        }

    }
}
