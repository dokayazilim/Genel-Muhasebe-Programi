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
    public partial class Form77 : Form
    {
        public Form77()
        {
            InitializeComponent();
        }

        private void Form77_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet49.firmakayit' table. You can move, or remove it, as needed.
            this.firmakayitTableAdapter3.Fill(this.mhsbdataDataSet49.firmakayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
