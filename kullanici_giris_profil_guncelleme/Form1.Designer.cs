namespace kullanici_giris_profil_guncelleme
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.radiobutton_grup = new System.Windows.Forms.GroupBox();
            this.radiobutton_kayit_ol = new System.Windows.Forms.RadioButton();
            this.radiobutton_giris = new System.Windows.Forms.RadioButton();
            this.groupBox_kayit_ol = new System.Windows.Forms.GroupBox();
            this.button_kayit_ol_kayit_ol = new System.Windows.Forms.Button();
            this.textBox_kayit_ol_sifre_onayla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kayit_ol_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kayit_ol_kullanici_adi = new System.Windows.Forms.TextBox();
            this.urun_ismi_label_guncelle = new System.Windows.Forms.Label();
            this.button_kayit_ol_fotograf_ekle = new System.Windows.Forms.Button();
            this.pictureBox_kayit_ol = new System.Windows.Forms.PictureBox();
            this.groupBox_giris = new System.Windows.Forms.GroupBox();
            this.pictureBox_giris = new System.Windows.Forms.PictureBox();
            this.button_giris_giris = new System.Windows.Forms.Button();
            this.textBox_giris_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_giris_kullanici_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobutton_grup.SuspendLayout();
            this.groupBox_kayit_ol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kayit_ol)).BeginInit();
            this.groupBox_giris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_giris)).BeginInit();
            this.SuspendLayout();
            // 
            // radiobutton_grup
            // 
            this.radiobutton_grup.Controls.Add(this.radiobutton_kayit_ol);
            this.radiobutton_grup.Controls.Add(this.radiobutton_giris);
            this.radiobutton_grup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radiobutton_grup.ForeColor = System.Drawing.Color.White;
            this.radiobutton_grup.Location = new System.Drawing.Point(12, 12);
            this.radiobutton_grup.Name = "radiobutton_grup";
            this.radiobutton_grup.Size = new System.Drawing.Size(1040, 65);
            this.radiobutton_grup.TabIndex = 34;
            this.radiobutton_grup.TabStop = false;
            // 
            // radiobutton_kayit_ol
            // 
            this.radiobutton_kayit_ol.AutoSize = true;
            this.radiobutton_kayit_ol.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobutton_kayit_ol.ForeColor = System.Drawing.Color.Teal;
            this.radiobutton_kayit_ol.Location = new System.Drawing.Point(82, 22);
            this.radiobutton_kayit_ol.Name = "radiobutton_kayit_ol";
            this.radiobutton_kayit_ol.Size = new System.Drawing.Size(98, 29);
            this.radiobutton_kayit_ol.TabIndex = 1;
            this.radiobutton_kayit_ol.TabStop = true;
            this.radiobutton_kayit_ol.Text = "Kayıt Ol";
            this.radiobutton_kayit_ol.UseVisualStyleBackColor = true;
            this.radiobutton_kayit_ol.CheckedChanged += new System.EventHandler(this.radiobutton_kayit_ol_CheckedChanged);
            // 
            // radiobutton_giris
            // 
            this.radiobutton_giris.AutoSize = true;
            this.radiobutton_giris.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radiobutton_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radiobutton_giris.Location = new System.Drawing.Point(6, 22);
            this.radiobutton_giris.Name = "radiobutton_giris";
            this.radiobutton_giris.Size = new System.Drawing.Size(70, 29);
            this.radiobutton_giris.TabIndex = 0;
            this.radiobutton_giris.TabStop = true;
            this.radiobutton_giris.Text = "Giriş";
            this.radiobutton_giris.UseVisualStyleBackColor = true;
            this.radiobutton_giris.CheckedChanged += new System.EventHandler(this.radiobutton_giris_CheckedChanged);
            // 
            // groupBox_kayit_ol
            // 
            this.groupBox_kayit_ol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox_kayit_ol.Controls.Add(this.button_kayit_ol_kayit_ol);
            this.groupBox_kayit_ol.Controls.Add(this.textBox_kayit_ol_sifre_onayla);
            this.groupBox_kayit_ol.Controls.Add(this.label2);
            this.groupBox_kayit_ol.Controls.Add(this.textBox_kayit_ol_sifre);
            this.groupBox_kayit_ol.Controls.Add(this.label1);
            this.groupBox_kayit_ol.Controls.Add(this.textBox_kayit_ol_kullanici_adi);
            this.groupBox_kayit_ol.Controls.Add(this.urun_ismi_label_guncelle);
            this.groupBox_kayit_ol.Controls.Add(this.button_kayit_ol_fotograf_ekle);
            this.groupBox_kayit_ol.Controls.Add(this.pictureBox_kayit_ol);
            this.groupBox_kayit_ol.ForeColor = System.Drawing.Color.Teal;
            this.groupBox_kayit_ol.Location = new System.Drawing.Point(12, 83);
            this.groupBox_kayit_ol.Name = "groupBox_kayit_ol";
            this.groupBox_kayit_ol.Size = new System.Drawing.Size(1040, 586);
            this.groupBox_kayit_ol.TabIndex = 35;
            this.groupBox_kayit_ol.TabStop = false;
            // 
            // button_kayit_ol_kayit_ol
            // 
            this.button_kayit_ol_kayit_ol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kayit_ol_kayit_ol.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_kayit_ol_kayit_ol.ForeColor = System.Drawing.Color.Teal;
            this.button_kayit_ol_kayit_ol.Location = new System.Drawing.Point(421, 283);
            this.button_kayit_ol_kayit_ol.Name = "button_kayit_ol_kayit_ol";
            this.button_kayit_ol_kayit_ol.Size = new System.Drawing.Size(613, 61);
            this.button_kayit_ol_kayit_ol.TabIndex = 5;
            this.button_kayit_ol_kayit_ol.Text = "Kayıt Ol";
            this.button_kayit_ol_kayit_ol.UseVisualStyleBackColor = true;
            this.button_kayit_ol_kayit_ol.Click += new System.EventHandler(this.button_kayit_ol_kayit_ol_Click);
            // 
            // textBox_kayit_ol_sifre_onayla
            // 
            this.textBox_kayit_ol_sifre_onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_kayit_ol_sifre_onayla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kayit_ol_sifre_onayla.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_kayit_ol_sifre_onayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.textBox_kayit_ol_sifre_onayla.Location = new System.Drawing.Point(421, 234);
            this.textBox_kayit_ol_sifre_onayla.Name = "textBox_kayit_ol_sifre_onayla";
            this.textBox_kayit_ol_sifre_onayla.PasswordChar = '*';
            this.textBox_kayit_ol_sifre_onayla.Size = new System.Drawing.Size(613, 43);
            this.textBox_kayit_ol_sifre_onayla.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(421, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifreyi Onayla:";
            // 
            // textBox_kayit_ol_sifre
            // 
            this.textBox_kayit_ol_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_kayit_ol_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kayit_ol_sifre.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_kayit_ol_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.textBox_kayit_ol_sifre.Location = new System.Drawing.Point(421, 148);
            this.textBox_kayit_ol_sifre.Name = "textBox_kayit_ol_sifre";
            this.textBox_kayit_ol_sifre.PasswordChar = '*';
            this.textBox_kayit_ol_sifre.Size = new System.Drawing.Size(613, 43);
            this.textBox_kayit_ol_sifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(421, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre:";
            // 
            // textBox_kayit_ol_kullanici_adi
            // 
            this.textBox_kayit_ol_kullanici_adi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_kayit_ol_kullanici_adi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_kayit_ol_kullanici_adi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_kayit_ol_kullanici_adi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.textBox_kayit_ol_kullanici_adi.Location = new System.Drawing.Point(421, 62);
            this.textBox_kayit_ol_kullanici_adi.MaxLength = 50;
            this.textBox_kayit_ol_kullanici_adi.Name = "textBox_kayit_ol_kullanici_adi";
            this.textBox_kayit_ol_kullanici_adi.Size = new System.Drawing.Size(613, 43);
            this.textBox_kayit_ol_kullanici_adi.TabIndex = 2;
            // 
            // urun_ismi_label_guncelle
            // 
            this.urun_ismi_label_guncelle.AutoSize = true;
            this.urun_ismi_label_guncelle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.urun_ismi_label_guncelle.ForeColor = System.Drawing.Color.Teal;
            this.urun_ismi_label_guncelle.Location = new System.Drawing.Point(421, 22);
            this.urun_ismi_label_guncelle.Name = "urun_ismi_label_guncelle";
            this.urun_ismi_label_guncelle.Size = new System.Drawing.Size(185, 37);
            this.urun_ismi_label_guncelle.TabIndex = 12;
            this.urun_ismi_label_guncelle.Text = "Kullanıcı Adı:";
            // 
            // button_kayit_ol_fotograf_ekle
            // 
            this.button_kayit_ol_fotograf_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kayit_ol_fotograf_ekle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_kayit_ol_fotograf_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.button_kayit_ol_fotograf_ekle.Location = new System.Drawing.Point(15, 428);
            this.button_kayit_ol_fotograf_ekle.Name = "button_kayit_ol_fotograf_ekle";
            this.button_kayit_ol_fotograf_ekle.Size = new System.Drawing.Size(400, 43);
            this.button_kayit_ol_fotograf_ekle.TabIndex = 6;
            this.button_kayit_ol_fotograf_ekle.Text = "Fotoğraft Ekle";
            this.button_kayit_ol_fotograf_ekle.UseVisualStyleBackColor = true;
            this.button_kayit_ol_fotograf_ekle.Click += new System.EventHandler(this.button_kayit_ol_fotograf_ekle_Click);
            // 
            // pictureBox_kayit_ol
            // 
            this.pictureBox_kayit_ol.BackgroundImage = global::kullanici_giris_profil_guncelleme.Properties.Resources.Fotograf_ekle;
            this.pictureBox_kayit_ol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_kayit_ol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_kayit_ol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_kayit_ol.Location = new System.Drawing.Point(15, 22);
            this.pictureBox_kayit_ol.Name = "pictureBox_kayit_ol";
            this.pictureBox_kayit_ol.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_kayit_ol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_kayit_ol.TabIndex = 37;
            this.pictureBox_kayit_ol.TabStop = false;
            this.pictureBox_kayit_ol.Click += new System.EventHandler(this.pictureBox_kayit_ol_Click);
            // 
            // groupBox_giris
            // 
            this.groupBox_giris.Controls.Add(this.pictureBox_giris);
            this.groupBox_giris.Controls.Add(this.button_giris_giris);
            this.groupBox_giris.Controls.Add(this.textBox_giris_sifre);
            this.groupBox_giris.Controls.Add(this.label3);
            this.groupBox_giris.Controls.Add(this.textBox_giris_kullanici_adi);
            this.groupBox_giris.Controls.Add(this.label4);
            this.groupBox_giris.Location = new System.Drawing.Point(12, 83);
            this.groupBox_giris.Name = "groupBox_giris";
            this.groupBox_giris.Size = new System.Drawing.Size(1040, 586);
            this.groupBox_giris.TabIndex = 36;
            this.groupBox_giris.TabStop = false;
            // 
            // pictureBox_giris
            // 
            this.pictureBox_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_giris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_giris.Location = new System.Drawing.Point(15, 22);
            this.pictureBox_giris.Name = "pictureBox_giris";
            this.pictureBox_giris.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_giris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_giris.TabIndex = 48;
            this.pictureBox_giris.TabStop = false;
            this.pictureBox_giris.Visible = false;
            // 
            // button_giris_giris
            // 
            this.button_giris_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_giris_giris.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_giris_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_giris_giris.Location = new System.Drawing.Point(421, 197);
            this.button_giris_giris.Name = "button_giris_giris";
            this.button_giris_giris.Size = new System.Drawing.Size(613, 61);
            this.button_giris_giris.TabIndex = 9;
            this.button_giris_giris.Text = "Giriş";
            this.button_giris_giris.UseVisualStyleBackColor = true;
            this.button_giris_giris.Click += new System.EventHandler(this.button_giris_giris_Click);
            // 
            // textBox_giris_sifre
            // 
            this.textBox_giris_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_giris_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_giris_sifre.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_giris_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.textBox_giris_sifre.Location = new System.Drawing.Point(421, 148);
            this.textBox_giris_sifre.Name = "textBox_giris_sifre";
            this.textBox_giris_sifre.PasswordChar = '*';
            this.textBox_giris_sifre.Size = new System.Drawing.Size(613, 43);
            this.textBox_giris_sifre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(421, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre:";
            // 
            // textBox_giris_kullanici_adi
            // 
            this.textBox_giris_kullanici_adi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox_giris_kullanici_adi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_giris_kullanici_adi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_giris_kullanici_adi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(233)))), ((int)(((byte)(145)))));
            this.textBox_giris_kullanici_adi.Location = new System.Drawing.Point(421, 62);
            this.textBox_giris_kullanici_adi.MaxLength = 50;
            this.textBox_giris_kullanici_adi.Name = "textBox_giris_kullanici_adi";
            this.textBox_giris_kullanici_adi.Size = new System.Drawing.Size(613, 43);
            this.textBox_giris_kullanici_adi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(421, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.groupBox_giris);
            this.Controls.Add(this.radiobutton_grup);
            this.Controls.Add(this.groupBox_kayit_ol);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.radiobutton_grup.ResumeLayout(false);
            this.radiobutton_grup.PerformLayout();
            this.groupBox_kayit_ol.ResumeLayout(false);
            this.groupBox_kayit_ol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kayit_ol)).EndInit();
            this.groupBox_giris.ResumeLayout(false);
            this.groupBox_giris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_giris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox radiobutton_grup;
        private RadioButton radiobutton_kayit_ol;
        private RadioButton radiobutton_giris;
        private GroupBox groupBox_kayit_ol;
        private TextBox textBox_kayit_ol_sifre_onayla;
        private Label label2;
        private TextBox textBox_kayit_ol_sifre;
        private Label label1;
        private TextBox textBox_kayit_ol_kullanici_adi;
        private Label urun_ismi_label_guncelle;
        private Button button_kayit_ol_fotograf_ekle;
        private PictureBox pictureBox_kayit_ol;
        private GroupBox groupBox_giris;
        private Button button_kayit_ol_kayit_ol;
        private Button button_giris_giris;
        private TextBox textBox_giris_sifre;
        private Label label3;
        private TextBox textBox_giris_kullanici_adi;
        private Label label4;
        private PictureBox pictureBox_giris;
    }
}