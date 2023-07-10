namespace muhasebe
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcToplamiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakToplamiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapanisfisiolusturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet3 = new muhasebe.mhsbortakDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.hesapkodu = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kapanisfisiolusturTableAdapter = new muhasebe.mhsbortakDataSet3TableAdapters.kapanisfisiolusturTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapanisfisiolusturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtlarToolStripMenuItem
            // 
            this.kayıtlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesaplaToolStripMenuItem,
            this.fişOluşturToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.kayıtlarToolStripMenuItem.Name = "kayıtlarToolStripMenuItem";
            this.kayıtlarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.kayıtlarToolStripMenuItem.Text = "Kayıtlar";
            // 
            // hesaplaToolStripMenuItem
            // 
            this.hesaplaToolStripMenuItem.Name = "hesaplaToolStripMenuItem";
            this.hesaplaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.hesaplaToolStripMenuItem.Text = "Hesapla";
            this.hesaplaToolStripMenuItem.Click += new System.EventHandler(this.hesaplaToolStripMenuItem_Click);
            // 
            // fişOluşturToolStripMenuItem
            // 
            this.fişOluşturToolStripMenuItem.Name = "fişOluşturToolStripMenuItem";
            this.fişOluşturToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fişOluşturToolStripMenuItem.Text = "Fiş Oluştur";
            this.fişOluşturToolStripMenuItem.Click += new System.EventHandler(this.fişOluşturToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapKoduDataGridViewTextBoxColumn,
            this.hesapAdiDataGridViewTextBoxColumn,
            this.borcToplamiDataGridViewTextBoxColumn,
            this.alacakToplamiDataGridViewTextBoxColumn,
            this.bakiyeTipiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kapanisfisiolusturBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(329, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(609, 378);
            this.dataGridView1.TabIndex = 10;
            // 
            // hesapKoduDataGridViewTextBoxColumn
            // 
            this.hesapKoduDataGridViewTextBoxColumn.DataPropertyName = "HesapKodu";
            this.hesapKoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapKoduDataGridViewTextBoxColumn.Name = "hesapKoduDataGridViewTextBoxColumn";
            this.hesapKoduDataGridViewTextBoxColumn.Width = 121;
            // 
            // hesapAdiDataGridViewTextBoxColumn
            // 
            this.hesapAdiDataGridViewTextBoxColumn.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn.Name = "hesapAdiDataGridViewTextBoxColumn";
            this.hesapAdiDataGridViewTextBoxColumn.Width = 121;
            // 
            // borcToplamiDataGridViewTextBoxColumn
            // 
            this.borcToplamiDataGridViewTextBoxColumn.DataPropertyName = "BorcToplami";
            this.borcToplamiDataGridViewTextBoxColumn.HeaderText = "Borç Toplamı";
            this.borcToplamiDataGridViewTextBoxColumn.Name = "borcToplamiDataGridViewTextBoxColumn";
            this.borcToplamiDataGridViewTextBoxColumn.Width = 121;
            // 
            // alacakToplamiDataGridViewTextBoxColumn
            // 
            this.alacakToplamiDataGridViewTextBoxColumn.DataPropertyName = "AlacakToplami";
            this.alacakToplamiDataGridViewTextBoxColumn.HeaderText = "Alacak Toplamı";
            this.alacakToplamiDataGridViewTextBoxColumn.Name = "alacakToplamiDataGridViewTextBoxColumn";
            this.alacakToplamiDataGridViewTextBoxColumn.Width = 121;
            // 
            // bakiyeTipiDataGridViewTextBoxColumn
            // 
            this.bakiyeTipiDataGridViewTextBoxColumn.DataPropertyName = "BakiyeTipi";
            this.bakiyeTipiDataGridViewTextBoxColumn.HeaderText = "Bakiye Tipi";
            this.bakiyeTipiDataGridViewTextBoxColumn.Name = "bakiyeTipiDataGridViewTextBoxColumn";
            this.bakiyeTipiDataGridViewTextBoxColumn.Width = 121;
            // 
            // kapanisfisiolusturBindingSource
            // 
            this.kapanisfisiolusturBindingSource.DataMember = "kapanisfisiolustur";
            this.kapanisfisiolusturBindingSource.DataSource = this.mhsbortakDataSet3;
            // 
            // mhsbortakDataSet3
            // 
            this.mhsbortakDataSet3.DataSetName = "mhsbortakDataSet3";
            this.mhsbortakDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarihinden Tarihine";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(75, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tarihinden :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(76, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarihine :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.hesapkodu);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(5, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiş Kaydı";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(267, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // hesapkodu
            // 
            this.hesapkodu.Location = new System.Drawing.Point(75, 13);
            this.hesapkodu.Name = "hesapkodu";
            this.hesapkodu.Size = new System.Drawing.Size(186, 20);
            this.hesapkodu.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(216, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(75, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Fiş Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(216, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(75, 37);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Açıklaması :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hesap Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarihi :";
            // 
            // kapanisfisiolusturTableAdapter
            // 
            this.kapanisfisiolusturTableAdapter.ClearBeforeFill = true;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(958, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(958, 451);
            this.Name = "Form17";
            this.Text = "Kapanış Fişi Oluştur";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapanisfisiolusturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem kayıtlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem hesaplaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fişOluşturToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker3;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public mhsbortakDataSet3 mhsbortakDataSet3;
        public System.Windows.Forms.BindingSource kapanisfisiolusturBindingSource;
        public mhsbortakDataSet3TableAdapters.kapanisfisiolusturTableAdapter kapanisfisiolusturTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn borcToplamiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn alacakToplamiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn bakiyeTipiDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox hesapkodu;
        public System.Windows.Forms.Button button4;

    }
}