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
    public partial class ProfilEkrani : Form
    {
        public delegate void UrunResimLoadEventHandler();
        public event UrunResimLoadEventHandler urunresimload;
        public ProfilEkrani()
        {
            InitializeComponent();
        }
        public ProfilEkrani(string idgönderme)
        {
            InitializeComponent();
            id_alma = idgönderme;
        }
        public string id_alma { get; set; }
        


        //Şifre Gizleme
        private void profilbox_eskisifre_TextChanged(object sender, EventArgs e)
        {
            profilbox_eskisifre.PasswordChar = '*';
        }
        private void profilbox_yenisifre_TextChanged(object sender, EventArgs e)
        {
            profilbox_yenisifre.PasswordChar = '*';
        }
        private void profilbox_yenisifretekrar_TextChanged(object sender, EventArgs e)
        {
            profilbox_yenisifretekrar.PasswordChar = '*';
        }
        // Şifre Gizleme

        private void ProfilEkrani_Load(object sender, EventArgs e)
        {
            // Bilgi Alma
            if (Program.baglan.State == ConnectionState.Closed)
            Program.baglan.Open();
            OleDbCommand bilgicom = new OleDbCommand("SELECT uyelik_id, uyelik_ad, uyelik_soyad, uyelik_eposta, uyelik_resim FROM uyelik_veritabani where uyelik_id= '"+id_alma+"'", Program.baglan);
            OleDbDataReader bilgidr = bilgicom.ExecuteReader();
            while (bilgidr.Read())
            {
                profilbox_id.Text = bilgidr["uyelik_id"].ToString();
                profilbox_ad.Text = bilgidr["uyelik_ad"].ToString();
                profilbox_soyad.Text = bilgidr["uyelik_soyad"].ToString();
                profilbox_eposta.Text = bilgidr["uyelik_eposta"].ToString();
                profil_resmi.ImageLocation = bilgidr["uyelik_resim"].ToString();
            }
            Program.baglan.Close();
            // Bilgi Alma
        }   //Veritabanından Üyelik Bilgisi Alma
        private void resimekleme_butonu_Click(object sender, EventArgs e)
        {
            profil_fd.Title = "Resim Ekle";
            profil_fd.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            profil_fd.ShowDialog();
            string resimkonum = profil_fd.FileName;
            profil_resmi.Text = resimkonum;
            profil_resmi.ImageLocation = resimkonum;
        }   //Resim ekleme
        private void guncelle_butonu_Click(object sender, EventArgs e)      // Veri Güncelleme
        {
            if (profilbox_id.Text == string.Empty || profilbox_ad.Text == string.Empty || profilbox_soyad.Text == string.Empty || profilbox_eposta.Text == string.Empty)  // Boş Textbox Kontrol
            {
                profildurum_label.Text = "Boş kısımları doldurunuz";
            }
            else
            {
                if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
                //Eski Şifre Kontrol
                OleDbCommand profilcmd = new OleDbCommand("SELECT * FROM uyelik_veritabani where uyelik_id= '" + id_alma + "'", Program.baglan);
                OleDbDataReader sfrdt = profilcmd.ExecuteReader();
                if (sfrdt.Read() == true) // Şifre Doğru
                {
                    if (sfrdt["uyelik_sifre"].ToString() == profilbox_eskisifre.Text.ToString())
                    {
                        if (profilbox_yenisifre.Text == string.Empty || profilbox_yenisifretekrar.Text == string.Empty) // Şifre Değişmeyecek İse
                        {
                            OleDbCommand guncelcmd = new OleDbCommand("UPDATE uyelik_veritabani SET [uyelik_ad]=@yeniad, [uyelik_soyad]=@yenisoyad, [uyelik_eposta]=@yenieposta where uyelik_id= '" + id_alma + "'", Program.baglan);

                            guncelcmd.Parameters.AddWithValue("@yeniad", profilbox_ad.Text);
                            guncelcmd.Parameters.AddWithValue("@yenisoyad", profilbox_soyad.Text);
                            guncelcmd.Parameters.AddWithValue("@yenieposta", profilbox_eposta.Text);
                            guncelcmd.ExecuteNonQuery();
                            MessageBox.Show("Bilgileriniz Güncellendi");
                            urunresimload();
                            this.Close();   //Profil Ekranını Kapatma
                        }
                        else   //Şifre Değişecek ise
                        {
                            if (profilbox_yenisifre.Text.ToString() != profilbox_yenisifretekrar.Text.ToString())    //Yeni Şifre Kontrol
                            {
                                profildurum_label.Text = "Yeni şifreler aynı değil";
                            }
                            else        // Veri Güncelleme
                            {
                                OleDbCommand tamguncelcmd = new OleDbCommand("UPDATE uyelik_veritabani SET [uyelik_ad]=@yeniad, [uyelik_soyad]=@yenisoyad, [uyelik_eposta]=@yenieposta, [uyelik_sifre]=@yenisifre where uyelik_id= '" + id_alma + "'", Program.baglan);

                                tamguncelcmd.Parameters.AddWithValue("@yeniad", profilbox_ad.Text);
                                tamguncelcmd.Parameters.AddWithValue("@yenisoyad", profilbox_soyad.Text);
                                tamguncelcmd.Parameters.AddWithValue("@yenieposta", profilbox_eposta.Text);
                                tamguncelcmd.Parameters.AddWithValue("@yenisifre", profilbox_yenisifre.Text);
                                tamguncelcmd.ExecuteNonQuery();;
                                MessageBox.Show("Bilgileriniz Güncellendi");
                                urunresimload();
                                this.Close();   //Profil Ekranını Kapatma
                            }
                        }
                    }
                    else
                    {
                        if (profilbox_eskisifre.Text == "") //Boş İse
                        {
                            profildurum_label.Text = "Onay için şifreyi giriniz";
                        }
                        else        //Yanlış İse
                        {
                            profildurum_label.Text = "Şifreyi yanlış girdiniz";
                        }
                    }
                }
                Program.baglan.Close();
            }
        }
        private void profiliptal_butonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }       // İptal Et
        private void sifrepanel_butonu_Click(object sender, EventArgs e)
        {
            yenisifre_paneli.Visible = true;
        }   // Yeni Şifre Paneli
        private void profil_fd_FileOk(object sender, CancelEventArgs e)
        {   
            if (Program.baglan.State == ConnectionState.Closed)
            Program.baglan.Open();
            OleDbCommand guncelcmd = new OleDbCommand("UPDATE uyelik_veritabani SET [uyelik_resim]=@yeniresim where uyelik_id= '" + id_alma + "'", Program.baglan);
            guncelcmd.Parameters.AddWithValue("@yeniresim", profil_fd.FileName);
            guncelcmd.ExecuteNonQuery();
            Program.baglan.Close();
        }    // Resim Güncelleme  

    }
}