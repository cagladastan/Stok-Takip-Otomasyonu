using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Globalization;
using System.Threading;

namespace cagdasotomasyon_v1._0
{
    public partial class depo_ekle_guncelle : Form
    {
        public depo_ekle_guncelle()
        {
            InitializeComponent();
        }
        public string dil { get; set; }
        public string id { get; set; }

        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        private void depo_ekle_guncelle_Load(object sender, EventArgs e)
        {
            diller(dil);

            dropdowyazdir();
            if (id!=null)
            {
                button3.Visible = true;
                button2.Visible = false;
                button1.Visible = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from depolar where depo_id = "+Convert.ToInt32(id), baglanti);
                komut.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["depo_adi"].ToString();
                    textBox2.Text = dr["depo_adresi"].ToString();
                    comboBox1.SelectedItem = dr["depo_sorumlu_kadi"].ToString();
                    textBox3.Text = dr["depo_tel"].ToString();
                    textBox4.Text = dr["depo_sehir"].ToString();
                }
                baglanti.Close();
            }
        }
        public void dropdowyazdir()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select uye_kadi from uyeler", baglanti);
            komut.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["uye_kadi"].ToString());
            }
            baglanti.Close();
        }
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = Localization.depo + " " + Localization.ekle;
            label2.Text = Localization.depo + " " + Localization.ekle;
            label3.Text = Localization.adı;
            label4.Text = Localization.adres;
            label6.Text = Localization.sorumlu + " " + Localization.kullanici_adi;
            label5.Text = Localization.tel;
            label7.Text = Localization.sehir;
            button1.Text = Localization.ekle;
            button3.Text = Localization.güncelle;
            this.Text = Localization.depo;
            if (id!=null)
            {

                label1.Text = Localization.depo + " " + Localization.güncelle;
                label2.Text = Localization.depo + " " + Localization.güncelle;

            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into depolar(depo_adi,depo_adresi,depo_sorumlu_kadi,depo_tel,depo_sehir)values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Deponuz Eklenmiştir", "İşlem Tamam.");
            baglanti.Close();
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedItem = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE depolar Set depo_adi = '" + textBox1.Text + "'  ,depo_adresi = '" + textBox2.Text + "',depo_sorumlu_kadi ='" + comboBox1.SelectedItem.ToString() + "',depo_tel='" + textBox3.Text.ToString() + "',depo_sehir ='" + textBox4.Text + "' where depo_id="+id, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Deponuz Güncellenmiştir", "İşlem Tamam.");
            baglanti.Close();
            this.Hide();
            this.Close();
        }
    }
}
