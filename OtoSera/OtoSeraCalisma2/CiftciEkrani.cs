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
    public partial class CiftciEkrani : Form
    {
        public UrunGuncelle urunguncelle;

        public CiftciEkrani()
        {
            InitializeComponent();
            //urunguncelle = new UrunGuncelle();
            //urunguncelle.ciftciform = this;
        }

        public CiftciEkrani(string id)
        {
            InitializeComponent();
            idgönderme = id;
        }
        public string idgönderme { get; set; }

        // Close Butonu Pasifleştirme
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        // Close Butonu Pasifleştirme

        private void profil_buton_Click(object sender, EventArgs e)
        {
            ProfilEkrani cagirma = new ProfilEkrani(idgönderme);
            cagirma.urunresimload += Cagirma_ProfilListeleme;
            cagirma.Show();
            this.Show();
        }  //Profil Ekranı Çağırma
        private void CiftciEkrani_Load(object sender, EventArgs e)
        {
            if (tarla_groupbox.Visible == false)
            {
                BackgroundImage = Image.FromFile("yaprakpnglogosu.png");
                BackgroundImageLayout = ImageLayout.Center;
            }
            // Veritabanından Bilgi ve Resim Çağırma
            // Labele Ad ve Soyad Yazdırma
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbCommand bilgicom = new OleDbCommand("SELECT uyelik_ad, uyelik_soyad, uyelik_resim FROM uyelik_veritabani where uyelik_id= '" + idgönderme + "'", Program.baglan);
            OleDbDataReader bilgidr = bilgicom.ExecuteReader();
            if (bilgidr.Read())
            {
                ciftciad_label.Text = bilgidr["uyelik_ad"].ToString();
                ciftciad_label.Text += " ";
                ciftciad_label.Text += bilgidr["uyelik_soyad"].ToString();
                ciftciprofil_resmi.ImageLocation = bilgidr["uyelik_resim"].ToString();
            }
            // Labele Ad ve Soyad Yazdırma
        }   // Profil Bilgi Gösterim
        private void ciftci_cikis_butonu_Click(object sender, EventArgs e)
        {
            DialogResult ciftci_cikis_butonu = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ciftci_cikis_butonu == DialogResult.Yes)
            {
                Application.Exit();
            }
        }       // Çıkış Butonu
        private void tarla_butonu_Click(object sender, EventArgs e)
        {
            tarla_groupbox.Visible = true;  //Tarla GroupBox'unu Görünür Yap
            BackgroundImage = null;     // Arkaplanı Kapat
            // Veritabanı Çağırma
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbDataAdapter urundt = new OleDbDataAdapter("SELECT urun_adi, urun_adet, urun_ekim, urun_hasat, hasat_adet FROM urunler where uyelik_id= '"+idgönderme+"'", Program.baglan);
            DataSet urundts = new DataSet();
            urundt.Fill(urundts, "urunler");
            data_ciftci.DataSource = urundts.Tables["urunler"];
            urundt.Dispose();

            // Data Sutün İsimlendirme
            data_ciftci.Columns[0].HeaderText = "Ürün";
            data_ciftci.Columns[1].HeaderText = "Adet";
            data_ciftci.Columns[2].HeaderText = "Ekim Tarihi";
            data_ciftci.Columns[3].HeaderText = "Hasat Tarihi";
            data_ciftci.Columns[4].HeaderText = "Hasat Edilen Ürün Adeti";
            // Data Sutün İsimlendirme 
        }   // Tarla Veritabanını Çağırma 
        private void data_kapat_Click(object sender, EventArgs e)
        {
            tarla_groupbox.Visible = false;
            if (tarla_groupbox.Visible == false)
            {
                BackgroundImage = Image.FromFile("yaprakpnglogosu.png");
                BackgroundImageLayout = ImageLayout.Center;
            }
        }   // Tarla Boxunu Kapatma ve Arkaplan   
 
       // Ürün Ekleme-Güncelleme-Silme
        private void ciftci_urun_ekle_Click(object sender, EventArgs e)
        {
            UrunKayit cagirma = new UrunKayit(idgönderme);
            cagirma.UrunEkle += Cagirma_FormListeleme;
            cagirma.Show();
            this.Show();
        }
        private void ciftci_urun_guncelle_Click(object sender, EventArgs e)
        {
            string[] veriler = new string[3];
            DateTime[] zamanlar = new DateTime[2];
            veriler[0] = data_ciftci.CurrentRow.Cells[0].Value.ToString();
            veriler[1] = data_ciftci.CurrentRow.Cells[1].Value.ToString();
            zamanlar[0] = DateTime.Parse(data_ciftci.CurrentRow.Cells[2].Value.ToString());
            zamanlar[1] = DateTime.Parse(data_ciftci.CurrentRow.Cells[3].Value.ToString());
            veriler[2] = data_ciftci.CurrentRow.Cells[4].Value.ToString();

            UrunGuncelle cagirma = new UrunGuncelle(idgönderme, veriler, zamanlar);
            cagirma.UrunGun += Cagirma_FormListeleme;
            cagirma.ShowDialog();
            this.Show();
        }
        private void ciftci_urun_sil_Click(object sender, EventArgs e)
        {
            if (data_ciftci.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Lütfen bir veri seçiniz");
            }
            else
            {
                if (Program.baglan.State == ConnectionState.Closed)
                    Program.baglan.Open();
                OleDbCommand profilcmd = new OleDbCommand("SELECT * FROM urunler where uyelik_id= '" + idgönderme + "'", Program.baglan);
                OleDbDataReader profildt = profilcmd.ExecuteReader();
                if (profildt.Read() == true)
                {
                    DialogResult silmeonay = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (silmeonay == DialogResult.Yes)
                    {
                        OleDbCommand silmecmd = new OleDbCommand("DELETE FROM urunler where uyelik_id= '" + idgönderme + "' AND urun_adi= '" + data_ciftci.CurrentRow.Cells[0].Value.ToString() + "'", Program.baglan);

                        silmecmd.ExecuteNonQuery();
                        Cagirma_FormListeleme();
                    }
                }
            }
            Program.baglan.Close();
        }
        // Ürün Ekleme-Güncelleme-Silme

        private void Cagirma_FormListeleme()
        {
            tarla_butonu_Click(tarla_butonu, new EventArgs());
        }// Yeniden Listeleme (Tarla) 
        private void Cagirma_ProfilListeleme()
        {
            CiftciEkrani_Load(profil_buton, new EventArgs());
        }   // Yeniden Listeleme (Profil)

        private void motor1_Click(object sender, EventArgs e)
        {
            makineler_form cagirma = new makineler_form();
            cagirma.Show();
            this.Show();

        } // Motorlar Ekranı
    }
}
