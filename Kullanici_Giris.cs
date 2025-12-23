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
using TeknikServisOtomasyonu;



namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Kullanici_Giris : Form
    {
        public Kullanici_Giris()
        {
            InitializeComponent();
        }

        private void Kullanici_Giris_Load(object sender, EventArgs e)
        {
            this.ApplyModernStyling();
            this.SubscribeToEvents();
        }

        
        private void ApplyModernStyling()
        {
            // TextBox stillendirmesi
            this.StyleTextBox(this.txtUsername);
            this.StyleTextBox(this.txtPassword);

            // Form merkezde konumlandır
            this.CenterToScreen();
        }

        
        private void StyleTextBox(TextBox txt)
        {
            txt.BackColor = System.Drawing.Color.White;
            txt.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        
        private void SubscribeToEvents()
        {
            this.BtnGiris.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BTN_Temizle.Click += new System.EventHandler(this.BtnReset_Click);
            this.Lnk_Sifre_Sıfırla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgotPassword_LinkClicked);
        }


        SqlConnection baglanti = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }

        
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            //this.chkRememberMe.Checked = false;
            this.txtUsername.Focus();
        }

      
        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

      
        private void PnlForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(System.Drawing.Color.FromArgb(200, 200, 200), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlForm.Width - 1, this.pnlForm.Height - 1);
            }
        }

      

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void Lnk_Sifre_Sıfırla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Kullanıcı Adı Girilmiş mi Kontrolü
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Şifre Sıfırlamak İçin Öncelikle Kullanıcı Adını Giriniz ve 'Şifremi Unuttum'a basınız ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "Select Personel_ID, Ad, Soyad From Personeller Where Kullanici_Ad=@kadi And Aktifmi=1"; //Where şartı ile sql sorgusu 

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@kadi", txtUsername.Text.Trim()); //kadi parametresi ile sorgulama

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    // -- Kullanıcı Bulundu --

                    Oturum.PersonelID = int.Parse(dr["Personel_ID"].ToString());
                    Oturum.AdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();

                    dr.Close();
                    baglanti.Close();

                    MessageBox.Show("Kullanıcı doğrulandı! Lütfen yeni şifrenizi belirleyin.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Sifre_Sifirla form = new Sifre_Sifirla(); 
                    form.Show();
                    this.Hide();
                }
                else
                {
                    // -- Kullanıcı Bulunamadı --
                    dr.Close();
                    baglanti.Close();
                    MessageBox.Show("Bu Kullanıcı Adına Ait Aktif Bir Kayıt Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                
                MessageBox.Show("Sistemsel Bir Hata Oldu: " + ex.Message);
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü (Senin kodundaki gibi kalsın)
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                string sorgu = "SELECT p.Personel_ID, p.Ad, p.Soyad, r.Rol_Ad, p.İlkGirisMi " +
                               "FROM Personeller p " +
                               "INNER JOIN Roller r ON p.Rol_ID = r.Rol_ID " +
                               "WHERE p.Kullanici_Ad = @p1 AND p.SifreHash = @p2 AND p.AktifMi = 1";

                System.Data.SqlClient.SqlCommand komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtUsername.Text.Trim());
                komut.Parameters.AddWithValue("@p2", txtPassword.Text.Trim());

                System.Data.SqlClient.SqlDataReader dr = komut.ExecuteReader();


                if (dr.Read())
                {
                    // Verileri al
                    Oturum.PersonelID = int.Parse(dr["Personel_ID"].ToString());
                    Oturum.AdSoyad = dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
                    Oturum.Rol = dr["Rol_Ad"].ToString();
                    bool ilkGiris = bool.Parse(dr["İlkGirisMi"].ToString());

                    dr.Close(); 

                   
                    if (ilkGiris)
                    {
                        MessageBox.Show("İlk girişiniz! Güvenlik için şifrenizi değiştirmeniz gerekmektedir.",
                                        "Şifre Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    // -----------------------------

                    // Eğer ilk giriş değilse normal akış devam edecektir
                    MessageBox.Show($"Hoşgeldiniz Sayın {Oturum.AdSoyad}", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // Giriş formunu gizle

                    // Rol Kontrolü ve Yönlendirme
                    if (Oturum.Rol == "Admin")
                    {
                        Admin_Ana_Panel frm = new Admin_Ana_Panel();
                        frm.Show();
                    }
                    else if (Oturum.Rol == "Teknisyen")
                    {
                        Teknisyen_Ana_Panel frm = new Teknisyen_Ana_Panel();
                        frm.Show();
                    }
                    else if (Oturum.Rol == "Danisma")
                    {
                        Danisma_Panel frm = new Danisma_Panel();
                        frm.Show();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open)
                   baglanti.Close();
            
            }
        }
    
    }
}
