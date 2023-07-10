using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace muhasebe
{
    public partial class Form62 : Form
    {
        public Form62()
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
            firmakodu.Clear();
            soyadi.Clear();
            adi.Clear();
            vergino.Clear();
            kimlikno.Clear();
            adres.Clear();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firmakodu.Clear();
            soyadi.Clear();
            adi.Clear();
            vergino.Clear();
            kimlikno.Clear();
            adres.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde şirket/firma kaydı yapılamamaktadır.","Firma Kayıt");
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form63 a = new Form63();
            a.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde şirket/firma kaydı yapılamamaktadır.", "Firma Kayıt");
        }

        }
    }

