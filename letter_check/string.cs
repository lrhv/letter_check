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
    public partial class @string : Form
    {
        public @string()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Substring(2);//parantezin içerisine yazılan sayı kadar sonasını alır
            label2.Text = textBox1.Text.Replace('a', 'A');//ilk tırnakta belirtilen harfi ikinci tırnakta belirtilen harfle değüiştiri
            label3.Text = textBox1.Text.PadRight(15, 'x');//sonuna belirtilen sayı kadar belirtilen harfi koyar
            label4.Text = textBox1.Text.PadLeft(15, 'y');//başına belirtilen sayı kadar belirtilen harfi koyar
        }
    }
}
