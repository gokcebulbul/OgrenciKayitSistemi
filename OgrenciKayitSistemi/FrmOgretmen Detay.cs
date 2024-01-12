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

namespace OgrenciKayitSistemi
{
    public partial class FrmOgretmen_Detay : Form
    {
        public FrmOgretmen_Detay()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        SqlConnection baglanti = new SqlConnection(@"Data Source=GOKCE;Initial Catalog=DbNotKayıt;Integrated Security=True");




        void griddoldur()
        {
            con = new SqlConnection(@"Data Source=GOKCE;Initial Catalog=DbNotKayıt;Integrated Security=True");
            da = new SqlDataAdapter("Select * From TBLDERS", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "TBLDERS");
            dataGridView1.DataSource = ds.Tables["TBLDERS"];
            con.Close();
        }

        private void FrmOgretmen_Detay_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS(OgrenciNumara,OgrenciAd,OgrenciSoyad) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", maskNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            maskNumara.Text = dataGridView1.Rows[secilen].Cells[1].ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama,s1,s2,s3;
            string durum;
            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);

            ortalama=(s1+s2+s3)/3;
            lblOrtalama.Text=ortalama.ToString();

            if (ortalama > 50)
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set Sınav1=@p1,Sınav2=@p2,Sınav3=@p3,Ortalama=@p4,Durum=@p5 WHERE OgrenciNumara=@p6",baglanti);
            komut.Parameters.AddWithValue("@p1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5",durum);
            komut.Parameters.AddWithValue("@p6", maskNumara.Text);

        }
    }
}
