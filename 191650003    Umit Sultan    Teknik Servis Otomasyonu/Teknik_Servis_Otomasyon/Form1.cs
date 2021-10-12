using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri frm = new musteri();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel per = new personel();
            per.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stok st = new stok();
            st.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
