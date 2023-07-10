namespace muhasebe
{
    partial class Form63
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form63));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ftckimlik = new System.Windows.Forms.TextBox();
            this.fadi = new System.Windows.Forms.TextBox();
            this.fkodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmakayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet32 = new muhasebe.mhsbdataDataSet32();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbDataSet = new muhasebe.mhsbDataSet();
            this.firmakayitTableAdapter = new muhasebe.mhsbDataSetTableAdapters.firmakayitTableAdapter();
            this.firmakayitTableAdapter1 = new muhasebe.mhsbdataDataSet32TableAdapters.firmakayitTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.ftckimlik);
            this.tabPage2.Controls.Add(this.fadi);
            this.tabPage2.Controls.Add(this.fkodu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtrele";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(20, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(111, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(20, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ftckimlik
            // 
            this.ftckimlik.Location = new System.Drawing.Point(86, 70);
            this.ftckimlik.Name = "ftckimlik";
            this.ftckimlik.Size = new System.Drawing.Size(100, 20);
            this.ftckimlik.TabIndex = 3;
            // 
            // fadi
            // 
            this.fadi.Location = new System.Drawing.Point(86, 42);
            this.fadi.Name = "fadi";
            this.fadi.Size = new System.Drawing.Size(100, 20);
            this.fadi.TabIndex = 2;
            this.fadi.TextChanged += new System.EventHandler(this.fadi_TextChanged);
            // 
            // fkodu
            // 
            this.fkodu.Location = new System.Drawing.Point(86, 13);
            this.fkodu.Name = "fkodu";
            this.fkodu.Size = new System.Drawing.Size(100, 20);
            this.fkodu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "T.C. Kimlik No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Kodu :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaKoduDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.tCKimlikNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmakayitBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(204, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(425, 247);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firmaKoduDataGridViewTextBoxColumn
            // 
            this.firmaKoduDataGridViewTextBoxColumn.DataPropertyName = "FirmaKodu";
            this.firmaKoduDataGridViewTextBoxColumn.HeaderText = "Firma Kodu";
            this.firmaKoduDataGridViewTextBoxColumn.Name = "firmaKoduDataGridViewTextBoxColumn";
            this.firmaKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            this.soyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            this.adiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vergiNoDataGridViewTextBoxColumn
            // 
            this.vergiNoDataGridViewTextBoxColumn.DataPropertyName = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.HeaderText = "Vergi No";
            this.vergiNoDataGridViewTextBoxColumn.Name = "vergiNoDataGridViewTextBoxColumn";
            this.vergiNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCKimlikNoDataGridViewTextBoxColumn
            // 
            this.tCKimlikNoDataGridViewTextBoxColumn.DataPropertyName = "TCKimlikNo";
            this.tCKimlikNoDataGridViewTextBoxColumn.HeaderText = "T.C. Kimlik No";
            this.tCKimlikNoDataGridViewTextBoxColumn.Name = "tCKimlikNoDataGridViewTextBoxColumn";
            this.tCKimlikNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmakayitBindingSource1
            // 
            this.firmakayitBindingSource1.DataMember = "firmakayit";
            this.firmakayitBindingSource1.DataSource = this.mhsbdataDataSet32;
            // 
            // mhsbdataDataSet32
            // 
            this.mhsbdataDataSet32.DataSetName = "mhsbdataDataSet32";
            this.mhsbdataDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.mhsbDataSet;
            // 
            // mhsbDataSet
            // 
            this.mhsbDataSet.DataSetName = "mhsbDataSet";
            this.mhsbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // firmakayitTableAdapter1
            // 
            this.firmakayitTableAdapter1.ClearBeforeFill = true;
            // 
            // Form63
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 273);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 311);
            this.Name = "Form63";
            this.Text = "Firma Kayıtları";
            this.Load += new System.EventHandler(this.Form63_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mhsbDataSet mhsbDataSet;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private mhsbDataSetTableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ftckimlik;
        private System.Windows.Forms.TextBox fadi;
        private System.Windows.Forms.TextBox fkodu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private mhsbdataDataSet32 mhsbdataDataSet32;
        private System.Windows.Forms.BindingSource firmakayitBindingSource1;
        private mhsbdataDataSet32TableAdapters.firmakayitTableAdapter firmakayitTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;

    }
}