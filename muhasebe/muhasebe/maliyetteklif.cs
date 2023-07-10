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
    public partial class maliyetteklif : Form
    {
        public maliyetteklif()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void maliyetteklif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet17.maliyetteklifbilgileriki' table. You can move, or remove it, as needed.
            this.maliyetteklifbilgilerikiTableAdapter.Fill(this.muhasebepaketlerDataSet17.maliyetteklifbilgileriki);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet16.maliyetteklifbilgiler' table. You can move, or remove it, as needed.
            this.maliyetteklifbilgilerTableAdapter.Fill(this.muhasebepaketlerDataSet16.maliyetteklifbilgiler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet15.maliyetteklifteklifler' table. You can move, or remove it, as needed.
            this.maliyettekliftekliflerTableAdapter.Fill(this.muhasebepaketlerDataSet15.maliyetteklifteklifler);

        }
    }
}
