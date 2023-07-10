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
    public partial class Form59 : Form
    {
        public Form59()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form59_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeDataSet1.hesapkodlari' table. You can move, or remove it, as needed.
            this.hesapkodlariTableAdapter.Fill(this.muhasebeDataSet1.hesapkodlari);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     

            
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form8 frm2 = (Form8)Application.OpenForms["Form8"];
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
