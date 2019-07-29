namespace OtoSeraCalisma2
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.giris_butonu = new System.Windows.Forms.Button();
            this.kayit_butonu = new System.Windows.Forms.Button();
            this.sifre_goster = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifre_kutusu = new WindowsFormsApplication4.OzelTextBox();
            this.id_kutusu = new WindowsFormsApplication4.OzelTextBox();
            this.cikis_butonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giris_butonu
            // 
            resources.ApplyResources(this.giris_butonu, "giris_butonu");
            this.giris_butonu.Name = "giris_butonu";
            this.giris_butonu.UseVisualStyleBackColor = true;
            this.giris_butonu.Click += new System.EventHandler(this.giris_butonu_Click);
            // 
            // kayit_butonu
            // 
            resources.ApplyResources(this.kayit_butonu, "kayit_butonu");
            this.kayit_butonu.Name = "kayit_butonu";
            this.kayit_butonu.UseVisualStyleBackColor = true;
            this.kayit_butonu.Click += new System.EventHandler(this.kayit_butonu_Click);
            // 
            // sifre_goster
            // 
            resources.ApplyResources(this.sifre_goster, "sifre_goster");
            this.sifre_goster.Name = "sifre_goster";
            this.sifre_goster.UseVisualStyleBackColor = true;
            this.sifre_goster.CheckedChanged += new System.EventHandler(this.sifre_kutusu_TextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // sifre_kutusu
            // 
            this.sifre_kutusu.Arkayazi = "ŞİFRE";
            this.sifre_kutusu.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            resources.ApplyResources(this.sifre_kutusu, "sifre_kutusu");
            this.sifre_kutusu.ForeColor = System.Drawing.Color.Black;
            this.sifre_kutusu.Name = "sifre_kutusu";
            this.sifre_kutusu.TextChanged += new System.EventHandler(this.sifre_kutusu_TextChanged);
            // 
            // id_kutusu
            // 
            this.id_kutusu.Arkayazi = "KULLANICI ADI";
            this.id_kutusu.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_kutusu.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.id_kutusu, "id_kutusu");
            this.id_kutusu.ForeColor = System.Drawing.Color.Black;
            this.id_kutusu.Name = "id_kutusu";
            // 
            // cikis_butonu
            // 
            resources.ApplyResources(this.cikis_butonu, "cikis_butonu");
            this.cikis_butonu.Name = "cikis_butonu";
            this.cikis_butonu.UseVisualStyleBackColor = true;
            this.cikis_butonu.Click += new System.EventHandler(this.cikis_butonu_Click);
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.giris_butonu;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cikis_butonu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sifre_goster);
            this.Controls.Add(this.kayit_butonu);
            this.Controls.Add(this.giris_butonu);
            this.Controls.Add(this.sifre_kutusu);
            this.Controls.Add(this.id_kutusu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication4.OzelTextBox id_kutusu;
        private WindowsFormsApplication4.OzelTextBox sifre_kutusu;
        private System.Windows.Forms.Button giris_butonu;
        private System.Windows.Forms.Button kayit_butonu;
        private System.Windows.Forms.CheckBox sifre_goster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cikis_butonu;
    }
}

