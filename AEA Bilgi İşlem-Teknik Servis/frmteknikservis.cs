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
    public partial class frmteknikservis : Form
    {
        public string deger; 
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public frmteknikservis()
        {
            InitializeComponent();
        }

        private void frmteknikservis_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox1.Items.Add("Domain Adı");
            comboBox1.Items.Add("Modeli");
            comboBox1.Items.Add("Serino");
            comboBox1.Items.Add("Mac Adresi");
            sonarizalariyazdir();
            
            dataGridView1.Columns[0].Visible = false;
        }
        private void sonarizalariyazdir() {
            try
            {
                baglan.Open();
                string query = "select *from arizakayit order by id desc";
                MySqlCommand kmt = new MySqlCommand(query, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(kmt);
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
            if(txtarizageldigiyer.Text.Length>0 && txtdomainismi.Text.Length>0 && txtmodel.Text.Length>0 && txtarizasi.Text.Length>0&& txtserino.Text.Length>0 && txtmacadresi.Text.Length>0&&txtdvd.Text.Length>0 &&txtgetiren.Text.Length>0 && txtteslimeden.Text.Length>0 && txtdegisenparca.Text.Length>0 &&txtyapilanislem.Text.Length>0&&txtyerineverilenyedek.Text.Length>0 &&txtanakartmodeli.Text.Length>0 &&txtislemci.Text.Length>0 &&txtram.Text.Length>0 &&txtekrankarti.Text.Length>0){
                   baglan.Open();
                string arizakayitsorgusu = "insert into arizakayit(arizageldigiyer,domainismi,model,arizasi,serino,macadresi,gelistarihi,getiren,teslimtarihi,teslimeden,degisenparca,yapilanislem,yerineverilenyedek,anakartmodeli,islemci,ram,ekrankarti,dvd) values('" + txtarizageldigiyer.Text + "','" + txtdomainismi.Text + "','" + txtmodel.Text + "','" + txtarizasi.Text + "','" + txtserino.Text + "','" + txtmacadresi.Text + "','" +dtgelistarihi.Text + "','" + txtgetiren.Text + "','" + dtteslimtarihi.Text + "','" + txtteslimeden.Text + "','" + txtdegisenparca.Text + "','" + txtyapilanislem.Text + "','" + txtyerineverilenyedek.Text + "','" + txtanakartmodeli.Text + "','" + txtislemci.Text + "','" + txtram.Text + "','" + txtekrankarti.Text + "','"+txtdvd.Text+"')";
                MySqlCommand cmd = new MySqlCommand(arizakayitsorgusu, baglan);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Arıza Kaydı Başarıyla Tamamlandı!");
                sonarizalariyazdir();
                baglan.Close();
              
          
        
            }
            else {
            MessageBox.Show("Bilgileri tam  doldurunuz");
            }

            
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                string sorgu = "select * from arizakayit where " + deger + " like'" + textBox1.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                baglan.Close();

            }
            catch
            {
               

            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                deger = "";
                deger = "domainismi";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                deger = "";
                deger = "model";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                deger = "";
                deger = "serino";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                deger = "";
                deger = "macadresi";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                try
                {
                    baglan.Open();
                    string silmesorgusu = "delete from arizakayit where yapilanislem='" +textBox2.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(silmesorgusu, baglan);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Silme işlemi başarılı!");
                        textBox2.Clear();
                        baglan.Close();
                        sonarizalariyazdir();

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
