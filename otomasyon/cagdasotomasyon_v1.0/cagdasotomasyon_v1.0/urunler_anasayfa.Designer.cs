
namespace cagdasotomasyon_v1._0
{
    partial class urunler_anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunler_anasayfa));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_depo_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_depo_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.red_lbl = new System.Windows.Forms.Label();
            this.lbl_yellow = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürünler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ara:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::cagdasotomasyon_v1._0.Properties.Resources.loop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(878, 223);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(150, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::cagdasotomasyon_v1._0.Properties.Resources.remove;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(878, 143);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::cagdasotomasyon_v1._0.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(878, 63);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(685, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun_id,
            this.urun_adi,
            this.urun_depo_adi,
            this.urun_depo_yeri,
            this.urun_miktari,
            this.urun_alis,
            this.urun_satis,
            this.urun_aciklama,
            this.urun_barcode});
            this.dataGridView1.Location = new System.Drawing.Point(21, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(850, 513);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // urun_id
            // 
            this.urun_id.DataPropertyName = "urun_id";
            this.urun_id.FillWeight = 50F;
            this.urun_id.HeaderText = "Ürün İD";
            this.urun_id.Name = "urun_id";
            this.urun_id.ReadOnly = true;
            // 
            // urun_adi
            // 
            this.urun_adi.DataPropertyName = "urun_adi";
            this.urun_adi.HeaderText = "Ürün Adı";
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.ReadOnly = true;
            // 
            // urun_depo_adi
            // 
            this.urun_depo_adi.DataPropertyName = "urun_depo_adi";
            this.urun_depo_adi.HeaderText = "Bulunduğu Depo";
            this.urun_depo_adi.Name = "urun_depo_adi";
            this.urun_depo_adi.ReadOnly = true;
            // 
            // urun_depo_yeri
            // 
            this.urun_depo_yeri.DataPropertyName = "urun_depo_yeri";
            this.urun_depo_yeri.HeaderText = "Depodaki Yeri";
            this.urun_depo_yeri.Name = "urun_depo_yeri";
            this.urun_depo_yeri.ReadOnly = true;
            // 
            // urun_miktari
            // 
            this.urun_miktari.DataPropertyName = "urun_miktari";
            this.urun_miktari.HeaderText = "Miktarı";
            this.urun_miktari.Name = "urun_miktari";
            this.urun_miktari.ReadOnly = true;
            // 
            // urun_alis
            // 
            this.urun_alis.DataPropertyName = "urun_alis";
            this.urun_alis.HeaderText = "Alış Fiyatı";
            this.urun_alis.Name = "urun_alis";
            this.urun_alis.ReadOnly = true;
            // 
            // urun_satis
            // 
            this.urun_satis.DataPropertyName = "urun_satis";
            this.urun_satis.HeaderText = "Satış Fiyatı";
            this.urun_satis.Name = "urun_satis";
            this.urun_satis.ReadOnly = true;
            // 
            // urun_aciklama
            // 
            this.urun_aciklama.DataPropertyName = "urun_aciklama";
            this.urun_aciklama.HeaderText = "Açıklama";
            this.urun_aciklama.Name = "urun_aciklama";
            this.urun_aciklama.ReadOnly = true;
            // 
            // urun_barcode
            // 
            this.urun_barcode.DataPropertyName = "urun_barcode";
            this.urun_barcode.HeaderText = "Barcode";
            this.urun_barcode.Name = "urun_barcode";
            this.urun_barcode.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(122, 594);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 35);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Image = global::cagdasotomasyon_v1._0.Properties.Resources.barcode;
            this.button4.Location = new System.Drawing.Point(30, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = global::cagdasotomasyon_v1._0.Properties.Resources.refresh;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(878, 301);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(150, 60);
            this.button5.TabIndex = 17;
            this.button5.Text = "Yenile";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // red_lbl
            // 
            this.red_lbl.AutoSize = true;
            this.red_lbl.ForeColor = System.Drawing.Color.Red;
            this.red_lbl.Location = new System.Drawing.Point(297, 594);
            this.red_lbl.Name = "red_lbl";
            this.red_lbl.Size = new System.Drawing.Size(284, 15);
            this.red_lbl.TabIndex = 18;
            this.red_lbl.Text = "* Miktar 50 den az kalan ürünler Kırmızı ile işaretllenir";
            // 
            // lbl_yellow
            // 
            this.lbl_yellow.AutoSize = true;
            this.lbl_yellow.BackColor = System.Drawing.Color.Yellow;
            this.lbl_yellow.ForeColor = System.Drawing.Color.Black;
            this.lbl_yellow.Location = new System.Drawing.Point(297, 617);
            this.lbl_yellow.Name = "lbl_yellow";
            this.lbl_yellow.Size = new System.Drawing.Size(273, 15);
            this.lbl_yellow.TabIndex = 19;
            this.lbl_yellow.Text = "* Miktar 200 den az kalan ürünler Sarı ile işaretllenir";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ekle ",
            "sil",
            "güncelle"});
            this.comboBox1.Location = new System.Drawing.Point(878, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            this.comboBox1.Enter += new System.EventHandler(this.urunler_anasayfa_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(912, 586);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "çıkış";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // urunler_anasayfa
            // 
            this.AcceptButton = this.button4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::cagdasotomasyon_v1._0.Properties.Resources.pngwing_com__1_;
            this.ClientSize = new System.Drawing.Size(1069, 641);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_yellow);
            this.Controls.Add(this.red_lbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urunler_anasayfa";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.urunler_anasayfa_Load);
            this.Enter += new System.EventHandler(this.urunler_anasayfa_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_depo_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_depo_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_satis;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_barcode;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label red_lbl;
        private System.Windows.Forms.Label lbl_yellow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
    }
}