using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace muhasebe
{
    public partial class Form112 : Form
    {
        public Form112()
        {
            InitializeComponent();
        }

        private void Form112_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebedigerortaklartumhesapDataSet1.kdvtahakkuku' table. You can move, or remove it, as needed.
            this.kdvtahakkukuTableAdapter.Fill(this.muhasebedigerortaklartumhesapDataSet1.kdvtahakkuku);

        }
    }
}
