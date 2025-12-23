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
    public partial class Sifre_Sifirla : Form
    {
        
        private string validCaptchaCode;

        public Sifre_Sifirla()
        {
            InitializeComponent();
        }

        private void Sifre_Sifirla_Load(object sender, EventArgs e)
        {
            this.GenerateCaptcha();
            this.SubscribeToEvents();
        }

        
        private void GenerateCaptcha()
        {
            //Captcha kodunun oluşturulması 
            // Rastgele 8 karakterlik kod oluştur
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ*#/";
            Random random = new Random();
            this.validCaptchaCode = "";

            for (int i = 0; i < 8; i++)
            {
                this.validCaptchaCode += chars[random.Next(chars.Length)];
            }

            this.lblCaptchaImage.Text = this.validCaptchaCode;
        }

        private void SubscribeToEvents()
        {
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.BtnRefreshCaptcha_Click);
            this.btnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            this.btnBackToLogin.Click += new System.EventHandler(this.BtnBackToLogin_Click);
        }

        
        private void BtnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            this.GenerateCaptcha();
        }



        SqlConnection baglantı = new SqlConnection("Data Source=Kaan_Ata\\KAAN_ATA;Initial Catalog=Teknik_Servis_DB;Integrated Security=True;");
        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            // Doğrulama İşlemlerinin ve Eksik Boşluk Kontrollerinin Yapılması
            if (string.IsNullOrWhiteSpace(this.txtNewPassword.Text)) //Yeni Şifre Alananın Boş Olup Olmadığını Kontrol Et
            {
                MessageBox.Show("Lütfen yeni şifre giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewPassword.Focus(); 
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtConfirmPassword.Text)) //Yeni Şifre Tekrar Alanının Boş Olup Olmadığını Kontrol Et
            {
                MessageBox.Show("Lütfen şifreyi onaylayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtConfirmPassword.Focus();
                return;
            }

            if (this.txtNewPassword.Text != this.txtConfirmPassword.Text) //Yeni Şifre ile Yeni Şifre Tekrar Alanlarının Eşleşip Eşleşmediğini Kontrol Et
            {
                MessageBox.Show("Şifreler eşleşmiyor. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNewPassword.Clear();
                this.txtConfirmPassword.Clear();
                return;
            }

            if (this.txtNewPassword.Text.Length < 8) //Yeni Şifrenin Uzunluğunun Minimum 8 Karakter Olduğunu Kontrol Et
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtCaptchaCode.Text)) //Captcha Kodunun Boş Olup Olmadığını Kontrol Et
            {
                MessageBox.Show("Lütfen Captcha kodunu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCaptchaCode.Focus();
                return;
            }

            if (this.txtCaptchaCode.Text.ToUpper() != this.validCaptchaCode) //Captcha Kodunun Doğru Girilip Girilmediğini Kontrol Et   
            {
                MessageBox.Show("Captcha kodu hatalı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCaptchaCode.Clear();
                this.GenerateCaptcha();
                return;
            }
            //Database İşlemlerinin Olacağı Alan
            //Kullanıcı Burada Şifre Değiştirdiği İçin SQL Sorgusu "UPDATE"(Güncelle) Olarak Yazılır
            try
            {
                if(baglantı.State == ConnectionState.Closed)
                    baglantı.Open();

                
                //ilkGirisMi kısmını =0 yapıyoruz ki kullanıcı sürekli yeni şifre belirlemek zorunda olmasın
                string sorgu = "Update Personeller Set SifreHash = @yeniSifre, İlkGirisMi = 0 Where Personel_ID=@id"; //Burada Oturum.Personel_ID kullanılmaktadır. (Sorgular da hata olmaması) için
                SqlCommand komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@yeniSifre", txtNewPassword.Text.Trim());
                komut.Parameters.AddWithValue("@id", Oturum.PersonelID);

                int sonuc = komut.ExecuteNonQuery(); //İşlemi yap
                baglantı.Close();
                if(sonuc > 0)
                {
                    MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir Yeni Şifrenizle Giriş Yapabilirsiniz", "Bilgi");

                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Şifre Değiştirilemedi Lütfen Tekrar Deneyiniz", "UYARI");
                }
            }
            catch(Exception ex)
            {
                if (baglantı.State == System.Data.ConnectionState.Open)
                    baglantı.Close();

                MessageBox.Show("Sistemsel Bir Hata Oluştu Lütfen Tekrar Deneyiniz");
            }

            /*
            this.Close();
            Kullanici_Giris loginForm = new Kullanici_Giris();
            loginForm.Show();
            */
        }

        
        private void BtnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Kullanici_Giris loginForm = new Kullanici_Giris();
            loginForm.Show();
        }

        
        private void PnlForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(200, 200, 200), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.pnlForm.Width - 1, this.pnlForm.Height - 1);
            }
        }

        private void btnResetPassword_Click_1(object sender, EventArgs e)
        {

        }
    }
}
