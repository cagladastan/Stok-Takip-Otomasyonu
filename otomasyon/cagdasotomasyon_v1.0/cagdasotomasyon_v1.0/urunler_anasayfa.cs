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
    public partial class urunler_anasayfa : Form
    {

        public string dil { get; set; }

        public string yetki { get; set; }
        public urunler_anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        private void button1_Click(object sender, EventArgs e)
        {
            urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
            urunler.dil = dil;
            urunler.id = null;

            urunler.Show();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label2.Text = Localization.urunler;
            label1.Text = Localization.ara;
            button1.Text = Localization.ekle;
            button2.Text = Localization.sil;
            button3.Text = Localization.güncelle;
            button5.Text = Localization.yenile;
            this.Text = Localization.urunler;
            red_lbl.Text = Localization.işaret_kırmızı;
            lbl_yellow.Text = Localization.işaret_sarı;
                

        }
        public void datagetir()
        {
            baglanti.Open();
            SqlDataAdapter komutda = new SqlDataAdapter("select * from urunler", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];
            baglanti.Close();
            datarenk();
        }
        private void urunler_anasayfa_Load(object sender, EventArgs e)
        {
            datagetir();
            diller(dil);
            if (yetki== "Yok") {
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open(); 
            SqlDataAdapter komutda = new SqlDataAdapter("select * from urunler where urun_adi like '%"+textBox1.Text+"%'", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];
            baglanti.Close();
            datarenk();

        }
        void datarenk()
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= 200)
                {

                    renk.BackColor = Color.Yellow;
                    renk.ForeColor = Color.Black;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= 50)
                {

                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                

                dataGridView1.Rows[i].DefaultCellStyle = renk;

            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM urunler WHERE urun_id=" + id, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Silinmiştir.", "İşlem");
            baglanti.Close();
            datagetir();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlDataAdapter komutda = new SqlDataAdapter("select * from urunler where urun_barcode like '%" + textBox2.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];
            baglanti.Close();
            datarenk();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            datagetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
            urunler.dil = dil;
            urunler.id = id.ToString();
            urunler.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedText == "ekle")
            //{
            //    urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
            //    urunler.dil = dil;
            //    urunler.id = null;
            //    urunler.Show();
            //}
            //else if (comboBox1.SelectedText == "güncelle")
            //{
            //    urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
            //    urunler.dil = dil;
            //    urunler.id = id.ToString();
            //    urunler.Show();
            //}
            //else if (comboBox1.SelectedText == "sil")
            //{
            //    this.baglanti.Open();
            //    SqlCommand komut = new SqlCommand("DELETE FROM urunler WHERE urun_id=" + id, baglanti);
            //    komut.ExecuteNonQuery();
            //    MessageBox.Show("Ürün Silinmiştir.", "İşlem");
            //    baglanti.Close();
            //    datagetir();
            //}
        }

        private void urunler_anasayfa_Enter(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "ekle")
            {
                urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
                urunler.dil = dil;
                urunler.id = null;
                urunler.Show();
            }
            else if (comboBox1.SelectedText == "güncelle")
            {
                urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
                urunler.dil = dil;
                urunler.id = id.ToString();
                urunler.Show();
            }
            else if (comboBox1.SelectedText == "sil")
            {
                this.baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM urunler WHERE urun_id=" + id, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Silinmiştir.", "İşlem");
                baglanti.Close();
                datagetir();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Çıkamk istediğinize emin misiniz","Çıkış mesajı",MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ekle")
            {
                urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
                urunler.dil = dil;
                urunler.id = null;
                urunler.Show();
            }
            else if (comboBox1.SelectedText == "güncelle")
            {
                urunler_ekle_guncelle urunler = new urunler_ekle_guncelle();
                urunler.dil = dil;
                urunler.id = id.ToString();
                urunler.Show();
            }
            else if (comboBox1.SelectedText == "sil")
            {
                this.baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM urunler WHERE urun_id=" + id, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün Silinmiştir.", "İşlem");
                baglanti.Close();
                datagetir();
            }
        }
    }
}
