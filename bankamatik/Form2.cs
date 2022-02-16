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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string hesap;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FG36IKJ\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From TblKISILER where HESAPNO =@P1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTc.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void btnGonder2_Click(object sender, EventArgs e)
        {
            // Gönderilen Hesabın Para Artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tblhesap set BAKIYE=BAKIYE+@P1 where HESAPNO=@P2", baglanti);
            komut.Parameters.AddWithValue("P1", decimal.Parse(txtBoxTutar.Text));
            komut.Parameters.AddWithValue("p1", decimal.Parse(txtBoxTutar.Text));
            komut.Parameters.AddWithValue("P2", maskedbxHesapno2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update tblhesap set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
            komut2.Parameters.AddWithValue("k1", decimal.Parse(txtBoxTutar.Text));
            komut2.Parameters.AddWithValue("k2", maskedbxHesapno2.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}

      
