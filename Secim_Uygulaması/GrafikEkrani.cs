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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Secim_Uygulaması
{
    public partial class GrafikEkrani : Form
    {
        public GrafikEkrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=SecimDatabase;Integrated Security=True;Encrypt=False");
        private void GrafikEkrani_Load(object sender, EventArgs e)
        {
            cmbIlce.Size = new Size(240, 28);

            //Grafik
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM(APartisi), SUM(BPartisi), SUM(CPartisi), SUM(DPartisi), SUM(EPartisi) FROM Tbl_ILCE", baglanti);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Partisi", dr[0]);
                chart1.Series["Partiler"].Points.AddXY("B Partisi", dr[1]);
                chart1.Series["Partiler"].Points.AddXY("C Partisi", dr[2]);
                chart1.Series["Partiler"].Points.AddXY("D Partisi", dr[3]);
                chart1.Series["Partiler"].Points.AddXY("E Partisi", dr[4]);
            }
            dr.Close();
            baglanti.Close();

            //Combabox veri çekme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select ILCE From Tbl_ILCE", baglanti);
            SqlDataReader dr2= komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbIlce.Items.Add(dr2[0]);
            }
            dr2.Close();
            baglanti.Close();

        }
        void UpdateChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Partiler");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT APartisi, BPartisi, CPartisi, DPartisi, EPartisi FROM Tbl_ILCE where ILCE=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbIlce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Partisi", dr[0]);
                chart1.Series["Partiler"].Points.AddXY("B Partisi", dr[1]);
                chart1.Series["Partiler"].Points.AddXY("C Partisi", dr[2]);
                chart1.Series["Partiler"].Points.AddXY("D Partisi", dr[3]);
                chart1.Series["Partiler"].Points.AddXY("E Partisi", dr[4]);
            }
            dr.Close();
            baglanti.Close();
        }
        void UpdateProgressBar()
        {
            //ProgressBar
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT APartisi, BPartisi, CPartisi, DPartisi, EPartisi FROM Tbl_ILCE WHERE ILCE = @ilce", baglanti);
            komut3.Parameters.AddWithValue("@ilce", cmbIlce.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            if (dr3.Read())
            {
                progressBar1.Value = int.Parse(dr3[0].ToString());
                progressBar2.Value = int.Parse(dr3[1].ToString());
                progressBar4.Value = int.Parse(dr3[2].ToString());
                progressBar3.Value = int.Parse(dr3[3].ToString());
                progressBar5.Value = int.Parse(dr3[4].ToString());
                label2.Text = dr3[0].ToString();
                label3.Text = dr3[1].ToString();
                label5.Text = dr3[2].ToString();
                label7.Text = dr3[3].ToString();
                label9.Text = dr3[4].ToString();
            }
            dr3.Close();
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
            UpdateProgressBar();
        }
    }
}
