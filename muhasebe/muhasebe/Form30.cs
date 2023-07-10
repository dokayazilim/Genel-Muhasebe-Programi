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
    public partial class Form30 : Form
    {
        public Form30()
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

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılan hesap bulunamadı. Lütfen öncelikle hesabın yansıtılmış olduğundan emin olunuz!","7/A Hesapların Kapatılması");
        }

        private void hesaplaVeFişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılan hesap bulunamadı. Lütfen öncelikle hesabın yansıtılmış olduğundan emin olunuz!", "7/A Hesapların Kapatılması");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
