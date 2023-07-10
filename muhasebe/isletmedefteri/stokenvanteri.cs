using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace isletmedefteri
{
    public partial class stokenvanteri : Form
    {
        public stokenvanteri()
        {
            InitializeComponent();
        }

        private void stokenvanteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarstokDataSet1.stokenvanteri' table. You can move, or remove it, as needed.
            this.stokenvanteriTableAdapter.Fill(this.muhasebeortakhesaplarstokDataSet1.stokenvanteri);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi yapılmamaktadır.", "Deneme Sürümü");
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            grubu.Clear();
            birimi.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı.","Uyarı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            grubu.Clear();
            birimi.SelectedIndex = -1;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }
    }
}
