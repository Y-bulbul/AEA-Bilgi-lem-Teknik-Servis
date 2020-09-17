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
    public partial class frmmalzemecikisi : Form
    {
        MySqlDataAdapter da_malzeme;
        DataTable dt_malzeme;
        public static string degisken;
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public frmmalzemecikisi(MySqlDataAdapter da1)
        {
            InitializeComponent();
            da_malzeme = da1;

            try
            {
                malzemegetir();
                for (int satir = 0; satir < dt_malzeme.Rows.Count; satir++)
                {
                    cbmalzemeadi.Items.Add(dt_malzeme.Rows[satir].ItemArray[1].ToString());
                }
                cbmalzemeadi.SelectedIndex = 0;
                cbmalzemeadi_SelectedIndexChanged(null, null);
            }
            catch (Exception)
            {


            }

        }

        private void labelguncelle()
        {


            try
            {
                baglan.Open();
                string sorgu = "select malzemeadedi from malzeme where malzemeadi='" + cbmalzemeadi.SelectedItem + "'";
                MySqlCommand sec = new MySqlCommand(sorgu, baglan);
                MySqlDataReader read = sec.ExecuteReader();
                read.Read();
                label3.Text = read["malzemeadedi"].ToString();
                baglan.Close();
            }
            catch
            {

            }
        }
        private void eskiliste()
        {
            try
            {
                baglan.Open();
                string sorgu = "select * from cikis";
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
        private void frmmalzemecikisi_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox1.Items.Add("Malzeme Adı");
            comboBox1.Items.Add("Malzeme Cinsi");
            comboBox1.Items.Add("Malzeme Çıkış Tarihi");
            comboBox1.Items.Add("Üst Birim");
            comboBox1.Items.Add("Alt Birim");



            cbustbirim.Items.Add("Poliklinik");
            cbustbirim.Items.Add("İdari Birimler");
            cbustbirim.Items.Add("Ameliyathane");
            cbustbirim.Items.Add("Yoğun Bakım");
            cbustbirim.Items.Add("Servisler");

            labelguncelle();
            try
            {
                eskiliste();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Malzeme Adı";
                dataGridView1.Columns[2].HeaderText = "Malzeme Cinsi";
                dataGridView1.Columns[3].HeaderText = "Malzeme Çıkış Tarihi";
                dataGridView1.Columns[4].HeaderText = "Üst Birim";
                dataGridView1.Columns[5].HeaderText = "Alt Birim";
                dataGridView1.Columns[6].HeaderText = "Malzeme Adedi";
                dataGridView1.Columns[7].HeaderText = "Açıklama";
            }
            catch (Exception)
            {


            }




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

            int x = Convert.ToInt32(label3.Text);
            int y = Convert.ToInt32(textBox1.Text);
            if (cbustbirim.SelectedIndex > -1 && cbaltbirim.SelectedIndex > -1 && cbmalzemecinsi.SelectedIndex > -1 && txtaciklama.Text.Length > 0 && textBox1.Text.Length > 0 && x >= y)
            {
                baglan.Open();
                string ekle = "insert into cikis(malzemeadi,malzemecinsi,malzemecikistarihi,ustbirim,altbirim,malzemeadedi,aciklama) values('" + cbmalzemeadi.SelectedItem + "','" + cbmalzemecinsi.SelectedItem + "','" + DateTime.Now.ToShortDateString() + "','" + cbustbirim.SelectedItem + "','" + cbaltbirim.SelectedItem + "','" + textBox1.Text + "','" + txtaciklama.Text + "')";
                MySqlCommand komut = new MySqlCommand(ekle, baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                baglan.Open();
                string sorgu = "select * from malzeme where malzemeadi='" + cbmalzemeadi.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);

                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();
                int a = Convert.ToInt32(read["malzemeadedi"]);

                baglan.Close();
                a -= Convert.ToInt32(textBox1.Text);

                baglan.Open();
                string sorgu2 = "update malzeme set malzemeadedi='" + a.ToString() + "' where malzemeadi='" + cbmalzemeadi.SelectedItem + "'";
                MySqlCommand upd = new MySqlCommand(sorgu2, baglan);
                upd.ExecuteNonQuery();
                baglan.Close();
                eskiliste();
                labelguncelle();

                txtaciklama.Text = "";
                textBox1.Text = "";

                if (a == 0)
                {
                    baglan.Open();
                    string sill = "delete from malzeme where malzemeadi='" + cbmalzemeadi.Text + "'";
                    MySqlCommand sil = new MySqlCommand(sill, baglan);
                    sil.ExecuteNonQuery();
                    MessageBox.Show("Bu malzeme çıkışıyla birlikte bu malzeme  adına kayıtlı tüm stoklar tükendi.");
                    baglan.Close();
                }
                MessageBox.Show("Malzeme çıkış kaydı başarıyla gerçekleşti ! ");



            }
            else { MessageBox.Show("Ya boşlukları tam doldurmadınız ya da stokta olduğundan fazla değer girdiniz"); }


        }

        private void cbustbirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbustbirim.Items[cbustbirim.SelectedIndex].ToString() == "Poliklinik")
            {
                cbaltbirim.Items.Clear();
                cbaltbirim.Items.Add("KBB");
                cbaltbirim.Items.Add("Genel Cerrahi Polikliniği");


            }

            else if (cbustbirim.Items[cbustbirim.SelectedIndex].ToString() == "İdari Birimler")
            {
                cbaltbirim.Items.Clear();
                cbaltbirim.Items.Add("Hastane Yöneticisi");
                cbaltbirim.Items.Add("Başhekimlik");
                cbaltbirim.Items.Add("İdari Ve Mali İşler Müdürlüğü");
                cbaltbirim.Items.Add("Sağlık Bakım Hizmetleri Müdürlüğü");
                cbaltbirim.Items.Add("Hastane Hizmetleri Ve Sağlık Otelciliği Müdürlüğü");


            }

        }

        private void cbmalzemeadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelguncelle();
            cbmalzemecinsi.Items.Clear();
            string s = cbmalzemeadi.SelectedItem + "";
            for (int i = 0; i < dt_malzeme.Rows.Count; i++)
            {
                if (s == dt_malzeme.Rows[i].ItemArray[1] + "")
                    cbmalzemecinsi.Items.Add(dt_malzeme.Rows[i].ItemArray[2]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                string sorgu = "select * from cikis where " + degisken + " like'" + textBox2.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();

            }
            catch
            {


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                degisken = "";
                degisken = "malzemeadi";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                degisken = "";
                degisken = "malzemecinsi";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                degisken = "";
                degisken = "malzemecikistarihi";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                degisken = "";
                degisken = "ustbirim";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                degisken = "";
                degisken = "altbirim";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtsil.Text.Length > 0)
            {
                try
                {
                    baglan.Open();
                    string silmesorgusu = "delete from cikis where malzemeadi='" + txtsil.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(silmesorgusu, baglan);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Silme işlemi başarılı!");
                        txtsil.Clear();
                        baglan.Close();
                        eskiliste();
                        labelguncelle();
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
