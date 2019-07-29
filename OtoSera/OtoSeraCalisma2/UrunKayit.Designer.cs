namespace OtoSeraCalisma2
{
    partial class UrunKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urun_ekimtime = new System.Windows.Forms.DateTimePicker();
            this.urun_hasattime = new System.Windows.Forms.DateTimePicker();
            this.urunekle_butonu = new System.Windows.Forms.Button();
            this.urun_hasat_adeti = new WindowsFormsApplication4.OzelTextBox();
            this.urun_adeti = new WindowsFormsApplication4.OzelTextBox();
            this.urun_adi = new WindowsFormsApplication4.OzelTextBox();
            this.urunekle_iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(49, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ekim Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasat Tarihi:";
            // 
            // urun_ekimtime
            // 
            this.urun_ekimtime.Location = new System.Drawing.Point(145, 98);
            this.urun_ekimtime.Name = "urun_ekimtime";
            this.urun_ekimtime.Size = new System.Drawing.Size(200, 20);
            this.urun_ekimtime.TabIndex = 4;
            // 
            // urun_hasattime
            // 
            this.urun_hasattime.Location = new System.Drawing.Point(145, 128);
            this.urun_hasattime.Name = "urun_hasattime";
            this.urun_hasattime.Size = new System.Drawing.Size(200, 20);
            this.urun_hasattime.TabIndex = 5;
            // 
            // urunekle_butonu
            // 
            this.urunekle_butonu.Location = new System.Drawing.Point(189, 187);
            this.urunekle_butonu.Name = "urunekle_butonu";
            this.urunekle_butonu.Size = new System.Drawing.Size(75, 23);
            this.urunekle_butonu.TabIndex = 7;
            this.urunekle_butonu.Text = "Ekle";
            this.urunekle_butonu.UseVisualStyleBackColor = true;
            this.urunekle_butonu.Click += new System.EventHandler(this.urunekle_butonu_Click);
            // 
            // urun_hasat_adeti
            // 
            this.urun_hasat_adeti.Arkayazi = "Hasat Edilen Ürün Adeti";
            this.urun_hasat_adeti.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_hasat_adeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_hasat_adeti.ForeColor = System.Drawing.Color.Black;
            this.urun_hasat_adeti.Location = new System.Drawing.Point(53, 154);
            this.urun_hasat_adeti.Multiline = true;
            this.urun_hasat_adeti.Name = "urun_hasat_adeti";
            this.urun_hasat_adeti.Size = new System.Drawing.Size(292, 27);
            this.urun_hasat_adeti.TabIndex = 6;
            // 
            // urun_adeti
            // 
            this.urun_adeti.Arkayazi = "Ürün Adeti";
            this.urun_adeti.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adeti.ForeColor = System.Drawing.Color.Black;
            this.urun_adeti.Location = new System.Drawing.Point(53, 65);
            this.urun_adeti.Multiline = true;
            this.urun_adeti.Name = "urun_adeti";
            this.urun_adeti.Size = new System.Drawing.Size(292, 27);
            this.urun_adeti.TabIndex = 1;
            // 
            // urun_adi
            // 
            this.urun_adi.Arkayazi = "Ürün Adı";
            this.urun_adi.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.urun_adi.ForeColor = System.Drawing.Color.Black;
            this.urun_adi.Location = new System.Drawing.Point(53, 32);
            this.urun_adi.Multiline = true;
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(292, 27);
            this.urun_adi.TabIndex = 0;
            // 
            // urunekle_iptal
            // 
            this.urunekle_iptal.Location = new System.Drawing.Point(270, 187);
            this.urunekle_iptal.Name = "urunekle_iptal";
            this.urunekle_iptal.Size = new System.Drawing.Size(75, 23);
            this.urunekle_iptal.TabIndex = 8;
            this.urunekle_iptal.Text = "İptal Et";
            this.urunekle_iptal.UseVisualStyleBackColor = true;
            this.urunekle_iptal.Click += new System.EventHandler(this.urunekle_iptal_Click);
            // 
            // UrunKayit
            // 
            this.AcceptButton = this.urunekle_butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 239);
            this.Controls.Add(this.urunekle_iptal);
            this.Controls.Add(this.urunekle_butonu);
            this.Controls.Add(this.urun_hasat_adeti);
            this.Controls.Add(this.urun_hasattime);
            this.Controls.Add(this.urun_ekimtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urun_adeti);
            this.Controls.Add(this.urun_adi);
            this.Name = "UrunKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication4.OzelTextBox urun_adi;
        private WindowsFormsApplication4.OzelTextBox urun_adeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker urun_ekimtime;
        private System.Windows.Forms.DateTimePicker urun_hasattime;
        private WindowsFormsApplication4.OzelTextBox urun_hasat_adeti;
        private System.Windows.Forms.Button urunekle_butonu;
        private System.Windows.Forms.Button urunekle_iptal;
    }
}