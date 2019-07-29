namespace OtoSeraCalisma2
{
    partial class ProfilEkrani
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
            this.profil_resmi = new System.Windows.Forms.PictureBox();
            this.resimekleme_butonu = new System.Windows.Forms.Button();
            this.guncelle_butonu = new System.Windows.Forms.Button();
            this.profil_fd = new System.Windows.Forms.OpenFileDialog();
            this.profildurum_label = new System.Windows.Forms.Label();
            this.profiliptal_butonu = new System.Windows.Forms.Button();
            this.yenisifre_paneli = new System.Windows.Forms.Panel();
            this.profilbox_yenisifre = new WindowsFormsApplication4.OzelTextBox();
            this.profilbox_yenisifretekrar = new WindowsFormsApplication4.OzelTextBox();
            this.sifrepanel_butonu = new System.Windows.Forms.Button();
            this.profilbox_eskisifre = new WindowsFormsApplication4.OzelTextBox();
            this.profilbox_eposta = new WindowsFormsApplication4.OzelTextBox();
            this.profilbox_soyad = new WindowsFormsApplication4.OzelTextBox();
            this.profilbox_ad = new WindowsFormsApplication4.OzelTextBox();
            this.profilbox_id = new WindowsFormsApplication4.OzelTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profil_resmi)).BeginInit();
            this.yenisifre_paneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // profil_resmi
            // 
            this.profil_resmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.profil_resmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profil_resmi.Image = global::OtoSeraCalisma2.Properties.Resources.yaprakpnglogosu;
            this.profil_resmi.Location = new System.Drawing.Point(12, 12);
            this.profil_resmi.Name = "profil_resmi";
            this.profil_resmi.Size = new System.Drawing.Size(161, 160);
            this.profil_resmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profil_resmi.TabIndex = 0;
            this.profil_resmi.TabStop = false;
            // 
            // resimekleme_butonu
            // 
            this.resimekleme_butonu.Location = new System.Drawing.Point(13, 179);
            this.resimekleme_butonu.Name = "resimekleme_butonu";
            this.resimekleme_butonu.Size = new System.Drawing.Size(160, 23);
            this.resimekleme_butonu.TabIndex = 5;
            this.resimekleme_butonu.Text = "Resim Ekle";
            this.resimekleme_butonu.UseVisualStyleBackColor = true;
            this.resimekleme_butonu.Click += new System.EventHandler(this.resimekleme_butonu_Click);
            // 
            // guncelle_butonu
            // 
            this.guncelle_butonu.Location = new System.Drawing.Point(348, 307);
            this.guncelle_butonu.Name = "guncelle_butonu";
            this.guncelle_butonu.Size = new System.Drawing.Size(82, 25);
            this.guncelle_butonu.TabIndex = 10;
            this.guncelle_butonu.Text = "Güncelle";
            this.guncelle_butonu.UseVisualStyleBackColor = true;
            this.guncelle_butonu.Click += new System.EventHandler(this.guncelle_butonu_Click);
            // 
            // profil_fd
            // 
            this.profil_fd.FileName = "openFileDialog1";
            this.profil_fd.FileOk += new System.ComponentModel.CancelEventHandler(this.profil_fd_FileOk);
            // 
            // profildurum_label
            // 
            this.profildurum_label.AutoSize = true;
            this.profildurum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profildurum_label.ForeColor = System.Drawing.Color.Red;
            this.profildurum_label.Location = new System.Drawing.Point(201, 335);
            this.profildurum_label.Name = "profildurum_label";
            this.profildurum_label.Size = new System.Drawing.Size(137, 20);
            this.profildurum_label.TabIndex = 11;
            this.profildurum_label.Text = "                                ";
            // 
            // profiliptal_butonu
            // 
            this.profiliptal_butonu.Location = new System.Drawing.Point(436, 307);
            this.profiliptal_butonu.Name = "profiliptal_butonu";
            this.profiliptal_butonu.Size = new System.Drawing.Size(75, 25);
            this.profiliptal_butonu.TabIndex = 13;
            this.profiliptal_butonu.Text = "İptal Et";
            this.profiliptal_butonu.UseVisualStyleBackColor = true;
            this.profiliptal_butonu.Click += new System.EventHandler(this.profiliptal_butonu_Click);
            // 
            // yenisifre_paneli
            // 
            this.yenisifre_paneli.Controls.Add(this.profilbox_yenisifre);
            this.yenisifre_paneli.Controls.Add(this.profilbox_yenisifretekrar);
            this.yenisifre_paneli.Location = new System.Drawing.Point(205, 213);
            this.yenisifre_paneli.Name = "yenisifre_paneli";
            this.yenisifre_paneli.Size = new System.Drawing.Size(306, 68);
            this.yenisifre_paneli.TabIndex = 15;
            this.yenisifre_paneli.Visible = false;
            // 
            // profilbox_yenisifre
            // 
            this.profilbox_yenisifre.Arkayazi = "YENİ ŞİFRE";
            this.profilbox_yenisifre.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_yenisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_yenisifre.ForeColor = System.Drawing.Color.Black;
            this.profilbox_yenisifre.Location = new System.Drawing.Point(0, 3);
            this.profilbox_yenisifre.Multiline = true;
            this.profilbox_yenisifre.Name = "profilbox_yenisifre";
            this.profilbox_yenisifre.Size = new System.Drawing.Size(306, 27);
            this.profilbox_yenisifre.TabIndex = 7;
            this.profilbox_yenisifre.TextChanged += new System.EventHandler(this.profilbox_yenisifre_TextChanged);
            // 
            // profilbox_yenisifretekrar
            // 
            this.profilbox_yenisifretekrar.Arkayazi = "YENİ ŞİFRE TEKRAR";
            this.profilbox_yenisifretekrar.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_yenisifretekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_yenisifretekrar.ForeColor = System.Drawing.Color.Black;
            this.profilbox_yenisifretekrar.Location = new System.Drawing.Point(0, 36);
            this.profilbox_yenisifretekrar.Multiline = true;
            this.profilbox_yenisifretekrar.Name = "profilbox_yenisifretekrar";
            this.profilbox_yenisifretekrar.Size = new System.Drawing.Size(306, 27);
            this.profilbox_yenisifretekrar.TabIndex = 8;
            this.profilbox_yenisifretekrar.TextChanged += new System.EventHandler(this.profilbox_yenisifretekrar_TextChanged);
            // 
            // sifrepanel_butonu
            // 
            this.sifrepanel_butonu.Location = new System.Drawing.Point(238, 307);
            this.sifrepanel_butonu.Name = "sifrepanel_butonu";
            this.sifrepanel_butonu.Size = new System.Drawing.Size(104, 25);
            this.sifrepanel_butonu.TabIndex = 16;
            this.sifrepanel_butonu.Text = "Şifreyi Değiştir";
            this.sifrepanel_butonu.UseVisualStyleBackColor = true;
            this.sifrepanel_butonu.Click += new System.EventHandler(this.sifrepanel_butonu_Click);
            // 
            // profilbox_eskisifre
            // 
            this.profilbox_eskisifre.Arkayazi = "ŞİFRE";
            this.profilbox_eskisifre.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_eskisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_eskisifre.ForeColor = System.Drawing.Color.Black;
            this.profilbox_eskisifre.Location = new System.Drawing.Point(205, 180);
            this.profilbox_eskisifre.Multiline = true;
            this.profilbox_eskisifre.Name = "profilbox_eskisifre";
            this.profilbox_eskisifre.Size = new System.Drawing.Size(306, 27);
            this.profilbox_eskisifre.TabIndex = 6;
            this.profilbox_eskisifre.TextChanged += new System.EventHandler(this.profilbox_eskisifre_TextChanged);
            // 
            // profilbox_eposta
            // 
            this.profilbox_eposta.Arkayazi = "E-POSTA";
            this.profilbox_eposta.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_eposta.ForeColor = System.Drawing.Color.Black;
            this.profilbox_eposta.Location = new System.Drawing.Point(205, 147);
            this.profilbox_eposta.Multiline = true;
            this.profilbox_eposta.Name = "profilbox_eposta";
            this.profilbox_eposta.Size = new System.Drawing.Size(306, 27);
            this.profilbox_eposta.TabIndex = 4;
            // 
            // profilbox_soyad
            // 
            this.profilbox_soyad.Arkayazi = "SOYADI";
            this.profilbox_soyad.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_soyad.ForeColor = System.Drawing.Color.Black;
            this.profilbox_soyad.Location = new System.Drawing.Point(205, 114);
            this.profilbox_soyad.Multiline = true;
            this.profilbox_soyad.Name = "profilbox_soyad";
            this.profilbox_soyad.Size = new System.Drawing.Size(306, 27);
            this.profilbox_soyad.TabIndex = 3;
            // 
            // profilbox_ad
            // 
            this.profilbox_ad.Arkayazi = "ADI";
            this.profilbox_ad.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_ad.ForeColor = System.Drawing.Color.Black;
            this.profilbox_ad.Location = new System.Drawing.Point(205, 81);
            this.profilbox_ad.Multiline = true;
            this.profilbox_ad.Name = "profilbox_ad";
            this.profilbox_ad.Size = new System.Drawing.Size(306, 27);
            this.profilbox_ad.TabIndex = 2;
            // 
            // profilbox_id
            // 
            this.profilbox_id.Arkayazi = "KULLANICI ADI";
            this.profilbox_id.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.profilbox_id.ForeColor = System.Drawing.Color.Black;
            this.profilbox_id.Location = new System.Drawing.Point(205, 48);
            this.profilbox_id.Multiline = true;
            this.profilbox_id.Name = "profilbox_id";
            this.profilbox_id.Size = new System.Drawing.Size(306, 27);
            this.profilbox_id.TabIndex = 1;
            // 
            // ProfilEkrani
            // 
            this.AcceptButton = this.guncelle_butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 369);
            this.Controls.Add(this.sifrepanel_butonu);
            this.Controls.Add(this.yenisifre_paneli);
            this.Controls.Add(this.profiliptal_butonu);
            this.Controls.Add(this.profildurum_label);
            this.Controls.Add(this.guncelle_butonu);
            this.Controls.Add(this.profilbox_eskisifre);
            this.Controls.Add(this.resimekleme_butonu);
            this.Controls.Add(this.profilbox_eposta);
            this.Controls.Add(this.profilbox_soyad);
            this.Controls.Add(this.profilbox_ad);
            this.Controls.Add(this.profilbox_id);
            this.Controls.Add(this.profil_resmi);
            this.Name = "ProfilEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.ProfilEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profil_resmi)).EndInit();
            this.yenisifre_paneli.ResumeLayout(false);
            this.yenisifre_paneli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profil_resmi;
        private WindowsFormsApplication4.OzelTextBox profilbox_id;
        private WindowsFormsApplication4.OzelTextBox profilbox_ad;
        private WindowsFormsApplication4.OzelTextBox profilbox_soyad;
        private WindowsFormsApplication4.OzelTextBox profilbox_eposta;
        private System.Windows.Forms.Button resimekleme_butonu;
        private WindowsFormsApplication4.OzelTextBox profilbox_eskisifre;
        private WindowsFormsApplication4.OzelTextBox profilbox_yenisifre;
        private WindowsFormsApplication4.OzelTextBox profilbox_yenisifretekrar;
        private System.Windows.Forms.Button guncelle_butonu;
        private System.Windows.Forms.OpenFileDialog profil_fd;
        private System.Windows.Forms.Label profildurum_label;
        private System.Windows.Forms.Button profiliptal_butonu;
        private System.Windows.Forms.Panel yenisifre_paneli;
        private System.Windows.Forms.Button sifrepanel_butonu;
    }
}