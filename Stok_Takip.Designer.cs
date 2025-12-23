namespace Teknik_Servis_Otomasyon_Sistemi_Proje_1_
{
    partial class Stok_Takip
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
            this.pnlÜst = new System.Windows.Forms.Panel();
            this.lblBaşlık = new System.Windows.Forms.Label();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.sekmeKontrolAna = new System.Windows.Forms.TabControl();
            this.sekmeİşlemler = new System.Windows.Forms.TabPage();
            this.pnlİşlemler = new System.Windows.Forms.Panel();
            this.grpSonEklenenler = new System.Windows.Forms.GroupBox();
            this.dgv_Parcalar = new System.Windows.Forms.DataGridView();
            this.pnlStokFormu = new System.Windows.Forms.Panel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblParcaAdı = new System.Windows.Forms.Label();
            this.txtParcaAdı = new System.Windows.Forms.TextBox();
            this.lblMarkaModel = new System.Windows.Forms.Label();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.lblStokAdedi = new System.Windows.Forms.Label();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.lblKritikSeviye = new System.Windows.Forms.Label();
            this.txtKritikSeviye = new System.Windows.Forms.TextBox();
            this.pnlİşlemDugmeleri = new System.Windows.Forms.Panel();
            this.btnStokArttır = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.sekmeStokListesi = new System.Windows.Forms.TabPage();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.pnlVerileriTablosu = new System.Windows.Forms.Panel();
            this.dgvStok = new System.Windows.Forms.DataGridView();
            this.parcaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mevcutStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kritikSeviyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifMiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kaynakParçalar = new System.Windows.Forms.BindingSource(this.components);
            this.veriKümesi = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet8();
            this.pnlAramaFiltre = new System.Windows.Forms.Panel();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lblKategoriyeGöre = new System.Windows.Forms.Label();
            this.cmbKategoriFiltre = new System.Windows.Forms.ComboBox();
            this.btnFiltreyiKaldır = new System.Windows.Forms.Button();
            this.parçalarTableAdapter = new Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet8TableAdapters.ParcalarTableAdapter();
            this.pnlÜst.SuspendLayout();
            this.sekmeKontrolAna.SuspendLayout();
            this.sekmeİşlemler.SuspendLayout();
            this.pnlİşlemler.SuspendLayout();
            this.grpSonEklenenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcalar)).BeginInit();
            this.pnlStokFormu.SuspendLayout();
            this.pnlİşlemDugmeleri.SuspendLayout();
            this.sekmeStokListesi.SuspendLayout();
            this.pnlListe.SuspendLayout();
            this.pnlVerileriTablosu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakParçalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriKümesi)).BeginInit();
            this.pnlAramaFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlÜst
            // 
            this.pnlÜst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlÜst.Controls.Add(this.lblBaşlık);
            this.pnlÜst.Controls.Add(this.btnAnaSayfa);
            this.pnlÜst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlÜst.Location = new System.Drawing.Point(0, 0);
            this.pnlÜst.Name = "pnlÜst";
            this.pnlÜst.Size = new System.Drawing.Size(1460, 121);
            this.pnlÜst.TabIndex = 1;
            // 
            // lblBaşlık
            // 
            this.lblBaşlık.AutoSize = true;
            this.lblBaşlık.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaşlık.ForeColor = System.Drawing.Color.White;
            this.lblBaşlık.Location = new System.Drawing.Point(20, 20);
            this.lblBaşlık.Name = "lblBaşlık";
            this.lblBaşlık.Size = new System.Drawing.Size(422, 65);
            this.lblBaşlık.TabIndex = 0;
            this.lblBaşlık.Text = "📦 Stok Yönetimi";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Location = new System.Drawing.Point(1275, 20);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(140, 40);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "🏠 Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // sekmeKontrolAna
            // 
            this.sekmeKontrolAna.Controls.Add(this.sekmeİşlemler);
            this.sekmeKontrolAna.Controls.Add(this.sekmeStokListesi);
            this.sekmeKontrolAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sekmeKontrolAna.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sekmeKontrolAna.Location = new System.Drawing.Point(0, 121);
            this.sekmeKontrolAna.Name = "sekmeKontrolAna";
            this.sekmeKontrolAna.SelectedIndex = 0;
            this.sekmeKontrolAna.Size = new System.Drawing.Size(1460, 802);
            this.sekmeKontrolAna.TabIndex = 0;
            // 
            // sekmeİşlemler
            // 
            this.sekmeİşlemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.sekmeİşlemler.Controls.Add(this.pnlİşlemler);
            this.sekmeİşlemler.Location = new System.Drawing.Point(4, 37);
            this.sekmeİşlemler.Name = "sekmeİşlemler";
            this.sekmeİşlemler.Padding = new System.Windows.Forms.Padding(10);
            this.sekmeİşlemler.Size = new System.Drawing.Size(1452, 761);
            this.sekmeİşlemler.TabIndex = 0;
            this.sekmeİşlemler.Text = "➕ İşlemler";
            // 
            // pnlİşlemler
            // 
            this.pnlİşlemler.AutoScroll = true;
            this.pnlİşlemler.BackColor = System.Drawing.Color.White;
            this.pnlİşlemler.Controls.Add(this.grpSonEklenenler);
            this.pnlİşlemler.Controls.Add(this.pnlStokFormu);
            this.pnlİşlemler.Controls.Add(this.pnlİşlemDugmeleri);
            this.pnlİşlemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlİşlemler.Location = new System.Drawing.Point(10, 10);
            this.pnlİşlemler.Name = "pnlİşlemler";
            this.pnlİşlemler.Size = new System.Drawing.Size(1432, 741);
            this.pnlİşlemler.TabIndex = 0;
            // 
            // grpSonEklenenler
            // 
            this.grpSonEklenenler.Controls.Add(this.dgv_Parcalar);
            this.grpSonEklenenler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSonEklenenler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpSonEklenenler.Location = new System.Drawing.Point(10, 411);
            this.grpSonEklenenler.Name = "grpSonEklenenler";
            this.grpSonEklenenler.Size = new System.Drawing.Size(1370, 344);
            this.grpSonEklenenler.TabIndex = 2;
            this.grpSonEklenenler.TabStop = false;
            this.grpSonEklenenler.Text = "📋 Parçalar";
            // 
            // dgv_Parcalar
            // 
            this.dgv_Parcalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Parcalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Parcalar.Location = new System.Drawing.Point(3, 30);
            this.dgv_Parcalar.Name = "dgv_Parcalar";
            this.dgv_Parcalar.RowHeadersWidth = 62;
            this.dgv_Parcalar.RowTemplate.Height = 28;
            this.dgv_Parcalar.Size = new System.Drawing.Size(1364, 311);
            this.dgv_Parcalar.TabIndex = 0;
            this.dgv_Parcalar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Parcalar_CellDoubleClick);
            // 
            // pnlStokFormu
            // 
            this.pnlStokFormu.BackColor = System.Drawing.Color.White;
            this.pnlStokFormu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStokFormu.Controls.Add(this.lblKategori);
            this.pnlStokFormu.Controls.Add(this.cmbKategori);
            this.pnlStokFormu.Controls.Add(this.lblParcaAdı);
            this.pnlStokFormu.Controls.Add(this.txtParcaAdı);
            this.pnlStokFormu.Controls.Add(this.lblMarkaModel);
            this.pnlStokFormu.Controls.Add(this.txtMarkaModel);
            this.pnlStokFormu.Controls.Add(this.lblStokAdedi);
            this.pnlStokFormu.Controls.Add(this.txtStokAdedi);
            this.pnlStokFormu.Controls.Add(this.lblKritikSeviye);
            this.pnlStokFormu.Controls.Add(this.txtKritikSeviye);
            this.pnlStokFormu.Location = new System.Drawing.Point(10, 48);
            this.pnlStokFormu.Name = "pnlStokFormu";
            this.pnlStokFormu.Padding = new System.Windows.Forms.Padding(15);
            this.pnlStokFormu.Size = new System.Drawing.Size(1370, 196);
            this.pnlStokFormu.TabIndex = 0;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKategori.Location = new System.Drawing.Point(10, 15);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(133, 28);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "🏷️  Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategori.Items.AddRange(new object[] {
            "Kategori Seçiniz",
            "Ekran",
            "Batarya",
            "Kasa",
            "Bellek (RAM)",
            "Depolama (SSD/HDD)",
            "Konnektör",
            "Şarj Aleti",
            "Başka"});
            this.cmbKategori.Location = new System.Drawing.Point(15, 48);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(320, 44);
            this.cmbKategori.TabIndex = 1;
            // 
            // lblParcaAdı
            // 
            this.lblParcaAdı.AutoSize = true;
            this.lblParcaAdı.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblParcaAdı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblParcaAdı.Location = new System.Drawing.Point(360, 15);
            this.lblParcaAdı.Name = "lblParcaAdı";
            this.lblParcaAdı.Size = new System.Drawing.Size(136, 28);
            this.lblParcaAdı.TabIndex = 2;
            this.lblParcaAdı.Text = "📦 Parça Adı";
            // 
            // txtParcaAdı
            // 
            this.txtParcaAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParcaAdı.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcaAdı.Location = new System.Drawing.Point(360, 48);
            this.txtParcaAdı.Name = "txtParcaAdı";
            this.txtParcaAdı.Size = new System.Drawing.Size(320, 42);
            this.txtParcaAdı.TabIndex = 3;
            // 
            // lblMarkaModel
            // 
            this.lblMarkaModel.AutoSize = true;
            this.lblMarkaModel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarkaModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMarkaModel.Location = new System.Drawing.Point(705, 15);
            this.lblMarkaModel.Name = "lblMarkaModel";
            this.lblMarkaModel.Size = new System.Drawing.Size(181, 28);
            this.lblMarkaModel.TabIndex = 4;
            this.lblMarkaModel.Text = "🏷️  Marka/Model";
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkaModel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkaModel.Location = new System.Drawing.Point(710, 48);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(320, 42);
            this.txtMarkaModel.TabIndex = 5;
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.AutoSize = true;
            this.lblStokAdedi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStokAdedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStokAdedi.Location = new System.Drawing.Point(1050, 15);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(149, 28);
            this.lblStokAdedi.TabIndex = 6;
            this.lblStokAdedi.Text = "📊 Stok Adedi";
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStokAdedi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokAdedi.Location = new System.Drawing.Point(1055, 48);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(290, 42);
            this.txtStokAdedi.TabIndex = 7;
            // 
            // lblKritikSeviye
            // 
            this.lblKritikSeviye.AutoSize = true;
            this.lblKritikSeviye.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKritikSeviye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKritikSeviye.Location = new System.Drawing.Point(15, 105);
            this.lblKritikSeviye.Name = "lblKritikSeviye";
            this.lblKritikSeviye.Size = new System.Drawing.Size(171, 28);
            this.lblKritikSeviye.TabIndex = 8;
            this.lblKritikSeviye.Text = "⚠️  Kritik Seviye";
            // 
            // txtKritikSeviye
            // 
            this.txtKritikSeviye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKritikSeviye.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKritikSeviye.Location = new System.Drawing.Point(15, 138);
            this.txtKritikSeviye.Name = "txtKritikSeviye";
            this.txtKritikSeviye.Size = new System.Drawing.Size(320, 42);
            this.txtKritikSeviye.TabIndex = 9;
            this.txtKritikSeviye.Text = "10";
            // 
            // pnlİşlemDugmeleri
            // 
            this.pnlİşlemDugmeleri.BackColor = System.Drawing.Color.White;
            this.pnlİşlemDugmeleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlİşlemDugmeleri.Controls.Add(this.btnStokArttır);
            this.pnlİşlemDugmeleri.Controls.Add(this.btnEkle);
            this.pnlİşlemDugmeleri.Controls.Add(this.btnDüzenle);
            this.pnlİşlemDugmeleri.Controls.Add(this.btnSil);
            this.pnlİşlemDugmeleri.Controls.Add(this.btnTemizle);
            this.pnlİşlemDugmeleri.Location = new System.Drawing.Point(10, 268);
            this.pnlİşlemDugmeleri.Name = "pnlİşlemDugmeleri";
            this.pnlİşlemDugmeleri.Padding = new System.Windows.Forms.Padding(15);
            this.pnlİşlemDugmeleri.Size = new System.Drawing.Size(1370, 107);
            this.pnlİşlemDugmeleri.TabIndex = 1;
            // 
            // btnStokArttır
            // 
            this.btnStokArttır.BackColor = System.Drawing.Color.Teal;
            this.btnStokArttır.FlatAppearance.BorderSize = 0;
            this.btnStokArttır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokArttır.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokArttır.ForeColor = System.Drawing.Color.White;
            this.btnStokArttır.Location = new System.Drawing.Point(263, 17);
            this.btnStokArttır.Name = "btnStokArttır";
            this.btnStokArttır.Size = new System.Drawing.Size(252, 72);
            this.btnStokArttır.TabIndex = 4;
            this.btnStokArttır.Text = "+ Stok Arttır";
            this.btnStokArttır.UseVisualStyleBackColor = false;
            this.btnStokArttır.Click += new System.EventHandler(this.btnStokArttır_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(15, 18);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(232, 72);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "✅ Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnDüzenle.FlatAppearance.BorderSize = 0;
            this.btnDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDüzenle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDüzenle.ForeColor = System.Drawing.Color.White;
            this.btnDüzenle.Location = new System.Drawing.Point(531, 17);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(252, 70);
            this.btnDüzenle.TabIndex = 1;
            this.btnDüzenle.Text = "✏️  Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(804, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(194, 70);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "🗑️  Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(1023, 18);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(208, 70);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "🧹 Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // sekmeStokListesi
            // 
            this.sekmeStokListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.sekmeStokListesi.Controls.Add(this.pnlListe);
            this.sekmeStokListesi.Location = new System.Drawing.Point(4, 37);
            this.sekmeStokListesi.Name = "sekmeStokListesi";
            this.sekmeStokListesi.Padding = new System.Windows.Forms.Padding(10);
            this.sekmeStokListesi.Size = new System.Drawing.Size(1452, 761);
            this.sekmeStokListesi.TabIndex = 1;
            this.sekmeStokListesi.Text = "📋 Stok Listesi";
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.Color.White;
            this.pnlListe.Controls.Add(this.pnlVerileriTablosu);
            this.pnlListe.Controls.Add(this.pnlAramaFiltre);
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListe.Location = new System.Drawing.Point(10, 10);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1432, 741);
            this.pnlListe.TabIndex = 0;
            // 
            // pnlVerileriTablosu
            // 
            this.pnlVerileriTablosu.BackColor = System.Drawing.Color.White;
            this.pnlVerileriTablosu.Controls.Add(this.dgvStok);
            this.pnlVerileriTablosu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVerileriTablosu.Location = new System.Drawing.Point(0, 90);
            this.pnlVerileriTablosu.Name = "pnlVerileriTablosu";
            this.pnlVerileriTablosu.Padding = new System.Windows.Forms.Padding(10);
            this.pnlVerileriTablosu.Size = new System.Drawing.Size(1432, 651);
            this.pnlVerileriTablosu.TabIndex = 0;
            // 
            // dgvStok
            // 
            this.dgvStok.AllowUserToAddRows = false;
            this.dgvStok.AllowUserToDeleteRows = false;
            this.dgvStok.AutoGenerateColumns = false;
            this.dgvStok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStok.BackgroundColor = System.Drawing.Color.White;
            this.dgvStok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStok.ColumnHeadersHeight = 35;
            this.dgvStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcaIDDataGridViewTextBoxColumn,
            this.parcaAdDataGridViewTextBoxColumn,
            this.acıklamaDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.mevcutStokDataGridViewTextBoxColumn,
            this.kritikSeviyeDataGridViewTextBoxColumn,
            this.aktifMiDataGridViewCheckBoxColumn});
            this.dgvStok.DataSource = this.kaynakParçalar;
            this.dgvStok.Location = new System.Drawing.Point(10, 10);
            this.dgvStok.Name = "dgvStok";
            this.dgvStok.ReadOnly = true;
            this.dgvStok.RowHeadersVisible = false;
            this.dgvStok.RowHeadersWidth = 62;
            this.dgvStok.RowTemplate.Height = 28;
            this.dgvStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStok.Size = new System.Drawing.Size(1409, 628);
            this.dgvStok.TabIndex = 0;
            this.dgvStok.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStok_CellFormatting);
            // 
            // parcaIDDataGridViewTextBoxColumn
            // 
            this.parcaIDDataGridViewTextBoxColumn.DataPropertyName = "Parca_ID";
            this.parcaIDDataGridViewTextBoxColumn.HeaderText = "Parca_ID";
            this.parcaIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parcaIDDataGridViewTextBoxColumn.Name = "parcaIDDataGridViewTextBoxColumn";
            this.parcaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parcaAdDataGridViewTextBoxColumn
            // 
            this.parcaAdDataGridViewTextBoxColumn.DataPropertyName = "Parca_Ad";
            this.parcaAdDataGridViewTextBoxColumn.HeaderText = "Parca_Ad";
            this.parcaAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parcaAdDataGridViewTextBoxColumn.Name = "parcaAdDataGridViewTextBoxColumn";
            this.parcaAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acıklamaDataGridViewTextBoxColumn
            // 
            this.acıklamaDataGridViewTextBoxColumn.DataPropertyName = "Acıklama";
            this.acıklamaDataGridViewTextBoxColumn.HeaderText = "Acıklama";
            this.acıklamaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.acıklamaDataGridViewTextBoxColumn.Name = "acıklamaDataGridViewTextBoxColumn";
            this.acıklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mevcutStokDataGridViewTextBoxColumn
            // 
            this.mevcutStokDataGridViewTextBoxColumn.DataPropertyName = "Mevcut_Stok";
            this.mevcutStokDataGridViewTextBoxColumn.HeaderText = "Mevcut_Stok";
            this.mevcutStokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mevcutStokDataGridViewTextBoxColumn.Name = "mevcutStokDataGridViewTextBoxColumn";
            this.mevcutStokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kritikSeviyeDataGridViewTextBoxColumn
            // 
            this.kritikSeviyeDataGridViewTextBoxColumn.DataPropertyName = "Kritik_Seviye";
            this.kritikSeviyeDataGridViewTextBoxColumn.HeaderText = "Kritik_Seviye";
            this.kritikSeviyeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kritikSeviyeDataGridViewTextBoxColumn.Name = "kritikSeviyeDataGridViewTextBoxColumn";
            this.kritikSeviyeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktifMiDataGridViewCheckBoxColumn
            // 
            this.aktifMiDataGridViewCheckBoxColumn.DataPropertyName = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.HeaderText = "AktifMi";
            this.aktifMiDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.aktifMiDataGridViewCheckBoxColumn.Name = "aktifMiDataGridViewCheckBoxColumn";
            this.aktifMiDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // kaynakParçalar
            // 
            this.kaynakParçalar.DataMember = "Parcalar";
            this.kaynakParçalar.DataSource = this.veriKümesi;
            // 
            // veriKümesi
            // 
            this.veriKümesi.DataSetName = "Teknik_Servis_DBDataSet8";
            this.veriKümesi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlAramaFiltre
            // 
            this.pnlAramaFiltre.BackColor = System.Drawing.Color.White;
            this.pnlAramaFiltre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAramaFiltre.Controls.Add(this.btnFiltrele);
            this.pnlAramaFiltre.Controls.Add(this.lblKategoriyeGöre);
            this.pnlAramaFiltre.Controls.Add(this.cmbKategoriFiltre);
            this.pnlAramaFiltre.Controls.Add(this.btnFiltreyiKaldır);
            this.pnlAramaFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAramaFiltre.Location = new System.Drawing.Point(0, 0);
            this.pnlAramaFiltre.Name = "pnlAramaFiltre";
            this.pnlAramaFiltre.Padding = new System.Windows.Forms.Padding(15);
            this.pnlAramaFiltre.Size = new System.Drawing.Size(1432, 90);
            this.pnlAramaFiltre.TabIndex = 1;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFiltrele.FlatAppearance.BorderSize = 0;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltrele.ForeColor = System.Drawing.Color.White;
            this.btnFiltrele.Location = new System.Drawing.Point(249, 41);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(145, 44);
            this.btnFiltrele.TabIndex = 4;
            this.btnFiltrele.Text = "📁 Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // lblKategoriyeGöre
            // 
            this.lblKategoriyeGöre.AutoSize = true;
            this.lblKategoriyeGöre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategoriyeGöre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblKategoriyeGöre.Location = new System.Drawing.Point(4, 6);
            this.lblKategoriyeGöre.Name = "lblKategoriyeGöre";
            this.lblKategoriyeGöre.Size = new System.Drawing.Size(200, 28);
            this.lblKategoriyeGöre.TabIndex = 1;
            this.lblKategoriyeGöre.Text = "📂 Kategoriye Göre";
            // 
            // cmbKategoriFiltre
            // 
            this.cmbKategoriFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriFiltre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategoriFiltre.Items.AddRange(new object[] {
            "Tüm Kategoriler",
            "Ekran",
            "Batarya",
            "Kasa",
            "Bellek (RAM)",
            "Depolama (SSD/HDD)",
            "Konnektör",
            "Şarj Aleti",
            "Başka"});
            this.cmbKategoriFiltre.Location = new System.Drawing.Point(9, 43);
            this.cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            this.cmbKategoriFiltre.Size = new System.Drawing.Size(224, 40);
            this.cmbKategoriFiltre.TabIndex = 1;
            // 
            // btnFiltreyiKaldır
            // 
            this.btnFiltreyiKaldır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnFiltreyiKaldır.FlatAppearance.BorderSize = 0;
            this.btnFiltreyiKaldır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreyiKaldır.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFiltreyiKaldır.ForeColor = System.Drawing.Color.White;
            this.btnFiltreyiKaldır.Location = new System.Drawing.Point(1186, 29);
            this.btnFiltreyiKaldır.Name = "btnFiltreyiKaldır";
            this.btnFiltreyiKaldır.Size = new System.Drawing.Size(226, 41);
            this.btnFiltreyiKaldır.TabIndex = 2;
            this.btnFiltreyiKaldır.Text = "🔄 Filtre Kaldır";
            this.btnFiltreyiKaldır.UseVisualStyleBackColor = false;
            this.btnFiltreyiKaldır.Click += new System.EventHandler(this.btnFiltreyiKaldır_Click);
            // 
            // parçalarTableAdapter
            // 
            this.parçalarTableAdapter.ClearBeforeFill = true;
            // 
            // Stok_Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1460, 923);
            this.Controls.Add(this.sekmeKontrolAna);
            this.Controls.Add(this.pnlÜst);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Stok_Takip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Yönetimi - Teknik Servis Otomasyonu";
            this.Load += new System.EventHandler(this.Stok_Takip_Load);
            this.pnlÜst.ResumeLayout(false);
            this.pnlÜst.PerformLayout();
            this.sekmeKontrolAna.ResumeLayout(false);
            this.sekmeİşlemler.ResumeLayout(false);
            this.pnlİşlemler.ResumeLayout(false);
            this.grpSonEklenenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Parcalar)).EndInit();
            this.pnlStokFormu.ResumeLayout(false);
            this.pnlStokFormu.PerformLayout();
            this.pnlİşlemDugmeleri.ResumeLayout(false);
            this.sekmeStokListesi.ResumeLayout(false);
            this.pnlListe.ResumeLayout(false);
            this.pnlVerileriTablosu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakParçalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriKümesi)).EndInit();
            this.pnlAramaFiltre.ResumeLayout(false);
            this.pnlAramaFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlÜst;
        private System.Windows.Forms.Label lblBaşlık;
        private System.Windows.Forms.Button btnAnaSayfa;

        private System.Windows.Forms.TabControl sekmeKontrolAna;
        private System.Windows.Forms.TabPage sekmeİşlemler;
        private System.Windows.Forms.TabPage sekmeStokListesi;

        private System.Windows.Forms.Panel pnlİşlemler;
        private System.Windows.Forms.Panel pnlStokFormu;
        private System.Windows.Forms.Panel pnlİşlemDugmeleri;
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Panel pnlAramaFiltre;
        private System.Windows.Forms.Panel pnlVerileriTablosu;

        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblParcaAdı;
        private System.Windows.Forms.TextBox txtParcaAdı;
        private System.Windows.Forms.Label lblMarkaModel;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.Label lblStokAdedi;
        private System.Windows.Forms.TextBox txtStokAdedi;
        private System.Windows.Forms.Label lblKritikSeviye;
        private System.Windows.Forms.TextBox txtKritikSeviye;

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblKategoriyeGöre;
        private System.Windows.Forms.ComboBox cmbKategoriFiltre;
        private System.Windows.Forms.Button btnFiltreyiKaldır;

        private System.Windows.Forms.DataGridView dgvStok;
        private Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet8 veriKümesi;
        private System.Windows.Forms.BindingSource kaynakParçalar;
        private Teknik_Servis_Otomasyon_Sistemi_Proje_1_.Teknik_Servis_DBDataSet8TableAdapters.ParcalarTableAdapter parçalarTableAdapter;
        private System.Windows.Forms.Button btnStokArttır;
        private System.Windows.Forms.GroupBox grpSonEklenenler;
        private System.Windows.Forms.DataGridView dgv_Parcalar;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mevcutStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kritikSeviyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifMiDataGridViewCheckBoxColumn;
    }
}