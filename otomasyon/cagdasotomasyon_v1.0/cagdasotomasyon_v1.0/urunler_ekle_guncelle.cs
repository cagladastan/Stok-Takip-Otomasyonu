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
    public partial class urunler_ekle_guncelle : Form
    {
        public urunler_ekle_guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        public string dil { get; set; }
        public string id { get; set; }

        public void dropdowyazdir()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select depo_id,depo_adi from depolar", baglanti);
            komut.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["depo_adi"]);
            }
            baglanti.Close();
        }
        private void urunler_ekle_guncelle_Load(object sender, EventArgs e)
        {
            dropdowyazdir();
            diller(dil);
            if (id!=null)
            {
                button3.Visible = true;
                button3.Enabled = true;
                button2.Visible = false;
                button1.Visible = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from urunler where urun_id = " + Convert.ToInt32(id), baglanti);
                komut.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["urun_adi"].ToString();
                    comboBox1.SelectedItem = dr["urun_depo_adi"].ToString();
                    textBox3.Text = dr["urun_depo_yeri"].ToString();
                    textBox4.Text = dr["urun_miktari"].ToString();
                    textBox5.Text = dr["urun_alis"].ToString();
                    textBox6.Text = dr["urun_satis"].ToString();
                    textBox2.Text = dr["urun_aciklama"].ToString();
                    textBox7.Text = dr["urun_barcode"].ToString();
                }
                baglanti.Close();
            }
        }

        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label1.Text = Localization.urun + " " + Localization.ekle;
            label2.Text = Localization.urun + " " + Localization.ekle;
            label3.Text = Localization.urun + " " + Localization.adı;
            label6.Text = Localization.depo;
            label5.Text = Localization.lokasyon;
            label7.Text = Localization.miktar;
            label8.Text = Localization.alıs;
            label9.Text = Localization.satıs;
            label4.Text = Localization.aciklama;
            button1.Text = Localization.ekle;
            this.Text = Localization.urun;
            if (id!=null)
            {

                label1.Text = Localization.urun + " " + Localization.güncelle;
                label2.Text = Localization.urun + " " + Localization.güncelle;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urunler(urun_adi,urun_depo_adi,urun_depo_yeri,urun_miktari,urun_alis,urun_satis,urun_aciklama,urun_barcode)values('" + textBox1.Text + "','"+comboBox1.SelectedItem.ToString()+"','" + textBox3.Text + "'," + Convert.ToInt32(textBox4.Text) + "," + Convert.ToInt32(textBox5.Text) + "," + Convert.ToInt32(textBox6.Text) + ",'" + textBox2.Text + "','"+textBox7.Text+"')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün eklenmiştir", "İşlem");
                baglanti.Close();
                this.Hide();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen eksiksiz doldurunuz","Dikkat");
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE urunler Set urun_adi='" + textBox1.Text + "',urun_depo_adi='" + comboBox1.SelectedItem.ToString() + "',urun_depo_yeri='" + textBox3.Text + "',urun_miktari=" + Convert.ToInt32(textBox4.Text) + ",urun_alis=" + Convert.ToInt32(textBox5.Text) + ",urun_satis=" + Convert.ToInt32(textBox6.Text) + ",urun_aciklama ='" + textBox2.Text + "', urun_barcode = '"+textBox7.Text+"' where urun_id=" + id, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Güncellenmiştir", "İşlem.");
            baglanti.Close();
            this.Hide();
            this.Close();
        }
    }
}
