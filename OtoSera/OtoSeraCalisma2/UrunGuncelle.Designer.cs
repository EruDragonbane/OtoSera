namespace OtoSeraCalisma2
{
    partial class UrunGuncelle
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
            this.urunguncelle_butonu = new System.Windows.Forms.Button();
            this.urun_hasat_adeti = new WindowsFormsApplication4.OzelTextBox();
            this.urun_hasattime = new System.Windows.Forms.DateTimePicker();
            this.urun_ekimtime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urun_adeti = new WindowsFormsApplication4.OzelTextBox();
            this.urun_adi = new WindowsFormsApplication4.OzelTextBox();
            this.urunguncel_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urunguncelle_butonu
            // 
            this.urunguncelle_butonu.Location = new System.Drawing.Point(197, 185);
            this.urunguncelle_butonu.Name = "urunguncelle_butonu";
            this.urunguncelle_butonu.Size = new System.Drawing.Size(75, 23);
            this.urunguncelle_butonu.TabIndex = 15;
            this.urunguncelle_butonu.Text = "Güncelle";
            this.urunguncelle_butonu.UseVisualStyleBackColor = true;
            this.urunguncelle_butonu.Click += new System.EventHandler(this.urunguncelle_butonu_Click);
            // 
            // urun_hasat_adeti
            // 
            this.urun_hasat_adeti.Arkayazi = "Hasat Edilen Ürün Adeti";
            this.urun_hasat_adeti.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_hasat_adeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_hasat_adeti.ForeColor = System.Drawing.Color.Black;
            this.urun_hasat_adeti.Location = new System.Drawing.Point(62, 153);
            this.urun_hasat_adeti.Multiline = true;
            this.urun_hasat_adeti.Name = "urun_hasat_adeti";
            this.urun_hasat_adeti.Size = new System.Drawing.Size(292, 27);
            this.urun_hasat_adeti.TabIndex = 14;
            // 
            // urun_hasattime
            // 
            this.urun_hasattime.Location = new System.Drawing.Point(154, 127);
            this.urun_hasattime.Name = "urun_hasattime";
            this.urun_hasattime.Size = new System.Drawing.Size(200, 20);
            this.urun_hasattime.TabIndex = 13;
            // 
            // urun_ekimtime
            // 
            this.urun_ekimtime.Location = new System.Drawing.Point(154, 97);
            this.urun_ekimtime.Name = "urun_ekimtime";
            this.urun_ekimtime.Size = new System.Drawing.Size(200, 20);
            this.urun_ekimtime.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasat Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(58, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ekim Tarihi:";
            // 
            // urun_adeti
            // 
            this.urun_adeti.Arkayazi = "Ürün Adeti";
            this.urun_adeti.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adeti.ForeColor = System.Drawing.Color.Black;
            this.urun_adeti.Location = new System.Drawing.Point(62, 64);
            this.urun_adeti.Multiline = true;
            this.urun_adeti.Name = "urun_adeti";
            this.urun_adeti.Size = new System.Drawing.Size(292, 27);
            this.urun_adeti.TabIndex = 9;
            // 
            // urun_adi
            // 
            this.urun_adi.Arkayazi = "Ürün Adı";
            this.urun_adi.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adi.ForeColor = System.Drawing.Color.Black;
            this.urun_adi.Location = new System.Drawing.Point(62, 31);
            this.urun_adi.Multiline = true;
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(292, 27);
            this.urun_adi.TabIndex = 8;
            // 
            // urunguncel_iptal
            // 
            this.urunguncel_iptal.Location = new System.Drawing.Point(278, 185);
            this.urunguncel_iptal.Name = "urunguncel_iptal";
            this.urunguncel_iptal.Size = new System.Drawing.Size(75, 23);
            this.urunguncel_iptal.TabIndex = 16;
            this.urunguncel_iptal.Text = "İptal Et";
            this.urunguncel_iptal.UseVisualStyleBackColor = true;
            this.urunguncel_iptal.Click += new System.EventHandler(this.urunguncel_iptal_Click);
            // 
            // UrunGuncelle
            // 
            this.AcceptButton = this.urunguncelle_butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 230);
            this.Controls.Add(this.urunguncel_iptal);
            this.Controls.Add(this.urunguncelle_butonu);
            this.Controls.Add(this.urun_hasat_adeti);
            this.Controls.Add(this.urun_hasattime);
            this.Controls.Add(this.urun_ekimtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urun_adeti);
            this.Controls.Add(this.urun_adi);
            this.Name = "UrunGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.UrunGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urunguncelle_butonu;
        private WindowsFormsApplication4.OzelTextBox urun_hasat_adeti;
        private System.Windows.Forms.DateTimePicker urun_hasattime;
        private System.Windows.Forms.DateTimePicker urun_ekimtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication4.OzelTextBox urun_adeti;
        private WindowsFormsApplication4.OzelTextBox urun_adi;
        private System.Windows.Forms.Button urunguncel_iptal;
    }
}