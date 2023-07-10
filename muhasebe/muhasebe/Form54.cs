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
    public partial class Form54 : Form
    {
        public Form54()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form54_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarbelgeturleriDataSet3.belgeturu' table. You can move, or remove it, as needed.
            this.belgeturuTableAdapter2.Fill(this.muhasebeortakhesaplarbelgeturleriDataSet3.belgeturu);
            // TODO: This line of code loads data into the 'muhasebeortakhesaplarbelgeturleriDataSet2.belgeturu' table. You can move, or remove it, as needed.
            this.belgeturuTableAdapter1.Fill(this.muhasebeortakhesaplarbelgeturleriDataSet2.belgeturu);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
