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

namespace Teknik_Servis_Otomasyon
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teknik_Servis_OtomasyonuDataSet.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.musteri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteriBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow satir = this.teknik_Servis_OtomasyonuDataSet.Tables["musteri"].NewRow();
            this.teknik_Servis_OtomasyonuDataSet.Tables["musteri"].Rows.Add(satir);

            musteriBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO musteri(ad,soyad,tel,adres,eposta) VALUES('" + txt_adi.Text + "','" + txt_sadi.Text + "','" + txt_tel.Text + "','" + richTextBox1.Text + "','" + txt_mail.Text + "')";

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.musteriTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.musteri);

            dataGridView1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "DELETE FROM musteri WHERE mus_no="+txt_mus_no.Text;

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.musteriTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.musteri);

            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE musteri SET ad='" + txt_adi.Text + "', soyad='" + txt_sadi.Text + "', tel='" + txt_tel.Text + "', adres='" + richTextBox1.Text + "', eposta='" + txt_mail.Text + "' WHERE mus_no="+txt_mus_no.Text;

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.musteriTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.musteri);

            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
