namespace muhasebe
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bakiyegosterme = new System.Windows.Forms.RadioButton();
            this.bakiyegoster = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gosterme = new System.Windows.Forms.RadioButton();
            this.goster = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dahiletme = new System.Windows.Forms.RadioButton();
            this.dahilet = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekiDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onceDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozetbilancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet5 = new muhasebe.mhsbortakDataSet5();
            this.ozetbilancoTableAdapter = new muhasebe.mhsbortakDataSet5TableAdapters.ozetbilancoTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozetbilancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet5)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesaplaToolStripMenuItem,
            this.temizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(249, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesapla";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(172, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 66);
            this.button3.TabIndex = 11;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(90, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(7, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bakiyegosterme);
            this.groupBox4.Controls.Add(this.bakiyegoster);
            this.groupBox4.Location = new System.Drawing.Point(7, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bakiyesiz Hesaplar";
            // 
            // bakiyegosterme
            // 
            this.bakiyegosterme.AutoSize = true;
            this.bakiyegosterme.Location = new System.Drawing.Point(20, 42);
            this.bakiyegosterme.Name = "bakiyegosterme";
            this.bakiyegosterme.Size = new System.Drawing.Size(70, 17);
            this.bakiyegosterme.TabIndex = 8;
            this.bakiyegosterme.TabStop = true;
            this.bakiyegosterme.Text = "Gösterme";
            this.bakiyegosterme.UseVisualStyleBackColor = true;
            // 
            // bakiyegoster
            // 
            this.bakiyegoster.AutoSize = true;
            this.bakiyegoster.Location = new System.Drawing.Point(20, 19);
            this.bakiyegoster.Name = "bakiyegoster";
            this.bakiyegoster.Size = new System.Drawing.Size(56, 17);
            this.bakiyegoster.TabIndex = 7;
            this.bakiyegoster.TabStop = true;
            this.bakiyegoster.Text = "Göster";
            this.bakiyegoster.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gosterme);
            this.groupBox3.Controls.Add(this.goster);
            this.groupBox3.Location = new System.Drawing.Point(7, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Önceki Dönem";
            // 
            // gosterme
            // 
            this.gosterme.AutoSize = true;
            this.gosterme.Location = new System.Drawing.Point(20, 45);
            this.gosterme.Name = "gosterme";
            this.gosterme.Size = new System.Drawing.Size(70, 17);
            this.gosterme.TabIndex = 6;
            this.gosterme.TabStop = true;
            this.gosterme.Text = "Gösterme";
            this.gosterme.UseVisualStyleBackColor = true;
            // 
            // goster
            // 
            this.goster.AutoSize = true;
            this.goster.Location = new System.Drawing.Point(20, 22);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(56, 17);
            this.goster.TabIndex = 5;
            this.goster.TabStop = true;
            this.goster.Text = "Göster";
            this.goster.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dahiletme);
            this.groupBox2.Controls.Add(this.dahilet);
            this.groupBox2.Location = new System.Drawing.Point(7, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Özel Fiş Tanımları";
            // 
            // dahiletme
            // 
            this.dahiletme.AutoSize = true;
            this.dahiletme.Location = new System.Drawing.Point(20, 41);
            this.dahiletme.Name = "dahiletme";
            this.dahiletme.Size = new System.Drawing.Size(76, 17);
            this.dahiletme.TabIndex = 4;
            this.dahiletme.TabStop = true;
            this.dahiletme.Text = "Dahil Etme";
            this.dahiletme.UseVisualStyleBackColor = true;
            // 
            // dahilet
            // 
            this.dahilet.AutoSize = true;
            this.dahilet.Location = new System.Drawing.Point(20, 20);
            this.dahilet.Name = "dahilet";
            this.dahilet.Size = new System.Drawing.Size(62, 17);
            this.dahilet.TabIndex = 3;
            this.dahilet.TabStop = true;
            this.dahilet.Text = "Dahil Et";
            this.dahilet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(71, 44);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarihine :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarihinden :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapAdiDataGridViewTextBoxColumn,
            this.oncekiDonemDataGridViewTextBoxColumn,
            this.oncDonemDataGridViewTextBoxColumn,
            this.onceDonemDataGridViewTextBoxColumn,
            this.cDonemDataGridViewTextBoxColumn,
            this.cariDonemDataGridViewTextBoxColumn,
            this.crDonemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ozetbilancoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(263, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 375);
            this.dataGridView1.TabIndex = 12;
            // 
            // hesapAdiDataGridViewTextBoxColumn
            // 
            this.hesapAdiDataGridViewTextBoxColumn.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn.Name = "hesapAdiDataGridViewTextBoxColumn";
            // 
            // oncekiDonemDataGridViewTextBoxColumn
            // 
            this.oncekiDonemDataGridViewTextBoxColumn.DataPropertyName = "OncekiDonem";
            this.oncekiDonemDataGridViewTextBoxColumn.HeaderText = "Önceki Dönem";
            this.oncekiDonemDataGridViewTextBoxColumn.Name = "oncekiDonemDataGridViewTextBoxColumn";
            // 
            // oncDonemDataGridViewTextBoxColumn
            // 
            this.oncDonemDataGridViewTextBoxColumn.DataPropertyName = "OncDonem";
            this.oncDonemDataGridViewTextBoxColumn.HeaderText = "Önceki Dönem";
            this.oncDonemDataGridViewTextBoxColumn.Name = "oncDonemDataGridViewTextBoxColumn";
            // 
            // onceDonemDataGridViewTextBoxColumn
            // 
            this.onceDonemDataGridViewTextBoxColumn.DataPropertyName = "OnceDonem";
            this.onceDonemDataGridViewTextBoxColumn.HeaderText = "Önceki Dönem";
            this.onceDonemDataGridViewTextBoxColumn.Name = "onceDonemDataGridViewTextBoxColumn";
            // 
            // cDonemDataGridViewTextBoxColumn
            // 
            this.cDonemDataGridViewTextBoxColumn.DataPropertyName = "CDonem";
            this.cDonemDataGridViewTextBoxColumn.HeaderText = "Cari Dönem";
            this.cDonemDataGridViewTextBoxColumn.Name = "cDonemDataGridViewTextBoxColumn";
            // 
            // cariDonemDataGridViewTextBoxColumn
            // 
            this.cariDonemDataGridViewTextBoxColumn.DataPropertyName = "CariDonem";
            this.cariDonemDataGridViewTextBoxColumn.HeaderText = "Cari Dönem";
            this.cariDonemDataGridViewTextBoxColumn.Name = "cariDonemDataGridViewTextBoxColumn";
            // 
            // crDonemDataGridViewTextBoxColumn
            // 
            this.crDonemDataGridViewTextBoxColumn.DataPropertyName = "CrDonem";
            this.crDonemDataGridViewTextBoxColumn.HeaderText = "Cari Dönem";
            this.crDonemDataGridViewTextBoxColumn.Name = "crDonemDataGridViewTextBoxColumn";
            // 
            // ozetbilancoBindingSource
            // 
            this.ozetbilancoBindingSource.DataMember = "ozetbilanco";
            this.ozetbilancoBindingSource.DataSource = this.mhsbortakDataSet5;
            // 
            // mhsbortakDataSet5
            // 
            this.mhsbortakDataSet5.DataSetName = "mhsbortakDataSet5";
            this.mhsbortakDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ozetbilancoTableAdapter
            // 
            this.ozetbilancoTableAdapter.ClearBeforeFill = true;
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 462);
            this.Name = "Form25";
            this.Text = "Özet Bilanço";
            this.Load += new System.EventHandler(this.Form25_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ozetbilancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton dahilet;
        private System.Windows.Forms.RadioButton dahiletme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton goster;
        private System.Windows.Forms.RadioButton gosterme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton bakiyegoster;
        private System.Windows.Forms.RadioButton bakiyegosterme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private mhsbortakDataSet5 mhsbortakDataSet5;
        private System.Windows.Forms.BindingSource ozetbilancoBindingSource;
        private mhsbortakDataSet5TableAdapters.ozetbilancoTableAdapter ozetbilancoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncekiDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onceDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDonemDataGridViewTextBoxColumn;
    }
}