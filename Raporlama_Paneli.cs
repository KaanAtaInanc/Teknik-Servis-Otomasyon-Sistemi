using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Raporlama_Paneli : Form
    {
        // Bağlantı Adresi
        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");

        // Hangi raporun aktif olduğunu tutan değişken (Filtreleme için gerekli)
        private string aktifRaporTuru = "";

        public Raporlama_Paneli()
        {
            InitializeComponent();
        }

        private void Raporlama_Paneli_Load(object sender, EventArgs e)
        {
            ApplyModernStyling();

            // Tarihleri varsayılan ayarla (Son 30 gün)
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;

            // Olayları Bağla (Designer'da bağlı değilse diye garantiye alıyoruz)
            this.btnStockReport.Click += new EventHandler(BtnStockReport_Click);
            this.btnFaultReport.Click += new EventHandler(BtnFaultReport_Click);
            this.btnCustomerReport.Click += new EventHandler(BtnCustomerReport_Click);
            this.btnFiltre.Click += new EventHandler(BtnFiltre_Click); // Filtrele Butonu
            this.btnFiltreKaldır.Click += new EventHandler(BtnFiltreKaldir_Click); // Temizle Butonu
        }

        // --- MERKEZİ VERİ ÇEKME METODU ---
        private void VerileriGetir(string sorgu, bool tarihFiltresiVarMi)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                // Eğer tarih filtresi gerekiyorsa parametreleri ekle
                if (tarihFiltresiVarMi)
                {
                    // Başlangıç: Günün ilk saati (00:00:00)
                    da.SelectCommand.Parameters.AddWithValue("@tarih1", dtpStartDate.Value.Date);
                    
                    da.SelectCommand.Parameters.AddWithValue("@tarih2", dtpEndDate.Value.Date.AddDays(1));
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Grid'i sıfırla ve doldur
                dgvReport.DataSource = null;
                dgvReport.Columns.Clear();
                dgvReport.DataSource = dt;

                // Başlıkları ve genişlikleri ayarla
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // --- 1. STOK RAPORU ---
        private void BtnStockReport_Click(object sender, EventArgs e)
        {
            aktifRaporTuru = "Stok"; // Hafızaya al

            string sql = @"SELECT 
                            Parca_ID as [ID], 
                            Parca_Ad as [Parça Adı], 
                            [Marka-Model] as [Marka/Model], 
                            Kategori as [Kategori], 
                            Mevcut_Stok as [Mevcut Stok], 
                            Kritik_Seviye as [Kritik Sınır]
                           FROM Parcalar 
                           WHERE AktifMi = 1
                           ORDER BY Mevcut_Stok ASC";

            VerileriGetir(sql, false); // false = Tarih kullanma
        }

        // --- 2. ARIZA RAPORU ---
        private void BtnFaultReport_Click(object sender, EventArgs e)
        {
            aktifRaporTuru = "Ariza"; // Hafızaya al

            string sql = @"SELECT 
                            Ariza_ID as [İş No], 
                            Cihaz_Ad as [Cihaz], 
                            Cihaz_Marka_Model as [Model], 
                            Gelis_Tarihi as [Geliş Tarihi], 
                            Durum_ID as [Durum],
                            Teknisyen_Aciklama as [Notlar]
                           FROM Arizalar 
                           WHERE Gelis_Tarihi >= @tarih1 AND Gelis_Tarihi < @tarih2
                           ORDER BY Gelis_Tarihi DESC";

            VerileriGetir(sql, true); 
        }

        // --- 3. MÜŞTERİ RAPORU ---
        private void BtnCustomerReport_Click(object sender, EventArgs e)
        {
            aktifRaporTuru = "Musteri"; // Hafızaya al


            string sql = @"SELECT 
                            Musteri_ID as [ID], 
                            Ad + ' ' + Soyad as [Müşteri Adı], 
                            Telefon_No as [Telefon], 
                            Email as [E-Posta], 
                            Il + '/' + Ilce as [Konum], 
                            Kayıt_Tarih as [Kayıt Tarihi]
                           FROM Musteriler 
                           WHERE Kayıt_Tarih >= @tarih1 AND Kayıt_Tarih < @tarih2
                           ORDER BY Kayıt_Tarih DESC";

            VerileriGetir(sql, true); 
        }

        // --- 4. FİLTRELE BUTONU ---
        private void BtnFiltre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aktifRaporTuru))
            {
                MessageBox.Show("Lütfen önce yukarıdan bir rapor türü seçiniz.", "Uyarı");
                return;
            }

            // Aktif rapora göre buton click olayını tetikle
            if (aktifRaporTuru == "Stok") BtnStockReport_Click(null, null);
            else if (aktifRaporTuru == "Ariza") BtnFaultReport_Click(null, null);
            else if (aktifRaporTuru == "Musteri") BtnCustomerReport_Click(null, null);

            MessageBox.Show("Rapor güncellendi.");
        }

        // --- 5. FİLTRE KALDIR / TEMİZLE ---
        private void BtnFiltreKaldir_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            dgvReport.Columns.Clear();
            aktifRaporTuru = "";
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        // --- GÖRSEL AYARLAR ---
        private void ApplyModernStyling()
        {
            dgvReport.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvReport.DefaultCellStyle.BackColor = Color.White;
            dgvReport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvReport.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(189, 195, 199);
        }

        // --- BOŞ EVENTLER ---
        private void BtnExportExcel_Click(object sender, EventArgs e) { MessageBox.Show("Excel özelliği geliştirme aşamasındadır."); }
        private void BtnRefresh_Click(object sender, EventArgs e) { BtnFiltre_Click(null, null); }
        private void BtnClear_Click(object sender, EventArgs e) { BtnFiltreKaldir_Click(null, null); }

        // Yanlışlıkla oluşmuş olabilecek eventleri önlemek için
        private void btnStockReport_Click_1(object sender, EventArgs e) { }

        private void btnCustomerReport_Click_1(object sender, EventArgs e)
        {

        }
    }
}