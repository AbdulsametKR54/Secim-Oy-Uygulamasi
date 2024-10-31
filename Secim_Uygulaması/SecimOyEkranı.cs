using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secim_Uygulaması
{
    public partial class SecimOyEkranı : Form
    {
        public SecimOyEkranı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=SecimDatabase;Integrated Security=True;Encrypt=False");
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_ILCE (ILCE,APartisi,BPartisi,CPartisi,DPartisi,EPartisi) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtIlce.Text);
            komut.Parameters.AddWithValue("@p2", txtAP.Text);
            komut.Parameters.AddWithValue("@p3", txtBP.Text);
            komut.Parameters.AddWithValue("@p4", txtCP.Text);
            komut.Parameters.AddWithValue("@p5", txtDP.Text);
            komut.Parameters.AddWithValue("@p6", txtEP.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void SecimOyEkranı_Load(object sender, EventArgs e)
        {

        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            Form frmGrafik = new GrafikEkrani();
            frmGrafik.Show();
        }
    }
}
