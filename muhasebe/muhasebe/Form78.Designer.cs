namespace muhasebe
{
    partial class Form78
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form78));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kod = new System.Windows.Forms.RadioButton();
            this.oran = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mhsbortakhesaplartevfikatoraniDataSet1 = new muhasebe.mhsbortakhesaplartevfikatoraniDataSet1();
            this.tevfikatoraniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tevfikatoraniTableAdapter = new muhasebe.mhsbortakhesaplartevfikatoraniDataSet1TableAdapters.tevfikatoraniTableAdapter();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakhesaplartevfikatoraniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevfikatoraniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.arama);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama :";
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(55, 18);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(131, 20);
            this.arama.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.oranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tevfikatoraniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(209, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(460, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oran);
            this.groupBox1.Controls.Add(this.kod);
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Tercihleri";
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.Location = new System.Drawing.Point(6, 19);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(44, 17);
            this.kod.TabIndex = 2;
            this.kod.TabStop = true;
            this.kod.Text = "Kod";
            this.kod.UseVisualStyleBackColor = true;
            // 
            // oran
            // 
            this.oran.AutoSize = true;
            this.oran.Location = new System.Drawing.Point(6, 42);
            this.oran.Name = "oran";
            this.oran.Size = new System.Drawing.Size(48, 17);
            this.oran.TabIndex = 2;
            this.oran.TabStop = true;
            this.oran.Text = "Oran";
            this.oran.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(9, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yeni Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(9, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mhsbortakhesaplartevfikatoraniDataSet1
            // 
            this.mhsbortakhesaplartevfikatoraniDataSet1.DataSetName = "mhsbortakhesaplartevfikatoraniDataSet1";
            this.mhsbortakhesaplartevfikatoraniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tevfikatoraniBindingSource
            // 
            this.tevfikatoraniBindingSource.DataMember = "tevfikatorani";
            this.tevfikatoraniBindingSource.DataSource = this.mhsbortakhesaplartevfikatoraniDataSet1;
            // 
            // tevfikatoraniTableAdapter
            // 
            this.tevfikatoraniTableAdapter.ClearBeforeFill = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.Width = 50;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.Width = 315;
            // 
            // oranDataGridViewTextBoxColumn
            // 
            this.oranDataGridViewTextBoxColumn.DataPropertyName = "oran";
            this.oranDataGridViewTextBoxColumn.HeaderText = "Oran";
            this.oranDataGridViewTextBoxColumn.Name = "oranDataGridViewTextBoxColumn";
            this.oranDataGridViewTextBoxColumn.Width = 75;
            // 
            // Form78
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 356);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 356);
            this.Name = "Form78";
            this.Text = "Tevfikat Oranı";
            this.Load += new System.EventHandler(this.Form78_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakhesaplartevfikatoraniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tevfikatoraniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton kod;
        private System.Windows.Forms.RadioButton oran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private mhsbortakhesaplartevfikatoraniDataSet1 mhsbortakhesaplartevfikatoraniDataSet1;
        private System.Windows.Forms.BindingSource tevfikatoraniBindingSource;
        private mhsbortakhesaplartevfikatoraniDataSet1TableAdapters.tevfikatoraniTableAdapter tevfikatoraniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oranDataGridViewTextBoxColumn;
    }
}