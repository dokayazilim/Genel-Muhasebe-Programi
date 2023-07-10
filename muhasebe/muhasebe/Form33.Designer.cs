namespace muhasebe
{
    partial class Form33
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form33));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hesapkodu2 = new System.Windows.Forms.TextBox();
            this.hesapkodu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamAlacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virmanHesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virmanhesabinaaktarimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet8 = new muhasebe.mhsbortakDataSet8();
            this.virmanhesabinaaktarimTableAdapter = new muhasebe.mhsbortakDataSet8TableAdapters.virmanhesabinaaktarimTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.virmanhesabinaaktarimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet8)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
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
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
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
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 376);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.hesapkodu2);
            this.tabPage1.Controls.Add(this.hesapkodu);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiş Kaydı";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(9, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "Fiş Oluştur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "VİRMAN HESABINA AKTARIM FİŞİ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(86, 24);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fiş Açıklaması :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiş Tarihi :";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(145, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(6, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Filtrele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageKey = "Find122.png";
            this.button2.Location = new System.Drawing.Point(231, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageKey = "Find122.png";
            this.button1.Location = new System.Drawing.Point(231, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hesapkodu2
            // 
            this.hesapkodu2.Location = new System.Drawing.Point(94, 49);
            this.hesapkodu2.Name = "hesapkodu2";
            this.hesapkodu2.Size = new System.Drawing.Size(135, 20);
            this.hesapkodu2.TabIndex = 3;
            // 
            // hesapkodu
            // 
            this.hesapkodu.Location = new System.Drawing.Point(94, 17);
            this.hesapkodu.Name = "hesapkodu";
            this.hesapkodu.Size = new System.Drawing.Size(135, 20);
            this.hesapkodu.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Tarihi";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(71, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tarihine :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarihinden :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap Kodu 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
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
            this.toplamBorcDataGridViewTextBoxColumn,
            this.toplamAlacakDataGridViewTextBoxColumn,
            this.bakiyeDataGridViewTextBoxColumn,
            this.bASDataGridViewTextBoxColumn,
            this.virmanHesapKoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.virmanhesabinaaktarimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(274, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(633, 357);
            this.dataGridView1.TabIndex = 12;
            // 
            // hesapKoduDataGridViewTextBoxColumn
            // 
            this.hesapKoduDataGridViewTextBoxColumn.DataPropertyName = "HesapKodu";
            this.hesapKoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapKoduDataGridViewTextBoxColumn.Name = "hesapKoduDataGridViewTextBoxColumn";
            // 
            // toplamBorcDataGridViewTextBoxColumn
            // 
            this.toplamBorcDataGridViewTextBoxColumn.DataPropertyName = "ToplamBorc";
            this.toplamBorcDataGridViewTextBoxColumn.HeaderText = "Toplam Borç";
            this.toplamBorcDataGridViewTextBoxColumn.Name = "toplamBorcDataGridViewTextBoxColumn";
            // 
            // toplamAlacakDataGridViewTextBoxColumn
            // 
            this.toplamAlacakDataGridViewTextBoxColumn.DataPropertyName = "ToplamAlacak";
            this.toplamAlacakDataGridViewTextBoxColumn.HeaderText = "Toplam Alacak";
            this.toplamAlacakDataGridViewTextBoxColumn.Name = "toplamAlacakDataGridViewTextBoxColumn";
            // 
            // bakiyeDataGridViewTextBoxColumn
            // 
            this.bakiyeDataGridViewTextBoxColumn.DataPropertyName = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.HeaderText = "Bakiye";
            this.bakiyeDataGridViewTextBoxColumn.Name = "bakiyeDataGridViewTextBoxColumn";
            // 
            // bASDataGridViewTextBoxColumn
            // 
            this.bASDataGridViewTextBoxColumn.DataPropertyName = "BAS";
            this.bASDataGridViewTextBoxColumn.HeaderText = "B/A/S";
            this.bASDataGridViewTextBoxColumn.Name = "bASDataGridViewTextBoxColumn";
            // 
            // virmanHesapKoduDataGridViewTextBoxColumn
            // 
            this.virmanHesapKoduDataGridViewTextBoxColumn.DataPropertyName = "VirmanHesapKodu";
            this.virmanHesapKoduDataGridViewTextBoxColumn.HeaderText = "Virman Hesap Kodu";
            this.virmanHesapKoduDataGridViewTextBoxColumn.Name = "virmanHesapKoduDataGridViewTextBoxColumn";
            // 
            // virmanhesabinaaktarimBindingSource
            // 
            this.virmanhesabinaaktarimBindingSource.DataMember = "virmanhesabinaaktarim";
            this.virmanhesabinaaktarimBindingSource.DataSource = this.mhsbortakDataSet8;
            // 
            // mhsbortakDataSet8
            // 
            this.mhsbortakDataSet8.DataSetName = "mhsbortakDataSet8";
            this.mhsbortakDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // virmanhesabinaaktarimTableAdapter
            // 
            this.virmanhesabinaaktarimTableAdapter.ClearBeforeFill = true;
            // 
            // Form33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 406);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(925, 444);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(925, 444);
            this.Name = "Form33";
            this.Text = "Virman Hesabına Aktarım";
            this.Load += new System.EventHandler(this.Form33_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.virmanhesabinaaktarimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.TextBox hesapkodu;
        public System.Windows.Forms.TextBox hesapkodu2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dateTimePicker3;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        public mhsbortakDataSet8 mhsbortakDataSet8;
        public System.Windows.Forms.BindingSource virmanhesabinaaktarimBindingSource;
        public mhsbortakDataSet8TableAdapters.virmanhesabinaaktarimTableAdapter virmanhesabinaaktarimTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn toplamBorcDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn toplamAlacakDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn bakiyeDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn bASDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn virmanHesapKoduDataGridViewTextBoxColumn;

    }
}