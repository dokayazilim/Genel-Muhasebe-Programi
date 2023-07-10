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
    public partial class Form58 : Form
    {
        public Form58()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form58_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet47.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter2.Fill(this.mhsbdataDataSet47.firmakayit);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
