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
    public partial class UyelikEkrani : Form
    {

        public UyelikEkrani()
        {
            InitializeComponent();
        }
        private void uyelikiptal_butonu_Click(object sender, EventArgs e)
        {
            GirisEkrani geridon = new GirisEkrani();
            this.Close();
            geridon.Show();
        }       //Kayıt İptal ve Geri Dönüş
       
        // Şifre Gizleme
        private void uyelik_sifretekrar_TextChanged(object sender, EventArgs e)
        {
            uyelik_sifretekrar.PasswordChar = '*';
        }
        private void uyelik_sifre_TextChanged(object sender, EventArgs e)
        {
            uyelik_sifre.PasswordChar = '*';
        }
        //Şifre Gizleme
        
        private void UyelikEkrani_Load(object sender, EventArgs e)
        {
            adreslistele("iller", "", il_listesi,null);
        }                 // İl Listesi
        private void il_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            adreslistele("ilceler","il_no", ilce_listesi,il_listesi);
        }   // İlçe Listesi 
        private void ilce_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            adreslistele("semtler", "ilce_no", semt_listesi, ilce_listesi);
        } // Semt Listesi
        private void semt_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            adreslistele("mahalleler", "semt_no", mahalle_listesi, semt_listesi);
        } // Mahalle Listesi 
        private void uyelikonay_butonu_Click(object sender, EventArgs e)
        {   
            if (uyelik_ad.Text == string.Empty || uyelik_soyad.Text == string.Empty || uyelik_id.Text == string.Empty || uyelik_eposta.Text == string.Empty || uyelik_sifre.Text == string.Empty || uyelik_sifretekrar.Text == string.Empty)                //Boş TextBox Kontrolü
            {
                textbox_label.Text = "Boş kısımları doldurunuz";
            }
            else if (uyelik_sifre.Text.ToString() != uyelik_sifretekrar.Text.ToString())                //Şifre Benzerlik Kontrolü
            {
                textbox_label.Text = "Şifreler aynı değil";
            }
            else //Veritabanı Postakodu Kontrol ve Ekleme
            {
                Program.baglan.Open();
                OleDbCommand pkcmd = new OleDbCommand("SELECT postakodu FROM semtler where postakodu = '" + postakodu_kutusu.Text + "'", Program.baglan);
                OleDbDataReader pkdt = pkcmd.ExecuteReader();
                if (pkdt.Read() == false) // PK Yanlış İse
                {
                    if (postakodu_kutusu.Text == "")                //Posta Kutusu Kontrolü
                    {
                        //MessageBox.Show("POSTAKODU kısmı boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textbox_label.Text = "Postakodu kısmı boş bırakılamaz";
                    }
                    else
                    {
                        //MessageBox.Show("Postakodunu yanlış girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textbox_label.Text = "Postakodunu yanlış girdiniz";
                    }
                }
                else // PK Doğru İse
                {
                    string uyelik_tip = "Çiftci";
                    string uyelik_resim = "yaprakpnglogosu.png";
                    MessageBox.Show("Kayıt Başarılı");
                    //Veritabanı Kayıt Ekleme
                    kayitekleme(uyelik_ad.Text, uyelik_soyad.Text, uyelik_id.Text, uyelik_eposta.Text, uyelik_sifre.Text, il_listesi.Text, ilce_listesi.Text, semt_listesi.Text, mahalle_listesi.Text, postakodu_kutusu.Text, uyelik_tip, uyelik_resim);
                    //Veritabanı Kayıt Ekleme

                    GirisEkrani cagirma = new GirisEkrani();
                    cagirma.Show();
                    this.Close();
                }
                Program.baglan.Close();
            }
        }//Veri Kontrol ve Kayıt Ekleme Metodu
        void adreslistele(string tblAd, string bagimliVeri, ComboBox yeniListe, ComboBox eskiListe)
        {        //AdresVeri Tabloları  //Bağlı Olduğu Anahtar  //Açılacak Tablo  //Açacak Tablo
            OleDbDataAdapter da1=null;
            if (eskiListe != null)
            {
                da1 = new OleDbDataAdapter("SELECT * FROM " + tblAd + " where " + bagimliVeri + "=" +int.Parse( eskiListe.SelectedValue.ToString()) + "", Program.baglan);
            }
            else
            {
                da1 = new OleDbDataAdapter("SELECT * FROM " + tblAd , Program.baglan);
            }
            DataTable dt = new DataTable();
            da1.Fill(dt);
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            yeniListe.ValueMember = "numara";
            yeniListe.DisplayMember = "adi";
            yeniListe.DataSource = dt;
            Program.baglan.Close();


        }   //Veritabanı Listeleme Metodu
        public bool kayitekleme(string ad, string soyad, string id, string eposta, string sifre, string il, string ilce, string semt, string mahalle, string postakodu, string tip, string resim)
        {   
            OleDbCommand kayitcmd = new OleDbCommand("insert into uyelik_veritabani (uyelik_ad, uyelik_soyad, uyelik_id, uyelik_eposta, uyelik_sifre, uyelik_il, uyelik_ilce, uyelik_semt, uyelik_mahalle, uyelik_postakodu, uyelik_tip, uyelik_resim) values (@ad, @soyad, @id, @eposta, @sifre, @il, @ilce, @semt, @mahalle, @postakodu, @tip, @resim)", Program.baglan);
            OleDbCommand kontrolcmd = new OleDbCommand("SELECT * FROM uyelik_veritabani where uyelik_id = '" + id + "'", Program.baglan);
            if (Program.baglan.State == ConnectionState.Closed)
            Program.baglan.Open();
            OleDbDataReader okuyucu = kontrolcmd.ExecuteReader();
            if (okuyucu.Read() == true)
            {
                return false;
            }
            else
            {
                kayitcmd.Parameters.AddWithValue("@uyelik_ad", ad);
                kayitcmd.Parameters.AddWithValue("@uyelik_soyad", soyad);
                kayitcmd.Parameters.AddWithValue("@uyelik_id", id);
                kayitcmd.Parameters.AddWithValue("@uyelik_eposta", eposta);
                kayitcmd.Parameters.AddWithValue("@uyelik_sifre", sifre);
                kayitcmd.Parameters.AddWithValue("@uyelik_il", il);
                kayitcmd.Parameters.AddWithValue("@uyelik_ilce", ilce);
                kayitcmd.Parameters.AddWithValue("@uyelik_semt", semt);
                kayitcmd.Parameters.AddWithValue("@uyelik_mahalle", mahalle);
                kayitcmd.Parameters.AddWithValue("@uyelik_postakodu", postakodu);
                kayitcmd.Parameters.AddWithValue("@uyelik_tip", tip);
                kayitcmd.Parameters.AddWithValue("@uyelik_resim", resim);
                kayitcmd.ExecuteNonQuery();
                return true;
            }


        }//Veritabanı Kayıt Ekleme Metodu
    }
}
