namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Sifre_Sifirla
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
            this.lblResetTitle = new System.Windows.Forms.Label();
            this.lblResetSubtitle = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.txtCaptchaCode = new System.Windows.Forms.TextBox();
            this.lblCaptchaImage = new System.Windows.Forms.Label();
            this.btnRefreshCaptcha = new FontAwesome.Sharp.IconButton();
            this.btnResetPassword = new FontAwesome.Sharp.IconButton();
            this.btnBackToLogin = new FontAwesome.Sharp.IconButton();
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
            this.pnlBackground.Size = new System.Drawing.Size(800, 700);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.lblResetTitle);
            this.pnlForm.Controls.Add(this.lblResetSubtitle);
            this.pnlForm.Controls.Add(this.lblNewPassword);
            this.pnlForm.Controls.Add(this.txtNewPassword);
            this.pnlForm.Controls.Add(this.lblConfirmPassword);
            this.pnlForm.Controls.Add(this.txtConfirmPassword);
            this.pnlForm.Controls.Add(this.lblCaptcha);
            this.pnlForm.Controls.Add(this.txtCaptchaCode);
            this.pnlForm.Controls.Add(this.lblCaptchaImage);
            this.pnlForm.Controls.Add(this.btnRefreshCaptcha);
            this.pnlForm.Controls.Add(this.btnResetPassword);
            this.pnlForm.Controls.Add(this.btnBackToLogin);
            this.pnlForm.Location = new System.Drawing.Point(67, 35);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(30);
            this.pnlForm.Size = new System.Drawing.Size(650, 605);
            this.pnlForm.TabIndex = 0;
            this.pnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlForm_Paint);
            // 
            // lblResetTitle
            // 
            this.lblResetTitle.AutoSize = true;
            this.lblResetTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblResetTitle.Location = new System.Drawing.Point(115, 0);
            this.lblResetTitle.Name = "lblResetTitle";
            this.lblResetTitle.Size = new System.Drawing.Size(411, 74);
            this.lblResetTitle.TabIndex = 0;
            this.lblResetTitle.Text = "🔐 Şifre Sıfırla";
            // 
            // lblResetSubtitle
            // 
            this.lblResetSubtitle.AutoSize = true;
            this.lblResetSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblResetSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblResetSubtitle.Location = new System.Drawing.Point(52, 74);
            this.lblResetSubtitle.Name = "lblResetSubtitle";
            this.lblResetSubtitle.Size = new System.Drawing.Size(550, 30);
            this.lblResetSubtitle.TabIndex = 1;
            this.lblResetSubtitle.Text = "Lütfen yeni şifrenizi giriniz ve doğrulamayı tamamlayınız";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNewPassword.Location = new System.Drawing.Point(30, 115);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(145, 30);
            this.lblNewPassword.TabIndex = 2;
            this.lblNewPassword.Text = "🔑 Yeni Şifre";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNewPassword.Location = new System.Drawing.Point(30, 145);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(590, 39);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 187);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(193, 30);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "🔑 Şifreyi Onayla";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 220);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(590, 37);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCaptcha.Location = new System.Drawing.Point(20, 280);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(272, 30);
            this.lblCaptcha.TabIndex = 4;
            this.lblCaptcha.Text = "🤖 Captcha Doğrulaması";
            // 
            // txtCaptchaCode
            // 
            this.txtCaptchaCode.BackColor = System.Drawing.Color.White;
            this.txtCaptchaCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptchaCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptchaCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtCaptchaCode.Location = new System.Drawing.Point(25, 394);
            this.txtCaptchaCode.Name = "txtCaptchaCode";
            this.txtCaptchaCode.Size = new System.Drawing.Size(590, 39);
            this.txtCaptchaCode.TabIndex = 4;
            this.txtCaptchaCode.Text = "Kodu giriniz...";
            // 
            // lblCaptchaImage
            // 
            this.lblCaptchaImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblCaptchaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaptchaImage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCaptchaImage.ForeColor = System.Drawing.Color.White;
            this.lblCaptchaImage.Location = new System.Drawing.Point(25, 312);
            this.lblCaptchaImage.Name = "lblCaptchaImage";
            this.lblCaptchaImage.Size = new System.Drawing.Size(450, 60);
            this.lblCaptchaImage.TabIndex = 2;
            this.lblCaptchaImage.Text = "12AB45CD";
            this.lblCaptchaImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefreshCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCaptcha.FlatAppearance.BorderSize = 0;
            this.btnRefreshCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCaptcha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefreshCaptcha.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCaptcha.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnRefreshCaptcha.IconColor = System.Drawing.Color.White;
            this.btnRefreshCaptcha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshCaptcha.IconSize = 20;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(490, 312);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(130, 60);
            this.btnRefreshCaptcha.TabIndex = 3;
            this.btnRefreshCaptcha.Text = "Yenile";
            this.btnRefreshCaptcha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCaptcha.UseVisualStyleBackColor = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnResetPassword.IconColor = System.Drawing.Color.White;
            this.btnResetPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetPassword.IconSize = 24;
            this.btnResetPassword.Location = new System.Drawing.Point(25, 452);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(280, 67);
            this.btnResetPassword.TabIndex = 5;
            this.btnResetPassword.Text = "Şifremi Sıfırla";
            this.btnResetPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click_1);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBackToLogin.IconColor = System.Drawing.Color.White;
            this.btnBackToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackToLogin.IconSize = 24;
            this.btnBackToLogin.Location = new System.Drawing.Point(337, 452);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(280, 67);
            this.btnBackToLogin.TabIndex = 6;
            this.btnBackToLogin.Text = "Giriş Ekranına Dön";
            this.btnBackToLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // Sifre_Sifirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sifre_Sifirla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırla - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Sifre_Sifirla_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlForm;

        private System.Windows.Forms.Label lblResetTitle;
        private System.Windows.Forms.Label lblResetSubtitle;

        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;

        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Label lblCaptchaImage;
        private System.Windows.Forms.TextBox txtCaptchaCode;
        private FontAwesome.Sharp.IconButton btnRefreshCaptcha;

        private FontAwesome.Sharp.IconButton btnResetPassword;
        private FontAwesome.Sharp.IconButton btnBackToLogin;
    }
}