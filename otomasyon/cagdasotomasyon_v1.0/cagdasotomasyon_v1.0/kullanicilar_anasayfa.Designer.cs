
namespace cagdasotomasyon_v1._0
{
    partial class kullanicilar_anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanicilar_anasayfa));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uye_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_kadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uye_yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kullanıcılar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 22);
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
            this.button3.Location = new System.Drawing.Point(870, 219);
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
            this.button2.Location = new System.Drawing.Point(870, 142);
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
            this.button1.Location = new System.Drawing.Point(870, 62);
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
            this.textBox1.Location = new System.Drawing.Point(677, 17);
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
            this.uye_id,
            this.uye_adi,
            this.uye_soyad,
            this.uye_kadi,
            this.uye_sifre,
            this.uye_eposta,
            this.uye_tel,
            this.uye_yetki});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 499);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // uye_id
            // 
            this.uye_id.DataPropertyName = "uye_id";
            this.uye_id.FillWeight = 21.68768F;
            this.uye_id.HeaderText = " ID";
            this.uye_id.Name = "uye_id";
            this.uye_id.ReadOnly = true;
            // 
            // uye_adi
            // 
            this.uye_adi.DataPropertyName = "uye_adi";
            this.uye_adi.FillWeight = 34.33664F;
            this.uye_adi.HeaderText = " Adı";
            this.uye_adi.Name = "uye_adi";
            this.uye_adi.ReadOnly = true;
            // 
            // uye_soyad
            // 
            this.uye_soyad.DataPropertyName = "uye_soyad";
            this.uye_soyad.FillWeight = 34.33664F;
            this.uye_soyad.HeaderText = "Soyadı";
            this.uye_soyad.Name = "uye_soyad";
            this.uye_soyad.ReadOnly = true;
            // 
            // uye_kadi
            // 
            this.uye_kadi.DataPropertyName = "uye_kadi";
            this.uye_kadi.FillWeight = 34.33664F;
            this.uye_kadi.HeaderText = "Kullanıcı Adı";
            this.uye_kadi.Name = "uye_kadi";
            this.uye_kadi.ReadOnly = true;
            // 
            // uye_sifre
            // 
            this.uye_sifre.DataPropertyName = "uye_sifre";
            this.uye_sifre.FillWeight = 34.33664F;
            this.uye_sifre.HeaderText = "Şifresi";
            this.uye_sifre.Name = "uye_sifre";
            this.uye_sifre.ReadOnly = true;
            // 
            // uye_eposta
            // 
            this.uye_eposta.DataPropertyName = "uye_eposta";
            this.uye_eposta.FillWeight = 59.64112F;
            this.uye_eposta.HeaderText = "E-posta";
            this.uye_eposta.Name = "uye_eposta";
            this.uye_eposta.ReadOnly = true;
            // 
            // uye_tel
            // 
            this.uye_tel.DataPropertyName = "uye_tel";
            this.uye_tel.FillWeight = 48.79728F;
            this.uye_tel.HeaderText = "Telefon";
            this.uye_tel.Name = "uye_tel";
            this.uye_tel.ReadOnly = true;
            // 
            // uye_yetki
            // 
            this.uye_yetki.DataPropertyName = "uye_yetki";
            this.uye_yetki.FillWeight = 20F;
            this.uye_yetki.HeaderText = "Yetkisi";
            this.uye_yetki.Name = "uye_yetki";
            this.uye_yetki.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::cagdasotomasyon_v1._0.Properties.Resources.refresh;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(870, 300);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(150, 60);
            this.button4.TabIndex = 15;
            this.button4.Text = "Yenile";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // kullanicilar_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::cagdasotomasyon_v1._0.Properties.Resources.pngwing_com__1_;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullanicilar_anasayfa";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.kullanicilar_anasayfa_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_kadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uye_yetki;
        private System.Windows.Forms.Button button4;
    }
}