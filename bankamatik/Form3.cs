using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankamatik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-FG36IKJ\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void btnKydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglantı);
            komut.Parameters.AddWithValue("@p1", textBoxAD3.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad2.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextTc.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTel.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxHesap.Text);
            komut.Parameters.AddWithValue("@p6", textSifre.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 100000);
            maskedTextBoxHesap.Text = sayi.ToString();
        }
    }
}
