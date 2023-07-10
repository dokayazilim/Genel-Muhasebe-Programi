namespace muhasebe
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.belgeturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeturuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muhasebeortakhesaplarbelgeturleriDataSet1 = new muhasebe.muhasebeortakhesaplarbelgeturleriDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.belgeturuTableAdapter = new muhasebe.muhasebeortakhesaplarbelgeturleriDataSet1TableAdapters.belgeturuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeturuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeortakhesaplarbelgeturleriDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.belgeturuDataGridViewTextBoxColumn,
            this.belgeturDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.belgeturuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(319, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // belgeturuDataGridViewTextBoxColumn
            // 
            this.belgeturuDataGridViewTextBoxColumn.DataPropertyName = "belgeturu";
            this.belgeturuDataGridViewTextBoxColumn.HeaderText = "Belge Türü";
            this.belgeturuDataGridViewTextBoxColumn.Name = "belgeturuDataGridViewTextBoxColumn";
            this.belgeturuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // belgeturDataGridViewTextBoxColumn
            // 
            this.belgeturDataGridViewTextBoxColumn.DataPropertyName = "belgetur";
            this.belgeturDataGridViewTextBoxColumn.HeaderText = "Belge Türü";
            this.belgeturDataGridViewTextBoxColumn.Name = "belgeturDataGridViewTextBoxColumn";
            this.belgeturDataGridViewTextBoxColumn.ReadOnly = true;
            this.belgeturDataGridViewTextBoxColumn.Width = 195;
            // 
            // belgeturuBindingSource
            // 
            this.belgeturuBindingSource.DataMember = "belgeturu";
            this.belgeturuBindingSource.DataSource = this.muhasebeortakhesaplarbelgeturleriDataSet1;
            // 
            // muhasebeortakhesaplarbelgeturleriDataSet1
            // 
            this.muhasebeortakhesaplarbelgeturleriDataSet1.DataSetName = "muhasebeortakhesaplarbelgeturleriDataSet1";
            this.muhasebeortakhesaplarbelgeturleriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(247, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // belgeturuTableAdapter
            // 
            this.belgeturuTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 296);
            this.Name = "Form4";
            this.Text = "Belge Türleri";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeturuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeortakhesaplarbelgeturleriDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private muhasebeortakhesaplarbelgeturleriDataSet1 muhasebeortakhesaplarbelgeturleriDataSet1;
        private System.Windows.Forms.BindingSource belgeturuBindingSource;
        private muhasebeortakhesaplarbelgeturleriDataSet1TableAdapters.belgeturuTableAdapter belgeturuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeturDataGridViewTextBoxColumn;
    }
}