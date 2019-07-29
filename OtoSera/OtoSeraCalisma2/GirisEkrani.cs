using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtoSeraCalisma2
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        private void sifre_kutusu_TextChanged(object sender, EventArgs e)
        {
            if (sifre_goster.Checked)
            {
                sifre_kutusu.PasswordChar = '\0';
            }
            else
            {
                sifre_kutusu.PasswordChar = '*';
            }
        }   // Şifreyi Gösterme Yada Gizleme
        private void giris_butonu_Click(object sender, EventArgs e)
        {
            //Giriş
            string id = id_kutusu.Text;
            string pass = sifre_kutusu.Text;

            OleDbCommand giriscmd = new OleDbCommand("SELECT * FROM uyelik_veritabani where uyelik_id = '"+id_kutusu.Text+ "' AND uyelik_sifre= '"+ sifre_kutusu.Text + "'", Program.baglan);
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbDataReader girisdr = giriscmd.ExecuteReader();
            if (girisdr.Read())
            {
                //Yetkili veya Personel Girişi
                if (girisdr["uyelik_tip"].ToString() == "Yetkili")
                {
                    YoneticiEkrani cagirma = new YoneticiEkrani(id_kutusu.Text);
                    cagirma.Show();
                    this.Hide();
                }
                else //(girisdr["uyelik_tip"].ToString() == "Ciftci")
                {
                    CiftciEkrani cagirma = new CiftciEkrani(id_kutusu.Text);
                    cagirma.Show();
                    this.Hide();
                }
                //Yetkili veya Personel Girişi
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış girildi.");
            }
            Program.baglan.Close();
        }   // Veritabanından Kullanıcı Bilgileri Çağırma ve Textboxlar Üzerinde Kaydetme
        private void kayit_butonu_Click(object sender, EventArgs e)
        {
            UyelikEkrani kayit_cagirma = new UyelikEkrani();
            kayit_cagirma.Show();
            this.Hide();
        }   // Kayıt Ekranı
        private void cikis_butonu_Click(object sender, EventArgs e)
        {
            DialogResult cikisbutonu = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cikisbutonu == DialogResult.Yes)
            {
                Application.Exit();
            }
        }   // Çıkış Diyalogu
    }
}
