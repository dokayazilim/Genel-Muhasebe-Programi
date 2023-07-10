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
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Aktif çalışma formundan çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            unvani.Clear();
            yetkilisi.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            il.Clear();
            ilce.Clear();
            adres.Clear();
            nosu.Clear();
            ucretaciklama.Clear();
            stopajorani.Clear();
            kdvorani.SelectedIndex = -1;
            tevfikatorani.Clear();
            bruthesapkodu.Clear();
            stopajhesapkodu.Clear();
            vergino.Clear();
            kdvhesapkodu.Clear();
            tevfikathesapkodu.Clear();
            netucrethesapkodu.Clear();
            firmakodu.Clear();
            mhsbkayit.Checked = false;
            brutucreti.Clear();
            stopajtutari.Clear();
            kdvtutari.Clear();
            netucret.Clear();
            tevfikattutari.Clear();
            tahsiledilen.Clear();
            kalantutar.Clear();


        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvani.Clear();
            yetkilisi.Clear();
            vergidairesi.Clear();
            telefon.Clear();
            il.Clear();
            ilce.Clear();
            adres.Clear();
            nosu.Clear();
            ucretaciklama.Clear();
            stopajorani.Clear();
            kdvorani.SelectedIndex = -1;
            tevfikatorani.Clear();
            bruthesapkodu.Clear();
            stopajhesapkodu.Clear();
            kdvhesapkodu.Clear();
            tevfikathesapkodu.Clear();
            netucrethesapkodu.Clear();
            firmakodu.Clear();
            mhsbkayit.Checked = false;
            brutucreti.Clear();
            stopajtutari.Clear();
            kdvtutari.Clear();
            netucret.Clear();
            tevfikattutari.Clear();
            tahsiledilen.Clear();
            kalantutar.Clear();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran, ran2;
            ran = shee.get_Range("A1", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Ünvanı");
            ran2 = shee.get_Range("B1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Yetkilisi");
            ran2 = shee.get_Range("C1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Vergi Dairesi");
            ran2 = shee.get_Range("D1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Vergi No");
            ran2 = shee.get_Range("E1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Telefon");
            ran2 = shee.get_Range("F1", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "İl");
            ran2 = shee.get_Range("A3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "İlçe");
            ran2 = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Adres");
            ran2 = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Tarih");
            ran2 = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "No'su");
            ran2 = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Ücret Açıklaması");
            ran2 = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Stopaj Oranı");
            ran2 = shee.get_Range("A5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "KDV Oranı");
            ran2 = shee.get_Range("B5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Tevfikat Oranı");
            ran2 = shee.get_Range("C5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Brüt Ücrt.Hs.Kodu");
            ran2 = shee.get_Range("D5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Stpj.Hs.Kodu");
            ran2 = shee.get_Range("E5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "KDV Hs.Kodu");
            ran2 = shee.get_Range("F5", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Tvfkt.Hs.Kodu");
            ran2 = shee.get_Range("A7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Nt.Ücret Hs.Kodu");
            ran2 = shee.get_Range("B7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Firma Kodu");
            ran2 = shee.get_Range("C7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Brüt Ücreti");
            ran2 = shee.get_Range("D7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Stpj.Tutarı");
            ran2 = shee.get_Range("E7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "KDV Tutarı");
            ran2 = shee.get_Range("F7", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Net Ücret");
            ran2 = shee.get_Range("A9", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Tvfkt.Tutarı");
            ran2 = shee.get_Range("B9", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Thsl.Edilen");
            ran2 = shee.get_Range("C9", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, "Kln.Tutar");          
            // Ana bilgiler...
            ran = shee.get_Range("A2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, unvani.Text);
            ran2 = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, yetkilisi.Text);
            ran2 = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, vergidairesi.Text);
            ran2 = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, vergino.Text);
            ran2 = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, telefon.Text);
            ran2 = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, il.Text);
            ran2 = shee.get_Range("A4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, ilce.Text);
            ran2 = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, adres.Text);
            ran2 = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, tarihi.Text);
            ran2 = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, nosu.Text);
            ran2 = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, ucretaciklama.Text);
            ran2 = shee.get_Range("F4", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, stopajorani.Text);
            ran2 = shee.get_Range("A6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, kdvorani.Text);
            ran2 = shee.get_Range("B6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, tevfikatorani.Text);
            ran2 = shee.get_Range("C6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, bruthesapkodu.Text);
            ran2 = shee.get_Range("D6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, stopajhesapkodu.Text);
            ran2 = shee.get_Range("E6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, kdvhesapkodu.Text);
            ran2 = shee.get_Range("F6", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, tevfikathesapkodu.Text);
            ran2 = shee.get_Range("A8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, netucrethesapkodu.Text);
            ran2 = shee.get_Range("B8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, firmakodu.Text);
            ran2 = shee.get_Range("C8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, brutucreti.Text);
            ran2 = shee.get_Range("D8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, stopajtutari.Text);
            ran2 = shee.get_Range("E8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, kdvtutari.Text);
            ran2 = shee.get_Range("F8", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, netucret.Text);
            ran2 = shee.get_Range("A10", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, tevfikattutari.Text);
            ran2 = shee.get_Range("B10", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, tahsiledilen.Text);
            ran2 = shee.get_Range("C10", System.Reflection.Missing.Value);
            ran2.set_Value(System.Reflection.Missing.Value, kalantutar.Text);
  ;

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi gerçekleştiremezsiniz!", "Uyarı");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kayıt yapılamaz.", "Uyarı");
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde kayıt yapılamaz.","Uyarı");
        }

        private void kayıtlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("muhasebeyardim.pdf");
        }
    }
}
