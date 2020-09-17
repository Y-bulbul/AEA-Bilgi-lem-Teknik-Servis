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
    public partial class frmmalzemegirisi : Form
    { MySqlDataAdapter da_malzeme;
        DataTable dt_malzeme;
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public static string deger;
        
        public frmmalzemegirisi(MySqlDataAdapter _da1)
        {
            InitializeComponent();
             da_malzeme = _da1;

             malzemegetir();
        }
        private void eskiliste()
        {
            try
            {
                baglan.Open();
                string sorgu = "select * from malzeme";
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
        private void frmmalzemegirisi_Load(object sender, EventArgs e)
        {
            eskiliste();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           cmbmalzemecinsi.Items.Add("Ram");
           cmbmalzemecinsi.Items.Add("Ekran Kartı");
           cmbmalzemecinsi.Items.Add("İşlemci");
           cmbmalzemecinsi.Items.Add("Power");
           cmbmalzemecinsi.Items.Add("Mouse");
           cmbmalzemecinsi.Items.Add("Klavye");
           cmbmalzemecinsi.Items.Add("Fax cihazı");
           cmbmalzemecinsi.Items.Add("Barkod cihazı");
           comboBox1.Items.Add("Malzeme Adı");
           comboBox1.Items.Add("Malzeme Cinsi");
           comboBox1.Items.Add("Malzeme Adedi");
           comboBox1.Items.Add("Malzeme Giriş Tarihi");
       

       
            try
            {
                groupBox1.Visible = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Malzeme Adı";
                dataGridView1.Columns[2].HeaderText = "Malzeme Cinsi";
                dataGridView1.Columns[3].HeaderText = "Malzeme Adedi";
                dataGridView1.Columns[4].HeaderText = "Malzeme Giriş Tarihi";
                dataGridView1.Columns[5].HeaderText = "Açıklama";
                dataGridView2.Columns[0].Visible = false;
             
            }
            catch (Exception)
            {


            }

        }
      
      

       
        private void lblmalzemecinsi_Click(object sender, EventArgs e)
        {

        }
        private void malzemegetir()
        {
            try
            {
                dt_malzeme = new DataTable();
                da_malzeme.Fill(dt_malzeme);
                MessageBox.Show("Veritabanı bağlantısı çalıştı");
            }
            catch
            {
                MessageBox.Show("Çalışmadı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malzemeadi = txtmalzemeadi.Text;
            int cmbmalzeme = cmbmalzemecinsi.SelectedIndex;
            string date = dtgiris.Text;
            string aciklama = txtaciklama.Text;
            int adet;
            bool k = Int32.TryParse(txtadet.Text, out adet);
            if (malzemeadi.Length > 0 && cmbmalzeme > -1 && date.Length > 0 && aciklama.Length >0 &&k) {
                try {
                    DataRow dr = dt_malzeme.NewRow();
                    dr["malzemeadi"] = malzemeadi;
                    dr["malzemecinsi"] = cmbmalzemecinsi.Items[cmbmalzeme];
                    dr["malzemeadedi"] = adet;
                    dr["malzemegiristarihi"] = date;
                    dr["malzemeaciklama"] = aciklama;
                  
                    dt_malzeme.Rows.Add(dr);
                    da_malzeme.Update(dt_malzeme);
                    MessageBox.Show("Bilgileriniz veritabanına başarıyla kaydedildi");
                    eskiliste();
                
                
                }


                catch(Exception ex) {
                    MessageBox.Show(ex.ToString());
               
                
                }
        
            
            
            }
         

        }

        private void cmbmalzemecinsi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                deger = "";
                deger = "malzemeadi";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                deger = "";
                deger = "malzemecinsi";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                deger = "";
                deger = "malzemeadedi";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                deger = "";
                deger = "malzemegiristarihi";
            }
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sorgu = "select * from malzeme where " + deger + " like'" + textBox1.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                baglan.Close();
                dataGridView2.Columns[1].HeaderText = "Malzeme Adı";
                dataGridView2.Columns[2].HeaderText = "Malzeme Cinsi";
                dataGridView2.Columns[3].HeaderText = "Malzeme Adedi";
                dataGridView2.Columns[4].HeaderText = "Malzeme Giriş Tarihi";
                dataGridView2.Columns[5].HeaderText = "Açıklama";

            }
            catch
            {


            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (  textBox2.Text.Length > 0)
            {
                try
                {
                    baglan.Open();
                    string silmesorgusu = "delete from malzeme where malzemeadi='" + textBox2.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(silmesorgusu, baglan);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Silme işlemi başarılı!");
                        textBox2.Clear();
                        baglan.Close();
                        eskiliste();
                      
                    }
                    else
                    {
                        MessageBox.Show("Bu malzeme adına ait bir kayıt yoktu o yüzden silme başarısız.");

                    }
                }
                catch (Exception)
                {


                }


            }
        }
    }
}
