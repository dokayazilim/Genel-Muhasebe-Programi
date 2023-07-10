namespace muhasebe
{
    partial class Form55
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form55));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmakayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet46 = new muhasebe.mhsbdataDataSet46();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet45 = new muhasebe.mhsbdataDataSet45();
            this.firmakayitTableAdapter = new muhasebe.mhsbdataDataSet45TableAdapters.firmakayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.firmakayitTableAdapter1 = new muhasebe.mhsbdataDataSet46TableAdapters.firmakayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet45)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaKoduDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.tCKimlikNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmakayitBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(624, 262);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // firmaKoduDataGridViewTextBoxColumn
            // 
            this.firmaKoduDataGridViewTextBoxColumn.DataPropertyName = "FirmaKodu";
            this.firmaKoduDataGridViewTextBoxColumn.HeaderText = "Firma Kodu";
            this.firmaKoduDataGridViewTextBoxColumn.Name = "firmaKoduDataGridViewTextBoxColumn";
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
            // tCKimlikNoDataGridViewTextBoxColumn
            // 
            this.tCKimlikNoDataGridViewTextBoxColumn.DataPropertyName = "TCKimlikNo";
            this.tCKimlikNoDataGridViewTextBoxColumn.HeaderText = "T.C. Kimlik No";
            this.tCKimlikNoDataGridViewTextBoxColumn.Name = "tCKimlikNoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // firmakayitBindingSource1
            // 
            this.firmakayitBindingSource1.DataMember = "firmakayit";
            this.firmakayitBindingSource1.DataSource = this.mhsbdataDataSet46;
            // 
            // mhsbdataDataSet46
            // 
            this.mhsbdataDataSet46.DataSetName = "mhsbdataDataSet46";
            this.mhsbdataDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.mhsbdataDataSet45;
            // 
            // mhsbdataDataSet45
            // 
            this.mhsbdataDataSet45.DataSetName = "mhsbdataDataSet45";
            this.mhsbdataDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(550, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firmakayitTableAdapter1
            // 
            this.firmakayitTableAdapter1.ClearBeforeFill = true;
            // 
            // Form55
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 292);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(643, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(643, 330);
            this.Name = "Form55";
            this.Text = "Firma Bilgileri";
            this.Load += new System.EventHandler(this.Form55_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet45)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private mhsbdataDataSet45 mhsbdataDataSet45;
        private mhsbdataDataSet45TableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private System.Windows.Forms.Button button1;
        private mhsbdataDataSet46 mhsbdataDataSet46;
        private System.Windows.Forms.BindingSource firmakayitBindingSource1;
        private mhsbdataDataSet46TableAdapters.firmakayitTableAdapter firmakayitTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}