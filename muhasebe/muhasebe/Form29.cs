using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void temizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            fifo.Checked = false;
            lifo.Checked = false;
            ortalamaalis.Checked = false;
            ortalamaagirliklialis.Checked = false;
            enucuzalis.Checked = false;
            enpahalialis.Checked = false;
            fisaciklama.Clear();
        
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet7.maliyethesaplamalari' table. You can move, or remove it, as needed.
            this.maliyethesaplamalariTableAdapter.Fill(this.mhsbortakDataSet7.maliyethesaplamalari);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir hesaplama bulunamadı!","Maliyet Hesaplamaları");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form93 a = new Form93();
            a.Show();
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir hesaplama bulunamadı!", "Maliyet Hesaplamaları");
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maliyet Fişi oluşturulamadı.", "Maliyet Hesaplamaları");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maliyet Fişi oluşturulamadı.","Maliyet Hesaplamaları");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
