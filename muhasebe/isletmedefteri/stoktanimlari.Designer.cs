namespace isletmedefteri
{
    partial class stoktanimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stoktanimlari));
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsmmhesabialisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyethesabiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoktanimlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeortakhesaplarstokDataSet3 = new isletmedefteri.muhasebeortakhesaplarstokDataSet3();
            this.stoktanimlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maliyethesabi = new System.Windows.Forms.TextBox();
            this.dsmm = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelEAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimi = new System.Windows.Forms.ComboBox();
            this.grubu = new System.Windows.Forms.TextBox();
            this.stokadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stokkodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stoktanimlariTableAdapter = new isletmedefteri.muhasebeortakhesaplarstokDataSet3TableAdapters.stoktanimlariTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeortakhesaplarstokDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Maliyet Hesabı :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "save (2).png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(703, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 99);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet (F1)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kapat.png");
            this.ımageList1.Images.SetKeyName(1, "save (2).png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "DSMM Hesabı(Alış) :";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "kapat.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(836, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 99);
            this.button2.TabIndex = 9;
            this.button2.Text = "Vazgeç (Esc)";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(956, 429);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kaydedilen Stoklar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokkoduDataGridViewTextBoxColumn,
            this.stokadiDataGridViewTextBoxColumn,
            this.grubuDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.dsmmhesabialisDataGridViewTextBoxColumn,
            this.maliyethesabiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoktanimlariBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(944, 401);
            this.dataGridView1.TabIndex = 10;
            // 
            // stokkoduDataGridViewTextBoxColumn
            // 
            this.stokkoduDataGridViewTextBoxColumn.DataPropertyName = "stokkodu";
            this.stokkoduDataGridViewTextBoxColumn.HeaderText = "Stok Kodu";
            this.stokkoduDataGridViewTextBoxColumn.Name = "stokkoduDataGridViewTextBoxColumn";
            this.stokkoduDataGridViewTextBoxColumn.Width = 134;
            // 
            // stokadiDataGridViewTextBoxColumn
            // 
            this.stokadiDataGridViewTextBoxColumn.DataPropertyName = "stokadi";
            this.stokadiDataGridViewTextBoxColumn.HeaderText = "Stok Adı";
            this.stokadiDataGridViewTextBoxColumn.Name = "stokadiDataGridViewTextBoxColumn";
            this.stokadiDataGridViewTextBoxColumn.Width = 134;
            // 
            // grubuDataGridViewTextBoxColumn
            // 
            this.grubuDataGridViewTextBoxColumn.DataPropertyName = "grubu";
            this.grubuDataGridViewTextBoxColumn.HeaderText = "Grubu";
            this.grubuDataGridViewTextBoxColumn.Name = "grubuDataGridViewTextBoxColumn";
            this.grubuDataGridViewTextBoxColumn.Width = 134;
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            this.birimiDataGridViewTextBoxColumn.Width = 134;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 134;
            // 
            // dsmmhesabialisDataGridViewTextBoxColumn
            // 
            this.dsmmhesabialisDataGridViewTextBoxColumn.DataPropertyName = "dsmmhesabialis";
            this.dsmmhesabialisDataGridViewTextBoxColumn.HeaderText = "DSMM Hesabı (Alış)";
            this.dsmmhesabialisDataGridViewTextBoxColumn.Name = "dsmmhesabialisDataGridViewTextBoxColumn";
            this.dsmmhesabialisDataGridViewTextBoxColumn.Width = 134;
            // 
            // maliyethesabiDataGridViewTextBoxColumn
            // 
            this.maliyethesabiDataGridViewTextBoxColumn.DataPropertyName = "maliyethesabi";
            this.maliyethesabiDataGridViewTextBoxColumn.HeaderText = "Maliyet Hesabı";
            this.maliyethesabiDataGridViewTextBoxColumn.Name = "maliyethesabiDataGridViewTextBoxColumn";
            this.maliyethesabiDataGridViewTextBoxColumn.Width = 118;
            // 
            // stoktanimlariBindingSource1
            // 
            this.stoktanimlariBindingSource1.DataMember = "stoktanimlari";
            this.stoktanimlariBindingSource1.DataSource = this.muhasebeortakhesaplarstokDataSet3;
            // 
            // muhasebeortakhesaplarstokDataSet3
            // 
            this.muhasebeortakhesaplarstokDataSet3.DataSetName = "muhasebeortakhesaplarstokDataSet3";
            this.muhasebeortakhesaplarstokDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoktanimlariBindingSource
            // 
            this.stoktanimlariBindingSource.DataMember = "stoktanimlari";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maliyethesabi);
            this.groupBox2.Controls.Add(this.dsmm);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(302, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maliyet";
            // 
            // maliyethesabi
            // 
            this.maliyethesabi.Location = new System.Drawing.Point(280, 22);
            this.maliyethesabi.Name = "maliyethesabi";
            this.maliyethesabi.Size = new System.Drawing.Size(85, 20);
            this.maliyethesabi.TabIndex = 7;
            // 
            // dsmm
            // 
            this.dsmm.Location = new System.Drawing.Point(104, 22);
            this.dsmm.Name = "dsmm";
            this.dsmm.Size = new System.Drawing.Size(85, 20);
            this.dsmm.TabIndex = 6;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(361, 21);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(312, 46);
            this.aciklama.TabIndex = 5;
            this.aciklama.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayırToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kayırToolStripMenuItem
            // 
            this.kayırToolStripMenuItem.Name = "kayırToolStripMenuItem";
            this.kayırToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kayırToolStripMenuItem.Text = "Kaydet";
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
            this.yazdırToolStripMenuItem,
            this.excelEAktarToolStripMenuItem});
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
            // excelEAktarToolStripMenuItem
            // 
            this.excelEAktarToolStripMenuItem.Name = "excelEAktarToolStripMenuItem";
            this.excelEAktarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.excelEAktarToolStripMenuItem.Text = "Excel\' e Aktar";
            this.excelEAktarToolStripMenuItem.Click += new System.EventHandler(this.excelEAktarToolStripMenuItem_Click);
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
            this.genelMuhasebeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.genelMuhasebeToolStripMenuItem.Text = "İşletme Defteri";
            this.genelMuhasebeToolStripMenuItem.Click += new System.EventHandler(this.genelMuhasebeToolStripMenuItem_Click);
            // 
            // birimi
            // 
            this.birimi.FormattingEnabled = true;
            this.birimi.Items.AddRange(new object[] {
            "Adet",
            "Kilo",
            "Metre",
            "Koli"});
            this.birimi.Location = new System.Drawing.Point(78, 97);
            this.birimi.Name = "birimi";
            this.birimi.Size = new System.Drawing.Size(155, 21);
            this.birimi.TabIndex = 4;
            // 
            // grubu
            // 
            this.grubu.Location = new System.Drawing.Point(78, 73);
            this.grubu.Name = "grubu";
            this.grubu.Size = new System.Drawing.Size(155, 20);
            this.grubu.TabIndex = 3;
            // 
            // stokadi
            // 
            this.stokadi.Location = new System.Drawing.Point(78, 47);
            this.stokadi.Name = "stokadi";
            this.stokadi.Size = new System.Drawing.Size(155, 20);
            this.stokadi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birimi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grubu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stok Kodu :";
            // 
            // stokkodu
            // 
            this.stokkodu.Location = new System.Drawing.Point(78, 21);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(155, 20);
            this.stokkodu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Controls.Add(this.birimi);
            this.groupBox1.Controls.Add(this.grubu);
            this.groupBox1.Controls.Add(this.stokadi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.stokkodu);
            this.groupBox1.Location = new System.Drawing.Point(6, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok";
            // 
            // stoktanimlariTableAdapter
            // 
            this.stoktanimlariTableAdapter.ClearBeforeFill = true;
            // 
            // stoktanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 594);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(982, 632);
            this.MinimumSize = new System.Drawing.Size(982, 632);
            this.Name = "stoktanimlari";
            this.Text = "Stok Tanımları";
            this.Load += new System.EventHandler(this.stoktanimlari_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeortakhesaplarstokDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stoktanimlariBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maliyethesabi;
        private System.Windows.Forms.TextBox dsmm;
        private System.Windows.Forms.RichTextBox aciklama;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelEAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.ComboBox birimi;
        private System.Windows.Forms.TextBox grubu;
        private System.Windows.Forms.TextBox stokadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stokkodu;
        private System.Windows.Forms.GroupBox groupBox1;
        private muhasebeortakhesaplarstokDataSet3 muhasebeortakhesaplarstokDataSet3;
        private System.Windows.Forms.BindingSource stoktanimlariBindingSource1;
        private muhasebeortakhesaplarstokDataSet3TableAdapters.stoktanimlariTableAdapter stoktanimlariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsmmhesabialisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maliyethesabiDataGridViewTextBoxColumn;
    }
}