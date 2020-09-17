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
    public partial class frmistatistik : Form
    {
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=dbhastanebts;Uid=root;Pwd='oklahoma35'");
        public frmistatistik()
        {
            InitializeComponent();
        }
        private void giriskayitlari() {
            baglan.Open();
            string sorgu = "select * from malzeme order by id desc ";
            MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        
        }
        private void cikiskayitlari() {
            baglan.Open();
            string query = "select *from cikis order by id desc";
            MySqlCommand cmd = new MySqlCommand(query, baglan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglan.Close();

        
        }
        private void toplist() {
            baglan.Open();
            string query = "select malzemecinsi,sum(malzemeadedi) from cikis";
            MySqlCommand cmd = new MySqlCommand(query, baglan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            baglan.Close();

        
        }
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            giriskayitlari();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = false;
            cikiskayitlari();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toplist();
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.Columns[1].HeaderText = "Toplam";
        }
    }
}
