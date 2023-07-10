namespace muhasebe
{
    partial class Form81
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form81));
            this.vergidairesikodlariTableAdapter1 = new muhasebe.mhsbdataDataSet51TableAdapters.vergidairesikodlariTableAdapter();
            this.arama = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dairekodu = new System.Windows.Forms.RadioButton();
            this.il = new System.Windows.Forms.RadioButton();
            this.adi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vergidairesikodlariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbdataDataSet51 = new muhasebe.mhsbdataDataSet51();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mhsbdataDataSet50 = new muhasebe.mhsbdataDataSet50();
            this.vergidairesikodlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vergidairesikodlariTableAdapter = new muhasebe.mhsbdataDataSet50TableAdapters.vergidairesikodlariTableAdapter();
            this.mhsbdataDataSet52 = new muhasebe.mhsbdataDataSet52();
            this.vergidairesikodlariBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vergidairesikodlariTableAdapter2 = new muhasebe.mhsbdataDataSet52TableAdapters.vergidairesikodlariTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // vergidairesikodlariTableAdapter1
            // 
            this.vergidairesikodlariTableAdapter1.ClearBeforeFill = true;
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(46, 18);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(143, 20);
            this.arama.TabIndex = 1;
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
            this.tabPage1.Size = new System.Drawing.Size(192, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(9, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(9, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(9, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dairekodu);
            this.groupBox1.Controls.Add(this.il);
            this.groupBox1.Controls.Add(this.adi);
            this.groupBox1.Location = new System.Drawing.Point(9, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme Seçeneği";
            // 
            // dairekodu
            // 
            this.dairekodu.AutoSize = true;
            this.dairekodu.Location = new System.Drawing.Point(16, 65);
            this.dairekodu.Name = "dairekodu";
            this.dairekodu.Size = new System.Drawing.Size(78, 17);
            this.dairekodu.TabIndex = 2;
            this.dairekodu.TabStop = true;
            this.dairekodu.Text = "Daire Kodu";
            this.dairekodu.UseVisualStyleBackColor = true;
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Location = new System.Drawing.Point(16, 42);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(30, 17);
            this.il.TabIndex = 1;
            this.il.TabStop = true;
            this.il.Text = "İl";
            this.il.UseVisualStyleBackColor = true;
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(16, 19);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(40, 17);
            this.adi.TabIndex = 1;
            this.adi.TabStop = true;
            this.adi.Text = "Adı";
            this.adi.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 307);
            this.tabControl1.TabIndex = 4;
            // 
            // vergidairesikodlariBindingSource1
            // 
            this.vergidairesikodlariBindingSource1.DataMember = "vergidairesikodlari";
            this.vergidairesikodlariBindingSource1.DataSource = this.mhsbdataDataSet51;
            // 
            // mhsbdataDataSet51
            // 
            this.mhsbdataDataSet51.DataSetName = "mhsbdataDataSet51";
            this.mhsbdataDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.ılDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vergidairesikodlariBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(208, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(433, 287);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mhsbdataDataSet50
            // 
            this.mhsbdataDataSet50.DataSetName = "mhsbdataDataSet50";
            this.mhsbdataDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vergidairesikodlariBindingSource
            // 
            this.vergidairesikodlariBindingSource.DataMember = "vergidairesikodlari";
            this.vergidairesikodlariBindingSource.DataSource = this.mhsbdataDataSet50;
            // 
            // vergidairesikodlariTableAdapter
            // 
            this.vergidairesikodlariTableAdapter.ClearBeforeFill = true;
            // 
            // mhsbdataDataSet52
            // 
            this.mhsbdataDataSet52.DataSetName = "mhsbdataDataSet52";
            this.mhsbdataDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vergidairesikodlariBindingSource2
            // 
            this.vergidairesikodlariBindingSource2.DataMember = "vergidairesikodlari";
            this.vergidairesikodlariBindingSource2.DataSource = this.mhsbdataDataSet52;
            // 
            // vergidairesikodlariTableAdapter2
            // 
            this.vergidairesikodlariTableAdapter2.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Vergi Dairesi Adı";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 210;
            // 
            // ılDataGridViewTextBoxColumn
            // 
            this.ılDataGridViewTextBoxColumn.DataPropertyName = "Il";
            this.ılDataGridViewTextBoxColumn.HeaderText = "İl";
            this.ılDataGridViewTextBoxColumn.Name = "ılDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Daire Kodu";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // Form81
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 309);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 347);
            this.Name = "Form81";
            this.Text = "Vergi Dairesi";
            this.Load += new System.EventHandler(this.Form81_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbdataDataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergidairesikodlariBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private mhsbdataDataSet51TableAdapters.vergidairesikodlariTableAdapter vergidairesikodlariTableAdapter1;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dairekodu;
        private System.Windows.Forms.RadioButton il;
        private System.Windows.Forms.RadioButton adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource vergidairesikodlariBindingSource1;
        private mhsbdataDataSet51 mhsbdataDataSet51;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mhsbdataDataSet50 mhsbdataDataSet50;
        private System.Windows.Forms.BindingSource vergidairesikodlariBindingSource;
        private mhsbdataDataSet50TableAdapters.vergidairesikodlariTableAdapter vergidairesikodlariTableAdapter;
        private mhsbdataDataSet52 mhsbdataDataSet52;
        private System.Windows.Forms.BindingSource vergidairesikodlariBindingSource2;
        private mhsbdataDataSet52TableAdapters.vergidairesikodlariTableAdapter vergidairesikodlariTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
    }
}