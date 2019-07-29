namespace OtoSeraCalisma2
{
    partial class UyeGuncelle
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
            this.uyeadi_yonetici = new WindowsFormsApplication4.OzelTextBox();
            this.uyesoyadi_yonetici = new WindowsFormsApplication4.OzelTextBox();
            this.ozelTextBox3 = new WindowsFormsApplication4.OzelTextBox();
            this.ozelTextBox4 = new WindowsFormsApplication4.OzelTextBox();
            this.SuspendLayout();
            // 
            // uyeadi_yonetici
            // 
            this.uyeadi_yonetici.Arkayazi = "Üye Adı";
            this.uyeadi_yonetici.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uyeadi_yonetici.ForeColor = System.Drawing.Color.Gray;
            this.uyeadi_yonetici.Location = new System.Drawing.Point(51, 47);
            this.uyeadi_yonetici.Multiline = true;
            this.uyeadi_yonetici.Name = "uyeadi_yonetici";
            this.uyeadi_yonetici.Size = new System.Drawing.Size(322, 27);
            this.uyeadi_yonetici.TabIndex = 0;
            // 
            // uyesoyadi_yonetici
            // 
            this.uyesoyadi_yonetici.Arkayazi = "Üye Adı";
            this.uyesoyadi_yonetici.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uyesoyadi_yonetici.ForeColor = System.Drawing.Color.Gray;
            this.uyesoyadi_yonetici.Location = new System.Drawing.Point(51, 80);
            this.uyesoyadi_yonetici.Multiline = true;
            this.uyesoyadi_yonetici.Name = "uyesoyadi_yonetici";
            this.uyesoyadi_yonetici.Size = new System.Drawing.Size(322, 27);
            this.uyesoyadi_yonetici.TabIndex = 1;
            // 
            // ozelTextBox3
            // 
            this.ozelTextBox3.Arkayazi = "Üye Adı";
            this.ozelTextBox3.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ozelTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.ozelTextBox3.Location = new System.Drawing.Point(51, 113);
            this.ozelTextBox3.Multiline = true;
            this.ozelTextBox3.Name = "ozelTextBox3";
            this.ozelTextBox3.Size = new System.Drawing.Size(322, 27);
            this.ozelTextBox3.TabIndex = 2;
            // 
            // ozelTextBox4
            // 
            this.ozelTextBox4.Arkayazi = "Üye Adı";
            this.ozelTextBox4.ArkayaziFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ozelTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.ozelTextBox4.Location = new System.Drawing.Point(51, 146);
            this.ozelTextBox4.Multiline = true;
            this.ozelTextBox4.Name = "ozelTextBox4";
            this.ozelTextBox4.Size = new System.Drawing.Size(322, 27);
            this.ozelTextBox4.TabIndex = 3;
            // 
            // UyeGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 441);
            this.Controls.Add(this.ozelTextBox4);
            this.Controls.Add(this.ozelTextBox3);
            this.Controls.Add(this.uyesoyadi_yonetici);
            this.Controls.Add(this.uyeadi_yonetici);
            this.Name = "UyeGuncelle";
            this.Text = "UyeGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication4.OzelTextBox uyeadi_yonetici;
        private WindowsFormsApplication4.OzelTextBox uyesoyadi_yonetici;
        private WindowsFormsApplication4.OzelTextBox ozelTextBox3;
        private WindowsFormsApplication4.OzelTextBox ozelTextBox4;
    }
}