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
    public partial class Form55 : Form
    {
        public Form55()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form55_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet46.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter1.Fill(this.mhsbdataDataSet46.firmakayit);

        }
    }
}
