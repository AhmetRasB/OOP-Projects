using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        }
    }
}
