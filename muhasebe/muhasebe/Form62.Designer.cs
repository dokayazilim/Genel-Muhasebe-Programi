namespace muhasebe
{
    partial class Form62
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form62));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firmakodu = new System.Windows.Forms.TextBox();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.adi = new System.Windows.Forms.TextBox();
            this.vergino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kimlikno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtİşlemleriToolStripMenuItem
            // 
            this.kayıtİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.yeniKayıtToolStripMenuItem,
            this.bulToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.kayıtİşlemleriToolStripMenuItem.Name = "kayıtİşlemleriToolStripMenuItem";
            this.kayıtİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.kayıtİşlemleriToolStripMenuItem.Text = "Kayıt İşlemleri";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            this.bulToolStripMenuItem.Click += new System.EventHandler(this.bulToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı/Ünvanı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vergi Numarası :";
            // 
            // firmakodu
            // 
            this.firmakodu.Location = new System.Drawing.Point(102, 30);
            this.firmakodu.Name = "firmakodu";
            this.firmakodu.Size = new System.Drawing.Size(181, 20);
            this.firmakodu.TabIndex = 1;
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(102, 52);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(181, 20);
            this.soyadi.TabIndex = 2;
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(102, 74);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(181, 20);
            this.adi.TabIndex = 3;
            // 
            // vergino
            // 
            this.vergino.Location = new System.Drawing.Point(102, 96);
            this.vergino.MaxLength = 11;
            this.vergino.Name = "vergino";
            this.vergino.Size = new System.Drawing.Size(181, 20);
            this.vergino.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // kimlikno
            // 
            this.kimlikno.Location = new System.Drawing.Point(102, 119);
            this.kimlikno.MaxLength = 11;
            this.kimlikno.Name = "kimlikno";
            this.kimlikno.Size = new System.Drawing.Size(181, 20);
            this.kimlikno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres :";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(102, 165);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(181, 58);
            this.adres.TabIndex = 7;
            this.adres.Text = "";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(102, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(208, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yeni Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dönem :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2013 - 2014"});
            this.comboBox1.Location = new System.Drawing.Point(102, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Form62
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 273);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.kimlikno);
            this.Controls.Add(this.vergino);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.firmakodu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(311, 311);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(311, 311);
            this.Name = "Form62";
            this.Text = "Firma Kayıt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox firmakodu;
        public System.Windows.Forms.TextBox soyadi;
        public System.Windows.Forms.TextBox adi;
        public System.Windows.Forms.TextBox vergino;
        public System.Windows.Forms.TextBox kimlikno;
        public System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}