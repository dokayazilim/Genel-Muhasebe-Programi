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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void temizleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            hesapkodu2.Clear();
            fisno.Clear();
            evrakno.Clear();
            fistipi.SelectedIndex = -1;
            rapor.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıtlı rapor bulunamadı.", "Kebir Defteri");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            hesapkodu2.Clear();
            fisno.Clear();
            evrakno.Clear();
            fistipi.SelectedIndex = -1;
            rapor.Clear();
        }

        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form96 a = new Form96();
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form97 a = new Form97();
            a.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void xMLEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıtlı rapor bulunamadı.", "Kebir Defteri");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
