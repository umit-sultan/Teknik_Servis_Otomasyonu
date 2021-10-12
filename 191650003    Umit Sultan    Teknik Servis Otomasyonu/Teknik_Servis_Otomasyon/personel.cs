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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teknik_Servis_OtomasyonuDataSet.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.personel);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           personelBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personelBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow satir = this.teknik_Servis_OtomasyonuDataSet.Tables["personel"].NewRow();
            this.teknik_Servis_OtomasyonuDataSet.Tables["personel"].Rows.Add(satir);

            personelBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO personel(ad,soyad,tcno,baba_adi,dog_tar,dog_yeri,tel,adres,eposta) VALUES('" + txt_adi.Text + "','" + txt_sadi.Text + "','"+txt_tc.Text+"','"+txt_badi.Text+"','"+txt_dog_tar.Text+"','"+txt_dog_yer.Text+"','" + txt_tel.Text + "','" + richTextBox1.Text + "','" + txt_mail.Text + "')";

            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.personelTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.personel);

            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE personel SET ad='" + txt_adi.Text + "', soyad='" + txt_sadi.Text + "', tcno='" + txt_tc.Text + "', baba_adi='" + txt_badi.Text + "', dog_tar='" + txt_dog_tar.Text + "', dog_yeri='" + txt_dog_yer.Text + "', tel='" + txt_tel.Text + "', adres='" + richTextBox1.Text + "', eposta='" + txt_mail.Text + "'WHERE per_no=" + txt_per_no.Text;
            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.personelTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.personel);

            dataGridView1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Teknik_Servis_Otomasyonu.mdf';Integrated Security=True;Connect Timeout=30";
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "DELETE FROM personel WHERE per_no=" + txt_per_no.Text;
            komut.ExecuteNonQuery();

            dataGridView1.Refresh();

            this.personelTableAdapter.Fill(this.teknik_Servis_OtomasyonuDataSet.personel);

            dataGridView1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
