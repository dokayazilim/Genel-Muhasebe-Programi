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
    public partial class Form34 : Form
    {
        public Form34()
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

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fisaciklama.Clear();
            gelirhesabi.Clear();
            giderhesabi.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet10.karzararhesaplamalarigiderhesaplari' table. You can move, or remove it, as needed.
            this.karzararhesaplamalarigiderhesaplariTableAdapter.Fill(this.mhsbortakDataSet10.karzararhesaplamalarigiderhesaplari);
            // TODO: This line of code loads data into the 'mhsbortakDataSet9.karzararhesaplamalarigelirhesaplari' table. You can move, or remove it, as needed.
            this.karzararhesaplamalarigelirhesaplariTableAdapter.Fill(this.mhsbortakDataSet9.karzararhesaplamalarigelirhesaplari);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kar/Zarar hesaplaması tamamlanamadı. Dönem bulunamadı!","Kar/Zarar Hesaplamaları");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kar/Zarar hesaplaması bulunamadığından fiş oluşturulamadı.","Kar/Zarar Hesaplamaları");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kar/Zarar hesaplaması tamamlanamadı. Dönem bulunamadı!", "Kar/Zarar Hesaplamaları");
        }

        private void karZararFişiniOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kar/Zarar hesaplaması bulunamadığından fiş oluşturulamadı.", "Kar/Zarar Hesaplamaları");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
