using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Atanan_Islemler : Form
    {
        // --- DEĞİŞKENLER ---
        int secilenArizaID = 0;
        DataTable dtSepet = new DataTable();
        private int currentTechnicianId = 0;
        private string currentTechnicianName = "";

        // Bağlantı Adresi
        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");

        public Atanan_Islemler()
        {
            InitializeComponent();
            SepetTablosunuHazirla();
        }

        public Atanan_Islemler(int technicianId, string technicianName)
        {
            InitializeComponent();
            this.currentTechnicianId = technicianId;
            this.currentTechnicianName = technicianName;
            SepetTablosunuHazirla();
        }

        // Sepet yapısını hazırla
        private void SepetTablosunuHazirla()
        {
            if (dtSepet.Columns.Count == 0)
            {
                dtSepet.Columns.Add("Parca_ID", typeof(int));
                dtSepet.Columns.Add("Parca_Ad", typeof(string));
                dtSepet.Columns.Add("Adet", typeof(int));
            }
        }

        private void Atanan_Islemler_Load(object sender, EventArgs e)
        {
            try
            {
                IsleriListele();        // Tabloyu doldurur
                LoadTechnicianInfo();   // Teknisyen adını yazar
                DurumCombosunuDoldur(); // İş durumlarını doldurur
                ParcalariYukle();       // Parça listesini doldurur
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılış hatası: " + ex.Message);
            }
        }

        private void IsleriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                dgv_Atanan_İş_.DataSource = null;
                dgv_Atanan_İş_.Columns.Clear();

                string sorgu = @"SELECT Ariza_ID, Cihaz_Ad, Cihaz_Marka_Model, Seri_No, Musteri_Sikayet, Durum_ID, 
                                 Gelis_Tarihi, Atama_Tarihi, Bitis_Tarihi, Teknisyen_Aciklama
                                 FROM Arizalar 
                                 WHERE Durum_ID != 5"; // 5: İptal/Bitti statüsü hariçleri getir

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgv_Atanan_İş_.AutoGenerateColumns = true;
                dgv_Atanan_İş_.DataSource = dt;

                // Başlıkları düzenle
                if (dgv_Atanan_İş_.Columns.Contains("Ariza_ID")) dgv_Atanan_İş_.Columns["Ariza_ID"].HeaderText = "İş No";
                if (dgv_Atanan_İş_.Columns.Contains("Cihaz_Ad")) dgv_Atanan_İş_.Columns["Cihaz_Ad"].HeaderText = "Cihaz";
                if (dgv_Atanan_İş_.Columns.Contains("Cihaz_Marka_Model")) dgv_Atanan_İş_.Columns["Cihaz_Marka_Model"].HeaderText = "Marka/Model";
                if (dgv_Atanan_İş_.Columns.Contains("Musteri_Sikayet")) dgv_Atanan_İş_.Columns["Musteri_Sikayet"].HeaderText = "Şikayet";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        // --- PARÇA YÖNETİMİ ---
        private void ParcalariYukle()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "SELECT Parca_ID, Parca_Ad, Mevcut_Stok FROM Parcalar WHERE Mevcut_Stok > 0 AND AktifMi = 1";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dtParcalar = new DataTable();
                da.Fill(dtParcalar);

                CMB_KullanılanParçaSecim.DisplayMember = "Parca_Ad";
                CMB_KullanılanParçaSecim.ValueMember = "Parca_ID";
                CMB_KullanılanParçaSecim.DataSource = dtParcalar;
                CMB_KullanılanParçaSecim.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parçalar yüklenemedi: " + ex.Message);
            }
            finally { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        private void BTN_Parca_Ekle_Click(object sender, EventArgs e)
        {
            if (CMB_KullanılanParçaSecim.SelectedIndex == -1 || string.IsNullOrEmpty(TXT_Miktar.Text))
            {
                MessageBox.Show("Lütfen parça ve miktar seçiniz.");
                return;
            }

            try
            {
                int pID = (int)CMB_KullanılanParçaSecim.SelectedValue;
                string pAd = CMB_KullanılanParçaSecim.Text;
                int miktar = int.Parse(TXT_Miktar.Text);

                // Stok Kontrolü
                DataRowView secilenSatir = (DataRowView)CMB_KullanılanParçaSecim.SelectedItem;
                int stok = Convert.ToInt32(secilenSatir["Mevcut_Stok"]);

                if (miktar > stok)
                {
                    MessageBox.Show($"Yetersiz Stok! Mevcut: {stok}");
                    return;
                }

                // Sepete Ekleme
                dtSepet.Rows.Add(pID, pAd, miktar);
                MessageBox.Show($"{pAd} ({miktar} adet) listeye eklendi. 'İşlemi Kaydet'e basmayı unutmayın.");

                TXT_Miktar.Clear();
                CMB_KullanılanParçaSecim.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- YENİLENMİŞ KAYDETME İŞLEMİ (SADELEŞTİRİLMİŞ) ---
        private void BTN_Kaydet_Click(object sender, EventArgs e)
        {
            if (secilenArizaID == 0)
            {
                MessageBox.Show("Lütfen listeden bir iş seçiniz!");
                return;
            }

            // Seçili parça ve miktar varsa sepete ekle
            if (CMB_KullanılanParçaSecim.SelectedIndex != -1 && !string.IsNullOrEmpty(TXT_Miktar.Text))
            {
                try
                {
                    int pID = (int)CMB_KullanılanParçaSecim.SelectedValue;
                    string pAd = CMB_KullanılanParçaSecim.Text;
                    int miktar = int.Parse(TXT_Miktar.Text);

                    // Stok Kontrolü
                    DataRowView secilenSatir = (DataRowView)CMB_KullanılanParçaSecim.SelectedItem;
                    int stok = Convert.ToInt32(secilenSatir["Mevcut_Stok"]);

                    if (miktar > stok)
                    {
                        MessageBox.Show($"Yetersiz Stok! Mevcut: {stok}");
                        return;
                    }

                    // Aynı parça zaten sepete ekliyse miktarı güncelle
                    DataRow[] existingRows = dtSepet.Select($"Parca_ID = {pID}");
                    if (existingRows.Length > 0)
                    {
                        existingRows[0]["Adet"] = Convert.ToInt32(existingRows[0]["Adet"]) + miktar;
                    }
                    else
                    {
                        dtSepet.Rows.Add(pID, pAd, miktar);
                    }

                    TXT_Miktar.Clear();
                    CMB_KullanılanParçaSecim.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Parça eklenirken hata: " + ex.Message);
                    return;
                }
            }

            // Sepet boş mu kontrol et
            if (dtSepet.Rows.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir parça seçiniz!");
                return;
            }

            // ============ İŞLEMİ KAYDET - STOK DÜŞÜR ============
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kullanilanParcaNotu = "";

                // Sepetteki her parça için işlem yap
                foreach (DataRow row in dtSepet.Rows)
                {
                    int pID = Convert.ToInt32(row["Parca_ID"]);
                    string pAd = row["Parca_Ad"].ToString();
                    int adet = Convert.ToInt32(row["Adet"]);

                    // SORGU 1: STOKTAN DÜŞME
                    string sqlStok = @"UPDATE Parcalar 
                                      SET Mevcut_Stok = Mevcut_Stok - @adet 
                                      WHERE Parca_ID = @pID";

                    SqlCommand cmdStok = new SqlCommand(sqlStok, baglanti);
                    cmdStok.Parameters.AddWithValue("@adet", adet);
                    cmdStok.Parameters.AddWithValue("@pID", pID);
                    cmdStok.ExecuteNonQuery();

                    // SORGU 2: KullanilanParcalar tablosuna ekle
                    string sqlInsert = @"INSERT INTO KullanilanParcalar (Ariza_ID, Parca_ID, Adet) 
                                         VALUES (@aID, @pID, @adet)";

                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, baglanti);
                    cmdInsert.Parameters.AddWithValue("@aID", secilenArizaID);
                    cmdInsert.Parameters.AddWithValue("@pID", pID);
                    cmdInsert.Parameters.AddWithValue("@adet", adet);
                    cmdInsert.ExecuteNonQuery();

                    kullanilanParcaNotu += $"{pAd} ({adet} adet), ";
                }

                // Notu Düzenle
                if (!string.IsNullOrEmpty(kullanilanParcaNotu))
                {
                    kullanilanParcaNotu = kullanilanParcaNotu.TrimEnd(',', ' ');
                    kullanilanParcaNotu = " || Kullanılan Parçalar: [ " + kullanilanParcaNotu + " ]";
                }

                // SORGU 3: Arıza Kaydını Güncelle
                string sqlAriza = @"UPDATE Arizalar 
                                    SET Durum_ID = @d, 
                                        Teknisyen_Aciklama = @yeniAciklama, 
                                        Bitis_Tarihi = @bitis 
                                    WHERE Ariza_ID = @id";

                string finalAciklama = TXT_Teknisyen_Not.Text + kullanilanParcaNotu;

                SqlCommand cmdAriza = new SqlCommand(sqlAriza, baglanti);
                cmdAriza.Parameters.AddWithValue("@d", CMB_İs_Durum.SelectedIndex + 1);
                cmdAriza.Parameters.AddWithValue("@yeniAciklama", finalAciklama);
                cmdAriza.Parameters.AddWithValue("@bitis", DateTime.Now);
                cmdAriza.Parameters.AddWithValue("@id", secilenArizaID);
                cmdAriza.ExecuteNonQuery();

                MessageBox.Show("✓ İşlem başarıyla kaydedildi.\n✓ Stoklar güncellendi.\n✓ Parçalar kaydedildi.",
                       "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                IsleriListele();
                ParcalariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        // --- ÇİFT TIKLAMA İLE VERİ DOLDURMA ---
        private void dgv_Atanan_Is__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgv_Atanan_İş_.Rows[e.RowIndex];

                if (row.Cells["Ariza_ID"].Value != DBNull.Value)
                {
                    secilenArizaID = Convert.ToInt32(row.Cells["Ariza_ID"].Value);
                }

                TXT_Cihaz_Ad.Text = row.Cells["Cihaz_Ad"].Value?.ToString();
                Txt_Marka_Model.Text = row.Cells["Cihaz_Marka_Model"].Value?.ToString();
                TXT_Seri_No.Text = row.Cells["Seri_No"].Value?.ToString();
                TXT_Sikayet.Text = row.Cells["Musteri_Sikayet"].Value?.ToString();

                if (row.Cells["Teknisyen_Aciklama"].Value != DBNull.Value)
                    TXT_Teknisyen_Not.Text = row.Cells["Teknisyen_Aciklama"].Value.ToString();
                else
                    TXT_Teknisyen_Not.Clear();

                if (row.Cells["Durum_ID"].Value != DBNull.Value)
                {
                    int dID = Convert.ToInt32(row.Cells["Durum_ID"].Value);
                    if (dID > 0 && dID <= CMB_İs_Durum.Items.Count)
                        CMB_İs_Durum.SelectedIndex = dID - 1;
                }

                dtSepet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim Hatası: " + ex.Message);
            }
        }

        // --- YARDIMCI METOTLAR ---
        private void Temizle()
        {
            secilenArizaID = 0;
            TXT_Cihaz_Ad.Clear(); Txt_Marka_Model.Clear(); TXT_Seri_No.Clear();
            TXT_Sikayet.Clear(); TXT_Teknisyen_Not.Clear(); TXT_Miktar.Clear();
            CMB_İs_Durum.SelectedIndex = 0;
            CMB_KullanılanParçaSecim.SelectedIndex = -1;
            dtSepet.Clear();
        }

        private void DurumCombosunuDoldur()
        {
            CMB_İs_Durum.Items.Clear();
            CMB_İs_Durum.Items.AddRange(new object[] { "Bakımda", "Beklemede", "Parça Bekleniyor", "Tamamlandı", "İptal" });
            CMB_İs_Durum.SelectedIndex = 0;
        }

        private void LoadTechnicianInfo()
        {
            if (!string.IsNullOrEmpty(currentTechnicianName))
                this.Text = $"Teknisyen: {currentTechnicianName}";
        }

        // Gereksiz olaylar
        private void CmbPartCategory_SelectedIndexChanged(object sender, EventArgs e) { ParcalariYukle(); }
        private void TxtPartSearch_TextChanged(object sender, EventArgs e) { ParcalariYukle(); }
        private void CmbUsedParts_SelectedIndexChanged(object sender, EventArgs e) { }
        private void BTN_İptal_Click(object sender, EventArgs e) { Temizle(); }
        private void pnlTaskDetails_Paint(object sender, PaintEventArgs e) { }
        private void BTN_Ana_Sayfa_Click(object sender, EventArgs e)
        {
            Teknisyen_Ana_Panel frm = new Teknisyen_Ana_Panel();
            frm.Show();
            this.Hide();
        }
    }
}
