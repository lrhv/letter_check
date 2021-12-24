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
    public partial class tarih_saat_fonksiyonları : Form
    {
        public tarih_saat_fonksiyonları()
        {
            InitializeComponent();
        }

        private void tarih_saat_fonksiyonları_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;//bugün ile ilgili işlemlerde kullanılır
            listBox1.Items.Add(bugun);//bugünü gün ay yıl saat dakika ama saniyesiz olarak gösteriyor
            listBox1.Items.Add(bugun.ToString());//bugünü gün ay yıl saat dakika ve saniyesini ekleyerek gösteriyor
            listBox1.Items.Add(bugun.ToLongDateString());//Tarihi günün tarihi.ayın adı.yıl. günün adı olarak gösterir
            listBox1.Items.Add(bugun.ToLongTimeString());//Saati saat:dakika:saniye şeklinde gösterir
            listBox1.Items.Add(bugun.ToShortDateString());//Tarihi gün.ay.yıl olarak gösterir
            listBox1.Items.Add(bugun.ToShortTimeString());//Saati saat:dakika olarak gösterir
            listBox1.Items.Add(bugun.Year);//bugünün yılını gösterir
            listBox1.Items.Add(bugun.Month);//bügünün ayını gösterir
            listBox1.Items.Add(bugun.Day);//bugünün tarihini gösterir
            listBox1.Items.Add(bugun.Hour);//bugünün saatini gösterir
            listBox1.Items.Add(bugun.Minute);//saatin kaçıncı dakikasında olduğunu gösterir
            listBox1.Items.Add(bugun.Second);//saatin kaçıncı saniyesinde olduğunu gösterir
            listBox1.Items.Add(bugun.AddDays(6));//bugünün tarihine 6 gün ekler ve gösterir ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddMonths(-2));//bugünden 2 ay çıkarır (- işaretini kaldırırsak ekler) ve gösterir ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddYears(-3));//bugünden 3 yıl çıkarır (- işaretini kaldırırsak ekler) ve gösterir ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddHours(3));//bugüne 3 saat ekler ve gösterir ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddMinutes(25));//o anın dakikasına 25 dakika ekler ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddSeconds(35));//o anın saniyesine 35 saniye ekler ve gün ay yıl saat dakika şeklinde gösterir
            listBox1.Items.Add(bugun.AddDays(6).ToString("dd.MM.yyyy"));//bugünün tarihine 6 gün ekler ve gösterir ve "STRİNG İLE EKLEDİĞİMİZ ALAN SAYESİNDE gün ay yıl şeklinde gösterir"
            //MMM üç karakterli ay ismi
            //ddd üç karakterli gün ismi
            //d bulunulan günün rakamsal değeri
            //HH 24 saatlik gösterimde saat değeri
            //h 12 saatlik gösterimde saat değeri
            //mm iki basamaklı dakika değeri
            //yyyy dört basamaklı yıl değeri
            //yy iki basamaklı yıl değeri(son iki basamak)
            listBox1.Items.Add(bugun.AddDays(6).DayOfWeek);//bugünün haftanın hangi günü olduğunu gösterir
            listBox1.Items.Add(bugun.AddDays(6).DayOfYear);//bugünün yılın kaçıncı günü olduğunu gösterir


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime(2021, 11, 6);//belilrli bir tarih üzerinden yapılan işlemler için kullanılır, parantezin içerisine kullanılmak istenen tarih girilir ve işlemler yapılır EĞER PARANTEZ YERİNE.NOW KULLANILIRSA O ANIN TARİHİNİ ALIR
            listBox2.Items.Add("Seçilen Tarih : 6.11.2021");
            listBox2.Items.Add(tarih);//tarihi gün ay yıl saat dakika ama saniyesiz olarak gösteriyor
            listBox2.Items.Add(tarih.ToString());//tarihi gün ay yıl saat dakika ve saniyesini ekleyerek gösteriyor
            listBox2.Items.Add(tarih.ToString("d"));//tarihi gün.ay.yıl olarak gösterir
            listBox2.Items.Add(tarih.ToString("D"));//gün ay yıl günün adı şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("f"));//gün ay yıl günün adı saat dakika şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("F"));//gün ay yıl günün adı saat dakika saniye şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("g")); //gün.ay.yıl saat ve dakika şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("G"));//gün.ay.yıl saat dakika ve saniye şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("m"));//gün ve ay şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("M"));//gün ve ay şeklinde gösterir, m'lerin farkı yok gösterimde
            listBox2.Items.Add(tarih.ToString("o"));//gmt ye göre saat farkını gösterir
            listBox2.Items.Add(tarih.ToString("O"));
            listBox2.Items.Add(tarih.ToString("s"));//saat ve dakikayı gösterir
            listBox2.Items.Add(tarih.ToString("t"));//saat dakika saniyeyi gösterir
            listBox2.Items.Add(tarih.ToString("T"));
            listBox2.Items.Add(tarih.ToString("u"));
            listBox2.Items.Add(tarih.ToString("U"));//gün ay yıl gün adı saat dakika saniye şeklinde gösterir
            listBox2.Items.Add(tarih.ToString("y"));//ay ve yılı gösterir
            listBox2.Items.Add(tarih.ToString("Y"));//ay ve yılı gösterir










        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
