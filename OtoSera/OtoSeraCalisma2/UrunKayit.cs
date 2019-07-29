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
    public partial class UrunKayit : Form
    {
        public UrunKayit()
        {
            InitializeComponent();
        }

        public delegate void UruneklendiEventHandler();
        public event UruneklendiEventHandler UrunEkle;
        public UrunKayit(string idgönderme)
        {
            InitializeComponent();
            id_alma3 = idgönderme;
        }
        public string id_alma3 { get; set; }
        private void urunekle_butonu_Click(object sender, EventArgs e)
        {
            if (urun_adi.Text == string.Empty)
            {
                MessageBox.Show("Lütfen ürün adını giriniz");
            }
            else
            {
                if (Program.baglan.State == ConnectionState.Closed)
                    Program.baglan.Open();
                OleDbCommand uruneklecmd = new OleDbCommand("INSERT INTO urunler (uyelik_id, urun_adi, urun_adet, urun_ekim, urun_hasat, hasat_adet) VALUES (@uyeid, @urunadi, @urunadeti, @ekimtarihi, @hasattarihi, @hasatadeti)", Program.baglan);

                string uyeid = id_alma3;
                uruneklecmd.Parameters.AddWithValue("@uyeid", uyeid);
                uruneklecmd.Parameters.AddWithValue("@urunadi", urun_adi.Text);
                uruneklecmd.Parameters.AddWithValue("@urunadeti", urun_adeti.Text);
                uruneklecmd.Parameters.AddWithValue("@ekimtarihi", DateTime.Parse(urun_ekimtime.Text));
                uruneklecmd.Parameters.AddWithValue("@hasattarihi", DateTime.Parse(urun_hasattime.Text));
                uruneklecmd.Parameters.AddWithValue("@hasatadeti", urun_hasat_adeti.Text);
                uruneklecmd.ExecuteNonQuery();
                MessageBox.Show("Yeni ürün başarıyla eklendi.");
                UrunEkle();
                this.Close();
            }
        }       // Ürün ekle    
        private void urunekle_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }       // İptal Et
    }
}
