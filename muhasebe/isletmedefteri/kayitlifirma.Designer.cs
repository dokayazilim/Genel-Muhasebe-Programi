namespace isletmedefteri
{
    partial class kayitlifirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitlifirma));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tckimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmedefteriortaklarDataSet1 = new isletmedefteri.isletmedefteriortaklarDataSet1();
            this.firmakayitTableAdapter = new isletmedefteri.isletmedefteriortaklarDataSet1TableAdapters.firmakayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tckimliknoDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.vergidairesinoDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.ceptelefonDataGridViewTextBoxColumn,
            this.donemDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.firmakayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(746, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tckimliknoDataGridViewTextBoxColumn
            // 
            this.tckimliknoDataGridViewTextBoxColumn.DataPropertyName = "tckimlikno";
            this.tckimliknoDataGridViewTextBoxColumn.HeaderText = "T.C. Kimlik No";
            this.tckimliknoDataGridViewTextBoxColumn.Name = "tckimliknoDataGridViewTextBoxColumn";
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // vergidairesinoDataGridViewTextBoxColumn
            // 
            this.vergidairesinoDataGridViewTextBoxColumn.DataPropertyName = "vergidairesino";
            this.vergidairesinoDataGridViewTextBoxColumn.HeaderText = "Vergi Dairesi No";
            this.vergidairesinoDataGridViewTextBoxColumn.Name = "vergidairesinoDataGridViewTextBoxColumn";
            this.vergidairesinoDataGridViewTextBoxColumn.Width = 110;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // ceptelefonDataGridViewTextBoxColumn
            // 
            this.ceptelefonDataGridViewTextBoxColumn.DataPropertyName = "ceptelefon";
            this.ceptelefonDataGridViewTextBoxColumn.HeaderText = "Cep Telefonu";
            this.ceptelefonDataGridViewTextBoxColumn.Name = "ceptelefonDataGridViewTextBoxColumn";
            // 
            // donemDataGridViewTextBoxColumn
            // 
            this.donemDataGridViewTextBoxColumn.DataPropertyName = "donem";
            this.donemDataGridViewTextBoxColumn.HeaderText = "Dönem";
            this.donemDataGridViewTextBoxColumn.Name = "donemDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.isletmedefteriortaklarDataSet1;
            // 
            // isletmedefteriortaklarDataSet1
            // 
            this.isletmedefteriortaklarDataSet1.DataSetName = "isletmedefteriortaklarDataSet1";
            this.isletmedefteriortaklarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(669, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(588, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yeni Firma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayitlifirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 368);
            this.Name = "kayitlifirma";
            this.Text = "Kayıtlı Firmalar";
            this.Load += new System.EventHandler(this.kayitlifirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private isletmedefteriortaklarDataSet1 isletmedefteriortaklarDataSet1;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private isletmedefteriortaklarDataSet1TableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}