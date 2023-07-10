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
    public partial class makine : Form
    {
        public makine()
        {
            InitializeComponent();
        }

        private void makine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet55.makineuretimkayitlari' table. You can move, or remove it, as needed.
            this.makineuretimkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet55.makineuretimkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet54.makineuretimler' table. You can move, or remove it, as needed.
            this.makineuretimlerTableAdapter.Fill(this.muhasebepaketlerDataSet54.makineuretimler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet53.makinemakine' table. You can move, or remove it, as needed.
            this.makinemakineTableAdapter.Fill(this.muhasebepaketlerDataSet53.makinemakine);

        }
    }
}
