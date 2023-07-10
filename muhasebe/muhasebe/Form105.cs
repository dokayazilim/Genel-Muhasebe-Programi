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
    public partial class Form105 : Form
    {
        public Form105()
        {
            InitializeComponent();
        }

        private void Form105_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet60.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter1.Fill(this.mhsbdataDataSet60.firmakayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form72 frm2 = (Form72)Application.OpenForms["Form72"];
            frm2.bslngctckimlik.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.Hide();
        }
    }
}
