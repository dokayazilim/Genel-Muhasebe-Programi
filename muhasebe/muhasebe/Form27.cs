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
    public partial class Form27 : Form
    {
        public Form27()
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

        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet4.stokenvanteri' table. You can move, or remove it, as needed.
            this.stokenvanteriTableAdapter.Fill(this.mhsbdigerhesaplarDataSet4.stokenvanteri);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            grubu.Clear();
            birimi.SelectedIndex = -1;
            fifo.Checked = false;
            lifo.Checked = false;
            ortalamaartis.Checked = false;
            ortalamaagirlikliartis.Checked = false;
            enucuzalis.Checked = false;
            enpahalialis.Checked = false;
            
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir stok envanteri bulunamadı!","Stok Envanteri");
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Herhangi bir stok envanteri bulunamadı!", "Stok Envanteri");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
