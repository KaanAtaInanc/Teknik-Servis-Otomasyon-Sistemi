namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Personel_Yonetim
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
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_Personeller = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teknik_Servis_DBDataSet5 = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet5();
            this.pnlStaffForm = new System.Windows.Forms.Panel();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.TXT_Kullanici_Ad = new System.Windows.Forms.TextBox();
            this.TXT_Soyad = new System.Windows.Forms.TextBox();
            this.TXT_Ad = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.BTN_Sil = new FontAwesome.Sharp.IconButton();
            this.BTN_Ekle = new FontAwesome.Sharp.IconButton();
            this.BTN_Düzenle = new FontAwesome.Sharp.IconButton();
            this.tabPagePerformance = new System.Windows.Forms.TabPage();
            this.pnlPerformance = new System.Windows.Forms.Panel();
            this.pnlPerformanceCards = new System.Windows.Forms.Panel();
            this.lblPerformanceTitle = new System.Windows.Forms.Label();
            this.lblSelectedStaffName = new System.Windows.Forms.Label();
            this.txtSelectedStaffName = new System.Windows.Forms.TextBox();
            this.lblSelectedStaffSurname = new System.Windows.Forms.Label();
            this.txtSelectedStaffSurname = new System.Windows.Forms.TextBox();
            this.lblResolvedIssues = new System.Windows.Forms.Label();
            this.txtResolvedIssues = new System.Windows.Forms.TextBox();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.txtAverageTime = new System.Windows.Forms.TextBox();
            this.btnTracking = new FontAwesome.Sharp.IconButton();
            this.dgvPerformanceList = new System.Windows.Forms.DataGridView();
            this.dgvIssueTypes = new System.Windows.Forms.DataGridView();
            this.pnlDataGridPerformance = new System.Windows.Forms.Panel();
            this.dgvStaffDetails = new System.Windows.Forms.DataGridView();
            this.personellerTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet5TableAdapters.PersonellerTableAdapter();
            this.TXT_Temizle = new FontAwesome.Sharp.IconButton();
            this.BTN_Ana_Sayfa = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet5)).BeginInit();
            this.pnlStaffForm.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.tabPagePerformance.SuspendLayout();
            this.pnlPerformance.SuspendLayout();
            this.pnlPerformanceCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformanceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1595, 80);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(513, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 Personel Yönetimi";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 24;
            this.btnHome.Location = new System.Drawing.Point(2715, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOperations);
            this.tabControlMain.Controls.Add(this.tabPagePerformance);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 80);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1595, 829);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageOperations.Controls.Add(this.pnlOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 37);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageOperations.Size = new System.Drawing.Size(1587, 788);
            this.tabPageOperations.TabIndex = 0;
            this.tabPageOperations.Text = "⚙️  İşlemler";
            // 
            // pnlOperations
            // 
            this.pnlOperations.AutoScroll = true;
            this.pnlOperations.BackColor = System.Drawing.Color.White;
            this.pnlOperations.Controls.Add(this.BTN_Ana_Sayfa);
            this.pnlOperations.Controls.Add(this.textBox1);
            this.pnlOperations.Controls.Add(this.dgv_Personeller);
            this.pnlOperations.Controls.Add(this.pnlStaffForm);
            this.pnlOperations.Controls.Add(this.pnlActionButtons);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperations.Location = new System.Drawing.Point(10, 10);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(1567, 768);
            this.pnlOperations.TabIndex = 0;
            this.pnlOperations.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOperations_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 546);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(596, 219);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Rol_ID kolonu Rol türlerini özel isimleri ile tutmaktadır.\r\nID = 1 -> Admin Rolü\r" +
    "\nID = 2 -> Teknisyen Rolü\r\nID= 3 -> Danışma Personel Rolü\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_Personeller
            // 
            this.dgv_Personeller.AllowUserToAddRows = false;
            this.dgv_Personeller.AutoGenerateColumns = false;
            this.dgv_Personeller.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Personeller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Personeller.ColumnHeadersHeight = 35;
            this.dgv_Personeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Personeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dgv_Personeller.DataSource = this.personellerBindingSource;
            this.dgv_Personeller.Location = new System.Drawing.Point(713, 10);
            this.dgv_Personeller.Name = "dgv_Personeller";
            this.dgv_Personeller.ReadOnly = true;
            this.dgv_Personeller.RowHeadersVisible = false;
            this.dgv_Personeller.RowHeadersWidth = 62;
            this.dgv_Personeller.RowTemplate.Height = 28;
            this.dgv_Personeller.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_Personeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Personeller.Size = new System.Drawing.Size(843, 530);
            this.dgv_Personeller.TabIndex = 2;
            this.dgv_Personeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Personeller_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Personel_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Personel_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rol_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rol_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 96;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kullanici_Ad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kullanici_Ad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SifreHash";
            this.dataGridViewTextBoxColumn6.HeaderText = "SifreHash";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AktifMi";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AktifMi";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 95;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "İlkGirisMi";
            this.dataGridViewCheckBoxColumn2.HeaderText = "İlkGirisMi";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 76;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.teknik_Servis_DBDataSet5;
            // 
            // teknik_Servis_DBDataSet5
            // 
            this.teknik_Servis_DBDataSet5.DataSetName = "Teknik_Servis_DBDataSet5";
            this.teknik_Servis_DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlStaffForm
            // 
            this.pnlStaffForm.BackColor = System.Drawing.Color.White;
            this.pnlStaffForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStaffForm.Controls.Add(this.cmbRol);
            this.pnlStaffForm.Controls.Add(this.TXT_Kullanici_Ad);
            this.pnlStaffForm.Controls.Add(this.TXT_Soyad);
            this.pnlStaffForm.Controls.Add(this.TXT_Ad);
            this.pnlStaffForm.Controls.Add(this.TXT_ID);
            this.pnlStaffForm.Controls.Add(this.lblStaffID);
            this.pnlStaffForm.Controls.Add(this.lblFirstName);
            this.pnlStaffForm.Controls.Add(this.lblLastName);
            this.pnlStaffForm.Controls.Add(this.lblUsername);
            this.pnlStaffForm.Controls.Add(this.lblPassword);
            this.pnlStaffForm.Controls.Add(this.txtPassword);
            this.pnlStaffForm.Controls.Add(this.lblRole);
            this.pnlStaffForm.Location = new System.Drawing.Point(10, 10);
            this.pnlStaffForm.Name = "pnlStaffForm";
            this.pnlStaffForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStaffForm.Size = new System.Drawing.Size(680, 400);
            this.pnlStaffForm.TabIndex = 0;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Admin",
            "Teknisyen",
            "Danışma"});
            this.cmbRol.Location = new System.Drawing.Point(360, 222);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(295, 46);
            this.cmbRol.TabIndex = 17;
            // 
            // TXT_Kullanici_Ad
            // 
            this.TXT_Kullanici_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Kullanici_Ad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Kullanici_Ad.Location = new System.Drawing.Point(360, 130);
            this.TXT_Kullanici_Ad.Name = "TXT_Kullanici_Ad";
            this.TXT_Kullanici_Ad.Size = new System.Drawing.Size(295, 45);
            this.TXT_Kullanici_Ad.TabIndex = 16;
            // 
            // TXT_Soyad
            // 
            this.TXT_Soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Soyad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Soyad.Location = new System.Drawing.Point(15, 130);
            this.TXT_Soyad.Name = "TXT_Soyad";
            this.TXT_Soyad.Size = new System.Drawing.Size(310, 45);
            this.TXT_Soyad.TabIndex = 15;
            // 
            // TXT_Ad
            // 
            this.TXT_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Ad.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Ad.Location = new System.Drawing.Point(360, 46);
            this.TXT_Ad.Name = "TXT_Ad";
            this.TXT_Ad.Size = new System.Drawing.Size(295, 45);
            this.TXT_Ad.TabIndex = 14;
            this.TXT_Ad.TextChanged += new System.EventHandler(this.TXT_Ad_TextChanged);
            // 
            // TXT_ID
            // 
            this.TXT_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TXT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID.Location = new System.Drawing.Point(15, 46);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(310, 45);
            this.TXT_ID.TabIndex = 13;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffID.Location = new System.Drawing.Point(15, 15);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(153, 28);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "🆔 Personel ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFirstName.Location = new System.Drawing.Point(360, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 28);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "👤 Ad";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLastName.Location = new System.Drawing.Point(15, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 28);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "👤 Soyad";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(360, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(166, 28);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "🔐 Kullanıcı Adı";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(15, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 28);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "🔑 Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(15, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(310, 45);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRole.Location = new System.Drawing.Point(360, 178);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(83, 28);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "🎖️  Rol";
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.TXT_Temizle);
            this.pnlActionButtons.Controls.Add(this.BTN_Sil);
            this.pnlActionButtons.Controls.Add(this.BTN_Ekle);
            this.pnlActionButtons.Controls.Add(this.BTN_Düzenle);
            this.pnlActionButtons.Location = new System.Drawing.Point(10, 420);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(680, 120);
            this.pnlActionButtons.TabIndex = 1;
            // 
            // BTN_Sil
            // 
            this.BTN_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sil.FlatAppearance.BorderSize = 0;
            this.BTN_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Sil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Sil.ForeColor = System.Drawing.Color.White;
            this.BTN_Sil.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BTN_Sil.IconColor = System.Drawing.Color.White;
            this.BTN_Sil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Sil.IconSize = 20;
            this.BTN_Sil.Location = new System.Drawing.Point(325, 18);
            this.BTN_Sil.Name = "BTN_Sil";
            this.BTN_Sil.Size = new System.Drawing.Size(140, 64);
            this.BTN_Sil.TabIndex = 4;
            this.BTN_Sil.Text = "Sil";
            this.BTN_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sil.UseVisualStyleBackColor = false;
            this.BTN_Sil.Click += new System.EventHandler(this.BTN_Sil_Click);
            // 
            // BTN_Ekle
            // 
            this.BTN_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BTN_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ekle.FlatAppearance.BorderSize = 0;
            this.BTN_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ekle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Ekle.ForeColor = System.Drawing.Color.White;
            this.BTN_Ekle.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BTN_Ekle.IconColor = System.Drawing.Color.White;
            this.BTN_Ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Ekle.IconSize = 20;
            this.BTN_Ekle.Location = new System.Drawing.Point(15, 18);
            this.BTN_Ekle.Name = "BTN_Ekle";
            this.BTN_Ekle.Size = new System.Drawing.Size(140, 64);
            this.BTN_Ekle.TabIndex = 4;
            this.BTN_Ekle.Text = "Personel Ekle";
            this.BTN_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ekle.UseVisualStyleBackColor = false;
            this.BTN_Ekle.Click += new System.EventHandler(this.BTN_Ekle_Click);
            // 
            // BTN_Düzenle
            // 
            this.BTN_Düzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.BTN_Düzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Düzenle.FlatAppearance.BorderSize = 0;
            this.BTN_Düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Düzenle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BTN_Düzenle.ForeColor = System.Drawing.Color.White;
            this.BTN_Düzenle.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.BTN_Düzenle.IconColor = System.Drawing.Color.White;
            this.BTN_Düzenle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Düzenle.IconSize = 20;
            this.BTN_Düzenle.Location = new System.Drawing.Point(170, 18);
            this.BTN_Düzenle.Name = "BTN_Düzenle";
            this.BTN_Düzenle.Size = new System.Drawing.Size(140, 64);
            this.BTN_Düzenle.TabIndex = 4;
            this.BTN_Düzenle.Text = "Düzenle";
            this.BTN_Düzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Düzenle.UseVisualStyleBackColor = false;
            this.BTN_Düzenle.Click += new System.EventHandler(this.BTN_Düzenle_Click);
            // 
            // tabPagePerformance
            // 
            this.tabPagePerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPagePerformance.Controls.Add(this.pnlPerformance);
            this.tabPagePerformance.Location = new System.Drawing.Point(4, 37);
            this.tabPagePerformance.Name = "tabPagePerformance";
            this.tabPagePerformance.Padding = new System.Windows.Forms.Padding(10);
            this.tabPagePerformance.Size = new System.Drawing.Size(1579, 788);
            this.tabPagePerformance.TabIndex = 1;
            this.tabPagePerformance.Text = "📊 Performans";
            // 
            // pnlPerformance
            // 
            this.pnlPerformance.AutoScroll = true;
            this.pnlPerformance.BackColor = System.Drawing.Color.White;
            this.pnlPerformance.Controls.Add(this.pnlPerformanceCards);
            this.pnlPerformance.Controls.Add(this.dgvPerformanceList);
            this.pnlPerformance.Controls.Add(this.dgvIssueTypes);
            this.pnlPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPerformance.Location = new System.Drawing.Point(10, 10);
            this.pnlPerformance.Name = "pnlPerformance";
            this.pnlPerformance.Size = new System.Drawing.Size(1559, 768);
            this.pnlPerformance.TabIndex = 0;
            // 
            // pnlPerformanceCards
            // 
            this.pnlPerformanceCards.BackColor = System.Drawing.Color.White;
            this.pnlPerformanceCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerformanceCards.Controls.Add(this.lblPerformanceTitle);
            this.pnlPerformanceCards.Controls.Add(this.lblSelectedStaffName);
            this.pnlPerformanceCards.Controls.Add(this.txtSelectedStaffName);
            this.pnlPerformanceCards.Controls.Add(this.lblSelectedStaffSurname);
            this.pnlPerformanceCards.Controls.Add(this.txtSelectedStaffSurname);
            this.pnlPerformanceCards.Controls.Add(this.lblResolvedIssues);
            this.pnlPerformanceCards.Controls.Add(this.txtResolvedIssues);
            this.pnlPerformanceCards.Controls.Add(this.lblAverageTime);
            this.pnlPerformanceCards.Controls.Add(this.txtAverageTime);
            this.pnlPerformanceCards.Controls.Add(this.btnTracking);
            this.pnlPerformanceCards.Location = new System.Drawing.Point(10, 10);
            this.pnlPerformanceCards.Name = "pnlPerformanceCards";
            this.pnlPerformanceCards.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPerformanceCards.Size = new System.Drawing.Size(1538, 182);
            this.pnlPerformanceCards.TabIndex = 0;
            // 
            // lblPerformanceTitle
            // 
            this.lblPerformanceTitle.AutoSize = true;
            this.lblPerformanceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPerformanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPerformanceTitle.Location = new System.Drawing.Point(14, 13);
            this.lblPerformanceTitle.Name = "lblPerformanceTitle";
            this.lblPerformanceTitle.Size = new System.Drawing.Size(248, 32);
            this.lblPerformanceTitle.TabIndex = 0;
            this.lblPerformanceTitle.Text = "👤 Personel Bilgileri";
            // 
            // lblSelectedStaffName
            // 
            this.lblSelectedStaffName.AutoSize = true;
            this.lblSelectedStaffName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedStaffName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSelectedStaffName.Location = new System.Drawing.Point(15, 45);
            this.lblSelectedStaffName.Name = "lblSelectedStaffName";
            this.lblSelectedStaffName.Size = new System.Drawing.Size(41, 25);
            this.lblSelectedStaffName.TabIndex = 1;
            this.lblSelectedStaffName.Text = "Ad:";
            // 
            // txtSelectedStaffName
            // 
            this.txtSelectedStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSelectedStaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedStaffName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSelectedStaffName.Location = new System.Drawing.Point(15, 70);
            this.txtSelectedStaffName.Multiline = true;
            this.txtSelectedStaffName.Name = "txtSelectedStaffName";
            this.txtSelectedStaffName.ReadOnly = true;
            this.txtSelectedStaffName.Size = new System.Drawing.Size(200, 45);
            this.txtSelectedStaffName.TabIndex = 2;
            // 
            // lblSelectedStaffSurname
            // 
            this.lblSelectedStaffSurname.AutoSize = true;
            this.lblSelectedStaffSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSelectedStaffSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSelectedStaffSurname.Location = new System.Drawing.Point(230, 45);
            this.lblSelectedStaffSurname.Name = "lblSelectedStaffSurname";
            this.lblSelectedStaffSurname.Size = new System.Drawing.Size(69, 25);
            this.lblSelectedStaffSurname.TabIndex = 3;
            this.lblSelectedStaffSurname.Text = "Soyad:";
            // 
            // txtSelectedStaffSurname
            // 
            this.txtSelectedStaffSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtSelectedStaffSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedStaffSurname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSelectedStaffSurname.Location = new System.Drawing.Point(230, 70);
            this.txtSelectedStaffSurname.Multiline = true;
            this.txtSelectedStaffSurname.Name = "txtSelectedStaffSurname";
            this.txtSelectedStaffSurname.ReadOnly = true;
            this.txtSelectedStaffSurname.Size = new System.Drawing.Size(200, 45);
            this.txtSelectedStaffSurname.TabIndex = 4;
            // 
            // lblResolvedIssues
            // 
            this.lblResolvedIssues.AutoSize = true;
            this.lblResolvedIssues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResolvedIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblResolvedIssues.Location = new System.Drawing.Point(445, 45);
            this.lblResolvedIssues.Name = "lblResolvedIssues";
            this.lblResolvedIssues.Size = new System.Drawing.Size(188, 25);
            this.lblResolvedIssues.TabIndex = 5;
            this.lblResolvedIssues.Text = "✅ Çözülen Arızalar:";
            // 
            // txtResolvedIssues
            // 
            this.txtResolvedIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtResolvedIssues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResolvedIssues.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtResolvedIssues.Location = new System.Drawing.Point(445, 70);
            this.txtResolvedIssues.Multiline = true;
            this.txtResolvedIssues.Name = "txtResolvedIssues";
            this.txtResolvedIssues.ReadOnly = true;
            this.txtResolvedIssues.Size = new System.Drawing.Size(200, 45);
            this.txtResolvedIssues.TabIndex = 6;
            this.txtResolvedIssues.Text = "0";
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAverageTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblAverageTime.Location = new System.Drawing.Point(660, 45);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(176, 25);
            this.lblAverageTime.TabIndex = 7;
            this.lblAverageTime.Text = "⏱️  Ortalama Süre:";
            // 
            // txtAverageTime
            // 
            this.txtAverageTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAverageTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAverageTime.Location = new System.Drawing.Point(660, 70);
            this.txtAverageTime.Multiline = true;
            this.txtAverageTime.Name = "txtAverageTime";
            this.txtAverageTime.ReadOnly = true;
            this.txtAverageTime.Size = new System.Drawing.Size(200, 45);
            this.txtAverageTime.TabIndex = 8;
            this.txtAverageTime.Text = "0";
            // 
            // btnTracking
            // 
            this.btnTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTracking.FlatAppearance.BorderSize = 0;
            this.btnTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTracking.ForeColor = System.Drawing.Color.White;
            this.btnTracking.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTracking.IconColor = System.Drawing.Color.White;
            this.btnTracking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTracking.IconSize = 20;
            this.btnTracking.Location = new System.Drawing.Point(875, 70);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(140, 45);
            this.btnTracking.TabIndex = 4;
            this.btnTracking.Text = "Takip Et";
            this.btnTracking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTracking.UseVisualStyleBackColor = false;
            // 
            // dgvPerformanceList
            // 
            this.dgvPerformanceList.AllowUserToAddRows = false;
            this.dgvPerformanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerformanceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerformanceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPerformanceList.ColumnHeadersHeight = 35;
            this.dgvPerformanceList.Location = new System.Drawing.Point(10, 220);
            this.dgvPerformanceList.Name = "dgvPerformanceList";
            this.dgvPerformanceList.ReadOnly = true;
            this.dgvPerformanceList.RowHeadersVisible = false;
            this.dgvPerformanceList.RowHeadersWidth = 62;
            this.dgvPerformanceList.RowTemplate.Height = 28;
            this.dgvPerformanceList.Size = new System.Drawing.Size(743, 440);
            this.dgvPerformanceList.TabIndex = 1;
            // 
            // dgvIssueTypes
            // 
            this.dgvIssueTypes.AllowUserToAddRows = false;
            this.dgvIssueTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssueTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssueTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIssueTypes.ColumnHeadersHeight = 35;
            this.dgvIssueTypes.Location = new System.Drawing.Point(791, 216);
            this.dgvIssueTypes.Name = "dgvIssueTypes";
            this.dgvIssueTypes.ReadOnly = true;
            this.dgvIssueTypes.RowHeadersVisible = false;
            this.dgvIssueTypes.RowHeadersWidth = 62;
            this.dgvIssueTypes.RowTemplate.Height = 28;
            this.dgvIssueTypes.Size = new System.Drawing.Size(757, 440);
            this.dgvIssueTypes.TabIndex = 2;
            // 
            // pnlDataGridPerformance
            // 
            this.pnlDataGridPerformance.Location = new System.Drawing.Point(0, 0);
            this.pnlDataGridPerformance.Name = "pnlDataGridPerformance";
            this.pnlDataGridPerformance.Size = new System.Drawing.Size(200, 100);
            this.pnlDataGridPerformance.TabIndex = 0;
            // 
            // dgvStaffDetails
            // 
            this.dgvStaffDetails.ColumnHeadersHeight = 34;
            this.dgvStaffDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvStaffDetails.Name = "dgvStaffDetails";
            this.dgvStaffDetails.RowHeadersWidth = 62;
            this.dgvStaffDetails.Size = new System.Drawing.Size(240, 150);
            this.dgvStaffDetails.TabIndex = 0;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // TXT_Temizle
            // 
            this.TXT_Temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TXT_Temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TXT_Temizle.FlatAppearance.BorderSize = 0;
            this.TXT_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TXT_Temizle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TXT_Temizle.ForeColor = System.Drawing.Color.White;
            this.TXT_Temizle.IconChar = FontAwesome.Sharp.IconChar.NodeJs;
            this.TXT_Temizle.IconColor = System.Drawing.Color.White;
            this.TXT_Temizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TXT_Temizle.IconSize = 20;
            this.TXT_Temizle.Location = new System.Drawing.Point(515, 18);
            this.TXT_Temizle.Name = "TXT_Temizle";
            this.TXT_Temizle.Size = new System.Drawing.Size(140, 64);
            this.TXT_Temizle.TabIndex = 5;
            this.TXT_Temizle.Text = "Temizle";
            this.TXT_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TXT_Temizle.UseVisualStyleBackColor = false;
            this.TXT_Temizle.Click += new System.EventHandler(this.TXT_Temizle_Click);
            // 
            // BTN_Ana_Sayfa
            // 
            this.BTN_Ana_Sayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.BTN_Ana_Sayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ana_Sayfa.FlatAppearance.BorderSize = 0;
            this.BTN_Ana_Sayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ana_Sayfa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_Ana_Sayfa.ForeColor = System.Drawing.Color.White;
            this.BTN_Ana_Sayfa.IconChar = FontAwesome.Sharp.IconChar.House;
            this.BTN_Ana_Sayfa.IconColor = System.Drawing.Color.White;
            this.BTN_Ana_Sayfa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Ana_Sayfa.Location = new System.Drawing.Point(1287, 598);
            this.BTN_Ana_Sayfa.Name = "BTN_Ana_Sayfa";
            this.BTN_Ana_Sayfa.Size = new System.Drawing.Size(269, 115);
            this.BTN_Ana_Sayfa.TabIndex = 7;
            this.BTN_Ana_Sayfa.Text = "Ana Ekrana\r\nDön\r\n";
            this.BTN_Ana_Sayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ana_Sayfa.UseVisualStyleBackColor = false;
            this.BTN_Ana_Sayfa.Click += new System.EventHandler(this.BTN_Ana_Sayfa_Click);
            // 
            // Personel_Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1595, 909);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Personel_Yonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Personel_Yonetim_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperations.ResumeLayout(false);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet5)).EndInit();
            this.pnlStaffForm.ResumeLayout(false);
            this.pnlStaffForm.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.tabPagePerformance.ResumeLayout(false);
            this.pnlPerformance.ResumeLayout(false);
            this.pnlPerformanceCards.ResumeLayout(false);
            this.pnlPerformanceCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformanceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPagePerformance;

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlStaffForm;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Panel pnlPerformance;
        private System.Windows.Forms.Panel pnlPerformanceCards;
        private System.Windows.Forms.Panel pnlDataGridPerformance;

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;

        private System.Windows.Forms.Label lblPerformanceTitle;
        private System.Windows.Forms.Label lblSelectedStaffName;
        private System.Windows.Forms.TextBox txtSelectedStaffName;
        private System.Windows.Forms.Label lblSelectedStaffSurname;
        private System.Windows.Forms.TextBox txtSelectedStaffSurname;
        private System.Windows.Forms.Label lblResolvedIssues;
        private System.Windows.Forms.TextBox txtResolvedIssues;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.TextBox txtAverageTime;
        private FontAwesome.Sharp.IconButton btnTracking;
        private System.Windows.Forms.DataGridView dgvStaffDetails;
        private System.Windows.Forms.DataGridView dgvPerformanceList;
        private System.Windows.Forms.DataGridView dgvIssueTypes;
        private System.Windows.Forms.TextBox TXT_Ad;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.TextBox TXT_Kullanici_Ad;
        private System.Windows.Forms.TextBox TXT_Soyad;
        private Teknik_Servis_DBDataSet5 teknik_Servis_DBDataSet5;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private Teknik_Servis_DBDataSet5TableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.ComboBox cmbRol;
        private FontAwesome.Sharp.IconButton BTN_Ekle;
        private FontAwesome.Sharp.IconButton BTN_Sil;
        private FontAwesome.Sharp.IconButton BTN_Düzenle;
        private System.Windows.Forms.DataGridView dgv_Personeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton TXT_Temizle;
        private FontAwesome.Sharp.IconButton BTN_Ana_Sayfa;
    }
}