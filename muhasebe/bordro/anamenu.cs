using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bordro
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void kayıtlıPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitlipersonel a = new kayitlipersonel();
            a.Show();
        }

        private void kDVBeyanname1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kdvbeyannamebir a = new kdvbeyannamebir();
            a.Show();
        }

        private void kDVBeyanname2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kdvbeyannamesiiki a = new kdvbeyannamesiiki();
            a.Show();
        }

        private void formBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formba a = new formba();
            a.Show();
        }

        private void formBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formbs a = new formbs();
            a.Show();
        }

        private void beyannamelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muhtasarBeyannameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muhtasarbeyanname a = new muhtasarbeyanname();
            a.Show();
        }

        private void gelirVergisiMükellefleriİçinGeçiciBeyannameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gelirvergisimukellefbeyannamesi a = new gelirvergisimukellefbeyannamesi();
            a.Show();
        }

        private void damgaVergisiBeyannamesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            damgavergisibeyannamesi a = new damgavergisibeyannamesi();
            a.Show();
        }

        private void yıllıkGelirVergisiBeyannamesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yillikgelirvergisibeyannamesi a = new yillikgelirvergisibeyannamesi();
            a.Show();
        }

        private void kesinMizanBildirimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kesinmizanbildirimi a = new kesinmizanbildirimi();
            a.Show();
        }
    }
}
