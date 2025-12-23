namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Raporlama_Paneli
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlReportSelection = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.btnStockReport = new FontAwesome.Sharp.IconButton();
            this.btnFaultReport = new FontAwesome.Sharp.IconButton();
            this.btnCustomerReport = new FontAwesome.Sharp.IconButton();
            this.pnlDateRange = new System.Windows.Forms.Panel();
            this.btnFiltreKaldır = new FontAwesome.Sharp.IconButton();
            this.btnFiltre = new FontAwesome.Sharp.IconButton();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnExportExcel = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            this.pnlReportSelection.SuspendLayout();
            this.pnlDateRange.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlActions.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1480, 95);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 Raporlama";
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
            this.btnHome.Location = new System.Drawing.Point(2600, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(140, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlReportSelection
            // 
            this.pnlReportSelection.BackColor = System.Drawing.Color.White;
            this.pnlReportSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportSelection.Controls.Add(this.lblReportType);
            this.pnlReportSelection.Controls.Add(this.btnStockReport);
            this.pnlReportSelection.Controls.Add(this.btnFaultReport);
            this.pnlReportSelection.Controls.Add(this.btnCustomerReport);
            this.pnlReportSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportSelection.Location = new System.Drawing.Point(0, 95);
            this.pnlReportSelection.Name = "pnlReportSelection";
            this.pnlReportSelection.Padding = new System.Windows.Forms.Padding(15);
            this.pnlReportSelection.Size = new System.Drawing.Size(1480, 130);
            this.pnlReportSelection.TabIndex = 1;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblReportType.Location = new System.Drawing.Point(14, 4);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(264, 32);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "📋 Rapor Türü Seçimi";
            // 
            // btnStockReport
            // 
            this.btnStockReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnStockReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockReport.FlatAppearance.BorderSize = 0;
            this.btnStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStockReport.ForeColor = System.Drawing.Color.White;
            this.btnStockReport.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnStockReport.IconColor = System.Drawing.Color.White;
            this.btnStockReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStockReport.IconSize = 20;
            this.btnStockReport.Location = new System.Drawing.Point(15, 50);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(172, 60);
            this.btnStockReport.TabIndex = 1;
            this.btnStockReport.Text = "Stok Raporu";
            this.btnStockReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockReport.UseVisualStyleBackColor = false;
            // 
            // btnFaultReport
            // 
            this.btnFaultReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnFaultReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaultReport.FlatAppearance.BorderSize = 0;
            this.btnFaultReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaultReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFaultReport.ForeColor = System.Drawing.Color.White;
            this.btnFaultReport.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnFaultReport.IconColor = System.Drawing.Color.White;
            this.btnFaultReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFaultReport.IconSize = 20;
            this.btnFaultReport.Location = new System.Drawing.Point(204, 50);
            this.btnFaultReport.Name = "btnFaultReport";
            this.btnFaultReport.Size = new System.Drawing.Size(189, 60);
            this.btnFaultReport.TabIndex = 2;
            this.btnFaultReport.Text = "Arıza Raporu";
            this.btnFaultReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaultReport.UseVisualStyleBackColor = false;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnCustomerReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCustomerReport.ForeColor = System.Drawing.Color.White;
            this.btnCustomerReport.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnCustomerReport.IconColor = System.Drawing.Color.White;
            this.btnCustomerReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerReport.IconSize = 20;
            this.btnCustomerReport.Location = new System.Drawing.Point(413, 50);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(196, 60);
            this.btnCustomerReport.TabIndex = 3;
            this.btnCustomerReport.Text = "Müşteri Raporu";
            this.btnCustomerReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerReport.UseVisualStyleBackColor = false;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click_1);
            // 
            // pnlDateRange
            // 
            this.pnlDateRange.BackColor = System.Drawing.Color.White;
            this.pnlDateRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDateRange.Controls.Add(this.btnFiltreKaldır);
            this.pnlDateRange.Controls.Add(this.btnFiltre);
            this.pnlDateRange.Controls.Add(this.lblDateRange);
            this.pnlDateRange.Controls.Add(this.lblStartDate);
            this.pnlDateRange.Controls.Add(this.dtpStartDate);
            this.pnlDateRange.Controls.Add(this.lblEndDate);
            this.pnlDateRange.Controls.Add(this.dtpEndDate);
            this.pnlDateRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateRange.Location = new System.Drawing.Point(0, 225);
            this.pnlDateRange.Name = "pnlDateRange";
            this.pnlDateRange.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDateRange.Size = new System.Drawing.Size(1480, 129);
            this.pnlDateRange.TabIndex = 2;
            // 
            // btnFiltreKaldır
            // 
            this.btnFiltreKaldır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnFiltreKaldır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreKaldır.FlatAppearance.BorderSize = 0;
            this.btnFiltreKaldır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreKaldır.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltreKaldır.ForeColor = System.Drawing.Color.White;
            this.btnFiltreKaldır.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnFiltreKaldır.IconColor = System.Drawing.Color.White;
            this.btnFiltreKaldır.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltreKaldır.IconSize = 20;
            this.btnFiltreKaldır.Location = new System.Drawing.Point(1123, 49);
            this.btnFiltreKaldır.Name = "btnFiltreKaldır";
            this.btnFiltreKaldır.Size = new System.Drawing.Size(196, 60);
            this.btnFiltreKaldır.TabIndex = 5;
            this.btnFiltreKaldır.Text = "Filtre Kaldır";
            this.btnFiltreKaldır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltreKaldır.UseVisualStyleBackColor = false;
            // 
            // btnFiltre
            // 
            this.btnFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnFiltre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltre.FlatAppearance.BorderSize = 0;
            this.btnFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltre.ForeColor = System.Drawing.Color.White;
            this.btnFiltre.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnFiltre.IconColor = System.Drawing.Color.White;
            this.btnFiltre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltre.IconSize = 20;
            this.btnFiltre.Location = new System.Drawing.Point(909, 49);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(196, 60);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltre.UseVisualStyleBackColor = false;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDateRange.Location = new System.Drawing.Point(14, 15);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(275, 32);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "📅 Tarih Aralığı Seçimi";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStartDate.Location = new System.Drawing.Point(18, 67);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(148, 28);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(172, 67);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(291, 34);
            this.dtpStartDate.TabIndex = 0;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEndDate.Location = new System.Drawing.Point(481, 67);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(103, 28);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Bitiş Tarihi:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Location = new System.Drawing.Point(599, 68);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(290, 34);
            this.dtpEndDate.TabIndex = 1;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvReport);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 354);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDataGrid.Size = new System.Drawing.Size(1480, 499);
            this.pnlDataGrid.TabIndex = 3;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReport.ColumnHeadersHeight = 35;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(10, 10);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowHeadersWidth = 62;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1460, 479);
            this.dgvReport.TabIndex = 0;
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.btnExportExcel);
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 750);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActions.Size = new System.Drawing.Size(1400, 80);
            this.pnlActions.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportExcel.IconColor = System.Drawing.Color.White;
            this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcel.IconSize = 24;
            this.btnExportExcel.Location = new System.Drawing.Point(15, 15);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(180, 50);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Excel\'e Aktar";
            this.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 24;
            this.btnRefresh.Location = new System.Drawing.Point(210, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 24;
            this.btnClear.Location = new System.Drawing.Point(365, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Temizle";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // Raporlama_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1480, 853);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlDateRange);
            this.Controls.Add(this.pnlReportSelection);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Raporlama_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Raporlama_Paneli_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlReportSelection.ResumeLayout(false);
            this.pnlReportSelection.PerformLayout();
            this.pnlDateRange.ResumeLayout(false);
            this.pnlDateRange.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnHome;

        private System.Windows.Forms.Panel pnlReportSelection;
        private System.Windows.Forms.Label lblReportType;
        private FontAwesome.Sharp.IconButton btnStockReport;
        private FontAwesome.Sharp.IconButton btnFaultReport;
        private FontAwesome.Sharp.IconButton btnCustomerReport;

        private System.Windows.Forms.Panel pnlDateRange;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;

        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvReport;

        private System.Windows.Forms.Panel pnlActions;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnFiltreKaldır;
        private FontAwesome.Sharp.IconButton btnFiltre;
    }
}