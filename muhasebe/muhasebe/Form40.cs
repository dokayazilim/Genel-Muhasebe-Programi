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
    public partial class Form40 : Form
    {
        public Form40()
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

        private void button2_Click(object sender, EventArgs e)
        {
            unvani.Clear();
            yetkilisi.Clear();
            ili.Clear();
            ilcesi.Clear();
            mukellefler.SelectedIndex = -1;
            ucretaciklamasi.Clear();
            makbuzno.Clear();
            makbuzno2.Clear();
            yevmiyefisi.SelectedIndex = -1;
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvani.Clear();
            yetkilisi.Clear();
            ili.Clear();
            ilcesi.Clear();
            mukellefler.SelectedIndex = -1;
            ucretaciklamasi.Clear();
            makbuzno.Clear();
            makbuzno2.Clear();
            yevmiyefisi.SelectedIndex = -1;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Form40_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet7.makbuzlistesitopluislemler' table. You can move, or remove it, as needed.
            this.makbuzlistesitopluislemlerTableAdapter.Fill(this.mhsbdigerhesaplarDataSet7.makbuzlistesitopluislemler);
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet6.makbuzlistesiaktarilanhareketler' table. You can move, or remove it, as needed.
            this.makbuzlistesiaktarilanhareketlerTableAdapter.Fill(this.mhsbdigerhesaplarDataSet6.makbuzlistesiaktarilanhareketler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek makbuz listesi bulunamadı.","Makbuz Listesi");
        }

        private void filtreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek makbuz listesi bulunamadı.", "Makbuz Listesi");
        }

        private void topluMakbuzOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oluşturulacak fiş bulunamadı!", "Uyarı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oluşturulacak fiş bulunamadı!","Uyarı");
        }

        private void muhasebeKaydınıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oluşturulacak fiş bulunamadı!", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
