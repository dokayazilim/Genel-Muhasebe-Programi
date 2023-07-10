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
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void versiyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vsb a = new vsb();
            a.Show();
        }

        private void yeniFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
        }

        private void kayıtlıFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitlifirmayeni a = new kayitlifirmayeni();
            a.Show();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dokasoft.com");
        }

        private void yeniDefterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen hem 'Gelir' Defteri, hem 'Gider' Defteri için verilecek olan 'Belge No' larının 'aynı' olmamasına dikkat ediniz.","Uyarı");
            Form1 a = new Form1();
            a.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carihesap a = new carihesap();
            a.Show();
        }

        private void cariMizanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carimizan a = new carimizan();
            a.Show();
        }

        private void yetkiliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void stokTanımlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stoktanimlari a = new stoktanimlari();
            a.Show();
        }

        private void stokEnvanteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokenvanteri a = new stokenvanteri();
            a.Show();
        }

        private void hareketRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokhareket a = new stokhareket();
            a.Show();
        }

        private void işletmeDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }
    }
}
