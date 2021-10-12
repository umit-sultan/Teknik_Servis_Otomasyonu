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

namespace Teknik_Servis_Otomasyon
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }

        private void stok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teknik_Servis_OtomasyonuDataSet.urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.urun);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow satir = this.teknik_Servis_OtomasyonuDataSet.Tables["urun"].NewRow();
            this.teknik_Servis_OtomasyonuDataSet.Tables["urun"].Rows.Add(satir);

            urunBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO urun(islem_tur,islem_fiyat,islem_tespit) VALUES('" + txt_islem_tur.Text + "', "+ txt_islem_fyt.Text +" ,'" + rtxt_tspt.Text+ "')";

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.urunTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.urun);

            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE urun SET islem_tur='" + txt_islem_tur.Text + "', islem_fiyat=" + txt_islem_fyt.Text + " , islem_tespit='" + rtxt_tspt.Text + "' WHERE islem_no=" + txt_islem_no.Text;

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.urunTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.urun);

            dataGridView1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "DELETE FROM urun WHERE islem_no=" + txt_islem_no.Text;

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.urunTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.urun);

            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
