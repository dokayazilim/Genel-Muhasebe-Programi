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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdigerhesaplarDataSet1.eskifisler' table. You can move, or remove it, as needed.
            this.eskifislerTableAdapter.Fill(this.mhsbdigerhesaplarDataSet1.eskifisler);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            evrakno.Clear();
            fisno.Clear();
            aciklama.Clear();
            fistipi.SelectedIndex = -1;
            entegrasyon.SelectedIndex = -1;
            hesapadi.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minimum.Clear();
            maksimum.Clear();
            min.Clear();
            max.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s1.SelectedIndex = -1;
            s2.SelectedIndex = -1;
            s3.SelectedIndex = -1;
            s4.SelectedIndex = -1;
            s5.SelectedIndex = -1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı!","Eski Fişler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı!", "Eski Fişler");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filtrelenecek kayıt bulunamadı!", "Eski Fişler");
        }
    }
}
