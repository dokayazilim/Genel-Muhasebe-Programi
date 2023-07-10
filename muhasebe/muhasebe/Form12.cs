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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdatayardimciortakDataSet3.yedibyansitilacakhedefhesaplarsabitler' table. You can move, or remove it, as needed.
            this.yedibyansitilacakhedefhesaplarsabitlerTableAdapter.Fill(this.mhsbdatayardimciortakDataSet3.yedibyansitilacakhedefhesaplarsabitler);
            // TODO: This line of code loads data into the 'mhsbdatayardimciortakDataSet2.yedibyansitilacakhedefhesaplar' table. You can move, or remove it, as needed.
            this.yedibyansitilacakhedefhesaplarTableAdapter.Fill(this.mhsbdatayardimciortakDataSet2.yedibyansitilacakhedefhesaplar);
            // TODO: This line of code loads data into the 'mhsbdatayardimciortakDataSet1.yedibyansitilacakhesaplar' table. You can move, or remove it, as needed.
            this.yedibyansitilacakhesaplarTableAdapter.Fill(this.mhsbdatayardimciortakDataSet1.yedibyansitilacakhesaplar);
            // TODO: This line of code loads data into the 'mhsbdataDataSet37.yansitilanhesaplaryedib' table. You can move, or remove it, as needed.
            this.yansitilanhesaplaryedibTableAdapter.Fill(this.mhsbdataDataSet37.yansitilanhesaplaryedib);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.","Hesapların Yansıtılması");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Yansıtılacak hedef hesap bulunamadı.","Hesapların Yansıtılması");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel tablo başarıyla aktarıldı.", "Hesapların Yansıtılması");
        }

        private void yansıtmaFişiniOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void sabitlerİçinVarsayılanTabloyuAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel tablo başarıyla aktarıldı.", "Hesapların Yansıtılması");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
