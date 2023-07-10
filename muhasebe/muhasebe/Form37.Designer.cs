namespace muhasebe
{
    partial class Form37
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form37));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.belgeTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVliTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVsizTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvlistelerinisorgulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdigerhesaplarDataSet2 = new muhasebe.mhsbdigerhesaplarDataSet2();
            this.kdvlistelerinisorgulaTableAdapter = new muhasebe.mhsbdigerhesaplarDataSet2TableAdapters.kdvlistelerinisorgulaTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvlistelerinisorgulaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdigerhesaplarDataSet2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtreleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // filtreleToolStripMenuItem
            // 
            this.filtreleToolStripMenuItem.Name = "filtreleToolStripMenuItem";
            this.filtreleToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.filtreleToolStripMenuItem.Text = "Filtrele";
            this.filtreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(72, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vazgeç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(72, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarihine :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarihinden :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belgeTarihiDataGridViewTextBoxColumn,
            this.belgeNoDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.kDVliTutarDataGridViewTextBoxColumn,
            this.kDVsizTutarDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kdvlistelerinisorgulaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(260, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(626, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // belgeTarihiDataGridViewTextBoxColumn
            // 
            this.belgeTarihiDataGridViewTextBoxColumn.DataPropertyName = "BelgeTarihi";
            this.belgeTarihiDataGridViewTextBoxColumn.HeaderText = "Belge Tarihi";
            this.belgeTarihiDataGridViewTextBoxColumn.Name = "belgeTarihiDataGridViewTextBoxColumn";
            // 
            // belgeNoDataGridViewTextBoxColumn
            // 
            this.belgeNoDataGridViewTextBoxColumn.DataPropertyName = "BelgeNo";
            this.belgeNoDataGridViewTextBoxColumn.HeaderText = "Belge No";
            this.belgeNoDataGridViewTextBoxColumn.Name = "belgeNoDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // vergiNoDataGridViewTextBoxColumn
            // 
            this.vergiNoDataGridViewTextBoxColumn.DataPropertyName = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.HeaderText = "Vergi No";
            this.vergiNoDataGridViewTextBoxColumn.Name = "vergiNoDataGridViewTextBoxColumn";
            // 
            // kDVliTutarDataGridViewTextBoxColumn
            // 
            this.kDVliTutarDataGridViewTextBoxColumn.DataPropertyName = "KDVliTutar";
            this.kDVliTutarDataGridViewTextBoxColumn.HeaderText = "KDV\'li Tutar";
            this.kDVliTutarDataGridViewTextBoxColumn.Name = "kDVliTutarDataGridViewTextBoxColumn";
            // 
            // kDVsizTutarDataGridViewTextBoxColumn
            // 
            this.kDVsizTutarDataGridViewTextBoxColumn.DataPropertyName = "KDVsizTutar";
            this.kDVsizTutarDataGridViewTextBoxColumn.HeaderText = "KDV\'siz Tutar";
            this.kDVsizTutarDataGridViewTextBoxColumn.Name = "kDVsizTutarDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "Toplam Tutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // kdvlistelerinisorgulaBindingSource
            // 
            this.kdvlistelerinisorgulaBindingSource.DataMember = "kdvlistelerinisorgula";
            this.kdvlistelerinisorgulaBindingSource.DataSource = this.mhsbdigerhesaplarDataSet2;
            // 
            // mhsbdigerhesaplarDataSet2
            // 
            this.mhsbdigerhesaplarDataSet2.DataSetName = "mhsbdigerhesaplarDataSet2";
            this.mhsbdigerhesaplarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kdvlistelerinisorgulaTableAdapter
            // 
            this.kdvlistelerinisorgulaTableAdapter.ClearBeforeFill = true;
            // 
            // Form37
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 336);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(905, 374);
            this.Name = "Form37";
            this.Text = "KDV Listeleri";
            this.Load += new System.EventHandler(this.Form37_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvlistelerinisorgulaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdigerhesaplarDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mhsbdigerhesaplarDataSet2 mhsbdigerhesaplarDataSet2;
        private System.Windows.Forms.BindingSource kdvlistelerinisorgulaBindingSource;
        private mhsbdigerhesaplarDataSet2TableAdapters.kdvlistelerinisorgulaTableAdapter kdvlistelerinisorgulaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVliTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVsizTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}