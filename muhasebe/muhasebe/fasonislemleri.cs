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
    public partial class fasonislemleri : Form
    {
        public fasonislemleri()
        {
            InitializeComponent();
        }

        private void fasonislemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet43.fasonislemlerifasontalimatlaristoklar' table. You can move, or remove it, as needed.
            this.fasonislemlerifasontalimatlaristoklarTableAdapter.Fill(this.muhasebepaketlerDataSet43.fasonislemlerifasontalimatlaristoklar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet42.fasonislemlerifasontalimatlaritalimatlar' table. You can move, or remove it, as needed.
            this.fasonislemlerifasontalimatlaritalimatlarTableAdapter.Fill(this.muhasebepaketlerDataSet42.fasonislemlerifasontalimatlaritalimatlar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet41.fasonislemlerioperasyonlarislemkayitlari' table. You can move, or remove it, as needed.
            this.fasonislemlerioperasyonlarislemkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet41.fasonislemlerioperasyonlarislemkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet40.fasonislemlerioperasyonlar' table. You can move, or remove it, as needed.
            this.fasonislemlerioperasyonlarTableAdapter.Fill(this.muhasebepaketlerDataSet40.fasonislemlerioperasyonlar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet39.fasonislemleriisemirleri' table. You can move, or remove it, as needed.
            this.fasonislemleriisemirleriTableAdapter.Fill(this.muhasebepaketlerDataSet39.fasonislemleriisemirleri);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet38.fasonislemleriuretimkayitlari' table. You can move, or remove it, as needed.
            this.fasonislemleriuretimkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet38.fasonislemleriuretimkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet37.fasonislemleristokhareketleriislemkayitlari' table. You can move, or remove it, as needed.
            this.fasonislemleristokhareketleriislemkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet37.fasonislemleristokhareketleriislemkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet36.fasonislemleristokhareketleristokkaydi' table. You can move, or remove it, as needed.
            this.fasonislemleristokhareketleristokkaydiTableAdapter.Fill(this.muhasebepaketlerDataSet36.fasonislemleristokhareketleristokkaydi);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet35.fasonislemlericarifason' table. You can move, or remove it, as needed.
            this.fasonislemlericarifasonTableAdapter.Fill(this.muhasebepaketlerDataSet35.fasonislemlericarifason);

        }
    }
}
