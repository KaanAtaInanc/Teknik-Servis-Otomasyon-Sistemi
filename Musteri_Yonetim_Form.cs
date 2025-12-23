using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Musteri_Yonetim_Form : Form
    {
        // Global Bağlantı ve Tablo
        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");
        DataTable tablo = new DataTable();

        public Musteri_Yonetim_Form()
        {
            InitializeComponent();
        }

        private void Musteri_Yonetim_Form_Load(object sender, EventArgs e)
        {
            VerileriGetir();      // Verileri Çek
            FiltreleriDoldur();   // ComboBox'ları Doldur
            TasarimiDuzenle();    // Görselliği Ayarla
        }

        // --- VERİLERİ GETİR ---
        void VerileriGetir()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;"))
            {
                try
                {
                    baglanti.Open();

                    // SQL Sorgusu: Cihazı olmayan müşteriler de gelsin diye LEFT JOIN ve ISNULL kullanıyoruz
                    string sorgu = @"
                        SELECT 
                            m.Musteri_ID,
                            m.Ad AS [Ad],
                            m.Soyad AS [Soyad],
                            m.Telefon_No AS [Telefon],
                            m.Email AS [E-Mail],
                            m.Il AS [Şehir],
                            m.Ilce AS [İlçe],
                            m.Acık_Adres AS [Adres],  
                            ISNULL(a.Cihaz_Ad, 'Cihaz Kaydı Yok') AS [Cihaz Türü],
                            m.Kayıt_Tarih AS [Kayıt Tarihi]
                        FROM Musteriler m
                        LEFT JOIN Arizalar a ON m.Musteri_ID = a.Musteri_ID
                        ORDER BY m.Musteri_ID DESC"; // En yeni müşteri en üstte

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                    tablo.Clear(); // Eski veriyi temizle
                    da.Fill(tablo); // Yeni veriyi doldur

                    // --- KRİTİK NOKTA: TABLOYU ZORLA YENİLE ---
                    dgvCustomers.DataSource = null;
                    dgvCustomers.AutoGenerateColumns = true; // Sütunları SQL'e göre otomatik oluştur
                    dgvCustomers.DataSource = tablo;

                    // ID sütununu gizle
                    if (dgvCustomers.Columns.Contains("Musteri_ID"))
                        dgvCustomers.Columns["Musteri_ID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri Hatası: " + ex.Message);
                }
            }
        }

        // --- FİLTRELEME İŞLEMİ ---
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string sehir = cmbCity.SelectedItem?.ToString();
                string cihaz = cmbDeviceType.SelectedItem?.ToString();
                string filtre = "";

                // Şehir Filtresi
                if (sehir != "Tüm Şehirler" && !string.IsNullOrEmpty(sehir))
                {
                    filtre += string.Format("[Şehir] LIKE '%{0}%'", sehir);
                }

                // Cihaz Filtresi
                if (cihaz != "Tüm Cihazlar" && !string.IsNullOrEmpty(cihaz))
                {
                    if (filtre.Length > 0) filtre += " AND ";
                    filtre += string.Format("[Cihaz Türü] LIKE '%{0}%'", cihaz);
                }

                // Filtreyi Uygula
                DataView dv = tablo.DefaultView;
                dv.RowFilter = filtre;
                dgvCustomers.DataSource = dv;
            }
            catch (Exception ex) { MessageBox.Show("Filtreleme Hatası: " + ex.Message); }
        }

        // --- FİLTREYİ KALDIR ---
        private void BtnClearFilter_Click(object sender, EventArgs e)
        {
            cmbCity.SelectedIndex = 0;
            cmbDeviceType.SelectedIndex = 0;

            DataView dv = tablo.DefaultView;
            dv.RowFilter = ""; // Filtreyi temizle
            dgvCustomers.DataSource = dv;
        }

        // --- COMBOBOX DOLDURMA ---
        void FiltreleriDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;"))
            {
                try
                {
                    baglanti.Open();

                    // Şehirleri Doldur
                    SqlCommand cmdSehir = new SqlCommand("SELECT DISTINCT Il FROM Musteriler WHERE Il IS NOT NULL ORDER BY Il ASC", baglanti);
                    SqlDataReader dr = cmdSehir.ExecuteReader();
                    cmbCity.Items.Clear();
                    cmbCity.Items.Add("Tüm Şehirler");
                    while (dr.Read()) cmbCity.Items.Add(dr["Il"].ToString());
                    dr.Close();
                    cmbCity.SelectedIndex = 0;

                    // Cihazları Doldur
                    SqlCommand cmdCihaz = new SqlCommand("SELECT DISTINCT Cihaz_Ad FROM Arizalar WHERE Cihaz_Ad IS NOT NULL", baglanti);
                    SqlDataReader drCihaz = cmdCihaz.ExecuteReader();
                    cmbDeviceType.Items.Clear();
                    cmbDeviceType.Items.Add("Tüm Cihazlar");
                    while (drCihaz.Read()) cmbDeviceType.Items.Add(drCihaz["Cihaz_Ad"].ToString());
                    drCihaz.Close();
                    cmbDeviceType.SelectedIndex = 0;
                }
                catch { }
            }
        }

        // --- TASARIM AYARLARI ---
        void TasarimiDuzenle()
        {
            if (dgvCustomers.Rows.Count > 0)
            {
                dgvCustomers.BorderStyle = BorderStyle.None;
                dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
                dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvCustomers.BackgroundColor = Color.White;
                dgvCustomers.EnableHeadersVisualStyles = false;
                dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
                dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}