namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Musteri_Yonetim_Form
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new FontAwesome.Sharp.IconButton();
            this.btnClearFilter = new FontAwesome.Sharp.IconButton();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.teknik_Servis_DBDataSet = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet();
            this.teknikServisDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arizalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arizalarTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSetTableAdapters.ArizalarTableAdapter();
            this.teknik_Servis_DBDataSet4 = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet4();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet4TableAdapters.MusterilerTableAdapter();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acıkAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknikServisDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1417, 80);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 Müşteri Takip";
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
            this.btnHome.Location = new System.Drawing.Point(2537, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblCity);
            this.pnlFilter.Controls.Add(this.cmbCity);
            this.pnlFilter.Controls.Add(this.lblDeviceType);
            this.pnlFilter.Controls.Add(this.cmbDeviceType);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnClearFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 80);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlFilter.Size = new System.Drawing.Size(1417, 100);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCity.Location = new System.Drawing.Point(15, 15);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(100, 28);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "🏙️  Şehir";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Tüm Şehirler",
            "Tekirdağ",
            "İstanbul",
            "Edirne",
            "Balıkesir",
            "Aydın",
            "Muğla",
            "Antalya",
            "Adana",
            "Eskişehir",
            "Ordu",
            "Erzincan",
            "Erzurum",
            "Kocaeli",
            "İzmir"});
            this.cmbCity.Location = new System.Drawing.Point(18, 46);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(200, 36);
            this.cmbCity.TabIndex = 0;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDeviceType.Location = new System.Drawing.Point(240, 15);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(146, 28);
            this.lblDeviceType.TabIndex = 1;
            this.lblDeviceType.Text = "💻 Cihaz Türü";
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Items.AddRange(new object[] {
            "Tüm Cihazlar",
            "Bilgisayar",
            "Laptop",
            "Tablet",
            "Telefon",
            "Yazıcı",
            "Sunucu",
            "Ağ Cihazı"});
            this.cmbDeviceType.Location = new System.Drawing.Point(245, 46);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(200, 36);
            this.cmbDeviceType.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilter.IconColor = System.Drawing.Color.White;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 20;
            this.btnFilter.Location = new System.Drawing.Point(455, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(162, 38);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnClearFilter.IconColor = System.Drawing.Color.White;
            this.btnClearFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilter.IconSize = 20;
            this.btnClearFilter.Location = new System.Drawing.Point(636, 40);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(172, 38);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Filtre Kaldır";
            this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvCustomers);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 180);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDataGrid.Size = new System.Drawing.Size(1417, 620);
            this.pnlDataGrid.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersHeight = 35;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ılDataGridViewTextBoxColumn,
            this.ılceDataGridViewTextBoxColumn,
            this.acıkAdresDataGridViewTextBoxColumn,
            this.kayıtTarihDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.musterilerBindingSource;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(10, 10);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1397, 600);
            this.dgvCustomers.TabIndex = 0;
            // 
            // teknik_Servis_DBDataSet
            // 
            this.teknik_Servis_DBDataSet.DataSetName = "Teknik_Servis_DBDataSet";
            this.teknik_Servis_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teknikServisDBDataSetBindingSource
            // 
            this.teknikServisDBDataSetBindingSource.DataSource = this.teknik_Servis_DBDataSet;
            this.teknikServisDBDataSetBindingSource.Position = 0;
            // 
            // arizalarBindingSource
            // 
            this.arizalarBindingSource.DataMember = "Arizalar";
            this.arizalarBindingSource.DataSource = this.teknikServisDBDataSetBindingSource;
            // 
            // arizalarTableAdapter
            // 
            this.arizalarTableAdapter.ClearBeforeFill = true;
            // 
            // teknik_Servis_DBDataSet4
            // 
            this.teknik_Servis_DBDataSet4.DataSetName = "Teknik_Servis_DBDataSet4";
            this.teknik_Servis_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.teknik_Servis_DBDataSet4;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "Musteri_ID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "Musteri_ID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "Telefon_No";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ılDataGridViewTextBoxColumn
            // 
            this.ılDataGridViewTextBoxColumn.DataPropertyName = "Il";
            this.ılDataGridViewTextBoxColumn.HeaderText = "Il";
            this.ılDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ılDataGridViewTextBoxColumn.Name = "ılDataGridViewTextBoxColumn";
            this.ılDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ılceDataGridViewTextBoxColumn
            // 
            this.ılceDataGridViewTextBoxColumn.DataPropertyName = "Ilce";
            this.ılceDataGridViewTextBoxColumn.HeaderText = "Ilce";
            this.ılceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ılceDataGridViewTextBoxColumn.Name = "ılceDataGridViewTextBoxColumn";
            this.ılceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acıkAdresDataGridViewTextBoxColumn
            // 
            this.acıkAdresDataGridViewTextBoxColumn.DataPropertyName = "Acık_Adres";
            this.acıkAdresDataGridViewTextBoxColumn.HeaderText = "Acık_Adres";
            this.acıkAdresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.acıkAdresDataGridViewTextBoxColumn.Name = "acıkAdresDataGridViewTextBoxColumn";
            this.acıkAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kayıtTarihDataGridViewTextBoxColumn
            // 
            this.kayıtTarihDataGridViewTextBoxColumn.DataPropertyName = "Kayıt_Tarih";
            this.kayıtTarihDataGridViewTextBoxColumn.HeaderText = "Kayıt_Tarih";
            this.kayıtTarihDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kayıtTarihDataGridViewTextBoxColumn.Name = "kayıtTarihDataGridViewTextBoxColumn";
            this.kayıtTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Musteri_Yonetim_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1417, 800);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Musteri_Yonetim_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Musteri_Yonetim_Form_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknikServisDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private FontAwesome.Sharp.IconButton btnFilter;
        private FontAwesome.Sharp.IconButton btnClearFilter;

        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.BindingSource teknikServisDBDataSetBindingSource;
        private Teknik_Servis_DBDataSet teknik_Servis_DBDataSet;
        private System.Windows.Forms.BindingSource arizalarBindingSource;
        private Teknik_Servis_DBDataSetTableAdapters.ArizalarTableAdapter arizalarTableAdapter;
        private Teknik_Servis_DBDataSet4 teknik_Servis_DBDataSet4;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private Teknik_Servis_DBDataSet4TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acıkAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtTarihDataGridViewTextBoxColumn;
    }
}