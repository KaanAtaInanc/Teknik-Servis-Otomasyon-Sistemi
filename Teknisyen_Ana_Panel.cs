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
    public partial class Teknisyen_Ana_Panel : Form
    {
        
        private int currentTechnicianId = 0;
        private string currentTechnicianName = "";

        public Teknisyen_Ana_Panel()
        {
            InitializeComponent();
        }

        
        public Teknisyen_Ana_Panel(int technicianId, string technicianName)
        {
            InitializeComponent();
            this.currentTechnicianId = technicianId;
            this.currentTechnicianName = technicianName;
        }

        private void Teknisyen_Ana_Panel_Load(object sender, EventArgs e)
        {
            this.LoadTechnicianInfo();
            this.SubscribeToEvents();
        }

       
        private void LoadTechnicianInfo()
        {
            if (string.IsNullOrEmpty(this.currentTechnicianName))
            {
                this.currentTechnicianName = "Teknisyen";
            }

            this.lblTechnicianInfo.Text = $"👤 Teknisyen: {this.currentTechnicianName}";
        }

        
        private void SubscribeToEvents()
        {
            this.btnAssignedTasks.Click += new System.EventHandler(this.BtnAssignedTasks_Click);
            //this.btnTodoList.Click += new System.EventHandler(this.BtnTodoList_Click);
            this.btnLogoutSession.Click += new System.EventHandler(this.BtnLogoutSession_Click);
            this.btnExitSystem.Click += new System.EventHandler(this.BtnExitSystem_Click);
        }

        private void BtnAssignedTasks_Click(object sender, EventArgs e)
        {
            Atanan_Islemler form = new Atanan_Islemler(this.currentTechnicianId, this.currentTechnicianName);
            form.ShowDialog();
            
        }
        private void BtnTodoList_Click(object sender, EventArgs e)
        {
            //TodoList_Panel form = new TodoList_Panel(this.currentTechnicianId, this.currentTechnicianName);
            //form.ShowDialog();
        }
        private void BtnLogoutSession_Click(object sender, EventArgs e)
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
        private void BtnExitSystem_Click(object sender, EventArgs e)
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
        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            this.lblTechnicianInfo.Text = $"👤 Teknisyen: {this.currentTechnicianName} | 📅 {DateTime.Now:dd.MM.yyyy HH:mm:ss}";
        }

        private void btnAssignedTasks_Click_1(object sender, EventArgs e)
        {

        }
    }
}
