using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Stok_Takip : Form
    {
        // --- DEĞİŞKENLER ---
        int secilenParcaID = 0;

        // Bağlantı Adresi 
        string connectionString = "Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;";

        public Stok_Takip()
        {
            InitializeComponent();

            //Olayların Kodla Bağlanması
            this.dgvStok.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvStok_CellFormatting);
            this.dgvStok.CellClick += new DataGridViewCellEventHandler(this.dgvStok_CellClick);
            this.dgv_Parcalar.CellDoubleClick += new DataGridViewCellEventHandler(this.dgv_Parcalar_CellDoubleClick);
        }

        // --- FORM YÜKLENİRKEN ---
        private void Stok_Takip_Load(object sender, EventArgs e)
        {
            try
            {
                KategorileriDoldur();
                TabloyuYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılış hatası: " + ex.Message);
            }
        }

        // --- MERKEZİ VERİ YÖNETİMİ (LİSTELEME)
        private void TabloyuYenile(string ekstraSart = "")
        {
            // Klasik 'using' bloğu kullanımı: İşlem bitince bağlantıyı otomatik kapatır.
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // SQL Sorgusu
                    string sorgu = "SELECT Parca_ID, Parca_Ad, [Marka-Model], Kategori, Mevcut_Stok, Kritik_Seviye FROM Parcalar WHERE AktifMi = 1 " + ekstraSart;

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Gridlere veriyi bağla
                    dgvStok.DataSource = dt;
                    dgv_Parcalar.DataSource = dt;

                    // Başlıkları ayarla
                    GridBaslikDuzenle(dgvStok);
                    GridBaslikDuzenle(dgv_Parcalar);

                    // Stok uyarısını kontrol et
                    KritikStokUyariVer(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // --- EKLEME İŞLEMİ
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sql = "INSERT INTO Parcalar (Parca_Ad, [Marka-Model], Kategori, Mevcut_Stok, Kritik_Seviye, AktifMi) VALUES (@ad, @marka, @kat, @stok, @kritik, 1)";

                    using (SqlCommand komut = new SqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", txtParcaAdı.Text);
                        komut.Parameters.AddWithValue("@marka", txtMarkaModel.Text);
                        komut.Parameters.AddWithValue("@kat", cmbKategori.Text);
                        // Sayısal değerleri Convert ederek gönderiyoruz
                        komut.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStokAdedi.Text));
                        komut.Parameters.AddWithValue("@kritik", Convert.ToInt32(txtKritikSeviye.Text));

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Parça başarıyla eklendi.");
                    TemizleVeYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.Message);
                }
            }
        }

        // --- GÜNCELLEME İŞLEMİ
        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (secilenParcaID == 0)
            {
                MessageBox.Show("Lütfen düzenlenecek ürünü seçiniz."); return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sql = "UPDATE Parcalar SET Parca_Ad=@ad, [Marka-Model]=@marka, Kategori=@kat, Mevcut_Stok=@stok, Kritik_Seviye=@kritik WHERE Parca_ID=@id";

                    using (SqlCommand komut = new SqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", txtParcaAdı.Text);
                        komut.Parameters.AddWithValue("@marka", txtMarkaModel.Text);
                        komut.Parameters.AddWithValue("@kat", cmbKategori.Text);
                        komut.Parameters.AddWithValue("@stok", Convert.ToInt32(txtStokAdedi.Text));
                        komut.Parameters.AddWithValue("@kritik", Convert.ToInt32(txtKritikSeviye.Text));
                        komut.Parameters.AddWithValue("@id", secilenParcaID);

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Parça bilgileri güncellendi.");
                    TemizleVeYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
        }

        // --- SİLME İŞLEMİ 
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenParcaID == 0) { MessageBox.Show("Silinecek ürünü seçiniz."); return; }

            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // Ürünü gerçekten silmiyoruz, AktifMi sütununu 0 yapıyoruz (Soft Delete)
                    string sql = "UPDATE Parcalar SET AktifMi = 0 WHERE Parca_ID=@id";

                    using (SqlCommand komut = new SqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", secilenParcaID);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Parça silindi.");
                    TemizleVeYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }

        // --- STOK ARTTIRMA İŞLEMİ
        private void btnStokArttır_Click(object sender, EventArgs e)
        {
            if (secilenParcaID == 0 || string.IsNullOrEmpty(txtStokAdedi.Text))
            {
                MessageBox.Show("Lütfen bir ürün seçiniz ve eklenecek miktarı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Parcalar SET Mevcut_Stok = Mevcut_Stok + @miktar WHERE Parca_ID = @id";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtStokAdedi.Text));
                        komut.Parameters.AddWithValue("@id", secilenParcaID);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Stok eklendi.");
                    TemizleVeYenile();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stok ekleme hatası: " + ex.Message);
                }
            }
        }

        // --- FİLTRELEME İŞLEMLERİ ---
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            if (cmbKategoriFiltre.SelectedIndex <= 0 || cmbKategoriFiltre.Text.Contains("Tüm"))
                TabloyuYenile();
            else
                TabloyuYenile($"AND Kategori = '{cmbKategoriFiltre.Text}'");
        }

        private void btnFiltreyiKaldır_Click(object sender, EventArgs e)
        {
            cmbKategoriFiltre.SelectedIndex = 0;
            TabloyuYenile();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleVeYenile();
        }

        // --- YARDIMCI VE GÖRSEL METOTLAR ---
        private void TemizleVeYenile()
        {
            secilenParcaID = 0;
            txtParcaAdı.Clear();
            txtMarkaModel.Clear();
            txtStokAdedi.Clear();
            txtKritikSeviye.Text = "10";
            cmbKategori.SelectedIndex = -1;
            TabloyuYenile();
        }

        private void KategorileriDoldur()
        {
            if (cmbKategori.Items.Count == 0)
            {
                string[] kat = { "Bilgisayar", "Telefon", "Tablet", "Yazıcı", "Aksesuar", "Yedek Parça" };
                cmbKategori.Items.AddRange(kat);
                if (!cmbKategoriFiltre.Items.Contains("Tümü")) cmbKategoriFiltre.Items.Add("Tümü");
                cmbKategoriFiltre.Items.AddRange(kat);
                cmbKategoriFiltre.SelectedIndex = 0;
            }
        }

        private void GridBaslikDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Parca_ID")) dgv.Columns["Parca_ID"].HeaderText = "ID";
            if (dgv.Columns.Contains("Parca_Ad")) dgv.Columns["Parca_Ad"].HeaderText = "Ürün Adı";
            if (dgv.Columns.Contains("Mevcut_Stok")) dgv.Columns["Mevcut_Stok"].HeaderText = "Stok";
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtParcaAdı.Text) || string.IsNullOrEmpty(txtStokAdedi.Text))
            {
                MessageBox.Show("Lütfen parça adı ve stok giriniz.");
                return false;
            }
            return true;
        }

        // --- KRİTİK STOK UYARISI ---
        private void KritikStokUyariVer(DataTable dt)
        {
            List<string> azalanUrunler = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                int stok = Convert.ToInt32(row["Mevcut_Stok"]);
                int kritik = 10;
                if (row["Kritik_Seviye"] != DBNull.Value)
                    kritik = Convert.ToInt32(row["Kritik_Seviye"]);

                string urunAd = row["Parca_Ad"].ToString();

                if (stok <= kritik)
                {
                    azalanUrunler.Add($"- {urunAd} (Stok: {stok})");
                }
            }

            if (azalanUrunler.Count > 0)
            {
                string mesaj = "⚠️ DİKKAT! KRİTİK STOK UYARISI ⚠️\n\nAşağıdaki ürünler bitmek üzere:\n" + string.Join("\n", azalanUrunler);
                MessageBox.Show(mesaj, "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvStok_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = dgvStok.Columns[e.ColumnIndex].Name;

            if (columnName == "Mevcut_Stok" || columnName.Contains("Stok") || columnName.Contains("stok"))
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int stok))
                {
                    int kritik = 10;
                    try
                    {
                        object kritikDeger = null;
                        if (dgvStok.Columns.Contains("Kritik_Seviye"))
                            kritikDeger = dgvStok.Rows[e.RowIndex].Cells["Kritik_Seviye"].Value;
                        else if (dgvStok.Columns.Contains("kritikSeviyeDataGridViewTextBoxColumn"))
                            kritikDeger = dgvStok.Rows[e.RowIndex].Cells["kritikSeviyeDataGridViewTextBoxColumn"].Value;

                        if (kritikDeger != null && kritikDeger != DBNull.Value)
                            kritik = Convert.ToInt32(kritikDeger);
                    }
                    catch { }

                    if (stok <= kritik)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.Font = new Font(dgvStok.Font, FontStyle.Bold);
                    }
                }
            }
        }


        private void dgvStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VeriAktar(dgvStok, e.RowIndex);
        }
        private void dgv_Parcalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VeriAktar(dgv_Parcalar, e.RowIndex);
        }

        private void VeriAktar(DataGridView dgv, int rowIndex)
        {
            if (rowIndex < 0) return;
            DataGridViewRow row = dgv.Rows[rowIndex];
            try
            {
                if (row.Cells["Parca_ID"] != null) secilenParcaID = Convert.ToInt32(row.Cells["Parca_ID"].Value);
                else if (row.Cells["parcaIDDataGridViewTextBoxColumn"] != null) secilenParcaID = Convert.ToInt32(row.Cells["parcaIDDataGridViewTextBoxColumn"].Value);

                var cellAd = row.Cells["Parca_Ad"] ?? row.Cells["parcaAdDataGridViewTextBoxColumn"];
                if (cellAd != null) txtParcaAdı.Text = cellAd.Value.ToString();

                var cellMarka = row.Cells["Marka-Model"] ?? row.Cells["acıklamaDataGridViewTextBoxColumn"];
                if (cellMarka != null) txtMarkaModel.Text = cellMarka.Value?.ToString();

                var cellStok = row.Cells["Mevcut_Stok"] ?? row.Cells["mevcutStokDataGridViewTextBoxColumn"];
                if (cellStok != null) txtStokAdedi.Text = cellStok.Value.ToString();

                var cellKritik = row.Cells["Kritik_Seviye"] ?? row.Cells["kritikSeviyeDataGridViewTextBoxColumn"];
                if (cellKritik != null) txtKritikSeviye.Text = cellKritik.Value.ToString();

                var cellKat = row.Cells["Kategori"] ?? row.Cells["kategoriDataGridViewTextBoxColumn"];
                if (cellKat != null) cmbKategori.Text = cellKat.Value.ToString();
            }
            catch { }
        }
    }
}