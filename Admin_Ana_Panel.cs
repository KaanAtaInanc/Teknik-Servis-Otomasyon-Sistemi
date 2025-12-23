using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    public partial class Admin_Ana_Panel : Form
    {
        public Admin_Ana_Panel()
        {
            InitializeComponent();
        }

        private void Admin_Ana_Panel_Load(object sender, EventArgs e)
        {
            this.UpdateDateTime();
            this.SubscribeToEvents();
        }

        
        private void UpdateDateTime()
        {
            this.lblDateTime.Text = $"📅 {DateTime.Now:dd MMMM yyyy} - {DateTime.Now:HH:mm:ss}";
        }

        
        private void SubscribeToEvents()
        {
            this.btnPersonnel.Click += new System.EventHandler(this.BtnPersonnel_Click);
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            this.btnFaults.Click += new System.EventHandler(this.BtnFaults_Click);
            this.btnStock.Click += new System.EventHandler(this.BtnStock_Click);
            this.btnReporting.Click += new System.EventHandler(this.BtnReporting_Click);
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            this.btnExitSystem.Click += new System.EventHandler(this.BtnExitSystem_Click);

            // Timer başlat
            this.timerDateTime.Start();
        }

       
        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            this.UpdateDateTime();
        }

       
        private void BtnPersonnel_Click(object sender, EventArgs e)
        {
            Personel_Yonetim form = new Personel_Yonetim();
            form.ShowDialog();
        }

        
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Musteri_Yonetim_Form form = new Musteri_Yonetim_Form();
            form.ShowDialog();
        }

       
        private void BtnFaults_Click(object sender, EventArgs e)
        {
            Ariza_Paneli form = new Ariza_Paneli();
            form.ShowDialog();
        }

     
        private void BtnStock_Click(object sender, EventArgs e)
        {
            Stok_Takip form = new Stok_Takip();
            form.ShowDialog();
        }

        
        private void BtnReporting_Click(object sender, EventArgs e)
        {
            Raporlama_Paneli form = new Raporlama_Paneli();
            form.ShowDialog();
        }

       
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Teknik Servis Otomasyon Sistemi v1.0\n\n" +
                "Bu uygulama teknik servis hizmetlerinin yönetilmesini sağlayan\n" +
                "kapsamlı bir otomasyon sistemidir.\n\n" +
                "© 2025 Tüm Hakları Saklıdır.",
                "Hakkımızda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "⚠️  Oturumu Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.timerDateTime.Stop();
                this.Hide(); // Mevcut formu gizle
                Kullanici_Giris frm = new Kullanici_Giris();
                frm.Show(); // Giriş ekranını aç
            }
        }

       
        private void BtnExitSystem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?\n\nHerhangi bir kaydedilmemiş veri kaybolabilir.", "⚠️ Sistemi Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.timerDateTime.Stop(); // Varsa zamanlayıcıyı durdur
                Application.Exit();        // Uygulamadan çık
            }
        }

        private void btnReporting_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPersonnel_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExitSystem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
