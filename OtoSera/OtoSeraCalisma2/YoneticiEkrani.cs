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
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }
        public YoneticiEkrani(string id2)
        {
            InitializeComponent();
            idgonderme2 = id2;
        }
        public string idgonderme2 { get; set; }

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

        private void yonetici_profil_buton_Click(object sender, EventArgs e)
        {
            ProfilEkrani cagirma = new ProfilEkrani(idgonderme2);
            cagirma.urunresimload += Cagirma_ProfilListeleme2;
            cagirma.Show();
            this.Show();
        }   // Profil Ekranı Çağırma
        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {
            uyetip_combobox.Items.Add("Yetkili");
            uyetip_combobox.Items.Add("Çiftci");

            if (uye_groupbox.Visible == false)
            {
                BackgroundImage = Image.FromFile("yaprakpnglogosu.png");
                BackgroundImageLayout = ImageLayout.Center;
            }
            //Veritabanından Bilgi ve Resim Çağırma
            //Labele Ad ve Soyad Yazdırma

            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbCommand bilgicom = new OleDbCommand("SELECT uyelik_ad, uyelik_soyad, uyelik_resim FROM uyelik_veritabani where uyelik_id= '" + idgonderme2 + "'", Program.baglan);
            OleDbDataReader bilgidr = bilgicom.ExecuteReader();
            if (bilgidr.Read())
            {
                yoneticiad_label.Text = bilgidr["uyelik_ad"].ToString();
                yoneticiad_label.Text += " ";
                yoneticiad_label.Text += bilgidr["uyelik_soyad"].ToString();
                yoneticiprofil_resmi.ImageLocation = bilgidr["uyelik_resim"].ToString();
            }
            //Labele Ad ve Soyad Yazdırma
        }       //Profil Bilgi Gösterimi  
        private void yonetici_cikis_butonu_Click(object sender, EventArgs e)
        {
            DialogResult yonetici_cikis_butonu = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yonetici_cikis_butonu == DialogResult.Yes)
            {
                Application.Exit();
            }
        }   // Çıkış Butonu
        private void uyeler_butonu_Click(object sender, EventArgs e)
        {
            uye_groupbox.Visible = true; // Üye GroupBox'unu Görünür Yap
            BackgroundImage = null; // Arkaplanı Kapat
            //Veritabanı Çağırma
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbDataAdapter uyedt = new OleDbDataAdapter("SELECT uyelik_ad, uyelik_soyad, uyelik_id, uyelik_eposta, uyelik_il, uyelik_ilce, uyelik_semt, uyelik_mahalle, uyelik_tip FROM uyelik_veritabani", Program.baglan);
            DataSet uyedts = new DataSet();
            uyedt.Fill(uyedts, "uyelik_veritabani");
            data_uyeler.DataSource = uyedts.Tables["uyelik_veritabani"];
            uyedt.Dispose();

            // Data Sütun İsimlendirme
            data_uyeler.Columns[0].HeaderText = "Ad";
            data_uyeler.Columns[1].HeaderText = "Soyad";
            data_uyeler.Columns[2].HeaderText = "Kullanıcı Adı";
            data_uyeler.Columns[3].HeaderText = "E-Posta";
            data_uyeler.Columns[4].HeaderText = "İl";
            data_uyeler.Columns[5].HeaderText = "İlçe";
            data_uyeler.Columns[6].HeaderText = "Semt";
            data_uyeler.Columns[7].HeaderText = "Mahalle";
            data_uyeler.Columns[8].HeaderText = "Üyelik Tipi";
            // Data Sütun İsimlendirme
        }   // Üyeler Veritabanını Çağırma
        private void data_kapat_Click(object sender, EventArgs e)
        {
            uye_groupbox.Visible = false;
            if (uye_groupbox.Visible == false)
            {
                BackgroundImage = Image.FromFile("yaprakpnglogosu.png");
                BackgroundImageLayout = ImageLayout.Center;
            }
            uyeliktip_group.Visible = false;
        }   // GroupBox Kapatma ve Arkaplan

        // Üye Güncelleme-Silme
        private void uye_guncelle_Click(object sender, EventArgs e)
        {   
            if (uye_groupbox.Visible == true)
            {
                uyeliktip_group.Visible = true;
            }

            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();

            // Üye Bilgileri
            OleDbCommand uyebilgicom = new OleDbCommand("SELECT uyelik_ad, uyelik_soyad, uyelik_id FROM uyelik_veritabani where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
            OleDbDataReader uyebilgidr = uyebilgicom.ExecuteReader();
            if (uyebilgidr.Read())
            {
                uyeguncelle_label.Text = uyebilgidr["uyelik_ad"].ToString();
                uyeguncelle_label.Text += " ";
                uyeguncelle_label.Text += uyebilgidr["uyelik_soyad"].ToString();
                uyeguncelle_label.Text += " / ";
                uyeguncelle_label.Text += uyebilgidr["uyelik_id"].ToString();
            }
            //Üye Bilgileri
        }
        private void uyetip_guncel_iptal_Click(object sender, EventArgs e)
        {
            uyeliktip_group.Visible = false;
        } 
        private void uye_sil_Click(object sender, EventArgs e)
        {
            if (Program.baglan.State == ConnectionState.Closed)
                Program.baglan.Open();
            OleDbCommand yetkilicom = new OleDbCommand("SELECT * FROM uyelik_veritabani where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
            OleDbDataReader yetkilidt = yetkilicom.ExecuteReader();
            yetkilidt.Read();
            if (yetkilidt["uyelik_tip"].ToString() == "Yetkili")
            {
                OleDbCommand yetkilisilmecmd = new OleDbCommand("SELECT COUNT (*) FROM uyelik_veritabani where uyelik_tip= 'Yetkili'", Program.baglan);
                int sayac = (int)yetkilisilmecmd.ExecuteScalar();
                if (sayac == 1)
                {
                    MessageBox.Show("Tek yöneticiyi silemezsiniz.");
                }
                else
                {
                    DialogResult silmeonay = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (silmeonay == DialogResult.Yes)
                    {
                        OleDbCommand silmetarlacmd = new OleDbCommand("DELETE FROM urunler where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
                        OleDbCommand silmeuyecmd = new OleDbCommand("DELETE FROM uyelik_veritabani where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
                        silmetarlacmd.ExecuteNonQuery();
                        silmeuyecmd.ExecuteNonQuery();
                        Cagirma_FormListeleme2();
                    }
                }
            }
            else
            {
                DialogResult silmeonay2 = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);
                if (silmeonay2 == DialogResult.Yes)
                {
                    OleDbCommand silmetarla2cmd = new OleDbCommand("DELETE FROM urunler where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
                    OleDbCommand silmeuye2cmd = new OleDbCommand("DELETE FROM uyelik_veritabani where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
                    silmetarla2cmd.ExecuteNonQuery();
                    silmeuye2cmd.ExecuteNonQuery();
                    Cagirma_FormListeleme2();
                }
            }
        }
        private void guncelle_uyetipi_Click(object sender, EventArgs e)
        {
            //Üyelik Tipi Güncelleme

            OleDbCommand uyetipcom = new OleDbCommand("UPDATE uyelik_veritabani SET [uyelik_tip]=@uyeliktip where uyelik_id= '" + data_uyeler.CurrentRow.Cells[2].Value.ToString() + "'", Program.baglan);
            uyetipcom.Parameters.AddWithValue("@uyeliktip", uyetip_combobox.Text);
            uyetipcom.ExecuteNonQuery();
            Cagirma_FormListeleme2();
            
        }
        // Üye güncelleme Silme

        private void Cagirma_FormListeleme2()
        {
            uyeler_butonu_Click(uyeler_butonu, new EventArgs());
        }   // Yeniden Listeleme (Üyeler)
        private void Cagirma_ProfilListeleme2()
        {
            YoneticiEkrani_Load(yonetici_profil_buton, new EventArgs());
        }  // Yeniden Listeleme (Profil)
    }
}
