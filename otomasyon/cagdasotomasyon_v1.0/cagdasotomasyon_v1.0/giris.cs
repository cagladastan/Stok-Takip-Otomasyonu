using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace cagdasotomasyon_v1._0
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public string dil="";
        
        public void diller ( string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            label4.Text = Localization.cagdas_otomasyon;
            button1.Text = Localization.giriş;
            linkLabel1.Text = Localization.sifre_unut;
            label2.Text = Localization.sifre;
            label1.Text = Localization.kullanici_adi;
            this.Text = Localization.giriş;
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uyeler where uye_kadi='"+textBox1.Text.ToString()+ "' and uye_sifre = '" + textBox2.Text.ToString() + "'",baglanti);  /// kullancı adı şifreyi sorguladığım sql kodu
            SqlDataReader dr = komut.ExecuteReader(); 
            dr.Read();
            if (dr.HasRows)
            {
                Form1 frm = new Form1();
                frm.kadi = textBox1.Text.ToString();
                frm.kadi = textBox1.Text;
                frm.dil = dil;
                frm.yetki = dr["uye_yetki"].ToString();
                baglanti.Close();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifreniz yanlış tekrar deneyiniz ", ".....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            diller("");
            dil = "";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            diller("en-US");
            dil = "en-US";

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sifremiunuttum frm = new sifremiunuttum();
            frm.dil = dil.ToString();
            frm.Show();
        }
    }
}
