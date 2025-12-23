namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Kullanici_Giris
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblLoginSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Lnk_Sifre_Sıfırla = new System.Windows.Forms.LinkLabel();
            this.BTN_Temizle = new FontAwesome.Sharp.IconButton();
            this.BtnGiris = new FontAwesome.Sharp.IconButton();
            this.pnlBackground.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlBackground.Controls.Add(this.pnlForm);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 600);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.BtnGiris);
            this.pnlForm.Controls.Add(this.lblLoginTitle);
            this.pnlForm.Controls.Add(this.lblLoginSubtitle);
            this.pnlForm.Controls.Add(this.lblUsername);
            this.pnlForm.Controls.Add(this.txtUsername);
            this.pnlForm.Controls.Add(this.lblPassword);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.Lnk_Sifre_Sıfırla);
            this.pnlForm.Controls.Add(this.BTN_Temizle);
            this.pnlForm.Location = new System.Drawing.Point(75, 60);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(30);
            this.pnlForm.Size = new System.Drawing.Size(650, 480);
            this.pnlForm.TabIndex = 0;
            this.pnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlForm_Paint);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(113, 30);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(435, 74);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "🔐 Hoşgeldiniz";
            // 
            // lblLoginSubtitle
            // 
            this.lblLoginSubtitle.AutoSize = true;
            this.lblLoginSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLoginSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblLoginSubtitle.Location = new System.Drawing.Point(113, 75);
            this.lblLoginSubtitle.Name = "lblLoginSubtitle";
            this.lblLoginSubtitle.Size = new System.Drawing.Size(412, 30);
            this.lblLoginSubtitle.TabIndex = 1;
            this.lblLoginSubtitle.Text = "Lütfen giriş yapmak için bilgilerinizi giriniz";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(25, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(178, 30);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "👤 Kullanıcı Adı";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtUsername.Location = new System.Drawing.Point(27, 150);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(590, 45);
            this.txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(25, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 30);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "🔑 Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtPassword.Location = new System.Drawing.Point(27, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(590, 45);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Lnk_Sifre_Sıfırla
            // 
            this.Lnk_Sifre_Sıfırla.AutoSize = true;
            this.Lnk_Sifre_Sıfırla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnk_Sifre_Sıfırla.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Lnk_Sifre_Sıfırla.Location = new System.Drawing.Point(369, 305);
            this.Lnk_Sifre_Sıfırla.Name = "Lnk_Sifre_Sıfırla";
            this.Lnk_Sifre_Sıfırla.Size = new System.Drawing.Size(281, 32);
            this.Lnk_Sifre_Sıfırla.TabIndex = 3;
            this.Lnk_Sifre_Sıfırla.TabStop = true;
            this.Lnk_Sifre_Sıfırla.Text = "Şifrenizi mi unuttunuz?";
            this.Lnk_Sifre_Sıfırla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Sifre_Sıfırla_LinkClicked);
            // 
            // BTN_Temizle
            // 
            this.BTN_Temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.BTN_Temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Temizle.FlatAppearance.BorderSize = 0;
            this.BTN_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Temizle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Temizle.ForeColor = System.Drawing.Color.White;
            this.BTN_Temizle.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.BTN_Temizle.IconColor = System.Drawing.Color.White;
            this.BTN_Temizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Temizle.IconSize = 24;
            this.BTN_Temizle.Location = new System.Drawing.Point(30, 350);
            this.BTN_Temizle.Name = "BTN_Temizle";
            this.BTN_Temizle.Size = new System.Drawing.Size(280, 64);
            this.BTN_Temizle.TabIndex = 5;
            this.BTN_Temizle.Text = "Temizle";
            this.BTN_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Temizle.UseVisualStyleBackColor = false;
            this.BTN_Temizle.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatAppearance.BorderSize = 0;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BtnGiris.IconColor = System.Drawing.Color.White;
            this.BtnGiris.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGiris.IconSize = 24;
            this.BtnGiris.Location = new System.Drawing.Point(340, 350);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(280, 64);
            this.BtnGiris.TabIndex = 6;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // Kullanici_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kullanici_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis Otomasyonu - Giriş";
            this.Load += new System.EventHandler(this.Kullanici_Giris_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSubtitle;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel Lnk_Sifre_Sıfırla;
        private FontAwesome.Sharp.IconButton BTN_Temizle;
        private FontAwesome.Sharp.IconButton BtnGiris;
    }
}

