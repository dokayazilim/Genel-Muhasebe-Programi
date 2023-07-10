namespace muhasebe
{
    partial class Form27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form27));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enpahalialis = new System.Windows.Forms.RadioButton();
            this.enucuzalis = new System.Windows.Forms.RadioButton();
            this.ortalamaagirlikliartis = new System.Windows.Forms.RadioButton();
            this.ortalamaartis = new System.Windows.Forms.RadioButton();
            this.lifo = new System.Windows.Forms.RadioButton();
            this.fifo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grubu = new System.Windows.Forms.TextBox();
            this.birimi = new System.Windows.Forms.ComboBox();
            this.stokadi = new System.Windows.Forms.TextBox();
            this.stokkodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envBirimFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envanterTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokenvanteriBindingSource = new System.Windows.Forms.BindingSource();
            this.mhsbdigerhesaplarDataSet4 = new muhasebe.mhsbdigerhesaplarDataSet4();
            this.stokenvanteriTableAdapter = new muhasebe.mhsbdigerhesaplarDataSet4TableAdapters.stokenvanteriTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokenvanteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdigerhesaplarDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
            this.filtreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelMuhasebeToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // genelMuhasebeToolStripMenuItem
            // 
            this.genelMuhasebeToolStripMenuItem.Name = "genelMuhasebeToolStripMenuItem";
            this.genelMuhasebeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.genelMuhasebeToolStripMenuItem.Text = "Genel Muhasebe";
            this.genelMuhasebeToolStripMenuItem.Click += new System.EventHandler(this.genelMuhasebeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(269, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(6, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(141, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(6, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enpahalialis);
            this.groupBox2.Controls.Add(this.enucuzalis);
            this.groupBox2.Controls.Add(this.ortalamaagirlikliartis);
            this.groupBox2.Controls.Add(this.ortalamaartis);
            this.groupBox2.Controls.Add(this.lifo);
            this.groupBox2.Controls.Add(this.fifo);
            this.groupBox2.Location = new System.Drawing.Point(6, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 156);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envanter Maliyet Tipi";
            // 
            // enpahalialis
            // 
            this.enpahalialis.AutoSize = true;
            this.enpahalialis.Location = new System.Drawing.Point(12, 134);
            this.enpahalialis.Name = "enpahalialis";
            this.enpahalialis.Size = new System.Drawing.Size(89, 17);
            this.enpahalialis.TabIndex = 10;
            this.enpahalialis.TabStop = true;
            this.enpahalialis.Text = "En Pahalı Alış";
            this.enpahalialis.UseVisualStyleBackColor = true;
            // 
            // enucuzalis
            // 
            this.enucuzalis.AutoSize = true;
            this.enucuzalis.Location = new System.Drawing.Point(12, 111);
            this.enucuzalis.Name = "enucuzalis";
            this.enucuzalis.Size = new System.Drawing.Size(85, 17);
            this.enucuzalis.TabIndex = 9;
            this.enucuzalis.TabStop = true;
            this.enucuzalis.Text = "En Ucuz Alış";
            this.enucuzalis.UseVisualStyleBackColor = true;
            // 
            // ortalamaagirlikliartis
            // 
            this.ortalamaagirlikliartis.AutoSize = true;
            this.ortalamaagirlikliartis.Location = new System.Drawing.Point(12, 88);
            this.ortalamaagirlikliartis.Name = "ortalamaagirlikliartis";
            this.ortalamaagirlikliartis.Size = new System.Drawing.Size(121, 17);
            this.ortalamaagirlikliartis.TabIndex = 8;
            this.ortalamaagirlikliartis.TabStop = true;
            this.ortalamaagirlikliartis.Text = "Ortalama Ağırlıklı Alış";
            this.ortalamaagirlikliartis.UseVisualStyleBackColor = true;
            // 
            // ortalamaartis
            // 
            this.ortalamaartis.AutoSize = true;
            this.ortalamaartis.Location = new System.Drawing.Point(12, 65);
            this.ortalamaartis.Name = "ortalamaartis";
            this.ortalamaartis.Size = new System.Drawing.Size(86, 17);
            this.ortalamaartis.TabIndex = 7;
            this.ortalamaartis.TabStop = true;
            this.ortalamaartis.Text = "Ortalama Alış";
            this.ortalamaartis.UseVisualStyleBackColor = true;
            // 
            // lifo
            // 
            this.lifo.AutoSize = true;
            this.lifo.Location = new System.Drawing.Point(12, 42);
            this.lifo.Name = "lifo";
            this.lifo.Size = new System.Drawing.Size(48, 17);
            this.lifo.TabIndex = 6;
            this.lifo.TabStop = true;
            this.lifo.Text = "LİFO";
            this.lifo.UseVisualStyleBackColor = true;
            // 
            // fifo
            // 
            this.fifo.AutoSize = true;
            this.fifo.Location = new System.Drawing.Point(12, 19);
            this.fifo.Name = "fifo";
            this.fifo.Size = new System.Drawing.Size(48, 17);
            this.fifo.TabIndex = 5;
            this.fifo.TabStop = true;
            this.fifo.Text = "FİFO";
            this.fifo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grubu);
            this.groupBox1.Controls.Add(this.birimi);
            this.groupBox1.Controls.Add(this.stokadi);
            this.groupBox1.Controls.Add(this.stokkodu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok";
            // 
            // grubu
            // 
            this.grubu.Location = new System.Drawing.Point(76, 60);
            this.grubu.Name = "grubu";
            this.grubu.Size = new System.Drawing.Size(167, 20);
            this.grubu.TabIndex = 3;
            // 
            // birimi
            // 
            this.birimi.FormattingEnabled = true;
            this.birimi.Items.AddRange(new object[] {
            "Adet",
            "Kilo",
            "Metre",
            "Koli"});
            this.birimi.Location = new System.Drawing.Point(76, 83);
            this.birimi.Name = "birimi";
            this.birimi.Size = new System.Drawing.Size(167, 21);
            this.birimi.TabIndex = 4;
            // 
            // stokadi
            // 
            this.stokadi.Location = new System.Drawing.Point(76, 38);
            this.stokadi.Name = "stokadi";
            this.stokadi.Size = new System.Drawing.Size(167, 20);
            this.stokadi.TabIndex = 2;
            // 
            // stokkodu
            // 
            this.stokkodu.Location = new System.Drawing.Point(76, 17);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(167, 20);
            this.stokkodu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birimi :";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grubu :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Kodu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokKoduDataGridViewTextBoxColumn,
            this.stokAdiDataGridViewTextBoxColumn,
            this.grubuDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.girisMiktariDataGridViewTextBoxColumn,
            this.girisTutariDataGridViewTextBoxColumn,
            this.cikisMiktariDataGridViewTextBoxColumn,
            this.cikisTutariDataGridViewTextBoxColumn,
            this.kalanMiktarDataGridViewTextBoxColumn,
            this.envBirimFiyatiDataGridViewTextBoxColumn,
            this.envanterTutariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stokenvanteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(277, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(562, 392);
            this.dataGridView1.TabIndex = 14;
            // 
            // stokKoduDataGridViewTextBoxColumn
            // 
            this.stokKoduDataGridViewTextBoxColumn.DataPropertyName = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.HeaderText = "Stok Kodu";
            this.stokKoduDataGridViewTextBoxColumn.Name = "stokKoduDataGridViewTextBoxColumn";
            // 
            // stokAdiDataGridViewTextBoxColumn
            // 
            this.stokAdiDataGridViewTextBoxColumn.DataPropertyName = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.HeaderText = "Stok Adı";
            this.stokAdiDataGridViewTextBoxColumn.Name = "stokAdiDataGridViewTextBoxColumn";
            // 
            // grubuDataGridViewTextBoxColumn
            // 
            this.grubuDataGridViewTextBoxColumn.DataPropertyName = "Grubu";
            this.grubuDataGridViewTextBoxColumn.HeaderText = "Grubu";
            this.grubuDataGridViewTextBoxColumn.Name = "grubuDataGridViewTextBoxColumn";
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "Birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            // 
            // girisMiktariDataGridViewTextBoxColumn
            // 
            this.girisMiktariDataGridViewTextBoxColumn.DataPropertyName = "GirisMiktari";
            this.girisMiktariDataGridViewTextBoxColumn.HeaderText = "Giriş Miktarı";
            this.girisMiktariDataGridViewTextBoxColumn.Name = "girisMiktariDataGridViewTextBoxColumn";
            // 
            // girisTutariDataGridViewTextBoxColumn
            // 
            this.girisTutariDataGridViewTextBoxColumn.DataPropertyName = "GirisTutari";
            this.girisTutariDataGridViewTextBoxColumn.HeaderText = "Giriş Tutarı";
            this.girisTutariDataGridViewTextBoxColumn.Name = "girisTutariDataGridViewTextBoxColumn";
            // 
            // cikisMiktariDataGridViewTextBoxColumn
            // 
            this.cikisMiktariDataGridViewTextBoxColumn.DataPropertyName = "CikisMiktari";
            this.cikisMiktariDataGridViewTextBoxColumn.HeaderText = "Çıkış Miktarı";
            this.cikisMiktariDataGridViewTextBoxColumn.Name = "cikisMiktariDataGridViewTextBoxColumn";
            // 
            // cikisTutariDataGridViewTextBoxColumn
            // 
            this.cikisTutariDataGridViewTextBoxColumn.DataPropertyName = "CikisTutari";
            this.cikisTutariDataGridViewTextBoxColumn.HeaderText = "Çıkış Tutarı";
            this.cikisTutariDataGridViewTextBoxColumn.Name = "cikisTutariDataGridViewTextBoxColumn";
            // 
            // kalanMiktarDataGridViewTextBoxColumn
            // 
            this.kalanMiktarDataGridViewTextBoxColumn.DataPropertyName = "KalanMiktar";
            this.kalanMiktarDataGridViewTextBoxColumn.HeaderText = "Kalan Miktar";
            this.kalanMiktarDataGridViewTextBoxColumn.Name = "kalanMiktarDataGridViewTextBoxColumn";
            // 
            // envBirimFiyatiDataGridViewTextBoxColumn
            // 
            this.envBirimFiyatiDataGridViewTextBoxColumn.DataPropertyName = "EnvBirimFiyati";
            this.envBirimFiyatiDataGridViewTextBoxColumn.HeaderText = "Envanter Birim Fiyatı";
            this.envBirimFiyatiDataGridViewTextBoxColumn.Name = "envBirimFiyatiDataGridViewTextBoxColumn";
            // 
            // envanterTutariDataGridViewTextBoxColumn
            // 
            this.envanterTutariDataGridViewTextBoxColumn.DataPropertyName = "EnvanterTutari";
            this.envanterTutariDataGridViewTextBoxColumn.HeaderText = "Envanter Tutarı";
            this.envanterTutariDataGridViewTextBoxColumn.Name = "envanterTutariDataGridViewTextBoxColumn";
            // 
            // stokenvanteriBindingSource
            // 
            this.stokenvanteriBindingSource.DataMember = "stokenvanteri";
            this.stokenvanteriBindingSource.DataSource = this.mhsbdigerhesaplarDataSet4;
            // 
            // mhsbdigerhesaplarDataSet4
            // 
            this.mhsbdigerhesaplarDataSet4.DataSetName = "mhsbdigerhesaplarDataSet4";
            this.mhsbdigerhesaplarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stokenvanteriTableAdapter
            // 
            this.stokenvanteriTableAdapter.ClearBeforeFill = true;
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(856, 476);
            this.MinimumSize = new System.Drawing.Size(856, 476);
            this.Name = "Form27";
            this.Text = "Stok Envanteri";
            this.Load += new System.EventHandler(this.Form27_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokenvanteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdigerhesaplarDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stokkodu;
        private System.Windows.Forms.TextBox stokadi;
        private System.Windows.Forms.ComboBox birimi;
        private System.Windows.Forms.TextBox grubu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton fifo;
        private System.Windows.Forms.RadioButton lifo;
        private System.Windows.Forms.RadioButton ortalamaartis;
        private System.Windows.Forms.RadioButton ortalamaagirlikliartis;
        private System.Windows.Forms.RadioButton enucuzalis;
        private System.Windows.Forms.RadioButton enpahalialis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mhsbdigerhesaplarDataSet4 mhsbdigerhesaplarDataSet4;
        private System.Windows.Forms.BindingSource stokenvanteriBindingSource;
        private mhsbdigerhesaplarDataSet4TableAdapters.stokenvanteriTableAdapter stokenvanteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envBirimFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envanterTutariDataGridViewTextBoxColumn;
    }
}