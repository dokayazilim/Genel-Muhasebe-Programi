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
    public partial class stokhareket : Form
    {
        public stokhareket()
        {
            InitializeComponent();
        }

        private void stokhareket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarstokDataSet2.stokhareketraporu' table. You can move, or remove it, as needed.
            this.stokhareketraporuTableAdapter.Fill(this.muhasebeortakhesaplarstokDataSet2.stokhareketraporu);

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı.", "Uyarı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            birimi.SelectedIndex = -1;
            evrakno.Clear();
            aciklama.Clear();
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı.", "Uyarı");
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            birimi.SelectedIndex = -1;
            evrakno.Clear();
            aciklama.Clear();
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
