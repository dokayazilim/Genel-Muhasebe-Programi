namespace muhasebe
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcBakiyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakBakiyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikAlacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikBorcBakiyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mikAlacakBakiyesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kesinmizanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet4 = new muhasebe.mhsbortakDataSet4();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.bakiyedurumu = new System.Windows.Forms.ComboBox();
            this.dokumbicimi = new System.Windows.Forms.ComboBox();
            this.detaygoster = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kapanis = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hesapkodu2 = new System.Windows.Forms.TextBox();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.hesapkodu = new System.Windows.Forms.TextBox();
            this.aysecimi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kesinmizanTableAdapter = new muhasebe.mhsbortakDataSet4TableAdapters.kesinmizanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kesinmizanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(484, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Birim Fiyat :";
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
            this.borcTutariDataGridViewTextBoxColumn,
            this.alacakTutariDataGridViewTextBoxColumn,
            this.borcBakiyesiDataGridViewTextBoxColumn,
            this.alacakBakiyesiDataGridViewTextBoxColumn,
            this.mikBorcDataGridViewTextBoxColumn,
            this.mikAlacakDataGridViewTextBoxColumn,
            this.mikBorcBakiyesiDataGridViewTextBoxColumn,
            this.mikAlacakBakiyesiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kesinmizanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(353, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(642, 391);
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
            // borcTutariDataGridViewTextBoxColumn
            // 
            this.borcTutariDataGridViewTextBoxColumn.DataPropertyName = "BorcTutari";
            this.borcTutariDataGridViewTextBoxColumn.HeaderText = "Borç Tutarı";
            this.borcTutariDataGridViewTextBoxColumn.Name = "borcTutariDataGridViewTextBoxColumn";
            // 
            // alacakTutariDataGridViewTextBoxColumn
            // 
            this.alacakTutariDataGridViewTextBoxColumn.DataPropertyName = "AlacakTutari";
            this.alacakTutariDataGridViewTextBoxColumn.HeaderText = "Alacak Tutarı";
            this.alacakTutariDataGridViewTextBoxColumn.Name = "alacakTutariDataGridViewTextBoxColumn";
            // 
            // borcBakiyesiDataGridViewTextBoxColumn
            // 
            this.borcBakiyesiDataGridViewTextBoxColumn.DataPropertyName = "BorcBakiyesi";
            this.borcBakiyesiDataGridViewTextBoxColumn.HeaderText = "Borç Bakiyesi";
            this.borcBakiyesiDataGridViewTextBoxColumn.Name = "borcBakiyesiDataGridViewTextBoxColumn";
            // 
            // alacakBakiyesiDataGridViewTextBoxColumn
            // 
            this.alacakBakiyesiDataGridViewTextBoxColumn.DataPropertyName = "AlacakBakiyesi";
            this.alacakBakiyesiDataGridViewTextBoxColumn.HeaderText = "Alacak Bakiyesi";
            this.alacakBakiyesiDataGridViewTextBoxColumn.Name = "alacakBakiyesiDataGridViewTextBoxColumn";
            // 
            // mikBorcDataGridViewTextBoxColumn
            // 
            this.mikBorcDataGridViewTextBoxColumn.DataPropertyName = "MikBorc";
            this.mikBorcDataGridViewTextBoxColumn.HeaderText = "Mik. Borç";
            this.mikBorcDataGridViewTextBoxColumn.Name = "mikBorcDataGridViewTextBoxColumn";
            // 
            // mikAlacakDataGridViewTextBoxColumn
            // 
            this.mikAlacakDataGridViewTextBoxColumn.DataPropertyName = "MikAlacak";
            this.mikAlacakDataGridViewTextBoxColumn.HeaderText = "Mik. Alacak";
            this.mikAlacakDataGridViewTextBoxColumn.Name = "mikAlacakDataGridViewTextBoxColumn";
            // 
            // mikBorcBakiyesiDataGridViewTextBoxColumn
            // 
            this.mikBorcBakiyesiDataGridViewTextBoxColumn.DataPropertyName = "MikBorcBakiyesi";
            this.mikBorcBakiyesiDataGridViewTextBoxColumn.HeaderText = "Mik. Borç Bakiyesi";
            this.mikBorcBakiyesiDataGridViewTextBoxColumn.Name = "mikBorcBakiyesiDataGridViewTextBoxColumn";
            // 
            // mikAlacakBakiyesiDataGridViewTextBoxColumn
            // 
            this.mikAlacakBakiyesiDataGridViewTextBoxColumn.DataPropertyName = "MikAlacakBakiyesi";
            this.mikAlacakBakiyesiDataGridViewTextBoxColumn.HeaderText = "Mik. Alacak Bakiyesi";
            this.mikAlacakBakiyesiDataGridViewTextBoxColumn.Name = "mikAlacakBakiyesiDataGridViewTextBoxColumn";
            // 
            // kesinmizanBindingSource
            // 
            this.kesinmizanBindingSource.DataMember = "kesinmizan";
            this.kesinmizanBindingSource.DataSource = this.mhsbortakDataSet4;
            // 
            // mhsbortakDataSet4
            // 
            this.mhsbortakDataSet4.DataSetName = "mhsbortakDataSet4";
            this.mhsbortakDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageKey = "none.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(194, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 74);
            this.button4.TabIndex = 13;
            this.button4.Text = "Vazgeç";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "none.png");
            this.ımageList1.Images.SetKeyName(1, "filtrele.png");
            // 
            // genelMuhasebeToolStripMenuItem
            // 
            this.genelMuhasebeToolStripMenuItem.Name = "genelMuhasebeToolStripMenuItem";
            this.genelMuhasebeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.genelMuhasebeToolStripMenuItem.Text = "Genel Muhasebe";
            this.genelMuhasebeToolStripMenuItem.Click += new System.EventHandler(this.genelMuhasebeToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "filtrele.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(22, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 74);
            this.button3.TabIndex = 12;
            this.button3.Text = "Filtrele";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bakiyedurumu
            // 
            this.bakiyedurumu.FormattingEnabled = true;
            this.bakiyedurumu.Items.AddRange(new object[] {
            "Bakiye Verenler",
            "Bakiye Vermeyenler"});
            this.bakiyedurumu.Location = new System.Drawing.Point(101, 256);
            this.bakiyedurumu.Name = "bakiyedurumu";
            this.bakiyedurumu.Size = new System.Drawing.Size(222, 21);
            this.bakiyedurumu.TabIndex = 10;
            // 
            // dokumbicimi
            // 
            this.dokumbicimi.FormattingEnabled = true;
            this.dokumbicimi.Items.AddRange(new object[] {
            "Tutar Toplam ve Bakiyeleri",
            "Tutar ve Miktar Toplamları",
            "Miktar Toplam ve Bakiyeleri",
            "Tutar ve Miktar Bakiyeleri",
            "Tutar ve Miktar Toplam ve Bakiyeleri"});
            this.dokumbicimi.Location = new System.Drawing.Point(101, 222);
            this.dokumbicimi.Name = "dokumbicimi";
            this.dokumbicimi.Size = new System.Drawing.Size(222, 21);
            this.dokumbicimi.TabIndex = 9;
            // 
            // detaygoster
            // 
            this.detaygoster.FormattingEnabled = true;
            this.detaygoster.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.detaygoster.Location = new System.Drawing.Point(101, 189);
            this.detaygoster.Name = "detaygoster";
            this.detaygoster.Size = new System.Drawing.Size(222, 21);
            this.detaygoster.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(101, 157);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // kapanis
            // 
            this.kapanis.AutoSize = true;
            this.kapanis.Location = new System.Drawing.Point(110, 305);
            this.kapanis.Name = "kapanis";
            this.kapanis.Size = new System.Drawing.Size(124, 17);
            this.kapanis.TabIndex = 11;
            this.kapanis.Text = "Kapanış Fişi de Dahil";
            this.kapanis.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(295, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hesapkodu2
            // 
            this.hesapkodu2.Location = new System.Drawing.Point(101, 93);
            this.hesapkodu2.Name = "hesapkodu2";
            this.hesapkodu2.Size = new System.Drawing.Size(188, 20);
            this.hesapkodu2.TabIndex = 4;
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelMuhasebeToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(353, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplamlar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Alacak Miktar :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Borç Miktar :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Alacak Tutar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Borç Tutar :";
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
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(295, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hesapkodu
            // 
            this.hesapkodu.Location = new System.Drawing.Point(101, 59);
            this.hesapkodu.Name = "hesapkodu";
            this.hesapkodu.Size = new System.Drawing.Size(188, 20);
            this.hesapkodu.TabIndex = 2;
            // 
            // aysecimi
            // 
            this.aysecimi.FormattingEnabled = true;
            this.aysecimi.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.aysecimi.Location = new System.Drawing.Point(101, 24);
            this.aysecimi.Name = "aysecimi";
            this.aysecimi.Size = new System.Drawing.Size(222, 21);
            this.aysecimi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bakiye Durumu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detay Göster :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bitiş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Döküm Biçimi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bşlgç. Tarihi :";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
            this.filtreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // kayıtlaToolStripMenuItem
            // 
            this.kayıtlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kaoatToolStripMenuItem});
            this.kayıtlaToolStripMenuItem.Name = "kayıtlaToolStripMenuItem";
            this.kayıtlaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kayıtlaToolStripMenuItem.Text = "Kayıtlar";
            // 
            // kaoatToolStripMenuItem
            // 
            this.kaoatToolStripMenuItem.Name = "kaoatToolStripMenuItem";
            this.kaoatToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kaoatToolStripMenuItem.Text = "Kapat";
            this.kaoatToolStripMenuItem.Click += new System.EventHandler(this.kaoatToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlaToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesap Kodu 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ay Seçimi :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.bakiyedurumu);
            this.tabPage1.Controls.Add(this.dokumbicimi);
            this.tabPage1.Controls.Add(this.detaygoster);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.kapanis);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.hesapkodu2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.hesapkodu);
            this.tabPage1.Controls.Add(this.aysecimi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 473);
            this.tabControl1.TabIndex = 4;
            // 
            // kesinmizanTableAdapter
            // 
            this.kesinmizanTableAdapter.ClearBeforeFill = true;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1015, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1015, 541);
            this.Name = "Form18";
            this.Text = "Kesin Mizan";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kesinmizanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox bakiyedurumu;
        public System.Windows.Forms.ComboBox dokumbicimi;
        public System.Windows.Forms.ComboBox detaygoster;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.CheckBox kapanis;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox hesapkodu2;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox hesapkodu;
        public System.Windows.Forms.ComboBox aysecimi;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kayıtlaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kaoatToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabControl tabControl1;
        public mhsbortakDataSet4 mhsbortakDataSet4;
        public System.Windows.Forms.BindingSource kesinmizanBindingSource;
        public mhsbortakDataSet4TableAdapters.kesinmizanTableAdapter kesinmizanTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn borcTutariDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn alacakTutariDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn borcBakiyesiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn alacakBakiyesiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn mikBorcDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn mikAlacakDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn mikBorcBakiyesiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn mikAlacakBakiyesiDataGridViewTextBoxColumn;

    }
}