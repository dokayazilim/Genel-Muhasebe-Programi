namespace muhasebe
{
    partial class Form112
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form112));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelEAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devredenkdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirilecekkdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvtahakkukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebedigerortaklartumhesapDataSet1 = new muhasebe.muhasebedigerortaklartumhesapDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kdvtahakkukuTableAdapter = new muhasebe.muhasebedigerortaklartumhesapDataSet1TableAdapters.kdvtahakkukuTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvtahakkukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebedigerortaklartumhesapDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem1,
            this.yeniKayıtToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.kaydetToolStripMenuItem.Text = "İşlemler";
            // 
            // kaydetToolStripMenuItem1
            // 
            this.kaydetToolStripMenuItem1.Name = "kaydetToolStripMenuItem1";
            this.kaydetToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.kaydetToolStripMenuItem1.Text = "Kaydet";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
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
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // excelEAktarToolStripMenuItem
            // 
            this.excelEAktarToolStripMenuItem.Name = "excelEAktarToolStripMenuItem";
            this.excelEAktarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.excelEAktarToolStripMenuItem.Text = "Excel\' e Aktar";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesaplanan KDV";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapkoduDataGridViewTextBoxColumn,
            this.borcDataGridViewTextBoxColumn,
            this.alacakDataGridViewTextBoxColumn,
            this.devredenkdvDataGridViewTextBoxColumn,
            this.indirilecekkdvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kdvtahakkukuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(857, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // hesapkoduDataGridViewTextBoxColumn
            // 
            this.hesapkoduDataGridViewTextBoxColumn.DataPropertyName = "hesapkodu";
            this.hesapkoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapkoduDataGridViewTextBoxColumn.Name = "hesapkoduDataGridViewTextBoxColumn";
            this.hesapkoduDataGridViewTextBoxColumn.Width = 175;
            // 
            // borcDataGridViewTextBoxColumn
            // 
            this.borcDataGridViewTextBoxColumn.DataPropertyName = "borc";
            this.borcDataGridViewTextBoxColumn.HeaderText = "Borç";
            this.borcDataGridViewTextBoxColumn.Name = "borcDataGridViewTextBoxColumn";
            this.borcDataGridViewTextBoxColumn.Width = 175;
            // 
            // alacakDataGridViewTextBoxColumn
            // 
            this.alacakDataGridViewTextBoxColumn.DataPropertyName = "alacak";
            this.alacakDataGridViewTextBoxColumn.HeaderText = "Alacak";
            this.alacakDataGridViewTextBoxColumn.Name = "alacakDataGridViewTextBoxColumn";
            this.alacakDataGridViewTextBoxColumn.Width = 175;
            // 
            // devredenkdvDataGridViewTextBoxColumn
            // 
            this.devredenkdvDataGridViewTextBoxColumn.DataPropertyName = "devredenkdv";
            this.devredenkdvDataGridViewTextBoxColumn.HeaderText = "Devreden KDV";
            this.devredenkdvDataGridViewTextBoxColumn.Name = "devredenkdvDataGridViewTextBoxColumn";
            this.devredenkdvDataGridViewTextBoxColumn.Width = 150;
            // 
            // indirilecekkdvDataGridViewTextBoxColumn
            // 
            this.indirilecekkdvDataGridViewTextBoxColumn.DataPropertyName = "indirilecekkdv";
            this.indirilecekkdvDataGridViewTextBoxColumn.HeaderText = "İndirilecek KDV";
            this.indirilecekkdvDataGridViewTextBoxColumn.Name = "indirilecekkdvDataGridViewTextBoxColumn";
            this.indirilecekkdvDataGridViewTextBoxColumn.Width = 160;
            // 
            // kdvtahakkukuBindingSource
            // 
            this.kdvtahakkukuBindingSource.DataMember = "kdvtahakkuku";
            this.kdvtahakkukuBindingSource.DataSource = this.muhasebedigerortaklartumhesapDataSet1;
            // 
            // muhasebedigerortaklartumhesapDataSet1
            // 
            this.muhasebedigerortaklartumhesapDataSet1.DataSetName = "muhasebedigerortaklartumhesapDataSet1";
            this.muhasebedigerortaklartumhesapDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplamlar";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(743, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(543, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(290, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(76, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İnd. KDV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alacak :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Devreden KDV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borç :";
            // 
            // kdvtahakkukuTableAdapter
            // 
            this.kdvtahakkukuTableAdapter.ClearBeforeFill = true;
            // 
            // Form112
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 453);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(887, 453);
            this.Name = "Form112";
            this.Text = "KDV Tahakkuku";
            this.Load += new System.EventHandler(this.Form112_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvtahakkukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebedigerortaklartumhesapDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelEAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genelMuhasebeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private muhasebedigerortaklartumhesapDataSet1 muhasebedigerortaklartumhesapDataSet1;
        private System.Windows.Forms.BindingSource kdvtahakkukuBindingSource;
        private muhasebedigerortaklartumhesapDataSet1TableAdapters.kdvtahakkukuTableAdapter kdvtahakkukuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alacakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devredenkdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirilecekkdvDataGridViewTextBoxColumn;
    }
}