using MetroFramework.Forms;
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
    public partial class Personel_Yonetim : Form
    {
        public Personel_Yonetim()
        {
            InitializeComponent();
        }

        private void Personel_Yonetim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'teknik_Servis_DBDataSet5.Personeller' tablosuna veri yükler.
            //this.personellerTableAdapter.Fill(this.teknik_Servis_DBDataSet5.Personeller);
            this.ApplyModernStyling();
            this.LoadInitialData();
            Listele(); // Form yüklenince listeyi getir
        }

        private void ApplyModernStyling()
        {
            // TabControl özelleştirme
            this.tabControlMain.Appearance = TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 40);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // DataGridView stillendirme
            this.StyleDataGridView(this.dgv_Personeller);
            this.StyleDataGridView(this.dgvPerformanceList);
            this.StyleDataGridView(this.dgvIssueTypes);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.GridColor = System.Drawing.Color.FromArgb(189, 195, 199);
        }

        private void LoadInitialData()
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXT_Ad_TextChanged(object sender, EventArgs e)
        {
        }

      

        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");

        private void dgv_Personeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Listede boş bir yere tıklanırsa hata vermesin diye kontrol
            if (e.RowIndex >= 0)
            {
                // DataGridView'deki satırdan verileri alıp kutulara dolduruyoruz
                TXT_ID.Text = dgv_Personeller.Rows[e.RowIndex].Cells["Personel_ID"].Value.ToString();
                TXT_Ad.Text = dgv_Personeller.Rows[e.RowIndex].Cells["Ad"].Value.ToString();
                TXT_Soyad.Text = dgv_Personeller.Rows[e.RowIndex].Cells["Soyad"].Value.ToString();
                TXT_Kullanici_Ad.Text = dgv_Personeller.Rows[e.RowIndex].Cells["Kullanici_Ad"].Value.ToString();
                txtPassword.Text = ""; // Şifreyi güvenlik gereği boş getirebiliriz veya hashli hali gelebilir

                // Rolü ComboBox'a getirmek için (Hücredeki değere göre)
                // Eğer gridde direkt "Admin", "Teknisyen" yazıyorsa:
                // cmbRol.Text = dgv_Personeller.Rows[e.RowIndex].Cells["Rol"].Value.ToString();
            }
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From dbo.Personeller", baglanti);
            DataTable Dt = new DataTable();
            da.Fill(Dt);
            dgv_Personeller.DataSource = Dt;

            // Sütun adlarını DataTable sütunlarına eşleme
            dgv_Personeller.Columns[0].Name = "Personel_ID";
            dgv_Personeller.Columns[1].Name = "Rol_ID";
            dgv_Personeller.Columns[2].Name = "Ad";
            dgv_Personeller.Columns[3].Name = "Soyad";
            dgv_Personeller.Columns[4].Name = "Kullanici_Ad";
            dgv_Personeller.Columns[5].Name = "SifreHash";
            dgv_Personeller.Columns[6].Name = "AktifMi";
            dgv_Personeller.Columns[7].Name = "İlkGirisMi";
        }

        private void pnlOperations_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Ekle_Click(object sender, EventArgs e)
        {
            int secilenRolID = 2;
            if (cmbRol.Text == "Admin") secilenRolID = 1;
            else if (cmbRol.Text == "Teknisyen") secilenRolID = 2;
            else if (cmbRol.Text == "Danışma") secilenRolID = 3;


            string connectionString = "Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;";

            using (SqlConnection localBaglanti = new SqlConnection(connectionString))
            {
                try
                {
                    localBaglanti.Open(); // Sadece bu işlem için açılır

                    string sorgu = "INSERT INTO dbo.Personeller (Rol_ID, Ad, Soyad, Kullanici_Ad, SifreHash, AktifMi, İlkGirisMi, MesgulMu) VALUES (@p1, @p2, @p3, @p4, @p5, 1, 1, 0)";

                    using (SqlCommand komut = new SqlCommand(sorgu, localBaglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", secilenRolID);
                        komut.Parameters.AddWithValue("@p2", TXT_Ad.Text);
                        komut.Parameters.AddWithValue("@p3", TXT_Soyad.Text);
                        komut.Parameters.AddWithValue("@p4", TXT_Kullanici_Ad.Text);
                        komut.Parameters.AddWithValue("@p5", txtPassword.Text);

                        komut.ExecuteNonQuery(); // Hızlıca ekler
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    return; // Hata varsa Listele'yi çağırma
                }
            }

            MessageBox.Show("Personel Eklendi.");


            Listele();
        }

        private void BTN_Düzenle_Click(object sender, EventArgs e)
        {
            // 1. Rolü belirliyoruz
            int secilenRolID = 2;
            if (cmbRol.Text == "Admin") secilenRolID = 1;
            else if (cmbRol.Text == "Teknisyen") secilenRolID = 2;
            else if (cmbRol.Text == "Danışma") secilenRolID = 3;

            string connectionString = "Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;";

            using (SqlConnection localBaglanti = new SqlConnection(connectionString))
            {
                try
                {
                    localBaglanti.Open();

                    string sorgu = "UPDATE dbo.Personeller SET Rol_ID=@r1, Ad=@p2, Soyad=@p3, Kullanici_Ad=@p4, SifreHash=@p5 WHERE Personel_ID=@id";

                    using (SqlCommand komut = new SqlCommand(sorgu, localBaglanti))
                    {
                        komut.Parameters.AddWithValue("@r1", secilenRolID);
                        komut.Parameters.AddWithValue("@p2", TXT_Ad.Text);
                        komut.Parameters.AddWithValue("@p3", TXT_Soyad.Text);
                        komut.Parameters.AddWithValue("@p4", TXT_Kullanici_Ad.Text);
                        komut.Parameters.AddWithValue("@p5", txtPassword.Text);
                        komut.Parameters.AddWithValue("@id", TXT_ID.Text);

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Bilgiler güncellendi.");
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void BTN_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;"))
                    {
                        baglanti.Open();

                        // Kutudaki ID'yi alarak siliyoruz
                        SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE Personel_ID=@p1", baglanti);
                        komut.Parameters.AddWithValue("@p1", TXT_ID.Text);

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Personel silindi.");
                    Listele(); // Silinen kişi listeden gitsin diye yeniliyoruz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_Temizle_Click(object sender, EventArgs e)
        {
            TXT_ID.Text = "";
            TXT_Ad.Text = "";
            TXT_Soyad.Text = "";
            TXT_Kullanici_Ad.Text = "";
            txtPassword.Text = "";
            cmbRol.SelectedIndex = -1;

        }

        private void BTN_Ana_Sayfa_Click(object sender, EventArgs e)
        {
            Admin_Ana_Panel frm = new Admin_Ana_Panel();
            frm.Show();
            this.Hide();
        }
    } 
} 