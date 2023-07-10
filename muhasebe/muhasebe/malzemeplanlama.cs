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
    public partial class malzemeplanlama : Form
    {
        public malzemeplanlama()
        {
            InitializeComponent();
        }

        private void malzemeplanlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet14.malzemeplanlamastokuc' table. You can move, or remove it, as needed.
            this.malzemeplanlamastokucTableAdapter.Fill(this.muhasebepaketlerDataSet14.malzemeplanlamastokuc);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet13.malzemeplanlamastoklarreceteler' table. You can move, or remove it, as needed.
            this.malzemeplanlamastoklarrecetelerTableAdapter.Fill(this.muhasebepaketlerDataSet13.malzemeplanlamastoklarreceteler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet12.malzemeplanlamastokiki' table. You can move, or remove it, as needed.
            this.malzemeplanlamastokikiTableAdapter.Fill(this.muhasebepaketlerDataSet12.malzemeplanlamastokiki);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet11.malzemeplanlamaisemirleri' table. You can move, or remove it, as needed.
            this.malzemeplanlamaisemirleriTableAdapter.Fill(this.muhasebepaketlerDataSet11.malzemeplanlamaisemirleri);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet10.malzemeplanlamastokbir' table. You can move, or remove it, as needed.
            this.malzemeplanlamastokbirTableAdapter.Fill(this.muhasebepaketlerDataSet10.malzemeplanlamastokbir);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet9.malzemeplanlamauretimsiparisleri' table. You can move, or remove it, as needed.
            this.malzemeplanlamauretimsiparisleriTableAdapter.Fill(this.muhasebepaketlerDataSet9.malzemeplanlamauretimsiparisleri);

        }
    }
}
