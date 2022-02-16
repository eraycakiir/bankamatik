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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-FG36IKJ\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *From TBLKISILER where HESAPNO=@P1 and SIFRE=@P2", baglantı);
            komut.Parameters.AddWithValue("@P1", maskedTextHesap.Text);
            komut.Parameters.AddWithValue("@P2", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = maskedTextHesap.Text;
                fr.Show();
               
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            baglantı.Close();
        }
    }
}
