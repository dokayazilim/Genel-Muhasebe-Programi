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
    public partial class Form70 : Form
    {
        public Form70()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form70_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbortakhesaplardigerDataSet1.kayitlar' table. You can move, or remove it, as needed.
            this.kayitlarTableAdapter.Fill(this.mhsbortakhesaplardigerDataSet1.kayitlar);

        }
    }
}
