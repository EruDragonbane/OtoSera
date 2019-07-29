namespace OtoSeraCalisma2
{
    partial class UyelikEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyelikEkrani));
            this.uyelikonay_butonu = new System.Windows.Forms.Button();
            this.uyelikiptal_butonu = new System.Windows.Forms.Button();
            this.ilce_listesi = new System.Windows.Forms.ComboBox();
            this.semt_listesi = new System.Windows.Forms.ComboBox();
            this.mahalle_listesi = new System.Windows.Forms.ComboBox();
            this.il_listesi = new System.Windows.Forms.ComboBox();
            this.textbox_label = new System.Windows.Forms.Label();
            this.postakodu_kutusu = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_sifretekrar = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_sifre = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_eposta = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_id = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_soyad = new WindowsFormsApplication4.OzelTextBox();
            this.uyelik_ad = new WindowsFormsApplication4.OzelTextBox();
            this.SuspendLayout();
            // 
            // uyelikonay_butonu
            // 
            resources.ApplyResources(this.uyelikonay_butonu, "uyelikonay_butonu");
            this.uyelikonay_butonu.Name = "uyelikonay_butonu";
            this.uyelikonay_butonu.UseVisualStyleBackColor = true;
            this.uyelikonay_butonu.Click += new System.EventHandler(this.uyelikonay_butonu_Click);
            // 
            // uyelikiptal_butonu
            // 
            resources.ApplyResources(this.uyelikiptal_butonu, "uyelikiptal_butonu");
            this.uyelikiptal_butonu.Name = "uyelikiptal_butonu";
            this.uyelikiptal_butonu.UseVisualStyleBackColor = true;
            this.uyelikiptal_butonu.Click += new System.EventHandler(this.uyelikiptal_butonu_Click);
            // 
            // ilce_listesi
            // 
            resources.ApplyResources(this.ilce_listesi, "ilce_listesi");
            this.ilce_listesi.ForeColor = System.Drawing.Color.Black;
            this.ilce_listesi.FormattingEnabled = true;
            this.ilce_listesi.Name = "ilce_listesi";
            this.ilce_listesi.SelectedIndexChanged += new System.EventHandler(this.ilce_listesi_SelectedIndexChanged);
            // 
            // semt_listesi
            // 
            resources.ApplyResources(this.semt_listesi, "semt_listesi");
            this.semt_listesi.ForeColor = System.Drawing.Color.Black;
            this.semt_listesi.FormattingEnabled = true;
            this.semt_listesi.Name = "semt_listesi";
            this.semt_listesi.SelectedIndexChanged += new System.EventHandler(this.semt_listesi_SelectedIndexChanged);
            // 
            // mahalle_listesi
            // 
            resources.ApplyResources(this.mahalle_listesi, "mahalle_listesi");
            this.mahalle_listesi.ForeColor = System.Drawing.Color.Black;
            this.mahalle_listesi.FormattingEnabled = true;
            this.mahalle_listesi.Name = "mahalle_listesi";
            // 
            // il_listesi
            // 
            resources.ApplyResources(this.il_listesi, "il_listesi");
            this.il_listesi.ForeColor = System.Drawing.Color.Black;
            this.il_listesi.FormattingEnabled = true;
            this.il_listesi.Name = "il_listesi";
            this.il_listesi.SelectedIndexChanged += new System.EventHandler(this.il_listesi_SelectedIndexChanged);
            // 
            // textbox_label
            // 
            resources.ApplyResources(this.textbox_label, "textbox_label");
            this.textbox_label.ForeColor = System.Drawing.Color.Red;
            this.textbox_label.Name = "textbox_label";
            // 
            // postakodu_kutusu
            // 
            this.postakodu_kutusu.Arkayazi = "POSTAKODU";
            this.postakodu_kutusu.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.postakodu_kutusu, "postakodu_kutusu");
            this.postakodu_kutusu.ForeColor = System.Drawing.Color.Black;
            this.postakodu_kutusu.Name = "postakodu_kutusu";
            // 
            // uyelik_sifretekrar
            // 
            this.uyelik_sifretekrar.Arkayazi = "Şifre Tekrar";
            this.uyelik_sifretekrar.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_sifretekrar, "uyelik_sifretekrar");
            this.uyelik_sifretekrar.ForeColor = System.Drawing.Color.Black;
            this.uyelik_sifretekrar.Name = "uyelik_sifretekrar";
            this.uyelik_sifretekrar.TextChanged += new System.EventHandler(this.uyelik_sifretekrar_TextChanged);
            // 
            // uyelik_sifre
            // 
            this.uyelik_sifre.Arkayazi = "Şifre";
            this.uyelik_sifre.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_sifre, "uyelik_sifre");
            this.uyelik_sifre.ForeColor = System.Drawing.Color.Black;
            this.uyelik_sifre.Name = "uyelik_sifre";
            this.uyelik_sifre.TextChanged += new System.EventHandler(this.uyelik_sifre_TextChanged);
            // 
            // uyelik_eposta
            // 
            this.uyelik_eposta.Arkayazi = "E-Posta";
            this.uyelik_eposta.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_eposta, "uyelik_eposta");
            this.uyelik_eposta.ForeColor = System.Drawing.Color.Black;
            this.uyelik_eposta.Name = "uyelik_eposta";
            // 
            // uyelik_id
            // 
            this.uyelik_id.Arkayazi = "Kullanıcı Adı";
            this.uyelik_id.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_id, "uyelik_id");
            this.uyelik_id.ForeColor = System.Drawing.Color.Black;
            this.uyelik_id.Name = "uyelik_id";
            // 
            // uyelik_soyad
            // 
            this.uyelik_soyad.Arkayazi = "Soyad";
            this.uyelik_soyad.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_soyad, "uyelik_soyad");
            this.uyelik_soyad.ForeColor = System.Drawing.Color.Black;
            this.uyelik_soyad.Name = "uyelik_soyad";
            // 
            // uyelik_ad
            // 
            this.uyelik_ad.Arkayazi = "Ad";
            this.uyelik_ad.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.uyelik_ad, "uyelik_ad");
            this.uyelik_ad.ForeColor = System.Drawing.Color.Black;
            this.uyelik_ad.Name = "uyelik_ad";
            // 
            // UyelikEkrani
            // 
            this.AcceptButton = this.uyelikonay_butonu;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textbox_label);
            this.Controls.Add(this.postakodu_kutusu);
            this.Controls.Add(this.mahalle_listesi);
            this.Controls.Add(this.semt_listesi);
            this.Controls.Add(this.ilce_listesi);
            this.Controls.Add(this.il_listesi);
            this.Controls.Add(this.uyelikiptal_butonu);
            this.Controls.Add(this.uyelikonay_butonu);
            this.Controls.Add(this.uyelik_sifretekrar);
            this.Controls.Add(this.uyelik_sifre);
            this.Controls.Add(this.uyelik_eposta);
            this.Controls.Add(this.uyelik_id);
            this.Controls.Add(this.uyelik_soyad);
            this.Controls.Add(this.uyelik_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyelikEkrani";
            this.Load += new System.EventHandler(this.UyelikEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication4.OzelTextBox uyelik_sifretekrar;
        private WindowsFormsApplication4.OzelTextBox uyelik_sifre;
        private WindowsFormsApplication4.OzelTextBox uyelik_eposta;
        private WindowsFormsApplication4.OzelTextBox uyelik_id;
        private WindowsFormsApplication4.OzelTextBox uyelik_soyad;
        private WindowsFormsApplication4.OzelTextBox uyelik_ad;
        private System.Windows.Forms.Button uyelikonay_butonu;
        private System.Windows.Forms.Button uyelikiptal_butonu;
        private WindowsFormsApplication4.OzelTextBox postakodu_kutusu;
        public System.Windows.Forms.ComboBox ilce_listesi;
        public System.Windows.Forms.ComboBox semt_listesi;
        public System.Windows.Forms.ComboBox mahalle_listesi;
        public System.Windows.Forms.ComboBox il_listesi;
        private System.Windows.Forms.Label textbox_label;
    }
}