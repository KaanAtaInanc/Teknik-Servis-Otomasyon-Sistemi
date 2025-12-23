using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Ariza_Paneli : Form
    {
        public Ariza_Paneli()
        {
            InitializeComponent();

            // Form boyutlandırma ayarların
            this.ClientSize = new System.Drawing.Size(1834, 1150);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
        }

        // Bağlantı Adresi
        string connectionString = "Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;";

        private void Ariza_Paneli_Load_1(object sender, EventArgs e)
        {
            // Form açılırken filtreleri ve listeyi doldur
            DurumlariDoldur();
            ListeyiGetir();
        }

        // --- LİSTELEME VE FİLTRELEME METODU ---
        private void ListeyiGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // SQL Sorgusu: ID'ler yerine İsimleri görmek için JOIN kullanıyoruz.
                    // 1=1 taktiği, dinamik olarak "AND..." eklemeyi kolaylaştırır.
                    string sorgu = @"
                        SELECT 
                            A.Ariza_ID as [İş No],
                            M.Ad + ' ' + M.Soyad as [Müşteri],
                            A.Cihaz_Ad as [Cihaz],
                            A.Cihaz_Marka_Model as [Model],
                            A.Seri_No as [Seri No],
                            CASE 
                                WHEN A.Durum_ID = 1 THEN 'Bekliyor'
                                WHEN A.Durum_ID = 2 THEN 'İşlemde'
                                WHEN A.Durum_ID = 3 THEN 'Parça Bekleniyor'
                                WHEN A.Durum_ID = 4 THEN 'Tamamlandı'
                                WHEN A.Durum_ID = 5 THEN 'İptal'
                                ELSE 'Bilinmiyor'
                            END as [Durum],
                            P.Ad + ' ' + P.Soyad as [Teknisyen],
                            A.Musteri_Sikayet as [Şikayet],
                            A.Gelis_Tarihi as [Geliş Tarihi],
                            A.Bitis_Tarihi as [Bitiş Tarihi],
                            A.Teknisyen_Aciklama as [Notlar]
                        FROM Arizalar A
                        LEFT JOIN Musteriler M ON A.Musteri_ID = M.Musteri_ID
                        LEFT JOIN Personeller P ON A.Teknisyen_ID = P.Personel_ID
                        WHERE 1=1";

                    // --- FİLTRELEME MANTIĞI ---
                    // Eğer 'Tümü' (index 0) seçili değilse filtre ekle
                    if (CMB_Durum.SelectedIndex > 0)
                    {
                        sorgu += " AND A.Durum_ID = @durum";
                    }

                    // En yeni kayıt en üstte görünsün
                    sorgu += " ORDER BY A.Ariza_ID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

                    // Parametre atama
                    if (CMB_Durum.SelectedIndex > 0)
                    {
                        // ComboBox sırası ile Veritabanı ID sırası aynı olduğu varsayılmıştır (1,2,3...)
                        da.SelectCommand.Parameters.AddWithValue("@durum", CMB_Durum.SelectedIndex);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Grid'i temizle ve doldur
                    dgv_Ariza_Kayit.DataSource = null;
                    dgv_Ariza_Kayit.DataSource = dt;

                    // Sütun genişliklerini otomatik ayarla
                    dgv_Ariza_Kayit.AutoGenerateColumns = true;
                    dgv_Ariza_Kayit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- DURUM KUTUSUNU DOLDUR ---
        private void DurumlariDoldur()
        {
            CMB_Durum.Items.Clear();
            CMB_Durum.Items.Add("Tümü");            // Index 0
            CMB_Durum.Items.Add("Bekliyor");        // Index 1 (ID 1)
            CMB_Durum.Items.Add("İşlemde");         // Index 2 (ID 2)
            CMB_Durum.Items.Add("Parça Bekleniyor");// Index 3 (ID 3)
            CMB_Durum.Items.Add("Tamamlandı");      // Index 4 (ID 4)
            CMB_Durum.Items.Add("İptal");           // Index 5 (ID 5)

            CMB_Durum.SelectedIndex = 0; // Varsayılan: Tümü
        }

        // --- FİLTRELE BUTONU ---
        private void BTN_Filter_Click(object sender, EventArgs e)
        {
            ListeyiGetir();
        }

        // --- FİLTREYİ KALDIR BUTONU ---
        private void BTN_Filtre_Kaldır_Click(object sender, EventArgs e)
        {
            CMB_Durum.SelectedIndex = 0; // Tümü seç
            ListeyiGetir();
        }

        private void BTN_Ana_Sayfa_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}