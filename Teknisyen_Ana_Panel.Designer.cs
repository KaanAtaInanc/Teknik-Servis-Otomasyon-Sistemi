namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Teknisyen_Ana_Panel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTechnicianInfo = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.pnlMenuContainer = new System.Windows.Forms.Panel();
            this.btnAssignedTasks = new FontAwesome.Sharp.IconButton();
            this.btnLogoutSession = new FontAwesome.Sharp.IconButton();
            this.btnExitSystem = new FontAwesome.Sharp.IconButton();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlMenuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblTechnicianInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔧 Teknisyen Paneli";
            // 
            // lblTechnicianInfo
            // 
            this.lblTechnicianInfo.AutoSize = true;
            this.lblTechnicianInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTechnicianInfo.ForeColor = System.Drawing.Color.White;
            this.lblTechnicianInfo.Location = new System.Drawing.Point(500, 35);
            this.lblTechnicianInfo.Name = "lblTechnicianInfo";
            this.lblTechnicianInfo.Size = new System.Drawing.Size(298, 32);
            this.lblTechnicianInfo.TabIndex = 1;
            this.lblTechnicianInfo.Text = "👤 Teknisyen: Yükleniyor...";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 24;
            this.btnLogout.Location = new System.Drawing.Point(1320, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Çıkış Yap";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlMenuContainer
            // 
            this.pnlMenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlMenuContainer.Controls.Add(this.btnAssignedTasks);
            this.pnlMenuContainer.Controls.Add(this.btnLogoutSession);
            this.pnlMenuContainer.Controls.Add(this.btnExitSystem);
            this.pnlMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlMenuContainer.Name = "pnlMenuContainer";
            this.pnlMenuContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMenuContainer.Size = new System.Drawing.Size(1400, 644);
            this.pnlMenuContainer.TabIndex = 0;
            // 
            // btnAssignedTasks
            // 
            this.btnAssignedTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAssignedTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignedTasks.FlatAppearance.BorderSize = 0;
            this.btnAssignedTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignedTasks.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAssignedTasks.ForeColor = System.Drawing.Color.White;
            this.btnAssignedTasks.IconChar = FontAwesome.Sharp.IconChar.SquareCheck;
            this.btnAssignedTasks.IconColor = System.Drawing.Color.White;
            this.btnAssignedTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssignedTasks.Location = new System.Drawing.Point(177, 23);
            this.btnAssignedTasks.Name = "btnAssignedTasks";
            this.btnAssignedTasks.Size = new System.Drawing.Size(280, 120);
            this.btnAssignedTasks.TabIndex = 0;
            this.btnAssignedTasks.Text = "📋 Atanan İşlemlerim";
            this.btnAssignedTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAssignedTasks.UseVisualStyleBackColor = false;
            this.btnAssignedTasks.Click += new System.EventHandler(this.btnAssignedTasks_Click_1);
            // 
            // btnLogoutSession
            // 
            this.btnLogoutSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnLogoutSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutSession.FlatAppearance.BorderSize = 0;
            this.btnLogoutSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutSession.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogoutSession.ForeColor = System.Drawing.Color.White;
            this.btnLogoutSession.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogoutSession.IconColor = System.Drawing.Color.White;
            this.btnLogoutSession.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogoutSession.Location = new System.Drawing.Point(494, 23);
            this.btnLogoutSession.Name = "btnLogoutSession";
            this.btnLogoutSession.Size = new System.Drawing.Size(280, 120);
            this.btnLogoutSession.TabIndex = 2;
            this.btnLogoutSession.Text = "🚪 Oturumu Kapat";
            this.btnLogoutSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogoutSession.UseVisualStyleBackColor = false;
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
            this.btnExitSystem.Location = new System.Drawing.Point(819, 23);
            this.btnExitSystem.Name = "btnExitSystem";
            this.btnExitSystem.Size = new System.Drawing.Size(280, 120);
            this.btnExitSystem.TabIndex = 3;
            this.btnExitSystem.Text = "⏻️  Sistemi Kapat";
            this.btnExitSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitSystem.UseVisualStyleBackColor = false;
            // 
            // timerDateTime
            // 
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.TimerDateTime_Tick);
            // 
            // Teknisyen_Ana_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1400, 744);
            this.Controls.Add(this.pnlMenuContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Teknisyen_Ana_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknisyen Paneli - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Teknisyen_Ana_Panel_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTechnicianInfo;
        private FontAwesome.Sharp.IconButton btnLogout;

        private System.Windows.Forms.Panel pnlMenuContainer;
        private FontAwesome.Sharp.IconButton btnAssignedTasks;
        private FontAwesome.Sharp.IconButton btnLogoutSession;
        private FontAwesome.Sharp.IconButton btnExitSystem;

        private System.Windows.Forms.Timer timerDateTime;
    }
}