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
    public partial class UrunGuncelle : Form
    {
        public delegate void UrunguncellendiEventHandler();
        public event UrunguncellendiEventHandler UrunGun;
        public CiftciEkrani ciftciform;

        public UrunGuncelle()
        {
            InitializeComponent();
        }
        public UrunGuncelle(string idgönderme, string[] datas, DateTime[] dataz)
        {
            Datas = datas;
            Dataz = dataz;
            InitializeComponent();
            id_alma2 = idgönderme;
        }
        public string id_alma2 { get; set; }    // Kullanıcı Adı
        public string[] Datas { get; set; }     // Textler
        public DateTime[] Dataz { get; set; }   // Zamanlar
        private void urunguncel_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }       // Güncelleme İptal
        private void urunguncelle_butonu_Click(object sender, EventArgs e)
        {
            if (urun_adi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen ürün adını giriniz");
            }
            else
            {
                if (Program.baglan.State == ConnectionState.Closed)
                    Program.baglan.Open();
                OleDbCommand urunguncmd = new OleDbCommand("UPDATE urunler SET [urun_adi]=@urunad, [urun_adet]=@urunadet, [urun_ekim]=@urunekim, [urun_hasat]=@urunhasat, [hasat_adet]=@hasatadet where uyelik_id= '" + id_alma2 + "' AND urun_adi= '" + Datas[0] + "'", Program.baglan);

                urunguncmd.Parameters.AddWithValue("@urunad", urun_adi.Text);
                urunguncmd.Parameters.AddWithValue("@urunadet", urun_adeti.Text);
                urunguncmd.Parameters.AddWithValue(@"urunekim", DateTime.Parse(urun_ekimtime.Text));
                urunguncmd.Parameters.AddWithValue(@"urunhasat", DateTime.Parse(urun_hasattime.Text));
                urunguncmd.Parameters.AddWithValue(@"hasatadet", urun_hasat_adeti.Text);
                urunguncmd.ExecuteNonQuery();
                urunguncmd.Dispose();
                MessageBox.Show("Ürün güncellendi");
                UrunGun();
                this.Close();
            }
        }   // Güncelleme Onay ve Veritabanına Yazdırma
        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            urun_adi.Text = Datas[0];
            urun_adeti.Text = Datas[1];
            urun_ekimtime.Text = Dataz[0].ToString();
            urun_hasattime.Text = Dataz[1].ToString();
            urun_hasat_adeti.Text = Datas[2];
        }     // Bilgileri Yazdırma
    }
}
