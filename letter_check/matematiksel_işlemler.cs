using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_2
{
    public partial class matematiksel_işlemler : Form
    {
        public matematiksel_işlemler()
        {
            InitializeComponent();
        }


        private void button13_Click_1(object sender, EventArgs e)
        {
            int deger = -10;
            int pozitif;
            pozitif = Math.Abs(deger);
            listBox1.Items.Add(pozitif);//belirtien sayının mutlak değerini alır

            double deger7;
            deger7 = 5.2;
            double yuvarla = Math.Ceiling(deger7);
            listBox1.Items.Add(yuvarla);//üste yuvarlar

            double sayi = 4.9;
            double yuvarla2 = Math.Floor(sayi);
            listBox1.Items.Add(yuvarla2);//alta yuvarlar

            double buyukdeger = Math.Max(4.87, 4.21);
            listBox1.Items.Add(buyukdeger);//maksimum değeri alır

            double kucukdeger = Math.Min(4.87, 4.21);
            listBox1.Items.Add(kucukdeger);//minumum değeri alır

            double usalma = Math.Pow(2, 5);
            listBox1.Items.Add(usalma);//üssünü alır

            double sayi3 = 625;
            double kok = Math.Sqrt(sayi3);
            listBox1.Items.Add(kok);//kökünü alır


            double deger1;
            deger1 = Math.PI;
            listBox1.Items.Add(deger1);//pi sayısını hesapalr

            double deger3;
            deger3 = Math.IEEERemainder(12, 5);
            listBox1.Items.Add(deger3);//kalanı hesaplar


            double deger4;
            deger4 = Math.Sin(90);
            listBox1.Items.Add(deger4);//sinüsünü hesaplar

            double deger5;
            deger5 = Math.Cos(90);
            listBox1.Items.Add(deger5);//cosinüsünü hesapalr


            double deger6;
            deger6 = Math.Tan(160);
            listBox1.Items.Add(deger6);//tanjantını hesapalr


        }
    }
}