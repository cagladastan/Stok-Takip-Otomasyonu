using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace cagdasotomasyon_v1._0
{
    public partial class kullanici_ekle_guncelle : Form
    {
        public kullanici_ekle_guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        public string dil { get; set; }
        public string id { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uyeler(uye_adi,uye_soyad,uye_kadi,uye_sifre,uye_eposta,uye_tel,uye_yetki)values('"+textBox6.Text+"','"+textBox5.Text+"','"+textBox1.Text+"','"+textBox4.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+comboBox1.SelectedItem.ToString()+"')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Üye Eklenmiştir.", "İşlem");
            baglanti.Close();

            kullanicilar_anasayfa frm = new kullanicilar_anasayfa();
            frm.Hide();
            frm.Close();
            
            this.Hide();
            this.Close();
            
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = Localization.Kullanıcı + " " + Localization.ekle;
            label2.Text = Localization.Kullanıcı + " " + Localization.ekle;
            label8.Text = Localization.adı;
            label7.Text = Localization.soyadı;
            label3.Text = Localization.kullanici_adi;
            label4.Text = Localization.eposta;
            label6.Text = Localization.sifre;
            label5.Text = Localization.tel;
            button1.Text = Localization.ekle;
            button3.Text = Localization.güncelle;
            if (id !=null)
            {
                label1.Text = Localization.Kullanıcı + " " + Localization.güncelle;
                label2.Text = Localization.Kullanıcı + " " + Localization.güncelle;
            }
            this.Text = Localization.Kullanıcı;
        }
        private void kullanici_ekle_guncelle_Load(object sender, EventArgs e)
        {
            diller(dil);
            if (id !=null)
            {
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from uyeler where uye_id = " + Convert.ToInt32(id), baglanti);
                komut.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox6.Text = dr["uye_adi"].ToString();
                    textBox5.Text = dr["uye_soyad"].ToString();
                    textBox1.Text = dr["uye_kadi"].ToString();
                    textBox4.Text = dr["uye_sifre"].ToString();
                    textBox2.Text = dr["uye_eposta"].ToString();
                    textBox3.Text = dr["uye_tel"].ToString();
                    comboBox1.SelectedItem = dr["uye_yetki"].ToString();
                }
                baglanti.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("UPDATE uyeler Set uye_adi='" + textBox6.Text + "',uye_soyad='" + textBox5.Text + "',uye_kadi='" + textBox1.Text + "',uye_sifre='" + textBox4.Text.ToString() + "',uye_eposta='" + textBox2.Text.ToString() + "',uye_tel='" + textBox3.Text.ToString() + "',uye_yetki='" + comboBox1.SelectedItem.ToString() + "' where uye_id=" + id, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Güncellenmiştir", "İşlem.");
            baglanti.Close();
            this.Hide();
            this.Close();
        }
    }
}
