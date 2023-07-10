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
    public partial class Form61 : Form
    {
        public Form61()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form61_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeDataSet3.hesapkodlari' table. You can move, or remove it, as needed.
            this.hesapkodlariTableAdapter2.Fill(this.muhasebeDataSet3.hesapkodlari);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form7 frm2 = (Form7)Application.OpenForms["Form7"];
            frm2.hesapkodu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            BindingSource sr = new BindingSource();
            sr.DataSource = dataGridView1.DataSource;

            sr.Filter = "HesapKodu like '%" + arama.Text + "%'";
            dataGridView1.DataSource = sr;
        }
    }
}
