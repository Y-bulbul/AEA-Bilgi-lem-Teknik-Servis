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
    public partial class uyesifresiguncelle : Form
    {
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public uyesifresiguncelle()
        {
            InitializeComponent();
        }

        private void uyesifresiguncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sifreguncellemesorgusu = "update uyegirisi set sifre='" + textBox1.Text + "' where kullaniciadi='"+Uyegirisi.kullaniciadi+"'";
                MySqlCommand cmd = new MySqlCommand(sifreguncellemesorgusu, baglan);
                cmd.ExecuteNonQuery();
                MessageBox.Show(Uyegirisi.kullaniciadi+" kullanıcı adlı şifreniz yazdığınız yeni şifreyle güncellenmiştir.");
                baglan.Close();
            }
            catch (Exception)
            {
                
               
            }
        }
    }
}
