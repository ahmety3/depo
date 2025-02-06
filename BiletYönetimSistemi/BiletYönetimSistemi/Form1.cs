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
using System.Security.Cryptography;

namespace BiletYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("SQL CONNECTİON GİRMENİZ LAZIM");
        

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTc.Text = "";
            MskNo.Text = "";
            CmbNereden.Text = "";
            CmbNereye.Text = "";


            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                dateTimePicker2.Enabled = false;
                label10.Text = "True";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                dateTimePicker2.Enabled = true;
                label10.Text = "False";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biletYönetimSistemiDataSet1.Tbl_UcakBiletYonetimSistemi' table. You can move, or remove it, as needed.
            this.tbl_UcakBiletYonetimSistemiTableAdapter1.Fill(this.biletYönetimSistemiDataSet1.Tbl_UcakBiletYonetimSistemi);
            

            for (int i =1; i<=100; i++)
            {
                if (i<=20)
                {
                    CmbKoltuk.Items.Add(i + " -VİP Class");
                }
                else
                {
                    CmbKoltuk.Items.Add(i + " -Ekonomi Class");
                }
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_UcakBiletYonetimSistemiTableAdapter1.Fill(this.biletYönetimSistemiDataSet1.Tbl_UcakBiletYonetimSistemi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydet = new SqlCommand("insert into Tbl_UcakBiletYonetimSistemi (Ad,Soyad,TcNo,TelefonNo,Nereden,Nereye,GidisTarihi,DönüsTarihi,YonTekYonCift,KoltukSecimi) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10) ",baglanti);
            kaydet.Parameters.AddWithValue("@a1",TxtAd.Text);
            kaydet.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            kaydet.Parameters.AddWithValue("@a3",MskTc.Text);
            kaydet.Parameters.AddWithValue("@a4",MskNo.Text);
            kaydet.Parameters.AddWithValue("@a5",CmbNereden.Text);
            kaydet.Parameters.AddWithValue("@a6",CmbNereye.Text);
            kaydet.Parameters.AddWithValue("@a7",dateTimePicker1.Value);
            kaydet.Parameters.AddWithValue("@a8",dateTimePicker2.Value);
            kaydet.Parameters.AddWithValue("@a9",label10.Text);
            kaydet.Parameters.AddWithValue("@a10",CmbKoltuk.Text);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı eklendi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_UcakBiletYonetimSistemi where TcNo=@k1",baglanti);
            sil.Parameters.AddWithValue("@k1", MskTc.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı silindi.");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbNereden.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbNereye.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[6].Value.ToString(), out DateTime tarih))
            {
                dateTimePicker1.Value = tarih;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            if (DateTime.TryParse(dataGridView1.Rows[secilen].Cells[7].Value.ToString(), out DateTime tarih2))
            {
                dateTimePicker2.Value = tarih2;
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelleme = new SqlCommand("Update Tbl_UcakBiletYonetimSistemi set Ad=@b1, Soyad=@b2, TcNo=@b3, TelefonNo=@b4, Nereden=@b5, Nereye=@b6, GidisTarihi=@b7, DönüsTarihi=@b8, YonTekYonCift=@b9 where KoltukSecimi=@b10",baglanti);
            guncelleme.Parameters.AddWithValue("@b1", TxtAd.Text);
            guncelleme.Parameters.AddWithValue("@b2",TxtSoyad.Text);
            guncelleme.Parameters.AddWithValue("@b3",MskTc.Text);
            guncelleme.Parameters.AddWithValue("@b4",MskNo.Text);
            guncelleme.Parameters.AddWithValue("@b5",CmbNereden.Text);
            guncelleme.Parameters.AddWithValue("@b6",CmbNereye.Text);
            guncelleme.Parameters.AddWithValue("@b7",dateTimePicker1.Value);
            guncelleme.Parameters.AddWithValue("@b8",dateTimePicker2.Value);
            guncelleme.Parameters.AddWithValue("@b9",label10.Text); 
            guncelleme.Parameters.AddWithValue("@b10",CmbKoltuk.Text);
            guncelleme.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgisi Güncellendi.");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
