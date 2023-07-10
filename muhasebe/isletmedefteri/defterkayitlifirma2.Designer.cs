namespace isletmedefteri
{
    partial class defterkayitlifirma2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(defterkayitlifirma2));
            this.firmakayitTableAdapter1 = new isletmedefteri.isletmedefteriortaklarDataSet3TableAdapters.firmakayitTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.firmakayitTableAdapter = new isletmedefteri.isletmedefteriortaklarDataSet2TableAdapters.firmakayitTableAdapter();
            this.isletmedefteriortaklarDataSet2 = new isletmedefteri.isletmedefteriortaklarDataSet2();
            this.firmakayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmedefteriortaklarDataSet3 = new isletmedefteri.isletmedefteriortaklarDataSet3();
            this.firmakayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isletmedefteriortaklarDataSet4 = new isletmedefteri.isletmedefteriortaklarDataSet4();
            this.firmakayitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.firmakayitTableAdapter2 = new isletmedefteri.isletmedefteriortaklarDataSet4TableAdapters.firmakayitTableAdapter();
            this.tckimliknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // firmakayitTableAdapter1
            // 
            this.firmakayitTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(592, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Yeni Firma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firmakayitTableAdapter
            // 
            this.firmakayitTableAdapter.ClearBeforeFill = true;
            // 
            // isletmedefteriortaklarDataSet2
            // 
            this.isletmedefteriortaklarDataSet2.DataSetName = "isletmedefteriortaklarDataSet2";
            this.isletmedefteriortaklarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource
            // 
            this.firmakayitBindingSource.DataMember = "firmakayit";
            this.firmakayitBindingSource.DataSource = this.isletmedefteriortaklarDataSet2;
            // 
            // isletmedefteriortaklarDataSet3
            // 
            this.isletmedefteriortaklarDataSet3.DataSetName = "isletmedefteriortaklarDataSet3";
            this.isletmedefteriortaklarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource1
            // 
            this.firmakayitBindingSource1.DataMember = "firmakayit";
            this.firmakayitBindingSource1.DataSource = this.isletmedefteriortaklarDataSet3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(673, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.DataSource = this.firmakayitBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(746, 289);
            this.dataGridView1.TabIndex = 8;
            // 
            // isletmedefteriortaklarDataSet4
            // 
            this.isletmedefteriortaklarDataSet4.DataSetName = "isletmedefteriortaklarDataSet4";
            this.isletmedefteriortaklarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmakayitBindingSource2
            // 
            this.firmakayitBindingSource2.DataMember = "firmakayit";
            this.firmakayitBindingSource2.DataSource = this.isletmedefteriortaklarDataSet4;
            // 
            // firmakayitTableAdapter2
            // 
            this.firmakayitTableAdapter2.ClearBeforeFill = true;
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
            // defterkayitlifirma2
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
            this.Name = "defterkayitlifirma2";
            this.Text = "Kayıtlı Firmalar";
            this.Load += new System.EventHandler(this.defterkayitlifirma2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmedefteriortaklarDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmakayitBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private isletmedefteriortaklarDataSet3TableAdapters.firmakayitTableAdapter firmakayitTableAdapter1;
        private System.Windows.Forms.Button button2;
        private isletmedefteriortaklarDataSet2TableAdapters.firmakayitTableAdapter firmakayitTableAdapter;
        private isletmedefteriortaklarDataSet2 isletmedefteriortaklarDataSet2;
        private System.Windows.Forms.BindingSource firmakayitBindingSource;
        private isletmedefteriortaklarDataSet3 isletmedefteriortaklarDataSet3;
        private System.Windows.Forms.BindingSource firmakayitBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private isletmedefteriortaklarDataSet4 isletmedefteriortaklarDataSet4;
        private System.Windows.Forms.BindingSource firmakayitBindingSource2;
        private isletmedefteriortaklarDataSet4TableAdapters.firmakayitTableAdapter firmakayitTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimliknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}