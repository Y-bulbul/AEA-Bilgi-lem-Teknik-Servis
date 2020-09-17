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
    public partial class frmmalzemeekrani : Form
    {
        MySqlConnection baglanti;
        MySqlDataAdapter da_malzeme, da_ustbirim, da_altbirim;
        DataTable dt_malzeme;
        public frmmalzemeekrani()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder bag = new MySqlConnectionStringBuilder();
            bag.Server = "localhost";
            bag.UserID = "root";
            bag.Password = "oklahoma35";
            bag.Database = "dbhastanebts";
            baglanti = new MySqlConnection(bag.ToString());

            //malzeme tablosu select,insert 
            MySqlCommand cmd_malzeme_sel = new MySqlCommand("select id,malzemeadi,malzemecinsi,malzemeadedi,malzemeaciklama,malzemegiristarihi from malzeme", baglanti);
            da_malzeme = new MySqlDataAdapter();
            da_malzeme.SelectCommand = cmd_malzeme_sel;
            MySqlCommand cmd_malzeme_ins = new MySqlCommand("insert into malzeme(malzemeadi,malzemecinsi,malzemeadedi,malzemegiristarihi,malzemeaciklama) values(@malzemeadi,@malzemecinsi,@malzemeadedi,@malzemegiristarihi,@malzemeaciklama)", baglanti);

            cmd_malzeme_ins.Parameters.Add("@malzemeadi", MySqlDbType.VarChar, 45, "malzemeadi");
            cmd_malzeme_ins.Parameters.Add("@malzemecinsi", MySqlDbType.VarChar, 45, "malzemecinsi");
            cmd_malzeme_ins.Parameters.Add("@malzemeadedi", MySqlDbType.Int32, 11, "malzemeadedi");
            cmd_malzeme_ins.Parameters.Add("@malzemegiristarihi", MySqlDbType.VarChar, 45, "malzemegiristarihi");
            cmd_malzeme_ins.Parameters.Add("@malzemeaciklama", MySqlDbType.VarChar, 45, "malzemeaciklama");

            da_malzeme.InsertCommand = cmd_malzeme_ins;
            malzemegetir();






            // 

            da_ustbirim = new MySqlDataAdapter();

            // ustbirim tablosu select,insert
            MySqlCommand cmd_ustbirim_sel = new MySqlCommand("select id,malzemeadi,malzemecinsi,malzemeadedi,malzemegiristarihi");
            da_ustbirim.SelectCommand = cmd_ustbirim_sel;
        }
        private void malzemegetir()
        {
            try
            {
                dt_malzeme = new DataTable();
                da_malzeme.Fill(dt_malzeme);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmalzemegirisi frmmalzeme = new frmmalzemegirisi(da_malzeme);
            frmmalzeme.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmalzemecikisi frmmalzemecikis = new frmmalzemecikisi(da_malzeme);
            frmmalzemecikis.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmistatistik frmistatistik = new frmistatistik();
            frmistatistik.Show(); 

        }

        private void frmmalzemeekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
