using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AEA_Bilgi_İşlem_Teknik_Servis
{
    public partial class frmana : Form
    {
        string kullanici;
       
        public frmana(string kullaniciadi)
        {
            InitializeComponent();
            kullanici = kullaniciadi;
            

           
        }
       
        private void btnmalzeme_Click(object sender, EventArgs e)
        {
          
            frmmalzemeekrani frm = new frmmalzemeekrani();
            frm.Show();

        }

        private void frmana_Load(object sender, EventArgs e)
        {
            if (kullanici == "fadli" || kullanici == "admin")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                btnmalzeme.Visible = true;
                btnariza.Visible = true;

            }
            else {
                btnariza.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                btnmalzeme.Visible = true;
            }

        }

        private void btnariza_Click(object sender, EventArgs e)
        {
            frmteknikservis frmteknik = new frmteknikservis();
            frmteknik.Show(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyekayit frmkayit = new uyekayit();
            frmkayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyesifresiguncelle frm = new uyesifresiguncelle();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgiislem frmbilgiislem = new bilgiislem();
            frmbilgiislem.ShowDialog();
        }
    }
}
