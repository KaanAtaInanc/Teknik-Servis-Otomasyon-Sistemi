namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Atanan_Islemler
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
            this.BTN_Ana_Sayfa = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAssignedTasks = new System.Windows.Forms.TabPage();
            this.pnlAssignedTasks = new System.Windows.Forms.Panel();
            this.pnlTasksList = new System.Windows.Forms.Panel();
            this.dgv_Atanan_İş = new System.Windows.Forms.DataGridView();
            this.teknisyenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazMarkaModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teknisyenAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arizalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teknik_Servis_DBDataSet9 = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet9();
            this.tabPageTaskDetails = new System.Windows.Forms.TabPage();
            this.pnlTaskDetails = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Atanan_İş_ = new System.Windows.Forms.DataGridView();
            this.arizalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.TXT_Cihaz_Ad = new System.Windows.Forms.TextBox();
            this.lblBrandModel = new System.Windows.Forms.Label();
            this.Txt_Marka_Model = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.TXT_Seri_No = new System.Windows.Forms.TextBox();
            this.lblComplaint = new System.Windows.Forms.Label();
            this.TXT_Sikayet = new System.Windows.Forms.TextBox();
            this.pnlWorkProgress = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.CMB_İs_Durum = new System.Windows.Forms.ComboBox();
            this.lblTechnicianNotes = new System.Windows.Forms.Label();
            this.TXT_Teknisyen_Not = new System.Windows.Forms.TextBox();
            this.pnlPartsUsed = new System.Windows.Forms.Panel();
            this.pnlPartFilters = new System.Windows.Forms.Panel();
            this.lblPartCategory = new System.Windows.Forms.Label();
            this.CMB_Parça_Kategori = new System.Windows.Forms.ComboBox();
            this.lblUsedParts = new System.Windows.Forms.Label();
            this.CMB_KullanılanParçaSecim = new System.Windows.Forms.ComboBox();
            this.lblPartQuantity = new System.Windows.Forms.Label();
            this.TXT_Miktar = new System.Windows.Forms.TextBox();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.BTN_Kaydet = new FontAwesome.Sharp.IconButton();
            this.BTN_İptal = new FontAwesome.Sharp.IconButton();
            this.arizalarTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet9TableAdapters.ArizalarTableAdapter();
            this.gelisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Parca_Kaydet = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageAssignedTasks.SuspendLayout();
            this.pnlAssignedTasks.SuspendLayout();
            this.pnlTasksList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atanan_İş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet9)).BeginInit();
            this.tabPageTaskDetails.SuspendLayout();
            this.pnlTaskDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atanan_İş_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource1)).BeginInit();
            this.pnlDeviceInfo.SuspendLayout();
            this.pnlWorkProgress.SuspendLayout();
            this.pnlPartsUsed.SuspendLayout();
            this.pnlPartFilters.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.BTN_Ana_Sayfa);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1624, 101);
            this.pnlHeader.TabIndex = 1;
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
            this.BTN_Ana_Sayfa.Location = new System.Drawing.Point(1293, 12);
            this.BTN_Ana_Sayfa.Name = "BTN_Ana_Sayfa";
            this.BTN_Ana_Sayfa.Size = new System.Drawing.Size(311, 72);
            this.BTN_Ana_Sayfa.TabIndex = 10;
            this.BTN_Ana_Sayfa.Text = "Ana Ekrana Dön\r\n";
            this.BTN_Ana_Sayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ana_Sayfa.UseVisualStyleBackColor = false;
            this.BTN_Ana_Sayfa.Click += new System.EventHandler(this.BTN_Ana_Sayfa_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔧 Atanan İşlemler";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAssignedTasks);
            this.tabControlMain.Controls.Add(this.tabPageTaskDetails);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 101);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1624, 1041);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageAssignedTasks
            // 
            this.tabPageAssignedTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageAssignedTasks.Controls.Add(this.pnlAssignedTasks);
            this.tabPageAssignedTasks.Location = new System.Drawing.Point(4, 37);
            this.tabPageAssignedTasks.Name = "tabPageAssignedTasks";
            this.tabPageAssignedTasks.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageAssignedTasks.Size = new System.Drawing.Size(1616, 1000);
            this.tabPageAssignedTasks.TabIndex = 0;
            this.tabPageAssignedTasks.Text = "📋 Atanan İşlerim";
            // 
            // pnlAssignedTasks
            // 
            this.pnlAssignedTasks.AutoScroll = true;
            this.pnlAssignedTasks.BackColor = System.Drawing.Color.White;
            this.pnlAssignedTasks.Controls.Add(this.pnlTasksList);
            this.pnlAssignedTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssignedTasks.Location = new System.Drawing.Point(10, 10);
            this.pnlAssignedTasks.Name = "pnlAssignedTasks";
            this.pnlAssignedTasks.Size = new System.Drawing.Size(1596, 980);
            this.pnlAssignedTasks.TabIndex = 0;
            // 
            // pnlTasksList
            // 
            this.pnlTasksList.BackColor = System.Drawing.Color.White;
            this.pnlTasksList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTasksList.Controls.Add(this.dgv_Atanan_İş);
            this.pnlTasksList.Location = new System.Drawing.Point(10, 10);
            this.pnlTasksList.Name = "pnlTasksList";
            this.pnlTasksList.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTasksList.Size = new System.Drawing.Size(1596, 1173);
            this.pnlTasksList.TabIndex = 0;
            // 
            // dgv_Atanan_İş
            // 
            this.dgv_Atanan_İş.AllowUserToAddRows = false;
            this.dgv_Atanan_İş.AutoGenerateColumns = false;
            this.dgv_Atanan_İş.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Atanan_İş.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Atanan_İş.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Atanan_İş.ColumnHeadersHeight = 35;
            this.dgv_Atanan_İş.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Atanan_İş.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teknisyenIDDataGridViewTextBoxColumn,
            this.durumIDDataGridViewTextBoxColumn,
            this.cihazAdDataGridViewTextBoxColumn,
            this.cihazMarkaModelDataGridViewTextBoxColumn,
            this.seriNoDataGridViewTextBoxColumn,
            this.musteriSikayetDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn,
            this.teknisyenAciklamaDataGridViewTextBoxColumn});
            this.dgv_Atanan_İş.DataSource = this.arizalarBindingSource;
            this.dgv_Atanan_İş.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Atanan_İş.Location = new System.Drawing.Point(15, 15);
            this.dgv_Atanan_İş.Name = "dgv_Atanan_İş";
            this.dgv_Atanan_İş.ReadOnly = true;
            this.dgv_Atanan_İş.RowHeadersVisible = false;
            this.dgv_Atanan_İş.RowHeadersWidth = 62;
            this.dgv_Atanan_İş.RowTemplate.Height = 28;
            this.dgv_Atanan_İş.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Atanan_İş.Size = new System.Drawing.Size(1564, 1141);
            this.dgv_Atanan_İş.TabIndex = 0;
            // 
            // teknisyenIDDataGridViewTextBoxColumn
            // 
            this.teknisyenIDDataGridViewTextBoxColumn.DataPropertyName = "Teknisyen_ID";
            this.teknisyenIDDataGridViewTextBoxColumn.HeaderText = "Teknisyen_ID";
            this.teknisyenIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teknisyenIDDataGridViewTextBoxColumn.Name = "teknisyenIDDataGridViewTextBoxColumn";
            this.teknisyenIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumIDDataGridViewTextBoxColumn
            // 
            this.durumIDDataGridViewTextBoxColumn.DataPropertyName = "Durum_ID";
            this.durumIDDataGridViewTextBoxColumn.HeaderText = "Durum_ID";
            this.durumIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durumIDDataGridViewTextBoxColumn.Name = "durumIDDataGridViewTextBoxColumn";
            this.durumIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazAdDataGridViewTextBoxColumn
            // 
            this.cihazAdDataGridViewTextBoxColumn.DataPropertyName = "Cihaz_Ad";
            this.cihazAdDataGridViewTextBoxColumn.HeaderText = "Cihaz_Ad";
            this.cihazAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cihazAdDataGridViewTextBoxColumn.Name = "cihazAdDataGridViewTextBoxColumn";
            this.cihazAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cihazMarkaModelDataGridViewTextBoxColumn
            // 
            this.cihazMarkaModelDataGridViewTextBoxColumn.DataPropertyName = "Cihaz_Marka_Model";
            this.cihazMarkaModelDataGridViewTextBoxColumn.HeaderText = "Cihaz_Marka_Model";
            this.cihazMarkaModelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cihazMarkaModelDataGridViewTextBoxColumn.Name = "cihazMarkaModelDataGridViewTextBoxColumn";
            this.cihazMarkaModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriNoDataGridViewTextBoxColumn
            // 
            this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "Seri_No";
            this.seriNoDataGridViewTextBoxColumn.HeaderText = "Seri_No";
            this.seriNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
            this.seriNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriSikayetDataGridViewTextBoxColumn
            // 
            this.musteriSikayetDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Sikayet";
            this.musteriSikayetDataGridViewTextBoxColumn.HeaderText = "Musteri_Sikayet";
            this.musteriSikayetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriSikayetDataGridViewTextBoxColumn.Name = "musteriSikayetDataGridViewTextBoxColumn";
            this.musteriSikayetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bitisTarihiDataGridViewTextBoxColumn
            // 
            this.bitisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Bitis_Tarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.HeaderText = "Bitis_Tarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bitisTarihiDataGridViewTextBoxColumn.Name = "bitisTarihiDataGridViewTextBoxColumn";
            this.bitisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teknisyenAciklamaDataGridViewTextBoxColumn
            // 
            this.teknisyenAciklamaDataGridViewTextBoxColumn.DataPropertyName = "Teknisyen_Aciklama";
            this.teknisyenAciklamaDataGridViewTextBoxColumn.HeaderText = "Teknisyen_Aciklama";
            this.teknisyenAciklamaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teknisyenAciklamaDataGridViewTextBoxColumn.Name = "teknisyenAciklamaDataGridViewTextBoxColumn";
            this.teknisyenAciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arizalarBindingSource
            // 
            this.arizalarBindingSource.DataMember = "Arizalar";
            this.arizalarBindingSource.DataSource = this.teknik_Servis_DBDataSet9;
            // 
            // teknik_Servis_DBDataSet9
            // 
            this.teknik_Servis_DBDataSet9.DataSetName = "Teknik_Servis_DBDataSet9";
            this.teknik_Servis_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageTaskDetails
            // 
            this.tabPageTaskDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageTaskDetails.Controls.Add(this.pnlTaskDetails);
            this.tabPageTaskDetails.Location = new System.Drawing.Point(4, 37);
            this.tabPageTaskDetails.Name = "tabPageTaskDetails";
            this.tabPageTaskDetails.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageTaskDetails.Size = new System.Drawing.Size(1616, 1000);
            this.tabPageTaskDetails.TabIndex = 1;
            this.tabPageTaskDetails.Text = "🔧 İşlem Detayları";
            // 
            // pnlTaskDetails
            // 
            this.pnlTaskDetails.AutoScroll = true;
            this.pnlTaskDetails.BackColor = System.Drawing.Color.White;
            this.pnlTaskDetails.Controls.Add(this.groupBox1);
            this.pnlTaskDetails.Controls.Add(this.pnlDeviceInfo);
            this.pnlTaskDetails.Controls.Add(this.pnlWorkProgress);
            this.pnlTaskDetails.Controls.Add(this.pnlPartsUsed);
            this.pnlTaskDetails.Controls.Add(this.pnlActionButtons);
            this.pnlTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaskDetails.Location = new System.Drawing.Point(10, 10);
            this.pnlTaskDetails.Name = "pnlTaskDetails";
            this.pnlTaskDetails.Size = new System.Drawing.Size(1596, 980);
            this.pnlTaskDetails.TabIndex = 0;
            this.pnlTaskDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTaskDetails_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Atanan_İş_);
            this.groupBox1.Location = new System.Drawing.Point(31, 669);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1481, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dgv_Atanan_İş_
            // 
            this.dgv_Atanan_İş_.AutoGenerateColumns = false;
            this.dgv_Atanan_İş_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Atanan_İş_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelisTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn1});
            this.dgv_Atanan_İş_.DataSource = this.arizalarBindingSource1;
            this.dgv_Atanan_İş_.Location = new System.Drawing.Point(3, 30);
            this.dgv_Atanan_İş_.Name = "dgv_Atanan_İş_";
            this.dgv_Atanan_İş_.RowHeadersWidth = 62;
            this.dgv_Atanan_İş_.RowTemplate.Height = 28;
            this.dgv_Atanan_İş_.Size = new System.Drawing.Size(1478, 407);
            this.dgv_Atanan_İş_.TabIndex = 4;
            this.dgv_Atanan_İş_.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Atanan_Is__CellDoubleClick);
            // 
            // arizalarBindingSource1
            // 
            this.arizalarBindingSource1.DataMember = "Arizalar";
            this.arizalarBindingSource1.DataSource = this.teknik_Servis_DBDataSet9;
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.BackColor = System.Drawing.Color.White;
            this.pnlDeviceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeviceInfo.Controls.Add(this.lblDeviceName);
            this.pnlDeviceInfo.Controls.Add(this.TXT_Cihaz_Ad);
            this.pnlDeviceInfo.Controls.Add(this.lblBrandModel);
            this.pnlDeviceInfo.Controls.Add(this.Txt_Marka_Model);
            this.pnlDeviceInfo.Controls.Add(this.lblSerialNo);
            this.pnlDeviceInfo.Controls.Add(this.TXT_Seri_No);
            this.pnlDeviceInfo.Controls.Add(this.lblComplaint);
            this.pnlDeviceInfo.Controls.Add(this.TXT_Sikayet);
            this.pnlDeviceInfo.Location = new System.Drawing.Point(10, 16);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDeviceInfo.Size = new System.Drawing.Size(680, 350);
            this.pnlDeviceInfo.TabIndex = 0;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDeviceName.Location = new System.Drawing.Point(15, 15);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(135, 28);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "💻 Cihaz Adı";
            // 
            // TXT_Cihaz_Ad
            // 
            this.TXT_Cihaz_Ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TXT_Cihaz_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cihaz_Ad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_Cihaz_Ad.Location = new System.Drawing.Point(15, 46);
            this.TXT_Cihaz_Ad.Name = "TXT_Cihaz_Ad";
            this.TXT_Cihaz_Ad.ReadOnly = true;
            this.TXT_Cihaz_Ad.Size = new System.Drawing.Size(630, 34);
            this.TXT_Cihaz_Ad.TabIndex = 1;
            // 
            // lblBrandModel
            // 
            this.lblBrandModel.AutoSize = true;
            this.lblBrandModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrandModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBrandModel.Location = new System.Drawing.Point(15, 85);
            this.lblBrandModel.Name = "lblBrandModel";
            this.lblBrandModel.Size = new System.Drawing.Size(181, 28);
            this.lblBrandModel.TabIndex = 2;
            this.lblBrandModel.Text = "🏷️  Marka/Model";
            // 
            // Txt_Marka_Model
            // 
            this.Txt_Marka_Model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Txt_Marka_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Marka_Model.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Txt_Marka_Model.Location = new System.Drawing.Point(15, 116);
            this.Txt_Marka_Model.Name = "Txt_Marka_Model";
            this.Txt_Marka_Model.ReadOnly = true;
            this.Txt_Marka_Model.Size = new System.Drawing.Size(290, 34);
            this.Txt_Marka_Model.TabIndex = 3;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSerialNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSerialNo.Location = new System.Drawing.Point(355, 85);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(179, 28);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "🔢 Seri Numarası";
            // 
            // TXT_Seri_No
            // 
            this.TXT_Seri_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TXT_Seri_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Seri_No.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_Seri_No.Location = new System.Drawing.Point(355, 116);
            this.TXT_Seri_No.Name = "TXT_Seri_No";
            this.TXT_Seri_No.ReadOnly = true;
            this.TXT_Seri_No.Size = new System.Drawing.Size(290, 34);
            this.TXT_Seri_No.TabIndex = 5;
            // 
            // lblComplaint
            // 
            this.lblComplaint.AutoSize = true;
            this.lblComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblComplaint.Location = new System.Drawing.Point(15, 155);
            this.lblComplaint.Name = "lblComplaint";
            this.lblComplaint.Size = new System.Drawing.Size(206, 28);
            this.lblComplaint.TabIndex = 6;
            this.lblComplaint.Text = "⚠️  Müşteri Şikayeti";
            // 
            // TXT_Sikayet
            // 
            this.TXT_Sikayet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.TXT_Sikayet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Sikayet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_Sikayet.Location = new System.Drawing.Point(15, 186);
            this.TXT_Sikayet.Multiline = true;
            this.TXT_Sikayet.Name = "TXT_Sikayet";
            this.TXT_Sikayet.ReadOnly = true;
            this.TXT_Sikayet.Size = new System.Drawing.Size(630, 144);
            this.TXT_Sikayet.TabIndex = 7;
            // 
            // pnlWorkProgress
            // 
            this.pnlWorkProgress.BackColor = System.Drawing.Color.White;
            this.pnlWorkProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWorkProgress.Controls.Add(this.lblStatus);
            this.pnlWorkProgress.Controls.Add(this.CMB_İs_Durum);
            this.pnlWorkProgress.Controls.Add(this.lblTechnicianNotes);
            this.pnlWorkProgress.Controls.Add(this.TXT_Teknisyen_Not);
            this.pnlWorkProgress.Location = new System.Drawing.Point(10, 372);
            this.pnlWorkProgress.Name = "pnlWorkProgress";
            this.pnlWorkProgress.Padding = new System.Windows.Forms.Padding(15);
            this.pnlWorkProgress.Size = new System.Drawing.Size(680, 223);
            this.pnlWorkProgress.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(15, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 28);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "📊 İş Durumu";
            // 
            // CMB_İs_Durum
            // 
            this.CMB_İs_Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_İs_Durum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMB_İs_Durum.Location = new System.Drawing.Point(15, 46);
            this.CMB_İs_Durum.Name = "CMB_İs_Durum";
            this.CMB_İs_Durum.Size = new System.Drawing.Size(630, 36);
            this.CMB_İs_Durum.TabIndex = 1;
            // 
            // lblTechnicianNotes
            // 
            this.lblTechnicianNotes.AutoSize = true;
            this.lblTechnicianNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTechnicianNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTechnicianNotes.Location = new System.Drawing.Point(15, 85);
            this.lblTechnicianNotes.Name = "lblTechnicianNotes";
            this.lblTechnicianNotes.Size = new System.Drawing.Size(247, 28);
            this.lblTechnicianNotes.TabIndex = 2;
            this.lblTechnicianNotes.Text = "📝 Teknisyen Açıklaması";
            // 
            // TXT_Teknisyen_Not
            // 
            this.TXT_Teknisyen_Not.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Teknisyen_Not.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_Teknisyen_Not.Location = new System.Drawing.Point(15, 116);
            this.TXT_Teknisyen_Not.Multiline = true;
            this.TXT_Teknisyen_Not.Name = "TXT_Teknisyen_Not";
            this.TXT_Teknisyen_Not.Size = new System.Drawing.Size(630, 70);
            this.TXT_Teknisyen_Not.TabIndex = 3;
            // 
            // pnlPartsUsed
            // 
            this.pnlPartsUsed.BackColor = System.Drawing.Color.White;
            this.pnlPartsUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartsUsed.Controls.Add(this.BTN_Parca_Kaydet);
            this.pnlPartsUsed.Controls.Add(this.pnlPartFilters);
            this.pnlPartsUsed.Controls.Add(this.lblUsedParts);
            this.pnlPartsUsed.Controls.Add(this.CMB_KullanılanParçaSecim);
            this.pnlPartsUsed.Controls.Add(this.lblPartQuantity);
            this.pnlPartsUsed.Controls.Add(this.TXT_Miktar);
            this.pnlPartsUsed.Location = new System.Drawing.Point(726, 16);
            this.pnlPartsUsed.Name = "pnlPartsUsed";
            this.pnlPartsUsed.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPartsUsed.Size = new System.Drawing.Size(680, 566);
            this.pnlPartsUsed.TabIndex = 2;
            // 
            // pnlPartFilters
            // 
            this.pnlPartFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.pnlPartFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartFilters.Controls.Add(this.lblPartCategory);
            this.pnlPartFilters.Controls.Add(this.CMB_Parça_Kategori);
            this.pnlPartFilters.Location = new System.Drawing.Point(15, 15);
            this.pnlPartFilters.Name = "pnlPartFilters";
            this.pnlPartFilters.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPartFilters.Size = new System.Drawing.Size(630, 110);
            this.pnlPartFilters.TabIndex = 0;
            // 
            // lblPartCategory
            // 
            this.lblPartCategory.AutoSize = true;
            this.lblPartCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPartCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartCategory.Location = new System.Drawing.Point(10, 10);
            this.lblPartCategory.Name = "lblPartCategory";
            this.lblPartCategory.Size = new System.Drawing.Size(181, 25);
            this.lblPartCategory.TabIndex = 0;
            this.lblPartCategory.Text = "📂 Parça Kategorisi";
            // 
            // CMB_Parça_Kategori
            // 
            this.CMB_Parça_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Parça_Kategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CMB_Parça_Kategori.Items.AddRange(new object[] {
            "Tümü",
            "Ekran",
            "Batarya",
            "Kasa",
            "Bellek",
            "Depolama",
            "Konnektör",
            "Şarj Aleti",
            "Başka"});
            this.CMB_Parça_Kategori.Location = new System.Drawing.Point(4, 38);
            this.CMB_Parça_Kategori.Name = "CMB_Parça_Kategori";
            this.CMB_Parça_Kategori.Size = new System.Drawing.Size(300, 33);
            this.CMB_Parça_Kategori.TabIndex = 0;
            this.CMB_Parça_Kategori.SelectedIndexChanged += new System.EventHandler(this.CmbPartCategory_SelectedIndexChanged);
            // 
            // lblUsedParts
            // 
            this.lblUsedParts.AutoSize = true;
            this.lblUsedParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsedParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsedParts.Location = new System.Drawing.Point(15, 140);
            this.lblUsedParts.Name = "lblUsedParts";
            this.lblUsedParts.Size = new System.Drawing.Size(237, 28);
            this.lblUsedParts.TabIndex = 1;
            this.lblUsedParts.Text = "🔩 Kullanılan Parça Seç";
            // 
            // CMB_KullanılanParçaSecim
            // 
            this.CMB_KullanılanParçaSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_KullanılanParçaSecim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CMB_KullanılanParçaSecim.Location = new System.Drawing.Point(15, 171);
            this.CMB_KullanılanParçaSecim.Name = "CMB_KullanılanParçaSecim";
            this.CMB_KullanılanParçaSecim.Size = new System.Drawing.Size(630, 36);
            this.CMB_KullanılanParçaSecim.TabIndex = 2;
            this.CMB_KullanılanParçaSecim.SelectedIndexChanged += new System.EventHandler(this.CmbUsedParts_SelectedIndexChanged);
            // 
            // lblPartQuantity
            // 
            this.lblPartQuantity.AutoSize = true;
            this.lblPartQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPartQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPartQuantity.Location = new System.Drawing.Point(15, 219);
            this.lblPartQuantity.Name = "lblPartQuantity";
            this.lblPartQuantity.Size = new System.Drawing.Size(210, 28);
            this.lblPartQuantity.TabIndex = 5;
            this.lblPartQuantity.Text = "📊 Kullanılan Miktar";
            // 
            // TXT_Miktar
            // 
            this.TXT_Miktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Miktar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TXT_Miktar.Location = new System.Drawing.Point(15, 250);
            this.TXT_Miktar.Name = "TXT_Miktar";
            this.TXT_Miktar.Size = new System.Drawing.Size(630, 34);
            this.TXT_Miktar.TabIndex = 3;
            // 
            // pnlActionButtons
            // 
            this.pnlActionButtons.BackColor = System.Drawing.Color.White;
            this.pnlActionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionButtons.Controls.Add(this.BTN_Kaydet);
            this.pnlActionButtons.Controls.Add(this.BTN_İptal);
            this.pnlActionButtons.Location = new System.Drawing.Point(726, 588);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtons.Size = new System.Drawing.Size(778, 78);
            this.pnlActionButtons.TabIndex = 3;
            // 
            // BTN_Kaydet
            // 
            this.BTN_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BTN_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Kaydet.FlatAppearance.BorderSize = 0;
            this.BTN_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Kaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_Kaydet.ForeColor = System.Drawing.Color.White;
            this.BTN_Kaydet.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BTN_Kaydet.IconColor = System.Drawing.Color.White;
            this.BTN_Kaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Kaydet.IconSize = 24;
            this.BTN_Kaydet.Location = new System.Drawing.Point(18, 13);
            this.BTN_Kaydet.Name = "BTN_Kaydet";
            this.BTN_Kaydet.Size = new System.Drawing.Size(300, 55);
            this.BTN_Kaydet.TabIndex = 0;
            this.BTN_Kaydet.Text = "✅ İşlemi Kaydet";
            this.BTN_Kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Kaydet.UseVisualStyleBackColor = false;
            this.BTN_Kaydet.Click += new System.EventHandler(this.BTN_Kaydet_Click);
            // 
            // BTN_İptal
            // 
            this.BTN_İptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_İptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_İptal.FlatAppearance.BorderSize = 0;
            this.BTN_İptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_İptal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_İptal.ForeColor = System.Drawing.Color.White;
            this.BTN_İptal.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.BTN_İptal.IconColor = System.Drawing.Color.White;
            this.BTN_İptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_İptal.IconSize = 24;
            this.BTN_İptal.Location = new System.Drawing.Point(458, 13);
            this.BTN_İptal.Name = "BTN_İptal";
            this.BTN_İptal.Size = new System.Drawing.Size(300, 55);
            this.BTN_İptal.TabIndex = 1;
            this.BTN_İptal.Text = "❌ İptal";
            this.BTN_İptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_İptal.UseVisualStyleBackColor = false;
            this.BTN_İptal.Click += new System.EventHandler(this.BTN_İptal_Click);
            // 
            // arizalarTableAdapter
            // 
            this.arizalarTableAdapter.ClearBeforeFill = true;
            // 
            // gelisTarihiDataGridViewTextBoxColumn
            // 
            this.gelisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Gelis_Tarihi";
            this.gelisTarihiDataGridViewTextBoxColumn.HeaderText = "Gelis_Tarihi";
            this.gelisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gelisTarihiDataGridViewTextBoxColumn.Name = "gelisTarihiDataGridViewTextBoxColumn";
            this.gelisTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // bitisTarihiDataGridViewTextBoxColumn1
            // 
            this.bitisTarihiDataGridViewTextBoxColumn1.DataPropertyName = "Bitis_Tarihi";
            this.bitisTarihiDataGridViewTextBoxColumn1.HeaderText = "Bitis_Tarihi";
            this.bitisTarihiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.bitisTarihiDataGridViewTextBoxColumn1.Name = "bitisTarihiDataGridViewTextBoxColumn1";
            this.bitisTarihiDataGridViewTextBoxColumn1.Width = 150;
            // 
            // BTN_Parca_Kaydet
            // 
            this.BTN_Parca_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BTN_Parca_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Parca_Kaydet.FlatAppearance.BorderSize = 0;
            this.BTN_Parca_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Parca_Kaydet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_Parca_Kaydet.ForeColor = System.Drawing.Color.White;
            this.BTN_Parca_Kaydet.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BTN_Parca_Kaydet.IconColor = System.Drawing.Color.White;
            this.BTN_Parca_Kaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Parca_Kaydet.IconSize = 1;
            this.BTN_Parca_Kaydet.Location = new System.Drawing.Point(15, 299);
            this.BTN_Parca_Kaydet.Name = "BTN_Parca_Kaydet";
            this.BTN_Parca_Kaydet.Size = new System.Drawing.Size(192, 80);
            this.BTN_Parca_Kaydet.TabIndex = 2;
            this.BTN_Parca_Kaydet.Text = "Parça Kaydet";
            this.BTN_Parca_Kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Parca_Kaydet.UseVisualStyleBackColor = false;
            //this.BTN_Parca_Kaydet.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // Atanan_Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1624, 1142);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Atanan_Islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atanan İşlemler - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Atanan_Islemler_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAssignedTasks.ResumeLayout(false);
            this.pnlAssignedTasks.ResumeLayout(false);
            this.pnlTasksList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atanan_İş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet9)).EndInit();
            this.tabPageTaskDetails.ResumeLayout(false);
            this.pnlTaskDetails.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Atanan_İş_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource1)).EndInit();
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlDeviceInfo.PerformLayout();
            this.pnlWorkProgress.ResumeLayout(false);
            this.pnlWorkProgress.PerformLayout();
            this.pnlPartsUsed.ResumeLayout(false);
            this.pnlPartsUsed.PerformLayout();
            this.pnlPartFilters.ResumeLayout(false);
            this.pnlPartFilters.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAssignedTasks;
        private System.Windows.Forms.TabPage tabPageTaskDetails;

        private System.Windows.Forms.Panel pnlAssignedTasks;
        private System.Windows.Forms.Panel pnlTasksList;
        private System.Windows.Forms.Panel pnlTaskDetails;
        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Panel pnlWorkProgress;
        private System.Windows.Forms.Panel pnlPartsUsed;
        private System.Windows.Forms.Panel pnlPartFilters;
        private System.Windows.Forms.Panel pnlActionButtons;

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox TXT_Cihaz_Ad;
        private System.Windows.Forms.Label lblBrandModel;
        private System.Windows.Forms.TextBox Txt_Marka_Model;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox TXT_Seri_No;
        private System.Windows.Forms.Label lblComplaint;
        private System.Windows.Forms.TextBox TXT_Sikayet;

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox CMB_İs_Durum;
        private System.Windows.Forms.Label lblTechnicianNotes;
        private System.Windows.Forms.TextBox TXT_Teknisyen_Not;

        private System.Windows.Forms.Label lblPartCategory;
        private System.Windows.Forms.ComboBox CMB_Parça_Kategori;
        private System.Windows.Forms.Label lblUsedParts;
        private System.Windows.Forms.ComboBox CMB_KullanılanParçaSecim;
        private System.Windows.Forms.Label lblPartQuantity;
        private System.Windows.Forms.TextBox TXT_Miktar;

        private FontAwesome.Sharp.IconButton BTN_Kaydet;
        private FontAwesome.Sharp.IconButton BTN_İptal;

        private System.Windows.Forms.DataGridView dgv_Atanan_İş;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Atanan_İş_;
        private Teknik_Servis_DBDataSet9 teknik_Servis_DBDataSet9;
        private System.Windows.Forms.BindingSource arizalarBindingSource;
        private Teknik_Servis_DBDataSet9TableAdapters.ArizalarTableAdapter arizalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknisyenIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazMarkaModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknisyenAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource arizalarBindingSource1;
        private FontAwesome.Sharp.IconButton BTN_Ana_Sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn1;
        private FontAwesome.Sharp.IconButton BTN_Parca_Kaydet;
    }
}