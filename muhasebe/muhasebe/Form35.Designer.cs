namespace muhasebe
{
    partial class Form35
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form35));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiDönemdenAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekiDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDonemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekidonemgelirtablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet11 = new muhasebe.mhsbortakDataSet11();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hesapAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekiDonemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDonemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekidonemsatislarinmaliyetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakDataSet12 = new muhasebe.mhsbortakDataSet12();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.oncekidonemgelirtablosuTableAdapter = new muhasebe.mhsbortakDataSet11TableAdapters.oncekidonemgelirtablosuTableAdapter();
            this.oncekidonemsatislarinmaliyetiTableAdapter = new muhasebe.mhsbortakDataSet12TableAdapters.oncekidonemsatislarinmaliyetiTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncekidonemgelirtablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncekidonemsatislarinmaliyetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet12)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.öncekiDönemdenAktarToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // öncekiDönemdenAktarToolStripMenuItem
            // 
            this.öncekiDönemdenAktarToolStripMenuItem.Name = "öncekiDönemdenAktarToolStripMenuItem";
            this.öncekiDönemdenAktarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.öncekiDönemdenAktarToolStripMenuItem.Text = "Önceki Dönemden Aktar";
            this.öncekiDönemdenAktarToolStripMenuItem.Click += new System.EventHandler(this.öncekiDönemdenAktarToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir Tablosu";
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
            this.oDonemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oncekidonemgelirtablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(871, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // hesapAdiDataGridViewTextBoxColumn
            // 
            this.hesapAdiDataGridViewTextBoxColumn.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn.Name = "hesapAdiDataGridViewTextBoxColumn";
            this.hesapAdiDataGridViewTextBoxColumn.Width = 285;
            // 
            // oncekiDonemDataGridViewTextBoxColumn
            // 
            this.oncekiDonemDataGridViewTextBoxColumn.DataPropertyName = "OncekiDonem";
            this.oncekiDonemDataGridViewTextBoxColumn.HeaderText = "Önceki Dönem";
            this.oncekiDonemDataGridViewTextBoxColumn.Name = "oncekiDonemDataGridViewTextBoxColumn";
            this.oncekiDonemDataGridViewTextBoxColumn.Width = 285;
            // 
            // oDonemDataGridViewTextBoxColumn
            // 
            this.oDonemDataGridViewTextBoxColumn.DataPropertyName = "ODonem";
            this.oDonemDataGridViewTextBoxColumn.HeaderText = "Önceki Dönem";
            this.oDonemDataGridViewTextBoxColumn.Name = "oDonemDataGridViewTextBoxColumn";
            this.oDonemDataGridViewTextBoxColumn.Width = 280;
            // 
            // oncekidonemgelirtablosuBindingSource
            // 
            this.oncekidonemgelirtablosuBindingSource.DataMember = "oncekidonemgelirtablosu";
            this.oncekidonemgelirtablosuBindingSource.DataSource = this.mhsbortakDataSet11;
            // 
            // mhsbortakDataSet11
            // 
            this.mhsbortakDataSet11.DataSetName = "mhsbortakDataSet11";
            this.mhsbortakDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(3, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satışların Maliyeti Tablosu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapAdiDataGridViewTextBoxColumn1,
            this.oncekiDonemDataGridViewTextBoxColumn1,
            this.oDonemDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.oncekidonemsatislarinmaliyetiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(5, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.Size = new System.Drawing.Size(871, 199);
            this.dataGridView2.TabIndex = 2;
            // 
            // hesapAdiDataGridViewTextBoxColumn1
            // 
            this.hesapAdiDataGridViewTextBoxColumn1.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn1.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn1.Name = "hesapAdiDataGridViewTextBoxColumn1";
            this.hesapAdiDataGridViewTextBoxColumn1.Width = 285;
            // 
            // oncekiDonemDataGridViewTextBoxColumn1
            // 
            this.oncekiDonemDataGridViewTextBoxColumn1.DataPropertyName = "OncekiDonem";
            this.oncekiDonemDataGridViewTextBoxColumn1.HeaderText = "Önceki Dönem";
            this.oncekiDonemDataGridViewTextBoxColumn1.Name = "oncekiDonemDataGridViewTextBoxColumn1";
            this.oncekiDonemDataGridViewTextBoxColumn1.Width = 285;
            // 
            // oDonemDataGridViewTextBoxColumn1
            // 
            this.oDonemDataGridViewTextBoxColumn1.DataPropertyName = "ODonem";
            this.oDonemDataGridViewTextBoxColumn1.HeaderText = "Önceki Dönem";
            this.oDonemDataGridViewTextBoxColumn1.Name = "oDonemDataGridViewTextBoxColumn1";
            this.oDonemDataGridViewTextBoxColumn1.Width = 280;
            // 
            // oncekidonemsatislarinmaliyetiBindingSource
            // 
            this.oncekidonemsatislarinmaliyetiBindingSource.DataMember = "oncekidonemsatislarinmaliyeti";
            this.oncekidonemsatislarinmaliyetiBindingSource.DataSource = this.mhsbortakDataSet12;
            // 
            // mhsbortakDataSet12
            // 
            this.mhsbortakDataSet12.DataSetName = "mhsbortakDataSet12";
            this.mhsbortakDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(116, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(308, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Önceki Dönemden Aktar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(687, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(557, 487);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Otomatik Hesapla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // oncekidonemgelirtablosuTableAdapter
            // 
            this.oncekidonemgelirtablosuTableAdapter.ClearBeforeFill = true;
            // 
            // oncekidonemsatislarinmaliyetiTableAdapter
            // 
            this.oncekidonemsatislarinmaliyetiTableAdapter.ClearBeforeFill = true;
            // 
            // Form35
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 516);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(902, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(902, 554);
            this.Name = "Form35";
            this.Text = "Önceki Dönem";
            this.Load += new System.EventHandler(this.Form35_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncekidonemgelirtablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oncekidonemsatislarinmaliyetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiDönemdenAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private mhsbortakDataSet11 mhsbortakDataSet11;
        private System.Windows.Forms.BindingSource oncekidonemgelirtablosuBindingSource;
        private mhsbortakDataSet11TableAdapters.oncekidonemgelirtablosuTableAdapter oncekidonemgelirtablosuTableAdapter;
        private mhsbortakDataSet12 mhsbortakDataSet12;
        private System.Windows.Forms.BindingSource oncekidonemsatislarinmaliyetiBindingSource;
        private mhsbortakDataSet12TableAdapters.oncekidonemsatislarinmaliyetiTableAdapter oncekidonemsatislarinmaliyetiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncekiDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDonemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncekiDonemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDonemDataGridViewTextBoxColumn1;
    }
}