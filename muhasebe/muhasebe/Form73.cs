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
    public partial class Form73 : Form
    {
        public Form73()
        {
            InitializeComponent();
        }

        private void Form73_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarbelgeturleriDataSet5.belgeturu' table. You can move, or remove it, as needed.
            this.belgeturuTableAdapter3.Fill(this.muhasebeortakhesaplarbelgeturleriDataSet5.belgeturu);

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
