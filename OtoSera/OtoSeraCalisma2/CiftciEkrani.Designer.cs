namespace OtoSeraCalisma2
{
    partial class CiftciEkrani
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
            this.ciftciad_label = new System.Windows.Forms.Label();
            this.profil_buton = new System.Windows.Forms.Button();
            this.ciftci_group = new System.Windows.Forms.GroupBox();
            this.tarla_butonu = new System.Windows.Forms.Button();
            this.ciftciprofil_resmi = new System.Windows.Forms.PictureBox();
            this.ciftci_cikis_butonu = new System.Windows.Forms.Button();
            this.data_ciftci = new System.Windows.Forms.DataGridView();
            this.ciftci_urun_sil = new System.Windows.Forms.Button();
            this.ciftci_urun_guncelle = new System.Windows.Forms.Button();
            this.tarla_groupbox = new System.Windows.Forms.GroupBox();
            this.motor1 = new System.Windows.Forms.Button();
            this.ciftci_urun_ekle = new System.Windows.Forms.Button();
            this.data_kapat = new System.Windows.Forms.Button();
            this.ciftci_arkaplan = new System.Windows.Forms.ImageList(this.components);
            this.ciftci_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciftciprofil_resmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ciftci)).BeginInit();
            this.tarla_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ciftciad_label
            // 
            this.ciftciad_label.AutoSize = true;
            this.ciftciad_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ciftciad_label.Location = new System.Drawing.Point(6, 182);
            this.ciftciad_label.Name = "ciftciad_label";
            this.ciftciad_label.Size = new System.Drawing.Size(60, 13);
            this.ciftciad_label.TabIndex = 1;
            this.ciftciad_label.Text = "İsimSoyisim";
            // 
            // profil_buton
            // 
            this.profil_buton.Location = new System.Drawing.Point(9, 287);
            this.profil_buton.Name = "profil_buton";
            this.profil_buton.Size = new System.Drawing.Size(148, 23);
            this.profil_buton.TabIndex = 2;
            this.profil_buton.Text = "Profil Değiştirme";
            this.profil_buton.UseVisualStyleBackColor = true;
            this.profil_buton.Click += new System.EventHandler(this.profil_buton_Click);
            // 
            // ciftci_group
            // 
            this.ciftci_group.Controls.Add(this.tarla_butonu);
            this.ciftci_group.Controls.Add(this.ciftciprofil_resmi);
            this.ciftci_group.Controls.Add(this.ciftci_cikis_butonu);
            this.ciftci_group.Controls.Add(this.profil_buton);
            this.ciftci_group.Controls.Add(this.ciftciad_label);
            this.ciftci_group.Location = new System.Drawing.Point(13, 13);
            this.ciftci_group.Name = "ciftci_group";
            this.ciftci_group.Size = new System.Drawing.Size(164, 347);
            this.ciftci_group.TabIndex = 3;
            this.ciftci_group.TabStop = false;
            // 
            // tarla_butonu
            // 
            this.tarla_butonu.Location = new System.Drawing.Point(9, 229);
            this.tarla_butonu.Name = "tarla_butonu";
            this.tarla_butonu.Size = new System.Drawing.Size(148, 23);
            this.tarla_butonu.TabIndex = 4;
            this.tarla_butonu.Text = "Tarla";
            this.tarla_butonu.UseVisualStyleBackColor = true;
            this.tarla_butonu.Click += new System.EventHandler(this.tarla_butonu_Click);
            // 
            // ciftciprofil_resmi
            // 
            this.ciftciprofil_resmi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ciftciprofil_resmi.Location = new System.Drawing.Point(6, 19);
            this.ciftciprofil_resmi.Name = "ciftciprofil_resmi";
            this.ciftciprofil_resmi.Size = new System.Drawing.Size(150, 150);
            this.ciftciprofil_resmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ciftciprofil_resmi.TabIndex = 0;
            this.ciftciprofil_resmi.TabStop = false;
            // 
            // ciftci_cikis_butonu
            // 
            this.ciftci_cikis_butonu.Location = new System.Drawing.Point(9, 316);
            this.ciftci_cikis_butonu.Name = "ciftci_cikis_butonu";
            this.ciftci_cikis_butonu.Size = new System.Drawing.Size(148, 23);
            this.ciftci_cikis_butonu.TabIndex = 3;
            this.ciftci_cikis_butonu.Text = "Çıkış";
            this.ciftci_cikis_butonu.UseVisualStyleBackColor = true;
            this.ciftci_cikis_butonu.Click += new System.EventHandler(this.ciftci_cikis_butonu_Click);
            // 
            // data_ciftci
            // 
            this.data_ciftci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_ciftci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ciftci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ciftci.Location = new System.Drawing.Point(-1, 49);
            this.data_ciftci.Name = "data_ciftci";
            this.data_ciftci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_ciftci.Size = new System.Drawing.Size(888, 212);
            this.data_ciftci.TabIndex = 4;
            // 
            // ciftci_urun_sil
            // 
            this.ciftci_urun_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ciftci_urun_sil.Location = new System.Drawing.Point(807, 287);
            this.ciftci_urun_sil.Name = "ciftci_urun_sil";
            this.ciftci_urun_sil.Size = new System.Drawing.Size(75, 23);
            this.ciftci_urun_sil.TabIndex = 5;
            this.ciftci_urun_sil.Text = "Sil";
            this.ciftci_urun_sil.UseVisualStyleBackColor = true;
            this.ciftci_urun_sil.Click += new System.EventHandler(this.ciftci_urun_sil_Click);
            // 
            // ciftci_urun_guncelle
            // 
            this.ciftci_urun_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ciftci_urun_guncelle.Location = new System.Drawing.Point(726, 287);
            this.ciftci_urun_guncelle.Name = "ciftci_urun_guncelle";
            this.ciftci_urun_guncelle.Size = new System.Drawing.Size(75, 23);
            this.ciftci_urun_guncelle.TabIndex = 6;
            this.ciftci_urun_guncelle.Text = "Güncelle";
            this.ciftci_urun_guncelle.UseVisualStyleBackColor = true;
            this.ciftci_urun_guncelle.Click += new System.EventHandler(this.ciftci_urun_guncelle_Click);
            // 
            // tarla_groupbox
            // 
            this.tarla_groupbox.Controls.Add(this.motor1);
            this.tarla_groupbox.Controls.Add(this.ciftci_urun_ekle);
            this.tarla_groupbox.Controls.Add(this.data_kapat);
            this.tarla_groupbox.Controls.Add(this.data_ciftci);
            this.tarla_groupbox.Controls.Add(this.ciftci_urun_guncelle);
            this.tarla_groupbox.Controls.Add(this.ciftci_urun_sil);
            this.tarla_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tarla_groupbox.Location = new System.Drawing.Point(182, 32);
            this.tarla_groupbox.Name = "tarla_groupbox";
            this.tarla_groupbox.Size = new System.Drawing.Size(888, 320);
            this.tarla_groupbox.TabIndex = 7;
            this.tarla_groupbox.TabStop = false;
            this.tarla_groupbox.Text = "Tarla Ürünleri";
            this.tarla_groupbox.Visible = false;
            // 
            // motor1
            // 
            this.motor1.Cursor = System.Windows.Forms.Cursors.Default;
            this.motor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.motor1.Location = new System.Drawing.Point(6, 291);
            this.motor1.Name = "motor1";
            this.motor1.Size = new System.Drawing.Size(75, 23);
            this.motor1.TabIndex = 9;
            this.motor1.Text = "Makineler";
            this.motor1.UseVisualStyleBackColor = true;
            this.motor1.Click += new System.EventHandler(this.motor1_Click);
            // 
            // ciftci_urun_ekle
            // 
            this.ciftci_urun_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ciftci_urun_ekle.Location = new System.Drawing.Point(645, 287);
            this.ciftci_urun_ekle.Name = "ciftci_urun_ekle";
            this.ciftci_urun_ekle.Size = new System.Drawing.Size(75, 23);
            this.ciftci_urun_ekle.TabIndex = 8;
            this.ciftci_urun_ekle.Text = "Ekle";
            this.ciftci_urun_ekle.UseVisualStyleBackColor = true;
            this.ciftci_urun_ekle.Click += new System.EventHandler(this.ciftci_urun_ekle_Click);
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
            // ciftci_arkaplan
            // 
            this.ciftci_arkaplan.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ciftci_arkaplan.ImageSize = new System.Drawing.Size(16, 16);
            this.ciftci_arkaplan.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CiftciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 472);
            this.Controls.Add(this.tarla_groupbox);
            this.Controls.Add(this.ciftci_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CiftciEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CiftciEkrani_Load);
            this.ciftci_group.ResumeLayout(false);
            this.ciftci_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciftciprofil_resmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_ciftci)).EndInit();
            this.tarla_groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ciftciprofil_resmi;
        private System.Windows.Forms.Label ciftciad_label;
        private System.Windows.Forms.Button profil_buton;
        private System.Windows.Forms.GroupBox ciftci_group;
        private System.Windows.Forms.Button ciftci_cikis_butonu;
        private System.Windows.Forms.Button tarla_butonu;
        private System.Windows.Forms.Button ciftci_urun_sil;
        private System.Windows.Forms.Button ciftci_urun_guncelle;
        private System.Windows.Forms.GroupBox tarla_groupbox;
        private System.Windows.Forms.Button data_kapat;
        private System.Windows.Forms.ImageList ciftci_arkaplan;
        private System.Windows.Forms.Button ciftci_urun_ekle;
        public System.Windows.Forms.DataGridView data_ciftci;
        private System.Windows.Forms.Button motor1;
    }
}