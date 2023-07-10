namespace muhasebe
{
    partial class Form69
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form69));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet44 = new muhasebe.mhsbdataDataSet44();
            this.firmakayitTableAdapter = new muhasebe.mhsbdataDataSet44TableAdapters.firmakayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet44)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.DataSource = this.firmakayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(643, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.adresDataGridViewTextBoxColumn.Width = 120;
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.mhsbdataDataSet44;
            // 
            // mhsbdataDataSet44
            // 
            this.mhsbdataDataSet44.DataSetName = "mhsbdataDataSet44";
            this.mhsbdataDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(441, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çalışma Dönemi :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2013 - 2014"});
            this.comboBox1.Location = new System.Drawing.Point(522, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "2013 - 2014";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(545, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(337, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Yeni Firma";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Demo";
            // 
            // Form69
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 357);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 357);
            this.Name = "Form69";
            this.Text = "Şirket Kayıtları";
            this.Load += new System.EventHandler(this.Form69_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet44)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mhsbdataDataSet44 mhsbdataDataSet44;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private mhsbdataDataSet44TableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}