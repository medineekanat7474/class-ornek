using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap1=new Kitap();
            kitap1.YazarAdi = "ASLI ARSLAN";
            kitap1.Turu = "ROMAN";
            kitap1.Sayfasayisi = 621;
            kitap1.KitapBoyutu = 234;
            kitap1.kitapismi = "SOKAK NÖBETÇİLERİ";
            kitap1.YayinlananTarih = 2018;
            label1.Text = kitap1.YazarAdi + " " + kitap1.Turu + " " + kitap1.Sayfasayisi + " " + kitap1.KitapBoyutu + " " + kitap1.Kitapİsmi + " " + kitap1.YayinlananTarih + " ";
        }
    }
}
