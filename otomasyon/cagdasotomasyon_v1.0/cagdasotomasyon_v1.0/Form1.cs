using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace cagdasotomasyon_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = cdotomasyon; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        public void diller(string culture)
        {
            Thread.CurrentThread.CurrentUICulture.ClearCachedData();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            label3.Text = Localization.hosgeldin;
            button1.Text = Localization.depolar;
            button2.Text = Localization.urunler;
            button4.Text = Localization.kullanıcilar;
            label2.Text = Localization.azalan_urunler;
            button3.Text = Localization.yenile;
        }
        public string kadi { get; set; }
        public string dil { get; set; }
        public string yetki { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            yazdir();
            diller(dil);
            if (yetki == "Yok")
            {
                button4.Enabled = false;
            }
            
        }
        void datarenk()
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) <= 50)
                {

                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;

            }
        }
        public void yazdir()
        {
            label4.Text = kadi; 
            baglanti.Open();
            SqlDataAdapter komutda = new SqlDataAdapter("select * from urunler", baglanti);
            DataSet ds = new DataSet();
            komutda.Fill(ds, "urunler");
            dataGridView1.DataSource = ds.Tables["urunler"];
            baglanti.Close();
            datarenk();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazdir();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunler_anasayfa urunler = new urunler_anasayfa();
            urunler.dil = dil;
            urunler.yetki = yetki;
            urunler.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(848,26);//// kayar menüler
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(1007, 26);//// kayar menüler
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Location = new Point(848, 97);//// kayar menüler
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(1007, 97);//// kayar menüler
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Location = new Point(830, 169);//// kayar menüler
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Location = new Point(1007, 169);//// kayar menüler
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            depolar_anasayfa depolar = new depolar_anasayfa();
            depolar.dil = dil;
            depolar.yetki = yetki;
            depolar.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            kullanicilar_anasayfa kullanicilar = new kullanicilar_anasayfa();
            kullanicilar.dil = dil;
            kullanicilar.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
