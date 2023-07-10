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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakDataSet19.yediayansitilacakhedefhesaplarsabitler' table. You can move, or remove it, as needed.
            this.yediayansitilacakhedefhesaplarsabitlerTableAdapter.Fill(this.mhsbortakDataSet19.yediayansitilacakhedefhesaplarsabitler);
            // TODO: This line of code loads data into the 'mhsbortakDataSet18.yediayansitilacakhedefhesaplar' table. You can move, or remove it, as needed.
            this.yediayansitilacakhedefhesaplarTableAdapter.Fill(this.mhsbortakDataSet18.yediayansitilacakhedefhesaplar);
            // TODO: This line of code loads data into the 'mhsbortakDataSet17.yediayansitmayakonuhesaplar' table. You can move, or remove it, as needed.
            this.yediayansitmayakonuhesaplarTableAdapter.Fill(this.mhsbortakDataSet17.yediayansitmayakonuhesaplar);
            // TODO: This line of code loads data into the 'mhsbdataDataSet36.yansitilanhesaplaryedia' table. You can move, or remove it, as needed.
            this.yansitilanhesaplaryediaTableAdapter.Fill(this.mhsbdataDataSet36.yansitilanhesaplaryedia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Yansıtılacak hedef hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel tablo başarıyla aktarıldı.", "Hesapların Yansıtılması");
        }

        private void hesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void yansıtmaFişiniOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yansıtılacak hesap bulunamadı.", "Hesapların Yansıtılması");
        }

        private void sabitlerİçinVarsayılanTabloyuAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel tablo başarıyla aktarıldı.", "Hesapların Yansıtılması");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
