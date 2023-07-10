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
    public partial class Form86 : Form
    {
        public Form86()
        {
            InitializeComponent();
        }

        private void Form86_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet57.vergidairesikodlari' table. You can move, or remove it, as needed.
            this.vergidairesikodlariTableAdapter7.Fill(this.mhsbdataDataSet57.vergidairesikodlari);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adi.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "Ad like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else if (il.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "Il like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else if (dairekodu.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "Kod like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else
            {
                MessageBox.Show("Lütfen filtreleme seçeneklerinden birini seçiniz.", "Uyarı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama.Clear();
            adi.Checked = false;
            il.Checked = false;
            dairekodu.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form51 frm2 = (Form51)Application.OpenForms["Form51"];
            frm2.vergidairesi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }
    }
}
