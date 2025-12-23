namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Admin_Ana_Panel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlMenuContainer = new System.Windows.Forms.Panel();
            this.btnPersonnel = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnFaults = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnReporting = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnExitSystem = new FontAwesome.Sharp.IconButton();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMenuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblAdminTitle);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdminTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(457, 65);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "🛡️  Yönetim Paneli";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(500, 40);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(317, 32);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "📅 02 Aralık 2025 - 12:00:00";
            // 
            // pnlMenuContainer
            // 
            this.pnlMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMenuContainer.Controls.Add(this.btnPersonnel);
            this.pnlMenuContainer.Controls.Add(this.btnCustomer);
            this.pnlMenuContainer.Controls.Add(this.btnFaults);
            this.pnlMenuContainer.Controls.Add(this.btnStock);
            this.pnlMenuContainer.Controls.Add(this.btnReporting);
            this.pnlMenuContainer.Controls.Add(this.btnAbout);
            this.pnlMenuContainer.Controls.Add(this.btnLogout);
            this.pnlMenuContainer.Controls.Add(this.btnExitSystem);
            this.pnlMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuContainer.Name = "pnlMenuContainer";
            this.pnlMenuContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMenuContainer.Size = new System.Drawing.Size(1400, 700);
            this.pnlMenuContainer.TabIndex = 0;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonnel.FlatAppearance.BorderSize = 0;
            this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnPersonnel.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnPersonnel.IconColor = System.Drawing.Color.White;
            this.btnPersonnel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonnel.Location = new System.Drawing.Point(20, 20);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(280, 120);
            this.btnPersonnel.TabIndex = 0;
            this.btnPersonnel.Text = "👥 Personel Yönetimi";
            this.btnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click_1);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnCustomer.IconColor = System.Drawing.Color.White;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.Location = new System.Drawing.Point(320, 20);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(280, 120);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "👨‍💼 Müşteri Yönetimi";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnFaults
            // 
            this.btnFaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnFaults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaults.FlatAppearance.BorderSize = 0;
            this.btnFaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaults.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFaults.ForeColor = System.Drawing.Color.White;
            this.btnFaults.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnFaults.IconColor = System.Drawing.Color.White;
            this.btnFaults.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFaults.Location = new System.Drawing.Point(620, 20);
            this.btnFaults.Name = "btnFaults";
            this.btnFaults.Size = new System.Drawing.Size(280, 120);
            this.btnFaults.TabIndex = 2;
            this.btnFaults.Text = "🔧 Arıza Kayıtları";
            this.btnFaults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaults.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnStock.IconColor = System.Drawing.Color.White;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.Location = new System.Drawing.Point(920, 20);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(280, 120);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "📦 Stok Yönetimi";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click_1);
            // 
            // btnReporting
            // 
            this.btnReporting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnReporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReporting.IconColor = System.Drawing.Color.White;
            this.btnReporting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporting.Location = new System.Drawing.Point(320, 165);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(280, 120);
            this.btnReporting.TabIndex = 4;
            this.btnReporting.Text = "📊 Raporlama";
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.Location = new System.Drawing.Point(620, 165);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(280, 120);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "ℹ️  Hakkımızda";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.Location = new System.Drawing.Point(1075, 432);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(313, 120);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪 Oturumu Kapat";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnExitSystem
            // 
            this.btnExitSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExitSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitSystem.FlatAppearance.BorderSize = 0;
            this.btnExitSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitSystem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnExitSystem.ForeColor = System.Drawing.Color.White;
            this.btnExitSystem.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExitSystem.IconColor = System.Drawing.Color.White;
            this.btnExitSystem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitSystem.Location = new System.Drawing.Point(1075, 568);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(313, 120);
            this.btnExitSystem.TabIndex = 7;
            this.btnExitSystem.Text = "⏻️  Sistemi Kapat";
            this.btnExitSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitSystem.UseVisualStyleBackColor = false;
            this.btnExitSystem.Click += new System.EventHandler(this.btnExitSystem_Click_1);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.TimerDateTime_Tick);
            // 
            // Admin_Ana_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMenuContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Admin_Ana_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Admin_Ana_Panel_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Label lblDateTime;

        private System.Windows.Forms.Panel pnlMenuContainer;
        private FontAwesome.Sharp.IconButton btnPersonnel;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnFaults;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnReporting;
        private FontAwesome.Sharp.IconButton btnAbout;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnExitSystem;

        private System.Windows.Forms.Timer timerDateTime;
    }
}