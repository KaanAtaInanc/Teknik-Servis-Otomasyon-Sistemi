using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Danisma_Panel : Form
    {
        public Danisma_Panel()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;";

        // Atama işlemi için gerekli değişkeni buraya ekledim (Eksikti)
        int secilenArizaID = 0;

        private void Danisma_Panel_Load(object sender, EventArgs e)
        {
            // TableAdapter satırlarını kaldırdım çünkü aşağıda manuel dolduruyoruz, çakışma yapmasın.

            GridleriYenile();        // Üst Tabloyu (Müşteri) Doldur
            BekleyenIsleriListele(); // Alt Tabloyu (Cihaz) Doldur
            AtananIsleriListele();   // Diğer Sekmeyi Doldur
            TeknisyenleriDoldur();   // Personel Kutusunu Doldur
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BTN_Sistem_Kapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Sistemden çıkmak istediğinize emin misiniz?\n\nHerhangi bir kaydedilmemiş veri kaybolabilir.",
              "⚠️  Sistemi Kapat",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_Oturum_Kapat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Oturumu kapatmak istediğinize emin misiniz?",
              "⚠️  Oturumu Kapat",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Kullanici_Giris loginForm = new Kullanici_Giris();
                loginForm.Show();
            }
        }

        void Temizle()
        {
            TXT_Ad.Text = ""; TXT_Soyad.Text = ""; TXT_Tel.Text = ""; TXT_MAİL.Text = "";
            TXT_İL.Text = ""; TXT_İLÇE.Text = ""; TXT_Adres.Text = "";
            TXT_Cihaz_Ad.Text = ""; TXT_Marka.Text = ""; TXT_Seri_No.Text = ""; TXT_Şikayet.Text = "";
        }

        // --- DÜZELTME 1: Burası artık sadece Müşterileri yüklüyor. Üstteki tablo düzelecek ---
        void GridleriYenile()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                // Müşteriler
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM dbo.Musteriler ORDER BY Musteri_ID DESC", baglanti);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dgv_Musteriler.DataSource = dt1;

                // NOT: Buradaki Arızalar sorgusunu sildim çünkü o alttaki tablonun işi.
                // Senin kodunda burada tekrar dgv_Musteriler'e basıyordu, o yüzden bozuluyordu.
            }
        }

        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // 1. Seri Numarası Kontrolü
                    string kontrolSorgusu = "SELECT COUNT(*) FROM dbo.Arizalar WHERE Seri_No = @sn AND Durum_ID != 3";

                    using (SqlCommand komutKontrol = new SqlCommand(kontrolSorgusu, baglanti))
                    {
                        komutKontrol.Parameters.AddWithValue("@sn", TXT_Seri_No.Text);
                        int kayitSayisi = Convert.ToInt32(komutKontrol.ExecuteScalar());

                        if (kayitSayisi > 0)
                        {
                            MessageBox.Show("DİKKAT! Bu Seri Numarasına sahip cihaz şu an zaten serviste görünüyor.\nTekrar kayıt açamazsınız.",
                                            "Mükerrer Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    // 2. Müşteri Kaydet
                    string musteriSorgu = "INSERT INTO dbo.Musteriler (Ad, Soyad, Telefon_No, Email, Il, Ilce, Acık_Adres, Kayıt_Tarih) " +
                                          "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8); " +
                                          "SELECT SCOPE_IDENTITY();";

                    int yeniMusteriID = 0;

                    using (SqlCommand komut = new SqlCommand(musteriSorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", TXT_Ad.Text);
                        komut.Parameters.AddWithValue("@p2", TXT_Soyad.Text);
                        komut.Parameters.AddWithValue("@p3", TXT_Tel.Text);
                        komut.Parameters.AddWithValue("@p4", TXT_MAİL.Text);
                        komut.Parameters.AddWithValue("@p5", TXT_İL.Text);
                        komut.Parameters.AddWithValue("@p6", TXT_İLÇE.Text);
                        komut.Parameters.AddWithValue("@p7", TXT_Adres.Text);
                        komut.Parameters.AddWithValue("@p8", DateTime.Now);

                        yeniMusteriID = Convert.ToInt32(komut.ExecuteScalar());
                    }

                    // 3. Cihaz Kaydet
                    string arizaSorgu = "INSERT INTO dbo.Arizalar (Musteri_ID, Cihaz_Ad, Cihaz_Marka_Model, Seri_No, Musteri_Sikayet, Gelis_Tarihi, Durum_ID) " +
                                        "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, 1)";

                    using (SqlCommand komutA = new SqlCommand(arizaSorgu, baglanti))
                    {
                        komutA.Parameters.AddWithValue("@a1", yeniMusteriID);
                        komutA.Parameters.AddWithValue("@a2", TXT_Cihaz_Ad.Text);
                        komutA.Parameters.AddWithValue("@a3", TXT_Marka.Text);
                        komutA.Parameters.AddWithValue("@a4", TXT_Seri_No.Text);
                        komutA.Parameters.AddWithValue("@a5", TXT_Şikayet.Text);
                        komutA.Parameters.AddWithValue("@a6", DateTime.Now);
                        komutA.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kayıt Başarıyla Tamamlandı!\nMüşteri Takip No: " + yeniMusteriID);

                    Temizle();

                    // --- DÜZELTME 2: İŞTE BURASI. EKSİK OLAN KISIM ---
                    // Kaydettikten sonra listeleri çağırıyoruz ki ekran güncellensin.
                    GridleriYenile();        // Üst tabloyu yenile
                    BekleyenIsleriListele(); // Alt tabloyu yenile (Samsung A21 burada görünecek)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // --- DÜZELTME 3: Sıralamayı düzelttim ki yeni kayıt en üste gelsin ---
        void BekleyenIsleriListele()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                // ORDER BY Ariza_ID DESC ekledim
                string sorgu = @"SELECT Ariza_ID, Cihaz_Ad, Cihaz_Marka_Model, Seri_No, Musteri_Sikayet, Gelis_Tarihi 
                                 FROM dbo.Arizalar 
                                 WHERE Teknisyen_ID IS NULL
                                 ORDER BY Ariza_ID DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_Kayıt_Cihaz.DataSource = null; // Bağlantıyı kesip tekrar veriyoruz ki kesin yenilensin
                dgv_Kayıt_Cihaz.DataSource = dt;
            }
        }

        void AtananIsleriListele()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                string sorgu = @"SELECT Ariza_ID, Cihaz_Ad, Cihaz_Marka_Model, Atama_Tarihi, Durum_ID 
                                 FROM dbo.Arizalar 
                                 WHERE Teknisyen_ID IS NOT NULL AND Durum_ID != 3";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Atanan_Per_Tablo.DataSource = dt;
            }
        }

        void TeknisyenleriDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Personel_ID, Ad + ' ' + Soyad AS AdSoyad FROM dbo.Personeller WHERE Rol_ID = 2", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb_Personeller.DataSource = dt;
                cmb_Personeller.DisplayMember = "AdSoyad";
                cmb_Personeller.ValueMember = "Personel_ID";
                cmb_Personeller.SelectedIndex = -1;
            }
        }

        void AtamaTemizle()
        {
            secilenArizaID = 0;
            TXT_Cihaz_Adi.Text = ""; TXT_Marka_Modeli.Text = "";
            TXT_Seri_Nosu.Text = ""; TXT_Sikayeti.Text = "";
            cmb_Personeller.SelectedIndex = -1;
        }

        private void dgv_Kayit_Cihaz_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridView grid = (DataGridView)sender;

                // Güvenli veri çekme
                if (grid.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
                {
                    DataRow satirVerisi = rowView.Row;

                    secilenArizaID = Convert.ToInt32(satirVerisi["Ariza_ID"]);
                    TXT_Cihaz_Adi.Text = satirVerisi["Cihaz_Ad"].ToString();
                    TXT_Marka_Modeli.Text = satirVerisi["Cihaz_Marka_Model"].ToString();
                    TXT_Seri_Nosu.Text = satirVerisi["Seri_No"].ToString();
                    TXT_Sikayeti.Text = satirVerisi["Musteri_Sikayet"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hücre seçilirken hata oluştu: " + ex.Message);
            }
        }

        private void btnAssignStaff_Click(object sender, EventArgs e)
        {
            if (secilenArizaID == 0)
            {
                MessageBox.Show("Lütfen listeden bir cihaz seçiniz.");
                return;
            }
            if (cmb_Personeller.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen atanacak personeli seçiniz.");
                return;
            }

            int secilenTeknisyenID = Convert.ToInt32(cmb_Personeller.SelectedValue);

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                string kontrol = "SELECT COUNT(*) FROM dbo.Arizalar WHERE Teknisyen_ID = @tid AND Durum_ID NOT IN (3, 4)";

                using (SqlCommand komutKontrol = new SqlCommand(kontrol, baglanti))
                {
                    komutKontrol.Parameters.AddWithValue("@tid", secilenTeknisyenID);
                    int isSayisi = Convert.ToInt32(komutKontrol.ExecuteScalar());

                    if (isSayisi > 0)
                    {
                        DialogResult cevap = MessageBox.Show(
                            "Bu personelin üzerinde şu an bitmemiş bir iş var!\n\nYine de atama yapmak istiyor musunuz?",
                            "Personel Meşgul",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (cevap == DialogResult.No) return;
                    }
                }

                string sql = "UPDATE dbo.Arizalar SET Teknisyen_ID = @tid, Atama_Tarihi = @tarih, Durum_ID = 2 WHERE Ariza_ID = @aid";

                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    komut.Parameters.AddWithValue("@tid", secilenTeknisyenID);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                    komut.Parameters.AddWithValue("@aid", secilenArizaID);
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Personel ataması başarıyla yapıldı!");

                Temizle();
                AtamaTemizle();
                BekleyenIsleriListele(); // Alt tabloyu güncelle
                AtananIsleriListele();   // Diğer sekmeyi güncelle
            }
        }

        private void dgv_Kayıt_Cihaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BTN_İptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}