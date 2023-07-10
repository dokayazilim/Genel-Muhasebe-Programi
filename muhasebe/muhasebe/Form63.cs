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
    public partial class Form63 : Form
    {
        public Form63()
        {
            InitializeComponent();
        }

        private void Form63_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet32.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter1.Fill(this.mhsbdataDataSet32.firmakayit);
            // TODO: This line of code loads data into the 'mhsbDataSet.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter.Fill(this.mhsbDataSet.firmakayit);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fkodu.Clear();
            fadi.Clear();
            ftckimlik.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource sr = new BindingSource();
            sr.DataSource = dataGridView1.DataSource;

            sr.Filter = "FirmaKodu like '%" + fkodu.Text + "%'";
            dataGridView1.DataSource = sr;

            BindingSource sr2 = new BindingSource();
            sr2.DataSource = dataGridView1.DataSource;

            sr2.Filter = "Adi like '%" + fadi.Text + "%'";
            dataGridView1.DataSource = sr2;

            BindingSource sr3 = new BindingSource();
            sr3.DataSource = dataGridView1.DataSource;

            sr3.Filter = "TCKimlikNo like '%" + ftckimlik.Text + "%'";
            dataGridView1.DataSource = sr3;
        }

        private void fadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
