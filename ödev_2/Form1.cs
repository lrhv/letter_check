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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarih_saat_fonksiyonları tsf = new tarih_saat_fonksiyonları();
            tsf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matematiksel_işlemler mti = new matematiksel_işlemler();
            mti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            @string str = new @string();
            str.Show();
        }
    }
}
