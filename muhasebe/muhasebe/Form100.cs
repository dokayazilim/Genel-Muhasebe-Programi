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
    public partial class Form100 : Form
    {
        public Form100()
        {
            InitializeComponent();
        }

        private void Form100_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeDataSet18.hesapkodlari' table. You can move, or remove it, as needed.
            this.hesapkodlariTableAdapter13.Fill(this.muhasebeDataSet18.hesapkodlari);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hesapkod.Checked)
            {

                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "HesapKodu like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else { }
            if (hesapad.Checked)
            {

                BindingSource src = new BindingSource();
                src.DataSource = dataGridView1.DataSource;

                src.Filter = "HesapAdi like '%" + arama.Text + "%'";
                dataGridView1.DataSource = src;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama.Clear();
            hesapkod.Checked = false;
            hesapad.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form18 frm2 = (Form18)Application.OpenForms["Form18"];
            frm2.hesapkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }
    }
}
