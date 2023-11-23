
namespace cagdasotomasyon_v1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_depo_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_depo_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_alis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azalan Ürünler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::cagdasotomasyon_v1._0.Properties.Resources.depo_icon;
            this.button1.Location = new System.Drawing.Point(1006, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "DEPOLAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::cagdasotomasyon_v1._0.Properties.Resources.urun_icon;
            this.button2.Location = new System.Drawing.Point(1006, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "ÜRÜNLER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::cagdasotomasyon_v1._0.Properties.Resources.unnamed;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::cagdasotomasyon_v1._0.Properties.Resources.refresh;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(852, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "Yenile";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun_id,
            this.urun_adi,
            this.urun_depo_adi,
            this.urun_depo_yeri,
            this.urun_miktari,
            this.urun_alis,
            this.urun_satis,
            this.urun_aciklama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(21, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(968, 496);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = global::cagdasotomasyon_v1._0.Properties.Resources.kullanici_icon;
            this.button4.Location = new System.Drawing.Point(1006, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(250, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "KULLANICILAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hoşgeldin,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::cagdasotomasyon_v1._0.Properties.Resources.pngwing_com__1_;
            this.ClientSize = new System.Drawing.Size(1074, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ÇAĞDAŞ Otomasyonu V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_depo_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_depo_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_alis;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_satis;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_aciklama;
    }
}

