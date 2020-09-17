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
    public partial class bilgiislem : Form
    {
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public bilgiislem()
        {
            InitializeComponent();
        }

        private void bilgiislem_Load(object sender, EventArgs e)
        {
            kayitliuyeler();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void kayitliuyeler() {
            try
            {
                baglan.Open();
                string sorgu = "select *from uyegirisi";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();

            }
            catch (Exception)
            {
                
             
            }
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            uyekayit frm = new uyekayit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) {
                try
                {
                    baglan.Open();
                    string silmesorgusu = "delete from uyegirisi where kullaniciadi='" + textBox1.Text + "'";
           
                    MySqlCommand cmd = new MySqlCommand(silmesorgusu, baglan);
          int a=     cmd.ExecuteNonQuery();
          if (a > 0)
          {
              MessageBox.Show("Silme işlemi başarılı!");
              textBox1.Clear();
              baglan.Close();
          }
          else {
              MessageBox.Show("Bu kullanıcıadına ait bir üye yoktur o yüzden silme başarısız");
          
          }
                }
                catch (Exception)
                {
                    
                    
                }
                kayitliuyeler();
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string searchquery = "select *from uyegirisi where kullaniciadi='" + textBox2.Text + "'";
                MySqlCommand komut = new MySqlCommand(searchquery, baglan);
             
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                   DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("Bu kullanıcı adındaki üye bilgileri listelendi");
                textBox2.Clear();
                baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bu kullanıcı adına ait hiçbir kullanıcı yok");
                
            }
        }
    }
}
