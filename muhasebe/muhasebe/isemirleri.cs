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
    public partial class isemirleri : Form
    {
        public isemirleri()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void isemirleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet5.isemirlerioperasyonlar' table. You can move, or remove it, as needed.
            this.isemirlerioperasyonlarTableAdapter.Fill(this.muhasebepaketlerDataSet5.isemirlerioperasyonlar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet4.isemirlerisarflar' table. You can move, or remove it, as needed.
            this.isemirlerisarflarTableAdapter.Fill(this.muhasebepaketlerDataSet4.isemirlerisarflar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet3.isemirleribilgileriki' table. You can move, or remove it, as needed.
            this.isemirleribilgilerikiTableAdapter.Fill(this.muhasebepaketlerDataSet3.isemirleribilgileriki);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet2.isemirleribilgilerbir' table. You can move, or remove it, as needed.
            this.isemirleribilgilerbirTableAdapter.Fill(this.muhasebepaketlerDataSet2.isemirleribilgilerbir);

        }
    }
}
