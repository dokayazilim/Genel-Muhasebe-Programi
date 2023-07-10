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
    public partial class departmanlar : Form
    {
        public departmanlar()
        {
            InitializeComponent();
        }

        private void departmanlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet34.departmanlarstokgrupoperasyonlarioperasyon' table. You can move, or remove it, as needed.
            this.departmanlarstokgrupoperasyonlarioperasyonTableAdapter.Fill(this.muhasebepaketlerDataSet34.departmanlarstokgrupoperasyonlarioperasyon);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet33.departmanlarstokgrupoperasyonlarigrup' table. You can move, or remove it, as needed.
            this.departmanlarstokgrupoperasyonlarigrupTableAdapter.Fill(this.muhasebepaketlerDataSet33.departmanlarstokgrupoperasyonlarigrup);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet32.departmanlargruprotagrup' table. You can move, or remove it, as needed.
            this.departmanlargruprotagrupTableAdapter.Fill(this.muhasebepaketlerDataSet32.departmanlargruprotagrup);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet31.departmanlargruprotarota' table. You can move, or remove it, as needed.
            this.departmanlargruprotarotaTableAdapter.Fill(this.muhasebepaketlerDataSet31.departmanlargruprotarota);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet30.departmanlaruretimkayitlari' table. You can move, or remove it, as needed.
            this.departmanlaruretimkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet30.departmanlaruretimkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet29.departmanlarisemirleri' table. You can move, or remove it, as needed.
            this.departmanlarisemirleriTableAdapter.Fill(this.muhasebepaketlerDataSet29.departmanlarisemirleri);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet28.departmanlardagitimkayitlaridagitimstoklistesi' table. You can move, or remove it, as needed.
            this.departmanlardagitimkayitlaridagitimstoklistesiTableAdapter.Fill(this.muhasebepaketlerDataSet28.departmanlardagitimkayitlaridagitimstoklistesi);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet27.departmanlardagitimkayitlaridagitimlistesi' table. You can move, or remove it, as needed.
            this.departmanlardagitimkayitlaridagitimlistesiTableAdapter.Fill(this.muhasebepaketlerDataSet27.departmanlardagitimkayitlaridagitimlistesi);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet26.departmanlargiderkayitlariislemkayitlari' table. You can move, or remove it, as needed.
            this.departmanlargiderkayitlariislemkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet26.departmanlargiderkayitlariislemkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet25.departmanlargiderkayitlarigiderler' table. You can move, or remove it, as needed.
            this.departmanlargiderkayitlarigiderlerTableAdapter.Fill(this.muhasebepaketlerDataSet25.departmanlargiderkayitlarigiderler);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet24.departmanlarstokkayitlariislemkayitlari' table. You can move, or remove it, as needed.
            this.departmanlarstokkayitlariislemkayitlariTableAdapter.Fill(this.muhasebepaketlerDataSet24.departmanlarstokkayitlariislemkayitlari);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet23.departmanlarstokkayitlaristoklar' table. You can move, or remove it, as needed.
            this.departmanlarstokkayitlaristoklarTableAdapter.Fill(this.muhasebepaketlerDataSet23.departmanlarstokkayitlaristoklar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet22.departmanlaroperasyonlarislemkaydi' table. You can move, or remove it, as needed.
            this.departmanlaroperasyonlarislemkaydiTableAdapter.Fill(this.muhasebepaketlerDataSet22.departmanlaroperasyonlarislemkaydi);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet21.departmanlaroperasyonlar' table. You can move, or remove it, as needed.
            this.departmanlaroperasyonlarTableAdapter.Fill(this.muhasebepaketlerDataSet21.departmanlaroperasyonlar);
            // TODO: This line of code loads data into the 'muhasebepaketlerDataSet20.departmanlardepartman' table. You can move, or remove it, as needed.
            this.departmanlardepartmanTableAdapter.Fill(this.muhasebepaketlerDataSet20.departmanlardepartman);

        }
    }
}
