using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan insan1 = new Insan();
            insan1.AdSoyad = "Duygu Balaban";
            insan1.CanliMi = true;
            Insan insan2 = new Insan();
            insan2.AdSoyad = "Ahmet Balaban";
            insan2.CanliMi = true;
            Insan insan3 = new Insan("Mesut Gül");
            Insan insan4 = new Insan("Caner Kırma");
            Insan insan5 = new Insan()
            {
                AdSoyad = "Erkan Zengin",
                CanliMi = true
            };
            MessageBox.Show(Insan.Selamver());
            MessageBox.Show(insan2.Adinisoyle());
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCVatandas vat1 = new TCVatandas();
            vat1.DogumTarihi = Convert.ToDateTime("1999-05-05");
            MessageBox.Show(vat1.Vizeal());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABDVatandas abd1 = new ABDVatandas();
            abd1.AdSoyad = "Michael Jackson";
            abd1.Dil = "English";
            abd1.DogumTarihi = Convert.ToDateTime("1975-12-12");
            MessageBox.Show(abd1.Yas.ToString());
        }
    }
}
