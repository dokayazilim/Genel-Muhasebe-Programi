using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class kurumlarvergisibeyannamesi : Form
    {
        public kurumlarvergisibeyannamesi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.", "Uyarı");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void xMLEOlarakKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname kaydı yapılamaz veya gönderilemez.", "Uyarı");
        }

        private void kapartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
