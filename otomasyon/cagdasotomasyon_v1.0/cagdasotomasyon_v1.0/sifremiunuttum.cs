using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Security;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace cagdasotomasyon_v1._0
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        public bool MailGonder(string konu, string icerik, string mail)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("cagdasotomasyon@outlook.com");
            ePosta.To.Add(textBox1.Text); 

            ePosta.Subject = konu; 
            ePosta.Body = icerik; 

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("cagdasotomasyon@outlook.com", "anafen12");
            client.Port = 587;
            client.Host = "smtp.outlook.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }
        public string dil { get; set; }

        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            this.Text = Localization.şifremiunuttum;
            label1.Text = Localization.sifre_unut_baslik;
            label2.Text = Localization.eposta + ":";
            button1.Text = Localization.gönder;
            onay_text = Localization.onay_text;
            mailbaslik = Localization.sifre.ToUpper() + " " + Localization.hatırlatma.ToUpper();
            sifreint = Localization.sifre;
        }
        private void sifremiunuttum_Load(object sender, EventArgs e)
        {
            diller(dil);
        }
        string sifre;
        string onay_text = "";
        string red_text = "";
        string mailbaslik = "";
        string sifreint = "";
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("select * from uyeler where uye_eposta='" + textBox1.Text + "'");
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["uye_sifre"].ToString();

                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Green;
                    lblHata.Text = onay_text;

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }

                    MailGonder(mailbaslik, sifreint + " :" + sifre,textBox1.Text);
                    baglanti.Close();
                    MessageBox.Show(onay_text,".....");
                    giris obj2 = new giris();
                    obj2.Show();
                    this.Hide();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = red_text;
                }
        }
            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mail Gönderme Hatası";
            }

}
    }
}
