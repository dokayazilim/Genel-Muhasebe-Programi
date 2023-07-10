namespace muhasebe
{
    partial class Form65
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form65));
            this.button5 = new System.Windows.Forms.Button();
            this.stokadiarama = new System.Windows.Forms.RadioButton();
            this.stokkoduarama = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kayitlarTableAdapter = new muhasebe.mhsbortaklarDataSet1TableAdapters.kayitlarTableAdapter();
            this.mhsbortaklarDataSet1 = new muhasebe.mhsbortaklarDataSet1();
            this.kayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSMMHesabiAlisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maliyetHesabiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoktanimlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet41 = new muhasebe.mhsbdataDataSet41();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stoktanimlariTableAdapter = new muhasebe.mhsbdataDataSet41TableAdapters.stoktanimlariTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortaklarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet41)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(77, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "İptal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // stokadiarama
            // 
            this.stokadiarama.AutoSize = true;
            this.stokadiarama.Location = new System.Drawing.Point(15, 44);
            this.stokadiarama.Name = "stokadiarama";
            this.stokadiarama.Size = new System.Drawing.Size(65, 17);
            this.stokadiarama.TabIndex = 3;
            this.stokadiarama.TabStop = true;
            this.stokadiarama.Text = "Stok Adı";
            this.stokadiarama.UseVisualStyleBackColor = true;
            // 
            // stokkoduarama
            // 
            this.stokkoduarama.AutoSize = true;
            this.stokkoduarama.Location = new System.Drawing.Point(15, 19);
            this.stokkoduarama.Name = "stokkoduarama";
            this.stokkoduarama.Size = new System.Drawing.Size(75, 17);
            this.stokkoduarama.TabIndex = 2;
            this.stokkoduarama.TabStop = true;
            this.stokkoduarama.Text = "Stok Kodu";
            this.stokkoduarama.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stokadiarama);
            this.groupBox1.Controls.Add(this.stokkoduarama);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme";
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(56, 22);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(156, 20);
            this.arama.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Arama :";
            // 
            // kayitlarTableAdapter
            // 
            this.kayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // mhsbortaklarDataSet1
            // 
            this.mhsbortaklarDataSet1.DataSetName = "mhsbortaklarDataSet1";
            this.mhsbortaklarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitlarBindingSource
            // 
            this.kayitlarBindingSource.DataMember = "kayitlar";
            this.kayitlarBindingSource.DataSource = this.mhsbortaklarDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokKoduDataGridViewTextBoxColumn,
            this.stokAdiDataGridViewTextBoxColumn,
            this.grubuDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.dSMMHesabiAlisDataGridViewTextBoxColumn,
            this.maliyetHesabiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoktanimlariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(246, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(421, 281);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stokKoduDataGridViewTextBoxColumn
            // 
            this.stokKoduDataGridViewTextBoxColumn.DataPropertyName = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.HeaderText = "Stok Kodu";
            this.stokKoduDataGridViewTextBoxColumn.Name = "stokKoduDataGridViewTextBoxColumn";
            // 
            // stokAdiDataGridViewTextBoxColumn
            // 
            this.stokAdiDataGridViewTextBoxColumn.DataPropertyName = "StokAdi";
            this.stokAdiDataGridViewTextBoxColumn.HeaderText = "Stok Adı";
            this.stokAdiDataGridViewTextBoxColumn.Name = "stokAdiDataGridViewTextBoxColumn";
            // 
            // grubuDataGridViewTextBoxColumn
            // 
            this.grubuDataGridViewTextBoxColumn.DataPropertyName = "Grubu";
            this.grubuDataGridViewTextBoxColumn.HeaderText = "Grubu";
            this.grubuDataGridViewTextBoxColumn.Name = "grubuDataGridViewTextBoxColumn";
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "Birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // dSMMHesabiAlisDataGridViewTextBoxColumn
            // 
            this.dSMMHesabiAlisDataGridViewTextBoxColumn.DataPropertyName = "DSMMHesabiAlis";
            this.dSMMHesabiAlisDataGridViewTextBoxColumn.HeaderText = "DSMM Hesabı (Alış)";
            this.dSMMHesabiAlisDataGridViewTextBoxColumn.Name = "dSMMHesabiAlisDataGridViewTextBoxColumn";
            // 
            // maliyetHesabiDataGridViewTextBoxColumn
            // 
            this.maliyetHesabiDataGridViewTextBoxColumn.DataPropertyName = "MaliyetHesabi";
            this.maliyetHesabiDataGridViewTextBoxColumn.HeaderText = "Maliyet Hesabı";
            this.maliyetHesabiDataGridViewTextBoxColumn.Name = "maliyetHesabiDataGridViewTextBoxColumn";
            // 
            // stoktanimlariBindingSource
            // 
            this.stoktanimlariBindingSource.DataMember = "stoktanimlari";
            this.stoktanimlariBindingSource.DataSource = this.mhsbdataDataSet41;
            // 
            // mhsbdataDataSet41
            // 
            this.mhsbdataDataSet41.DataSetName = "mhsbdataDataSet41";
            this.mhsbdataDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.arama);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(230, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtreleme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(77, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yeni Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(77, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Filtrele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 305);
            this.tabControl1.TabIndex = 2;
            // 
            // stoktanimlariTableAdapter
            // 
            this.stoktanimlariTableAdapter.ClearBeforeFill = true;
            // 
            // Form65
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 350);
            this.Name = "Form65";
            this.Text = "Stok Kayıtları";
            this.Load += new System.EventHandler(this.Form65_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortaklarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoktanimlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet41)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton stokadiarama;
        private System.Windows.Forms.RadioButton stokkoduarama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.Label label4;
        private mhsbortaklarDataSet1TableAdapters.kayitlarTableAdapter kayitlarTableAdapter;
        private mhsbortaklarDataSet1 mhsbortaklarDataSet1;
        private System.Windows.Forms.BindingSource kayitlarBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private mhsbdataDataSet41 mhsbdataDataSet41;
        private System.Windows.Forms.BindingSource stoktanimlariBindingSource;
        private mhsbdataDataSet41TableAdapters.stoktanimlariTableAdapter stoktanimlariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSMMHesabiAlisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maliyetHesabiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}