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
    public partial class Form18 : Form
    {
        public Form18()
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

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aysecimi.SelectedIndex = -1;
            hesapkodu.Clear();
            hesapkodu2.Clear();
            detaygoster.SelectedIndex = -1;
            dokumbicimi.SelectedIndex = -1;
            bakiyedurumu.SelectedIndex = -1;
            kapanis.Checked = false;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet4.kesinmizan' table. You can move, or remove it, as needed.
            this.kesinmizanTableAdapter.Fill(this.mhsbortakDataSet4.kesinmizan);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir kayıt bulunamadı.", "Kesin Mizan");
        }

        private void kaoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form100 a = new Form100();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form101 a = new Form101();
            a.Show();
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir kayıt bulunamadı.", "Kesin Mizan");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
