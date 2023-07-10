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
    public partial class Form78 : Form
    {
        public Form78()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama.Clear();
            kod.Checked = false;
            oran.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form78_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakhesaplartevfikatoraniDataSet1.tevfikatorani' table. You can move, or remove it, as needed.
            this.tevfikatoraniTableAdapter.Fill(this.mhsbortakhesaplartevfikatoraniDataSet1.tevfikatorani);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kod.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "kod like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else if (oran.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "oran like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else
            {
                MessageBox.Show("Lütfen filtreleme seçeneklerinden birini seçiniz.", "Uyarı");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
