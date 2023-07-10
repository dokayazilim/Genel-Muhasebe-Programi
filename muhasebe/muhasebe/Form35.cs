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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form35_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet12.oncekidonemsatislarinmaliyeti' table. You can move, or remove it, as needed.
            this.oncekidonemsatislarinmaliyetiTableAdapter.Fill(this.mhsbortakDataSet12.oncekidonemsatislarinmaliyeti);
            // TODO: This line of code loads data into the 'mhsbortakDataSet11.oncekidonemgelirtablosu' table. You can move, or remove it, as needed.
            this.oncekidonemgelirtablosuTableAdapter.Fill(this.mhsbortakDataSet11.oncekidonemgelirtablosu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydedilmedi. Lütfen öncelikle tabloya veri aktarıldığından emin olunuz!","Önceki Dönem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla aktarıldı.","Aktarma İşlemi");
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydedilmedi. Lütfen öncelikle tabloya veri aktarıldığından emin olunuz!", "Önceki Dönem");
        }

        private void öncekiDönemdenAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla aktarıldı.", "Aktarma İşlemi");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
