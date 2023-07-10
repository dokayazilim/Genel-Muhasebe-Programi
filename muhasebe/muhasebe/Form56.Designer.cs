namespace muhasebe
{
    partial class Form56
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form56));
            this.hesapkodlariTableAdapter1 = new muhasebe.muhasebeDataSet2TableAdapters.hesapkodlariTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.arama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hesapkoduTableAdapter = new muhasebe.muhasebeDataSetTableAdapters.hesapkoduTableAdapter();
            this.muhasebeDataSet2 = new muhasebe.muhasebeDataSet2();
            this.hesapkodlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapkodlariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet4 = new muhasebe.muhasebeDataSet4();
            this.hesapkodlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet1 = new muhasebe.muhasebeDataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hesapkoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet = new muhasebe.muhasebeDataSet();
            this.hesapkodlariTableAdapter = new muhasebe.muhasebeDataSet1TableAdapters.hesapkodlariTableAdapter();
            this.hesapkodlariTableAdapter2 = new muhasebe.muhasebeDataSet4TableAdapters.hesapkodlariTableAdapter();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkoduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // hesapkodlariTableAdapter1
            // 
            this.hesapkodlariTableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.arama);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtrele";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(77, 17);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(100, 20);
            this.arama.TabIndex = 1;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama :";
            // 
            // hesapkoduTableAdapter
            // 
            this.hesapkoduTableAdapter.ClearBeforeFill = true;
            // 
            // muhasebeDataSet2
            // 
            this.muhasebeDataSet2.DataSetName = "muhasebeDataSet2";
            this.muhasebeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapkodlariBindingSource1
            // 
            this.hesapkodlariBindingSource1.DataMember = "hesapkodlari";
            this.hesapkodlariBindingSource1.DataSource = this.muhasebeDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapKoduDataGridViewTextBoxColumn,
            this.hesapAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hesapkodlariBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(204, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(473, 298);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hesapKoduDataGridViewTextBoxColumn
            // 
            this.hesapKoduDataGridViewTextBoxColumn.DataPropertyName = "HesapKodu";
            this.hesapKoduDataGridViewTextBoxColumn.HeaderText = "Hesap Kodu";
            this.hesapKoduDataGridViewTextBoxColumn.Name = "hesapKoduDataGridViewTextBoxColumn";
            this.hesapKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hesapAdiDataGridViewTextBoxColumn
            // 
            this.hesapAdiDataGridViewTextBoxColumn.DataPropertyName = "HesapAdi";
            this.hesapAdiDataGridViewTextBoxColumn.HeaderText = "Hesap Adı";
            this.hesapAdiDataGridViewTextBoxColumn.Name = "hesapAdiDataGridViewTextBoxColumn";
            this.hesapAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hesapAdiDataGridViewTextBoxColumn.Width = 350;
            // 
            // hesapkodlariBindingSource2
            // 
            this.hesapkodlariBindingSource2.DataMember = "hesapkodlari";
            this.hesapkodlariBindingSource2.DataSource = this.muhasebeDataSet4;
            // 
            // muhasebeDataSet4
            // 
            this.muhasebeDataSet4.DataSetName = "muhasebeDataSet4";
            this.muhasebeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapkodlariBindingSource
            // 
            this.hesapkodlariBindingSource.DataMember = "hesapkodlari";
            this.hesapkodlariBindingSource.DataSource = this.muhasebeDataSet1;
            // 
            // muhasebeDataSet1
            // 
            this.muhasebeDataSet1.DataSetName = "muhasebeDataSet1";
            this.muhasebeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 318);
            this.tabControl1.TabIndex = 8;
            // 
            // hesapkoduBindingSource
            // 
            this.hesapkoduBindingSource.DataMember = "hesapkodu";
            this.hesapkoduBindingSource.DataSource = this.muhasebeDataSet;
            // 
            // muhasebeDataSet
            // 
            this.muhasebeDataSet.DataSetName = "muhasebeDataSet";
            this.muhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapkodlariTableAdapter
            // 
            this.hesapkodlariTableAdapter.ClearBeforeFill = true;
            // 
            // hesapkodlariTableAdapter2
            // 
            this.hesapkodlariTableAdapter2.ClearBeforeFill = true;
            // 
            // Form56
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(694, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(694, 360);
            this.Name = "Form56";
            this.Text = "Hesap Kodu Arama";
            this.Load += new System.EventHandler(this.Form56_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hesapkoduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private muhasebeDataSet2TableAdapters.hesapkodlariTableAdapter hesapkodlariTableAdapter1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.Label label1;
        private muhasebeDataSetTableAdapters.hesapkoduTableAdapter hesapkoduTableAdapter;
        private muhasebeDataSet2 muhasebeDataSet2;
        private System.Windows.Forms.BindingSource hesapkodlariBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hesapkodlariBindingSource;
        private muhasebeDataSet1 muhasebeDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource hesapkoduBindingSource;
        private muhasebeDataSet muhasebeDataSet;
        private muhasebeDataSet1TableAdapters.hesapkodlariTableAdapter hesapkodlariTableAdapter;
        private muhasebeDataSet4 muhasebeDataSet4;
        private System.Windows.Forms.BindingSource hesapkodlariBindingSource2;
        private muhasebeDataSet4TableAdapters.hesapkodlariTableAdapter hesapkodlariTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
    }
}