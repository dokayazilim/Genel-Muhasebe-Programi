﻿namespace muhasebe
{
    partial class Form32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form32));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.devredenkdvhesapkodu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.odenecekhesapkodu = new System.Windows.Forms.TextBox();
            this.tahakkukayi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.devredenkdvhesapkodu);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.odenecekhesapkodu);
            this.groupBox1.Controls.Add(this.tahakkukayi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahakkuk Hesapla";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageKey = "ayarlibul.png";
            this.button3.Location = new System.Drawing.Point(314, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // devredenkdvhesapkodu
            // 
            this.devredenkdvhesapkodu.Location = new System.Drawing.Point(166, 86);
            this.devredenkdvhesapkodu.Name = "devredenkdvhesapkodu";
            this.devredenkdvhesapkodu.Size = new System.Drawing.Size(147, 20);
            this.devredenkdvhesapkodu.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageKey = "ayarlibul.png";
            this.button2.Location = new System.Drawing.Point(314, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // odenecekhesapkodu
            // 
            this.odenecekhesapkodu.Location = new System.Drawing.Point(166, 54);
            this.odenecekhesapkodu.Name = "odenecekhesapkodu";
            this.odenecekhesapkodu.Size = new System.Drawing.Size(147, 20);
            this.odenecekhesapkodu.TabIndex = 2;
            // 
            // tahakkukayi
            // 
            this.tahakkukayi.FormattingEnabled = true;
            this.tahakkukayi.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.tahakkukayi.Location = new System.Drawing.Point(166, 22);
            this.tahakkukayi.Name = "tahakkukayi";
            this.tahakkukayi.Size = new System.Drawing.Size(176, 21);
            this.tahakkukayi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Devreden KDV Hesap Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödenecek Hesap Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tahakkuk Ayı :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(3, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 169);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(369, 207);
            this.Name = "Form32";
            this.Text = "KDV Tahakkuku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tahakkukayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox odenecekhesapkodu;
        public System.Windows.Forms.TextBox devredenkdvhesapkodu;
    }
}