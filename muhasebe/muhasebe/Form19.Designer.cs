namespace muhasebe
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gosterme = new System.Windows.Forms.RadioButton();
            this.tumdetay = new System.Windows.Forms.RadioButton();
            this.fistipi = new System.Windows.Forms.ComboBox();
            this.evrakno = new System.Windows.Forms.TextBox();
            this.fisno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yevmiyedefteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet38 = new muhasebe.mhsbdataDataSet38();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.yevmiyedefteriTableAdapter = new muhasebe.mhsbdataDataSet38TableAdapters.yevmiyedefteriTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yevmiyedefteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet38)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.fistipi);
            this.tabPage1.Controls.Add(this.evrakno);
            this.tabPage1.Controls.Add(this.fisno);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(264, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(22, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(22, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(22, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gosterme);
            this.groupBox2.Controls.Add(this.tumdetay);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplar (Detay)";
            // 
            // gosterme
            // 
            this.gosterme.AutoSize = true;
            this.gosterme.Location = new System.Drawing.Point(15, 51);
            this.gosterme.Name = "gosterme";
            this.gosterme.Size = new System.Drawing.Size(70, 17);
            this.gosterme.TabIndex = 7;
            this.gosterme.TabStop = true;
            this.gosterme.Text = "Gösterme";
            this.gosterme.UseVisualStyleBackColor = true;
            // 
            // tumdetay
            // 
            this.tumdetay.AutoSize = true;
            this.tumdetay.Location = new System.Drawing.Point(15, 19);
            this.tumdetay.Name = "tumdetay";
            this.tumdetay.Size = new System.Drawing.Size(77, 17);
            this.tumdetay.TabIndex = 6;
            this.tumdetay.TabStop = true;
            this.tumdetay.Text = "Tüm Detay";
            this.tumdetay.UseVisualStyleBackColor = true;
            // 
            // fistipi
            // 
            this.fistipi.FormattingEnabled = true;
            this.fistipi.Items.AddRange(new object[] {
            "Açılış Fişi",
            "Tahsil Fişi",
            "Tediye Fişi",
            "Mahsup Fişi",
            "Kapanış Fişi"});
            this.fistipi.Location = new System.Drawing.Point(81, 177);
            this.fistipi.Name = "fistipi";
            this.fistipi.Size = new System.Drawing.Size(171, 21);
            this.fistipi.TabIndex = 5;
            // 
            // evrakno
            // 
            this.evrakno.Location = new System.Drawing.Point(81, 146);
            this.evrakno.Name = "evrakno";
            this.evrakno.Size = new System.Drawing.Size(171, 20);
            this.evrakno.TabIndex = 4;
            // 
            // fisno
            // 
            this.fisno.Location = new System.Drawing.Point(81, 114);
            this.fisno.Name = "fisno";
            this.fisno.Size = new System.Drawing.Size(171, 20);
            this.fisno.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarihine :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarihinden :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fiş Tipi :";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Evrak No :";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiş No :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtlarToolStripMenuItem
            // 
            this.kayıtlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesaplaToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.kayıtlarToolStripMenuItem.Name = "kayıtlarToolStripMenuItem";
            this.kayıtlarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kayıtlarToolStripMenuItem.Text = "Kayıtlar";
            // 
            // hesaplaToolStripMenuItem
            // 
            this.hesaplaToolStripMenuItem.Name = "hesaplaToolStripMenuItem";
            this.hesaplaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.hesaplaToolStripMenuItem.Text = "Hesapla";
            this.hesaplaToolStripMenuItem.Click += new System.EventHandler(this.hesaplaToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapKoduDataGridViewTextBoxColumn,
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn,
            this.detayDataGridViewTextBoxColumn,
            this.borcDataGridViewTextBoxColumn,
            this.alacakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yevmiyedefteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(681, 469);
            this.dataGridView1.TabIndex = 11;
            // 
            // hesapKoduDataGridViewTextBoxColumn
            // 
            this.hesapKoduDataGridViewTextBoxColumn.DataPropertyName = "HesapKodu";
            this.hesapKoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapKoduDataGridViewTextBoxColumn.Name = "hesapKoduDataGridViewTextBoxColumn";
            this.hesapKoduDataGridViewTextBoxColumn.Width = 130;
            // 
            // hesapAdiveAciklamaDataGridViewTextBoxColumn
            // 
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn.DataPropertyName = "HesapAdiveAciklama";
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn.HeaderText = "Hesap Adı ve Açıklama";
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn.Name = "hesapAdiveAciklamaDataGridViewTextBoxColumn";
            this.hesapAdiveAciklamaDataGridViewTextBoxColumn.Width = 140;
            // 
            // detayDataGridViewTextBoxColumn
            // 
            this.detayDataGridViewTextBoxColumn.DataPropertyName = "Detay";
            this.detayDataGridViewTextBoxColumn.HeaderText = "Detay";
            this.detayDataGridViewTextBoxColumn.Name = "detayDataGridViewTextBoxColumn";
            this.detayDataGridViewTextBoxColumn.Width = 130;
            // 
            // borcDataGridViewTextBoxColumn
            // 
            this.borcDataGridViewTextBoxColumn.DataPropertyName = "Borc";
            this.borcDataGridViewTextBoxColumn.HeaderText = "Borç";
            this.borcDataGridViewTextBoxColumn.Name = "borcDataGridViewTextBoxColumn";
            this.borcDataGridViewTextBoxColumn.Width = 130;
            // 
            // alacakDataGridViewTextBoxColumn
            // 
            this.alacakDataGridViewTextBoxColumn.DataPropertyName = "Alacak";
            this.alacakDataGridViewTextBoxColumn.HeaderText = "Alacak";
            this.alacakDataGridViewTextBoxColumn.Name = "alacakDataGridViewTextBoxColumn";
            this.alacakDataGridViewTextBoxColumn.Width = 130;
            // 
            // yevmiyedefteriBindingSource
            // 
            this.yevmiyedefteriBindingSource.DataMember = "yevmiyedefteri";
            this.yevmiyedefteriBindingSource.DataSource = this.mhsbdataDataSet38;
            // 
            // mhsbdataDataSet38
            // 
            this.mhsbdataDataSet38.DataSetName = "mhsbdataDataSet38";
            this.mhsbdataDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(280, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 493);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtreleme Sonuçları";
            // 
            // yevmiyedefteriTableAdapter
            // 
            this.yevmiyedefteriTableAdapter.ClearBeforeFill = true;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(995, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(995, 576);
            this.Name = "Form19";
            this.Text = "Yevmiye Defteri";
            this.Load += new System.EventHandler(this.Form19_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yevmiyedefteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet38)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox evrakno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fistipi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tumdetay;
        private System.Windows.Forms.RadioButton gosterme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox fisno;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private mhsbdataDataSet38 mhsbdataDataSet38;
        private System.Windows.Forms.BindingSource yevmiyedefteriBindingSource;
        private mhsbdataDataSet38TableAdapters.yevmiyedefteriTableAdapter yevmiyedefteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiveAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alacakDataGridViewTextBoxColumn;
    }
}