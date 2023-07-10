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
    public partial class carimizan : Form
    {
        public carimizan()
        {
            InitializeComponent();
        }

        private void carimizan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarcariDataSet2.carimizan' table. You can move, or remove it, as needed.
            this.carimizanTableAdapter.Fill(this.muhasebeortakhesaplarcariDataSet2.carimizan);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı!", "Cari Mizan");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bslngchesapkodu.Clear();
            bitishesapkodu.Clear();
            bslngctckimlik.Clear();
            bitistckimlik.Clear();
            dokumbicimi.SelectedIndex = -1;
            bakiyesecimi.SelectedIndex = -1;
            hesapdetaygoster.Checked = false;
            hesapdetaygosterme.Checked = false;
            bakiyevermeyenlerdahil.Checked = false;
            bakiyevermeyenlerharic.Checked = false;
            acilisrakamlaridahil.Checked = false;
            acilisrakamlariharic.Checked = false;
            kapanisrakamlaridahil.Checked = false;
            kapanisrakamlariharic.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı!", "Cari Mizan");
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bslngchesapkodu.Clear();
            bitishesapkodu.Clear();
            bslngctckimlik.Clear();
            bitistckimlik.Clear();
            dokumbicimi.SelectedIndex = -1;
            bakiyesecimi.SelectedIndex = -1;
            hesapdetaygoster.Checked = false;
            hesapdetaygosterme.Checked = false;
            bakiyevermeyenlerdahil.Checked = false;
            bakiyevermeyenlerharic.Checked = false;
            acilisrakamlaridahil.Checked = false;
            acilisrakamlariharic.Checked = false;
            kapanisrakamlaridahil.Checked = false;
            kapanisrakamlariharic.Checked = false;
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

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("isletmedefteriyardim.pdf");
        }
    }
}
