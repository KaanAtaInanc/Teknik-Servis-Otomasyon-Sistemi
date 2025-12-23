namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Ariza_Paneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgv_Ariza_Kayit = new System.Windows.Forms.DataGridView();
            this.arizalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teknik_Servis_DBDataSet = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.CMB_Durum = new System.Windows.Forms.ComboBox();
            this.Btn_Filter = new System.Windows.Forms.Button();
            this.BTN_Filtre_Kaldır = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.teknik_Servis_DBDataSet2 = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet2();
            this.teknikServisDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arizalarTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSetTableAdapters.ArizalarTableAdapter();
            this.cihazAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cihazMarkaModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teknisyenAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ariza_Kayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet)).BeginInit();
            this.pnlSearchFilter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknikServisDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 150);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1805, 988);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageList
            // 
            this.tabPageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabPageList.Controls.Add(this.pnlList);
            this.tabPageList.Location = new System.Drawing.Point(4, 37);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageList.Size = new System.Drawing.Size(1797, 947);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "📋 Arıza Listesi";
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Controls.Add(this.pnlDataGrid);
            this.pnlList.Controls.Add(this.pnlSearchFilter);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(10, 10);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1777, 927);
            this.pnlList.TabIndex = 0;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgv_Ariza_Kayit);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 100);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDataGrid.Size = new System.Drawing.Size(1777, 827);
            this.pnlDataGrid.TabIndex = 0;
            // 
            // dgv_Ariza_Kayit
            // 
            this.dgv_Ariza_Kayit.AllowUserToAddRows = false;
            this.dgv_Ariza_Kayit.AllowUserToDeleteRows = false;
            this.dgv_Ariza_Kayit.AutoGenerateColumns = false;
            this.dgv_Ariza_Kayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ariza_Kayit.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ariza_Kayit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Ariza_Kayit.ColumnHeadersHeight = 35;
            this.dgv_Ariza_Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Ariza_Kayit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cihazAdDataGridViewTextBoxColumn,
            this.cihazMarkaModelDataGridViewTextBoxColumn,
            this.seriNoDataGridViewTextBoxColumn,
            this.musteriSikayetDataGridViewTextBoxColumn,
            this.gelisTarihiDataGridViewTextBoxColumn,
            this.atamaTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn,
            this.teknisyenAciklamaDataGridViewTextBoxColumn});
            this.dgv_Ariza_Kayit.DataSource = this.arizalarBindingSource;
            this.dgv_Ariza_Kayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ariza_Kayit.Location = new System.Drawing.Point(10, 10);
            this.dgv_Ariza_Kayit.Name = "dgv_Ariza_Kayit";
            this.dgv_Ariza_Kayit.ReadOnly = true;
            this.dgv_Ariza_Kayit.RowHeadersVisible = false;
            this.dgv_Ariza_Kayit.RowHeadersWidth = 62;
            this.dgv_Ariza_Kayit.RowTemplate.Height = 28;
            this.dgv_Ariza_Kayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ariza_Kayit.Size = new System.Drawing.Size(1757, 807);
            this.dgv_Ariza_Kayit.TabIndex = 0;
            // 
            // arizalarBindingSource
            // 
            this.arizalarBindingSource.DataMember = "Arizalar";
            this.arizalarBindingSource.DataSource = this.teknik_Servis_DBDataSet;
            // 
            // teknik_Servis_DBDataSet
            // 
            this.teknik_Servis_DBDataSet.DataSetName = "Teknik_Servis_DBDataSet";
            this.teknik_Servis_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlSearchFilter
            // 
            this.pnlSearchFilter.BackColor = System.Drawing.Color.White;
            this.pnlSearchFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchFilter.Controls.Add(this.lblStatus);
            this.pnlSearchFilter.Controls.Add(this.CMB_Durum);
            this.pnlSearchFilter.Controls.Add(this.Btn_Filter);
            this.pnlSearchFilter.Controls.Add(this.BTN_Filtre_Kaldır);
            this.pnlSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSearchFilter.Size = new System.Drawing.Size(1777, 100);
            this.pnlSearchFilter.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(18, -1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(111, 28);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "📊 Durum";
            // 
            // CMB_Durum
            // 
            this.CMB_Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Durum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Durum.FormattingEnabled = true;
            this.CMB_Durum.Items.AddRange(new object[] {
            "Tüm Durumlar",
            "Beklemede",
            "Bakımda",
            "Tamamlandı",
            "İptal Edildi"});
            this.CMB_Durum.Location = new System.Drawing.Point(23, 36);
            this.CMB_Durum.Name = "CMB_Durum";
            this.CMB_Durum.Size = new System.Drawing.Size(250, 46);
            this.CMB_Durum.TabIndex = 1;
            // 
            // Btn_Filter
            // 
            this.Btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Btn_Filter.FlatAppearance.BorderSize = 0;
            this.Btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filter.ForeColor = System.Drawing.Color.White;
            this.Btn_Filter.Location = new System.Drawing.Point(351, 16);
            this.Btn_Filter.Name = "Btn_Filter";
            this.Btn_Filter.Size = new System.Drawing.Size(248, 64);
            this.Btn_Filter.TabIndex = 2;
            this.Btn_Filter.Text = "🔍 Filtrele";
            this.Btn_Filter.UseVisualStyleBackColor = false;
            this.Btn_Filter.Click += new System.EventHandler(this.BTN_Filter_Click);
            // 
            // BTN_Filtre_Kaldır
            // 
            this.BTN_Filtre_Kaldır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Filtre_Kaldır.FlatAppearance.BorderSize = 0;
            this.BTN_Filtre_Kaldır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Filtre_Kaldır.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Filtre_Kaldır.ForeColor = System.Drawing.Color.White;
            this.BTN_Filtre_Kaldır.Location = new System.Drawing.Point(701, 16);
            this.BTN_Filtre_Kaldır.Name = "BTN_Filtre_Kaldır";
            this.BTN_Filtre_Kaldır.Size = new System.Drawing.Size(245, 64);
            this.BTN_Filtre_Kaldır.TabIndex = 3;
            this.BTN_Filtre_Kaldır.Text = "🔄 Filtre Kaldır";
            this.BTN_Filtre_Kaldır.UseVisualStyleBackColor = false;
            this.BTN_Filtre_Kaldır.Click += new System.EventHandler(this.BTN_Filtre_Kaldır_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnHome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1805, 150);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "⚠️ Arıza Kayıtları";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(2925, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "🏠 Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // teknik_Servis_DBDataSet2
            // 
            this.teknik_Servis_DBDataSet2.DataSetName = "Teknik_Servis_DBDataSet2";
            this.teknik_Servis_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teknikServisDBDataSet2BindingSource
            // 
            this.teknikServisDBDataSet2BindingSource.DataSource = this.teknik_Servis_DBDataSet2;
            this.teknikServisDBDataSet2BindingSource.Position = 0;
            // 
            // arizalarTableAdapter
            // 
            this.arizalarTableAdapter.ClearBeforeFill = true;
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
            // gelisTarihiDataGridViewTextBoxColumn
            // 
            this.gelisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Gelis_Tarihi";
            this.gelisTarihiDataGridViewTextBoxColumn.HeaderText = "Gelis_Tarihi";
            this.gelisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gelisTarihiDataGridViewTextBoxColumn.Name = "gelisTarihiDataGridViewTextBoxColumn";
            this.gelisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atamaTarihiDataGridViewTextBoxColumn
            // 
            this.atamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "Atama_Tarihi";
            this.atamaTarihiDataGridViewTextBoxColumn.HeaderText = "Atama_Tarihi";
            this.atamaTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.atamaTarihiDataGridViewTextBoxColumn.Name = "atamaTarihiDataGridViewTextBoxColumn";
            this.atamaTarihiDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Ariza_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 1138);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Ariza_Paneli";
            this.Text = "Ariza_Paneli";
            this.Load += new System.EventHandler(this.Ariza_Paneli_Load_1);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ariza_Kayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arizalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet)).EndInit();
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teknik_Servis_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teknikServisDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgv_Ariza_Kayit;
        private System.Windows.Forms.Panel pnlSearchFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox CMB_Durum;
        private System.Windows.Forms.Button Btn_Filter;
        private System.Windows.Forms.Button BTN_Filtre_Kaldır;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.BindingSource teknikServisDBDataSet2BindingSource;
        private Teknik_Servis_DBDataSet2 teknik_Servis_DBDataSet2;
        private Teknik_Servis_DBDataSet teknik_Servis_DBDataSet;
        private System.Windows.Forms.BindingSource arizalarBindingSource;
        private Teknik_Servis_DBDataSetTableAdapters.ArizalarTableAdapter arizalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cihazMarkaModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknisyenAciklamaDataGridViewTextBoxColumn;
    }
}