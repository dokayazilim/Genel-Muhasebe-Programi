namespace muhasebe
{
    partial class Form70
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form70));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.koduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergidairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mhsbortakhesaplardigerDataSet1 = new muhasebe.mhsbortakhesaplardigerDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.kayitlarTableAdapter = new muhasebe.mhsbortakhesaplardigerDataSet1TableAdapters.kayitlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakhesaplardigerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.koduDataGridViewTextBoxColumn,
            this.donemiDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.vergidairesiDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.subekoduDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(701, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // koduDataGridViewTextBoxColumn
            // 
            this.koduDataGridViewTextBoxColumn.DataPropertyName = "kodu";
            this.koduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            this.koduDataGridViewTextBoxColumn.Name = "koduDataGridViewTextBoxColumn";
            this.koduDataGridViewTextBoxColumn.ReadOnly = true;
            this.koduDataGridViewTextBoxColumn.Width = 110;
            // 
            // donemiDataGridViewTextBoxColumn
            // 
            this.donemiDataGridViewTextBoxColumn.DataPropertyName = "donemi";
            this.donemiDataGridViewTextBoxColumn.HeaderText = "Dönemi";
            this.donemiDataGridViewTextBoxColumn.Name = "donemiDataGridViewTextBoxColumn";
            this.donemiDataGridViewTextBoxColumn.ReadOnly = true;
            this.donemiDataGridViewTextBoxColumn.Width = 110;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Kayıt Tarihi";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 110;
            // 
            // vergidairesiDataGridViewTextBoxColumn
            // 
            this.vergidairesiDataGridViewTextBoxColumn.DataPropertyName = "vergidairesi";
            this.vergidairesiDataGridViewTextBoxColumn.HeaderText = "Vergi Dairesi";
            this.vergidairesiDataGridViewTextBoxColumn.Name = "vergidairesiDataGridViewTextBoxColumn";
            this.vergidairesiDataGridViewTextBoxColumn.ReadOnly = true;
            this.vergidairesiDataGridViewTextBoxColumn.Width = 110;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "Adı - Soyadı";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.adsoyadDataGridViewTextBoxColumn.Width = 110;
            // 
            // subekoduDataGridViewTextBoxColumn
            // 
            this.subekoduDataGridViewTextBoxColumn.DataPropertyName = "subekodu";
            this.subekoduDataGridViewTextBoxColumn.HeaderText = "Şube Kodu";
            this.subekoduDataGridViewTextBoxColumn.Name = "subekoduDataGridViewTextBoxColumn";
            this.subekoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.subekoduDataGridViewTextBoxColumn.Width = 110;
            // 
            // kayitlarBindingSource
            // 
            this.kayitlarBindingSource.DataMember = "kayitlar";
            this.kayitlarBindingSource.DataSource = this.mhsbortakhesaplardigerDataSet1;
            // 
            // mhsbortakhesaplardigerDataSet1
            // 
            this.mhsbortakhesaplardigerDataSet1.DataSetName = "mhsbortakhesaplardigerDataSet1";
            this.mhsbortakhesaplardigerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(596, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitlarTableAdapter
            // 
            this.kayitlarTableAdapter.ClearBeforeFill = true;
            // 
            // Form70
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(699, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(699, 360);
            this.Name = "Form70";
            this.Text = "Kayıtlı Beyannameler";
            this.Load += new System.EventHandler(this.Form70_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mhsbortakhesaplardigerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private mhsbortakhesaplardigerDataSet1 mhsbortakhesaplardigerDataSet1;
        private System.Windows.Forms.BindingSource kayitlarBindingSource;
        private mhsbortakhesaplardigerDataSet1TableAdapters.kayitlarTableAdapter kayitlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn koduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergidairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subekoduDataGridViewTextBoxColumn;
    }
}