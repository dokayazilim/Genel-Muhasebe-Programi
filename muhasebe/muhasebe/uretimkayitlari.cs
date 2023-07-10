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
    public partial class uretimkayitlari : Form
    {
        public uretimkayitlari()
        {
            InitializeComponent();
        }

        private void uretimkayitlari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet52.uretimkayitlaribaglievraklar' table. You can move, or remove it, as needed.
            this.uretimkayitlaribaglievraklarTableAdapter.Fill(this.muhasebepaketlerDataSet52.uretimkayitlaribaglievraklar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet51.uretimkayitlariuretilenler' table. You can move, or remove it, as needed.
            this.uretimkayitlariuretilenlerTableAdapter.Fill(this.muhasebepaketlerDataSet51.uretimkayitlariuretilenler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet50.uretimkayitlaribilgiler' table. You can move, or remove it, as needed.
            this.uretimkayitlaribilgilerTableAdapter.Fill(this.muhasebepaketlerDataSet50.uretimkayitlaribilgiler);

        }
    }
}
