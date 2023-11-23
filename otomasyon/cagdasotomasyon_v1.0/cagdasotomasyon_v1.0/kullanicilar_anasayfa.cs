using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace cagdasotomasyon_v1._0
{
    public partial class kullanicilar_anasayfa : Form
    {
        public kullanicilar_anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        public string dil { get; set; }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label2.Text = Localization.kullanıcilar;
            label1.Text = Localization.ara;
            button1.Text = Localization.ekle;
            button2.Text = Localization.sil;
            button3.Text = Localization.güncelle;
            button4.Text = Localization.yenile;
            this.Text = Localization.kullanıcilar;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_ekle_guncelle frm = new kullanici_ekle_guncelle();
            frm.dil = dil;
            frm.id = null;
            frm.Show();
        }

        public void datagetir()
        {
             baglanti.Open();
            SqlDataAdapter komutda = new SqlDataAdapter("select * from uyeler", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "uyeler");
            dataGridView1.DataSource = ds.Tables["uyeler"];
            baglanti.Close();
        }
        public void kullanicilar_anasayfa_Load(object sender, EventArgs e)
        {
            datagetir();

            diller(dil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM uyeler WHERE uye_id=" + id, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Üye Silinmiştir.", "İşlem");
            baglanti.Close();
            datagetir();
        }

        
        public int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;  
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                button2.Visible = true;
                button3.Visible = true;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open(); 
            SqlDataAdapter komutda = new SqlDataAdapter("select * from uyeler where uye_adi like '%" + textBox1.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "uyeler");
            dataGridView1.DataSource = ds.Tables["uyeler"];
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            datagetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanici_ekle_guncelle frm = new kullanici_ekle_guncelle();
            frm.dil = dil;
            frm.id = id.ToString();
            frm.Show();

        }
    }
}
