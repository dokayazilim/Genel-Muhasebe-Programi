namespace muhasebe
{
    partial class Form60
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form60));
            this.hesapkodlariTableAdapter = new muhasebe.muhasebeDataSet1TableAdapters.hesapkodlariTableAdapter();
            this.muhasebeDataSet = new muhasebe.muhasebeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapad = new System.Windows.Forms.RadioButton();
            this.hesapkod = new System.Windows.Forms.RadioButton();
            this.hesapkoduBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet1 = new muhasebe.muhasebeDataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.arama = new System.Windows.Forms.TextBox();
            this.hesapkodlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hesapKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapkodlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeDataSet2 = new muhasebe.muhasebeDataSet2();
            this.hesapkoduTableAdapter = new muhasebe.muhasebeDataSetTableAdapters.hesapkoduTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hesapkodlariTableAdapter1 = new muhasebe.muhasebeDataSet2TableAdapters.hesapkodlariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkoduBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hesapkodlariTableAdapter
            // 
            this.hesapkodlariTableAdapter.ClearBeforeFill = true;
            // 
            // muhasebeDataSet
            // 
            this.muhasebeDataSet.DataSetName = "muhasebeDataSet";
            this.muhasebeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hesapad);
            this.groupBox1.Controls.Add(this.hesapkod);
            this.groupBox1.Location = new System.Drawing.Point(7, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriteri";
            // 
            // hesapad
            // 
            this.hesapad.AutoSize = true;
            this.hesapad.Location = new System.Drawing.Point(9, 54);
            this.hesapad.Name = "hesapad";
            this.hesapad.Size = new System.Drawing.Size(74, 17);
            this.hesapad.TabIndex = 3;
            this.hesapad.TabStop = true;
            this.hesapad.Text = "Hesap Adı";
            this.hesapad.UseVisualStyleBackColor = true;
            // 
            // hesapkod
            // 
            this.hesapkod.AutoSize = true;
            this.hesapkod.Location = new System.Drawing.Point(9, 19);
            this.hesapkod.Name = "hesapkod";
            this.hesapkod.Size = new System.Drawing.Size(84, 17);
            this.hesapkod.TabIndex = 2;
            this.hesapkod.TabStop = true;
            this.hesapkod.Text = "Hesap Kodu";
            this.hesapkod.UseVisualStyleBackColor = true;
            // 
            // hesapkoduBindingSource
            // 
            this.hesapkoduBindingSource.DataMember = "hesapkodu";
            this.hesapkoduBindingSource.DataSource = this.muhasebeDataSet;
            // 
            // muhasebeDataSet1
            // 
            this.muhasebeDataSet1.DataSetName = "muhasebeDataSet1";
            this.muhasebeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(17, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Vazgeç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(102, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(17, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(77, 17);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(100, 20);
            this.arama.TabIndex = 1;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            // 
            // hesapkodlariBindingSource
            // 
            this.hesapkodlariBindingSource.DataMember = "hesapkodlari";
            this.hesapkodlariBindingSource.DataSource = this.muhasebeDataSet1;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapKoduDataGridViewTextBoxColumn,
            this.hesapAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hesapkodlariBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(204, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(473, 298);
            this.dataGridView1.TabIndex = 7;
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
            this.hesapAdiDataGridViewTextBoxColumn.Width = 351;
            // 
            // hesapkodlariBindingSource1
            // 
            this.hesapkodlariBindingSource1.DataMember = "hesapkodlari";
            this.hesapkodlariBindingSource1.DataSource = this.muhasebeDataSet2;
            // 
            // muhasebeDataSet2
            // 
            this.muhasebeDataSet2.DataSetName = "muhasebeDataSet2";
            this.muhasebeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapkoduTableAdapter
            // 
            this.hesapkoduTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 318);
            this.tabControl1.TabIndex = 6;
            // 
            // hesapkodlariTableAdapter1
            // 
            this.hesapkodlariTableAdapter1.ClearBeforeFill = true;
            // 
            // Form60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 322);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(694, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(694, 360);
            this.Name = "Form60";
            this.Text = "Hesap Kodu Arama";
            this.Load += new System.EventHandler(this.Form60_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkoduBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapkodlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private muhasebeDataSet1TableAdapters.hesapkodlariTableAdapter hesapkodlariTableAdapter;
        private muhasebeDataSet muhasebeDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton hesapad;
        private System.Windows.Forms.RadioButton hesapkod;
        private System.Windows.Forms.BindingSource hesapkoduBindingSource;
        private muhasebeDataSet1 muhasebeDataSet1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.BindingSource hesapkodlariBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private muhasebeDataSetTableAdapters.hesapkoduTableAdapter hesapkoduTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private muhasebeDataSet2 muhasebeDataSet2;
        private System.Windows.Forms.BindingSource hesapkodlariBindingSource1;
        private muhasebeDataSet2TableAdapters.hesapkodlariTableAdapter hesapkodlariTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapAdiDataGridViewTextBoxColumn;
    }
}