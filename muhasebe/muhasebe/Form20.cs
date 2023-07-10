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
    public partial class Form20 : Form
    {
        public Form20()
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hesapkodu.Clear();
            hesapkodu2.Clear();
            fisno.Clear();
            evrakno.Clear();
            fistipi.SelectedIndex = -1;
            rapor.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıtlı rapor bulunamadı.","Yardımcı Defter");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form94 a = new Form94();
            a.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form95 a = new Form95();
            a.Show();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void xMLEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde XML olarak aktaramazsınız!", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
