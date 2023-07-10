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
    public partial class kayitlifirma : Form
    {
        public kayitlifirma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kayitlifirma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isletmedefteriortaklarDataSet1.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter.Fill(this.isletmedefteriortaklarDataSet1.firmakayit);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Demo adlı şirketi seçtiniz.","Bilgilendirme");
            anamenu a = new anamenu();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenifirma a = new yenifirma();
            a.Show();
        }
    }
}
