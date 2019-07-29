namespace OtoSeraCalisma2
{
    partial class YoneticiEkrani
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
            this.components = new System.ComponentModel.Container();
            this.yonetici_group = new System.Windows.Forms.GroupBox();
            this.uyeler_butonu = new System.Windows.Forms.Button();
            this.yoneticiprofil_resmi = new System.Windows.Forms.PictureBox();
            this.yonetici_cikis_butonu = new System.Windows.Forms.Button();
            this.yonetici_profil_buton = new System.Windows.Forms.Button();
            this.yoneticiad_label = new System.Windows.Forms.Label();
            this.uye_groupbox = new System.Windows.Forms.GroupBox();
            this.data_kapat = new System.Windows.Forms.Button();
            this.data_uyeler = new System.Windows.Forms.DataGridView();
            this.uye_guncelle = new System.Windows.Forms.Button();
            this.uye_sil = new System.Windows.Forms.Button();
            this.yonetici_arkaplan = new System.Windows.Forms.ImageList(this.components);
            this.uyeliktip_group = new System.Windows.Forms.GroupBox();
            this.guncelle_uyetipi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uyeguncelle_label = new System.Windows.Forms.Label();
            this.uyetip_combobox = new System.Windows.Forms.ComboBox();
            this.uyetip_guncel_iptal = new System.Windows.Forms.Button();
            this.yonetici_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiprofil_resmi)).BeginInit();
            this.uye_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_uyeler)).BeginInit();
            this.uyeliktip_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // yonetici_group
            // 
            this.yonetici_group.Controls.Add(this.uyeler_butonu);
            this.yonetici_group.Controls.Add(this.yoneticiprofil_resmi);
            this.yonetici_group.Controls.Add(this.yonetici_cikis_butonu);
            this.yonetici_group.Controls.Add(this.yonetici_profil_buton);
            this.yonetici_group.Controls.Add(this.yoneticiad_label);
            this.yonetici_group.Location = new System.Drawing.Point(12, 12);
            this.yonetici_group.Name = "yonetici_group";
            this.yonetici_group.Size = new System.Drawing.Size(164, 347);
            this.yonetici_group.TabIndex = 4;
            this.yonetici_group.TabStop = false;
            // 
            // uyeler_butonu
            // 
            this.uyeler_butonu.Location = new System.Drawing.Point(9, 229);
            this.uyeler_butonu.Name = "uyeler_butonu";
            this.uyeler_butonu.Size = new System.Drawing.Size(148, 23);
            this.uyeler_butonu.TabIndex = 4;
            this.uyeler_butonu.Text = "Üyeler Veritabanı";
            this.uyeler_butonu.UseVisualStyleBackColor = true;
            this.uyeler_butonu.Click += new System.EventHandler(this.uyeler_butonu_Click);
            // 
            // yoneticiprofil_resmi
            // 
            this.yoneticiprofil_resmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yoneticiprofil_resmi.Location = new System.Drawing.Point(6, 19);
            this.yoneticiprofil_resmi.Name = "yoneticiprofil_resmi";
            this.yoneticiprofil_resmi.Size = new System.Drawing.Size(150, 150);
            this.yoneticiprofil_resmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yoneticiprofil_resmi.TabIndex = 0;
            this.yoneticiprofil_resmi.TabStop = false;
            // 
            // yonetici_cikis_butonu
            // 
            this.yonetici_cikis_butonu.Location = new System.Drawing.Point(9, 316);
            this.yonetici_cikis_butonu.Name = "yonetici_cikis_butonu";
            this.yonetici_cikis_butonu.Size = new System.Drawing.Size(148, 23);
            this.yonetici_cikis_butonu.TabIndex = 3;
            this.yonetici_cikis_butonu.Text = "Çıkış";
            this.yonetici_cikis_butonu.UseVisualStyleBackColor = true;
            this.yonetici_cikis_butonu.Click += new System.EventHandler(this.yonetici_cikis_butonu_Click);
            // 
            // yonetici_profil_buton
            // 
            this.yonetici_profil_buton.Location = new System.Drawing.Point(9, 287);
            this.yonetici_profil_buton.Name = "yonetici_profil_buton";
            this.yonetici_profil_buton.Size = new System.Drawing.Size(148, 23);
            this.yonetici_profil_buton.TabIndex = 2;
            this.yonetici_profil_buton.Text = "Profil Değiştirme";
            this.yonetici_profil_buton.UseVisualStyleBackColor = true;
            this.yonetici_profil_buton.Click += new System.EventHandler(this.yonetici_profil_buton_Click);
            // 
            // yoneticiad_label
            // 
            this.yoneticiad_label.AutoSize = true;
            this.yoneticiad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.yoneticiad_label.Location = new System.Drawing.Point(6, 182);
            this.yoneticiad_label.Name = "yoneticiad_label";
            this.yoneticiad_label.Size = new System.Drawing.Size(60, 13);
            this.yoneticiad_label.TabIndex = 1;
            this.yoneticiad_label.Text = "İsimSoyisim";
            // 
            // uye_groupbox
            // 
            this.uye_groupbox.Controls.Add(this.data_kapat);
            this.uye_groupbox.Controls.Add(this.data_uyeler);
            this.uye_groupbox.Controls.Add(this.uye_guncelle);
            this.uye_groupbox.Controls.Add(this.uye_sil);
            this.uye_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uye_groupbox.Location = new System.Drawing.Point(182, 31);
            this.uye_groupbox.Name = "uye_groupbox";
            this.uye_groupbox.Size = new System.Drawing.Size(888, 316);
            this.uye_groupbox.TabIndex = 8;
            this.uye_groupbox.TabStop = false;
            this.uye_groupbox.Text = "Üyeler";
            this.uye_groupbox.Visible = false;
            // 
            // data_kapat
            // 
            this.data_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.data_kapat.Location = new System.Drawing.Point(806, 10);
            this.data_kapat.Name = "data_kapat";
            this.data_kapat.Size = new System.Drawing.Size(75, 23);
            this.data_kapat.TabIndex = 7;
            this.data_kapat.Text = "Kapat";
            this.data_kapat.UseVisualStyleBackColor = true;
            this.data_kapat.Click += new System.EventHandler(this.data_kapat_Click);
            // 
            // data_uyeler
            // 
            this.data_uyeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_uyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_uyeler.Location = new System.Drawing.Point(-1, 49);
            this.data_uyeler.Name = "data_uyeler";
            this.data_uyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_uyeler.Size = new System.Drawing.Size(888, 208);
            this.data_uyeler.TabIndex = 4;
            // 
            // uye_guncelle
            // 
            this.uye_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.uye_guncelle.Location = new System.Drawing.Point(697, 287);
            this.uye_guncelle.Name = "uye_guncelle";
            this.uye_guncelle.Size = new System.Drawing.Size(104, 23);
            this.uye_guncelle.TabIndex = 6;
            this.uye_guncelle.Text = "Yetki Durumu";
            this.uye_guncelle.UseVisualStyleBackColor = true;
            this.uye_guncelle.Click += new System.EventHandler(this.uye_guncelle_Click);
            // 
            // uye_sil
            // 
            this.uye_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.uye_sil.Location = new System.Drawing.Point(807, 287);
            this.uye_sil.Name = "uye_sil";
            this.uye_sil.Size = new System.Drawing.Size(75, 23);
            this.uye_sil.TabIndex = 5;
            this.uye_sil.Text = "Sil";
            this.uye_sil.UseVisualStyleBackColor = true;
            this.uye_sil.Click += new System.EventHandler(this.uye_sil_Click);
            // 
            // yonetici_arkaplan
            // 
            this.yonetici_arkaplan.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.yonetici_arkaplan.ImageSize = new System.Drawing.Size(16, 16);
            this.yonetici_arkaplan.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uyeliktip_group
            // 
            this.uyeliktip_group.Controls.Add(this.uyetip_guncel_iptal);
            this.uyeliktip_group.Controls.Add(this.guncelle_uyetipi);
            this.uyeliktip_group.Controls.Add(this.label2);
            this.uyeliktip_group.Controls.Add(this.uyeguncelle_label);
            this.uyeliktip_group.Controls.Add(this.uyetip_combobox);
            this.uyeliktip_group.Location = new System.Drawing.Point(725, 354);
            this.uyeliktip_group.Name = "uyeliktip_group";
            this.uyeliktip_group.Size = new System.Drawing.Size(345, 115);
            this.uyeliktip_group.TabIndex = 9;
            this.uyeliktip_group.TabStop = false;
            this.uyeliktip_group.Text = "Üyelik Tipi Güncelleme";
            this.uyeliktip_group.Visible = false;
            // 
            // guncelle_uyetipi
            // 
            this.guncelle_uyetipi.Location = new System.Drawing.Point(183, 83);
            this.guncelle_uyetipi.Name = "guncelle_uyetipi";
            this.guncelle_uyetipi.Size = new System.Drawing.Size(75, 23);
            this.guncelle_uyetipi.TabIndex = 3;
            this.guncelle_uyetipi.Text = "Güncelle";
            this.guncelle_uyetipi.UseVisualStyleBackColor = true;
            this.guncelle_uyetipi.Click += new System.EventHandler(this.guncelle_uyetipi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üyelik Tipi:";
            // 
            // uyeguncelle_label
            // 
            this.uyeguncelle_label.AutoSize = true;
            this.uyeguncelle_label.Location = new System.Drawing.Point(28, 37);
            this.uyeguncelle_label.Name = "uyeguncelle_label";
            this.uyeguncelle_label.Size = new System.Drawing.Size(105, 13);
            this.uyeguncelle_label.TabIndex = 1;
            this.uyeguncelle_label.Text = "SeçiliÜyeKullanıcıAdı";
            // 
            // uyetip_combobox
            // 
            this.uyetip_combobox.FormattingEnabled = true;
            this.uyetip_combobox.Location = new System.Drawing.Point(98, 57);
            this.uyetip_combobox.Name = "uyetip_combobox";
            this.uyetip_combobox.Size = new System.Drawing.Size(160, 21);
            this.uyetip_combobox.TabIndex = 0;
            // 
            // uyetip_guncel_iptal
            // 
            this.uyetip_guncel_iptal.Location = new System.Drawing.Point(265, 83);
            this.uyetip_guncel_iptal.Name = "uyetip_guncel_iptal";
            this.uyetip_guncel_iptal.Size = new System.Drawing.Size(75, 23);
            this.uyetip_guncel_iptal.TabIndex = 4;
            this.uyetip_guncel_iptal.Text = "İptal";
            this.uyetip_guncel_iptal.UseVisualStyleBackColor = true;
            this.uyetip_guncel_iptal.Click += new System.EventHandler(this.uyetip_guncel_iptal_Click);
            // 
            // YoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 472);
            this.Controls.Add(this.uyeliktip_group);
            this.Controls.Add(this.uye_groupbox);
            this.Controls.Add(this.yonetici_group);
            this.Name = "YoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Ekranı";
            this.Load += new System.EventHandler(this.YoneticiEkrani_Load);
            this.yonetici_group.ResumeLayout(false);
            this.yonetici_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiprofil_resmi)).EndInit();
            this.uye_groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_uyeler)).EndInit();
            this.uyeliktip_group.ResumeLayout(false);
            this.uyeliktip_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox yonetici_group;
        private System.Windows.Forms.Button uyeler_butonu;
        private System.Windows.Forms.PictureBox yoneticiprofil_resmi;
        private System.Windows.Forms.Button yonetici_cikis_butonu;
        private System.Windows.Forms.Button yonetici_profil_buton;
        private System.Windows.Forms.Label yoneticiad_label;
        private System.Windows.Forms.GroupBox uye_groupbox;
        private System.Windows.Forms.Button data_kapat;
        public System.Windows.Forms.DataGridView data_uyeler;
        private System.Windows.Forms.Button uye_guncelle;
        private System.Windows.Forms.Button uye_sil;
        private System.Windows.Forms.ImageList yonetici_arkaplan;
        private System.Windows.Forms.GroupBox uyeliktip_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uyeguncelle_label;
        private System.Windows.Forms.ComboBox uyetip_combobox;
        private System.Windows.Forms.Button guncelle_uyetipi;
        private System.Windows.Forms.Button uyetip_guncel_iptal;




    }
}