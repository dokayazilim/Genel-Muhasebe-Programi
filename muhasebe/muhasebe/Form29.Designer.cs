namespace muhasebe
{
    partial class Form29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form29));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.illeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.fisaciklama = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enpahalialis = new System.Windows.Forms.RadioButton();
            this.enucuzalis = new System.Windows.Forms.RadioButton();
            this.ortalamaagirliklialis = new System.Windows.Forms.RadioButton();
            this.ortalamaalis = new System.Windows.Forms.RadioButton();
            this.lifo = new System.Windows.Forms.RadioButton();
            this.fifo = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.hesapkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcBakiyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSMMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyetTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyetHesabiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyethesaplamalariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet7 = new muhasebe.mhsbortakDataSet7();
            this.maliyethesaplamalariTableAdapter = new muhasebe.mhsbortakDataSet7TableAdapters.maliyethesaplamalariTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maliyethesaplamalariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.illeToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // illeToolStripMenuItem
            // 
            this.illeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesaplaToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.temizleToolStripMenuItem1,
            this.kapatToolStripMenuItem});
            this.illeToolStripMenuItem.Name = "illeToolStripMenuItem";
            this.illeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.illeToolStripMenuItem.Text = "İşlemler";
            // 
            // hesaplaToolStripMenuItem
            // 
            this.hesaplaToolStripMenuItem.Name = "hesaplaToolStripMenuItem";
            this.hesaplaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hesaplaToolStripMenuItem.Text = "Hesapla";
            this.hesaplaToolStripMenuItem.Click += new System.EventHandler(this.hesaplaToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.temizleToolStripMenuItem.Text = "Maliyet Fişini Oluştur";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem1
            // 
            this.temizleToolStripMenuItem1.Name = "temizleToolStripMenuItem1";
            this.temizleToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.temizleToolStripMenuItem1.Text = "Temizle";
            this.temizleToolStripMenuItem1.Click += new System.EventHandler(this.temizleToolStripMenuItem1_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem});
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.hesapkodu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İşlemler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.fisaciklama);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiş Kaydı";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(8, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Maliyet Fişini Oluştur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fisaciklama
            // 
            this.fisaciklama.Location = new System.Drawing.Point(88, 43);
            this.fisaciklama.Name = "fisaciklama";
            this.fisaciklama.Size = new System.Drawing.Size(152, 20);
            this.fisaciklama.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fiş Açıklaması :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiş Tarihi :";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(14, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enpahalialis);
            this.groupBox1.Controls.Add(this.enucuzalis);
            this.groupBox1.Controls.Add(this.ortalamaagirliklialis);
            this.groupBox1.Controls.Add(this.ortalamaalis);
            this.groupBox1.Controls.Add(this.lifo);
            this.groupBox1.Controls.Add(this.fifo);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envanter Maliyet Tipi";
            // 
            // enpahalialis
            // 
            this.enpahalialis.AutoSize = true;
            this.enpahalialis.Location = new System.Drawing.Point(11, 134);
            this.enpahalialis.Name = "enpahalialis";
            this.enpahalialis.Size = new System.Drawing.Size(89, 17);
            this.enpahalialis.TabIndex = 9;
            this.enpahalialis.TabStop = true;
            this.enpahalialis.Text = "En Pahalı Alış";
            this.enpahalialis.UseVisualStyleBackColor = true;
            // 
            // enucuzalis
            // 
            this.enucuzalis.AutoSize = true;
            this.enucuzalis.Location = new System.Drawing.Point(11, 111);
            this.enucuzalis.Name = "enucuzalis";
            this.enucuzalis.Size = new System.Drawing.Size(85, 17);
            this.enucuzalis.TabIndex = 8;
            this.enucuzalis.TabStop = true;
            this.enucuzalis.Text = "En Ucuz Alış";
            this.enucuzalis.UseVisualStyleBackColor = true;
            // 
            // ortalamaagirliklialis
            // 
            this.ortalamaagirliklialis.AutoSize = true;
            this.ortalamaagirliklialis.Location = new System.Drawing.Point(11, 88);
            this.ortalamaagirliklialis.Name = "ortalamaagirliklialis";
            this.ortalamaagirliklialis.Size = new System.Drawing.Size(121, 17);
            this.ortalamaagirliklialis.TabIndex = 7;
            this.ortalamaagirliklialis.TabStop = true;
            this.ortalamaagirliklialis.Text = "Ortalama Ağırlıklı Alış";
            this.ortalamaagirliklialis.UseVisualStyleBackColor = true;
            // 
            // ortalamaalis
            // 
            this.ortalamaalis.AutoSize = true;
            this.ortalamaalis.Location = new System.Drawing.Point(11, 65);
            this.ortalamaalis.Name = "ortalamaalis";
            this.ortalamaalis.Size = new System.Drawing.Size(86, 17);
            this.ortalamaalis.TabIndex = 6;
            this.ortalamaalis.TabStop = true;
            this.ortalamaalis.Text = "Ortalama Alış";
            this.ortalamaalis.UseVisualStyleBackColor = true;
            // 
            // lifo
            // 
            this.lifo.AutoSize = true;
            this.lifo.Location = new System.Drawing.Point(11, 42);
            this.lifo.Name = "lifo";
            this.lifo.Size = new System.Drawing.Size(48, 17);
            this.lifo.TabIndex = 5;
            this.lifo.TabStop = true;
            this.lifo.Text = "LİFO";
            this.lifo.UseVisualStyleBackColor = true;
            // 
            // fifo
            // 
            this.fifo.AutoSize = true;
            this.fifo.Location = new System.Drawing.Point(11, 19);
            this.fifo.Name = "fifo";
            this.fifo.Size = new System.Drawing.Size(48, 17);
            this.fifo.TabIndex = 4;
            this.fifo.TabStop = true;
            this.fifo.Text = "FİFO";
            this.fifo.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageKey = "(none)";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(223, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ayarlibul.png");
            // 
            // hesapkodu
            // 
            this.hesapkodu.Location = new System.Drawing.Point(84, 17);
            this.hesapkodu.Name = "hesapkodu";
            this.hesapkodu.Size = new System.Drawing.Size(140, 20);
            this.hesapkodu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dönem Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap Kodu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapKoduDataGridViewTextBoxColumn,
            this.hesapAdiDataGridViewTextBoxColumn,
            this.borcBakiyesiDataGridViewTextBoxColumn,
            this.dSMMDataGridViewTextBoxColumn,
            this.maliyetTutariDataGridViewTextBoxColumn,
            this.maliyetHesabiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maliyethesaplamalariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(273, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 405);
            this.dataGridView1.TabIndex = 14;
            // 
            // hesapKoduDataGridViewTextBoxColumn
            // 
            this.hesapKoduDataGridViewTextBoxColumn.DataPropertyName = "HesapKodu";
            this.hesapKoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapKoduDataGridViewTextBoxColumn.Name = "hesapKoduDataGridViewTextBoxColumn";
            // 
            // hesapAdiDataGridViewTextBoxColumn
            // 
            this.hesapAdiDataGridViewTextBoxColumn.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn.Name = "hesapAdiDataGridViewTextBoxColumn";
            // 
            // borcBakiyesiDataGridViewTextBoxColumn
            // 
            this.borcBakiyesiDataGridViewTextBoxColumn.DataPropertyName = "BorcBakiyesi";
            this.borcBakiyesiDataGridViewTextBoxColumn.HeaderText = "Borç Bakiyesi";
            this.borcBakiyesiDataGridViewTextBoxColumn.Name = "borcBakiyesiDataGridViewTextBoxColumn";
            // 
            // dSMMDataGridViewTextBoxColumn
            // 
            this.dSMMDataGridViewTextBoxColumn.DataPropertyName = "DSMM";
            this.dSMMDataGridViewTextBoxColumn.HeaderText = "DSMM";
            this.dSMMDataGridViewTextBoxColumn.Name = "dSMMDataGridViewTextBoxColumn";
            // 
            // maliyetTutariDataGridViewTextBoxColumn
            // 
            this.maliyetTutariDataGridViewTextBoxColumn.DataPropertyName = "MaliyetTutari";
            this.maliyetTutariDataGridViewTextBoxColumn.HeaderText = "Maliyet Tutarı";
            this.maliyetTutariDataGridViewTextBoxColumn.Name = "maliyetTutariDataGridViewTextBoxColumn";
            // 
            // maliyetHesabiDataGridViewTextBoxColumn
            // 
            this.maliyetHesabiDataGridViewTextBoxColumn.DataPropertyName = "MaliyetHesabi";
            this.maliyetHesabiDataGridViewTextBoxColumn.HeaderText = "Maliyet Hesabı";
            this.maliyetHesabiDataGridViewTextBoxColumn.Name = "maliyetHesabiDataGridViewTextBoxColumn";
            // 
            // maliyethesaplamalariBindingSource
            // 
            this.maliyethesaplamalariBindingSource.DataMember = "maliyethesaplamalari";
            this.maliyethesaplamalariBindingSource.DataSource = this.mhsbortakDataSet7;
            // 
            // mhsbortakDataSet7
            // 
            this.mhsbortakDataSet7.DataSetName = "mhsbortakDataSet7";
            this.mhsbortakDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maliyethesaplamalariTableAdapter
            // 
            this.maliyethesaplamalariTableAdapter.ClearBeforeFill = true;
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 494);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(849, 494);
            this.Name = "Form29";
            this.Text = "Maliyet Hesaplamaları";
            this.Load += new System.EventHandler(this.Form29_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maliyethesaplamalariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem illeToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ToolStripMenuItem hesaplaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton fifo;
        public System.Windows.Forms.RadioButton lifo;
        public System.Windows.Forms.RadioButton ortalamaalis;
        public System.Windows.Forms.RadioButton ortalamaagirliklialis;
        public System.Windows.Forms.RadioButton enucuzalis;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.TextBox fisaciklama;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem1;
        public System.Windows.Forms.TextBox hesapkodu;
        public System.Windows.Forms.RadioButton enpahalialis;
        public mhsbortakDataSet7 mhsbortakDataSet7;
        public System.Windows.Forms.BindingSource maliyethesaplamalariBindingSource;
        public mhsbortakDataSet7TableAdapters.maliyethesaplamalariTableAdapter maliyethesaplamalariTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn borcBakiyesiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn dSMMDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn maliyetTutariDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn maliyetHesabiDataGridViewTextBoxColumn;

    }
}