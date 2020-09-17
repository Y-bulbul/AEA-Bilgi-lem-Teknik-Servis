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
    public partial class uyekayit : Form
    {
        Random random1 = new Random();
        Random random2 = new Random();
        int sayi1, sayi2;
       
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public uyekayit()
        {
            InitializeComponent();
        }
        private void random() {
            sayi1 = random1.Next(2, 10);

            sayi2 = random2.Next(3, 9);
            label3.Text = sayi1.ToString();
            label4.Text = sayi2.ToString();
        }
        private void uyekayit_Load(object sender, EventArgs e)
        {

            random();
        }

        private void button1_Click(object sender, EventArgs e)
        {try
        {
            int toplam = sayi1 + sayi2;
            if (textBox3.Text == toplam.ToString())
            {




                baglan.Open();
                string sorgu = "select * from uyegirisi where kullaniciadi='" + textBox1.Text + "'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                int count = Convert.ToInt32(komut.ExecuteScalar());

                if (count > 0)
                {
                    baglan.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Bu kullanıcı adı kullanımda lütfen değiştiriniz");
                    random();
                   
                }
                else {
                    string uyeeklemesorgusu = "insert into uyegirisi(kullaniciadi,sifre) values('" + textBox1.Text + "','" + textBox2.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(uyeeklemesorgusu, baglan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydı başarılı!");
                    baglan.Close();
                    random();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                   
                }
            }
            else { MessageBox.Show("Robot(Doğrulama) Kontrolünü geçemediniz tekrar kontrol ediniz");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            random();
            }
        }
	catch (Exception)
        {
            
            baglan.Close();
		
	}
            
        }
    }
}
