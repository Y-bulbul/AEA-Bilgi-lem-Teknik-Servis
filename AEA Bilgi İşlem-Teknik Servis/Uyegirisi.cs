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
    
    public partial class Uyegirisi : Form
    {
        public static string kullaniciadi;
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public Uyegirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sorgu="select * from uyegirisi where kullaniciadi='"+textBox1.Text+"' and sifre='"+textBox2.Text+"'";
                MySqlCommand komut= new MySqlCommand(sorgu,baglan);
                int count=Convert.ToInt32(komut.ExecuteScalar());
                if (count > 0)
                {
                    kullaniciadi = textBox1.Text;
                    frmana frm = new frmana(kullaniciadi);
                    
                    frm.ShowDialog();
                    this.Hide();
                    baglan.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
                    baglan.Close();
                }
            }
            catch
            {
                
                
                baglan.Close();

            }
            
           
           
        }

        private void Uyegirisi_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            if (checkBox1.Checked == false) {
                textBox2.UseSystemPasswordChar = true;
            }

        }
    }
}
