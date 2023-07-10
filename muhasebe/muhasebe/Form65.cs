﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace muhasebe
{
    public partial class Form65 : Form
    {
        public Form65()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stokkoduarama.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "StokKodu like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else if (stokadiarama.Checked)
            {
                BindingSource sr = new BindingSource();
                sr.DataSource = dataGridView1.DataSource;

                sr.Filter = "StokAdi like '%" + arama.Text + "%'";
                dataGridView1.DataSource = sr;
            }
            else
            {
                MessageBox.Show("Lütfen arama için filtreleme seçeneği seçiniz.", "Uyarı");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form65_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mhsbdataDataSet41.stoktanimlari' table. You can move, or remove it, as needed.
            this.stoktanimlariTableAdapter.Fill(this.mhsbdataDataSet41.stoktanimlari);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form23 a = new Form23();
            a.Show();
        }
    }
}
