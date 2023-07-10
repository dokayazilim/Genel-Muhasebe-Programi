using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace bordro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde bildirge işlemleri yapılamamaktadır.","Uyarı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde yazdırma işlemi yapılamamaktadır.","Uyarı");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void excelEAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde Excel' e Aktarma işlemi yapılamamaktadır.","Uyarı");
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Sistemden Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bildirgeRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde bildirge işlemleri yapılamamaktadır.", "Uyarı");
        }

        private void topluÜcretDeğiştriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sicil bilgileri......
            adi.Text = "Demo";
            soyadi.Text = "Demo";
            tckimlikno.Text = "Demo";
            sigortasicilno.Clear();
            cinsiyeti.SelectedIndex = -1;
            sirano.Clear();
            isegiristarihi.Clear();
            istencikistarihi.Clear();
            istencikarmanedenisgk.SelectedIndex = -1;
            istencikarmanedenibolcalis.SelectedIndex = -1;
            asgarird.Checked = false;
            digerrd.Checked = false;
            ucretsekli.SelectedIndex = -1;
            personelgrubu.SelectedIndex = -1;
            isegirisgonderildi.SelectedIndex = -1;
            isecikisgonderildi.SelectedIndex = -1;
            ucret.Clear();
            tabioldugukanun.SelectedIndex = -1;
            cocuksayisi.Clear();
            stopajtesvigi.SelectedIndex = -1;
            sayilikanun5921.SelectedIndex = -1;
            vergimuafbolgesi.SelectedIndex = -1;
            uygunsure6111.Clear();
            ozurlu.SelectedIndex = -1;
            sayilikanun2821.SelectedIndex = -1;
            sigortalimeslekkodu.Clear();
            sozlesmeturu.SelectedIndex = -1;
            calismasi.SelectedIndex = -1;
            maastipi.Clear();
            ozurdurumu.SelectedIndex = -1;
            kidembaslamatarihi.Clear();
            vergimatrahi.Clear();
            asgarigecikmeindirimi.SelectedIndex = -1;
            doktoralimi.SelectedIndex = -1;
            departman.Clear();
            bes.Clear();
            sagsigprtutari.Clear();
            agiorani.Clear();
            hayatsigpirimtutari.Clear();
            //kimlik bilgileri...
            babaadi.Clear();
            anaadi.Clear();
            dogumyeri.Clear();
            dogumtarihi.Clear();
            medenidurumu.SelectedIndex = -1;
            cinsiyetkimlik.SelectedIndex = -1;
            kizliksoyadi.Clear();
            nufusakayolduguil.Clear();
            nufusakayolduguilce.Clear();
            nufusakayoldugumah.Clear();
            uyrugu.SelectedIndex = -1;
            ulke.Clear();
            ciltno.Clear();
            siranokimlik.Clear();
            ailesirano.Clear();
            cuzdankayitno.Clear();
            verilistarihi.Clear();
            cuzdanserino.Clear();
            tckimliknokimlik.Clear();
            //öğrenim/banka ve diğer bilgiler...
            ogrenimdurumu.SelectedIndex = -1;
            askerlikdurumu.SelectedIndex = -1;
            askerlikbaslamatarihi.Clear();
            askerlikbitistarihi.Clear();
            sigortalilikturu.SelectedIndex = -1;
            yaslilikayligi.SelectedIndex = 1;
            istihdamdurumu.SelectedIndex = -1;
            gorevkodu.SelectedIndex = -1;
            gorevi.Clear();
            sosyalguvenlikkodu.Clear();
            meslekgrubu.Clear();
            meslekili.Clear();
            meslekilcesi.Clear();
            uyeoldugusendika.Clear();
            bedenolcusu.Clear();
            pantolonolcusu.Clear();
            ayakkabino.Clear();
            bankasubekodu.Clear();
            bankaadi.Clear();
            bankasubeadi.Clear();
            bankahesapno.Clear();
            musterino.Clear();
            musterinopersonel.Clear();
            ibannopersonel.Clear();
            mahalle.Clear();
            cadde.Clear();
            sokak.Clear();
            il.Clear();
            ilce.Clear();
            diskapino.Clear();
            ickapino.Clear();
            koy.Clear();
            postakodu.Clear();
            vergino.Text = "Demo";
            telefonno.Clear();
            cepno.Clear();
            eposta.Clear();
            sgksicilno.Clear();
            bagkursicil.Clear();
            sicilemksandigi.Clear();
            maddesan506.Clear();
            adres.Text = "Demo";
            //muhasebe bilgileri...
            brutucretler.Clear();
            sigkesisverenpayi.Clear();
            issizliksigkesisverenpayi.Clear();
            fazlamesai.Clear();
            avans.Clear();
            damgavergisi.Clear();
            gelirstopaji.Clear();
            sigortakesintisi.Clear();
            issizliksigortakesintisi.Clear();
            mahsupedilecekagi.Clear();
            netucretler.Clear();
            gelirvergisiindirimi.Clear();
            gelirvergisiindirimikarsit.Clear();
            sgkisverenindirimi.Clear();
            sgkisverenindirimikarsiths.Clear();
            bruttutar.Clear();
            bruttutarkidem.Clear();
            damgavergisimuhasebe.Clear();
            damgavergisikidem.Clear();
            nettutar.Clear();
            netttutarkidem.Clear();
            bruttutarihbar.Clear();
            bruttutarihbarkidem.Clear();
            damgavergisiihbar.Clear();
            damgavergisiihbarkidem.Clear();
            nettutarihbar.Clear();
            nettutarihbarkidem.Clear();
            gelirvergisiihbar.Clear();
            gelirvergisiihbarkidem.Clear();



           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (asgarird.Checked)
            {
                
                yazi.Text = "Asgari";
                yazi.Visible = false;
            }
            else if(digerrd.Checked)
            {
                yazi.Text = "Diğer";
                yazi.Visible = false;
            }
            try
            {
                OleDbConnection baglanti;
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bordro.accdb");
                baglanti.Open();

                OleDbCommand kayit = new OleDbCommand();
                kayit.CommandText = "INSERT INTO sicilbilgi(adi,soyadi,tckimlikno,sigortasicilno,cinsiyeti,sirano,isegiristarihi,istencikistarihi,istencikisnedenisgk,istencikisnedenibol,personelinucreti,ucretsekli,personelgrubu,isegirisgonderildi,isecikisgonderildi,ucret,tabioldugukanun,cocuksayisi,stopajtesvigi,sayilikanunellidokuz,vergimuafbolgesi,uygunluksuresi,ozurlu,sayilikanunyirmisekiz,sigortalimeslekkodu,sozlesmeturu,calismasi,maastipi,ozurdurumu,kidembaslamatarihi,vergimatrahi,asgarigecikmeindirimi,doktoralimi,departman,bes,sagsigpirimtutari,agiorani,hayatsigpirimtutari)VALUES('" + adi.Text + "','" + soyadi.Text + "','" + tckimlikno.Text + "','" + sigortasicilno.Text + "','" + cinsiyeti.Text + "','" + sirano.Text + "','" + isegiristarihi.Text + "','" + istencikistarihi.Text + "','" + istencikarmanedenisgk.Text + "','" + istencikarmanedenibolcalis.Text + "','" + yazi.Text + "','" + ucretsekli.Text + "','" + personelgrubu.Text + "','" + isegirisgonderildi.Text + "','" + isecikisgonderildi.Text + "','" + ucret.Text + "','" + tabioldugukanun.Text + "','" + cocuksayisi.Text + "','" + stopajtesvigi.Text + "','" + sayilikanun5921.Text + "','" + vergimuafbolgesi.Text + "','" + uygunsure6111.Text + "','" + ozurlu.Text + "','" + sayilikanun2821.Text + "','" + sigortalimeslekkodu.Text + "','" + sozlesmeturu.Text + "','" + calismasi.Text + "','" + maastipi.Text + "','" + ozurdurumu.Text + "','" + kidembaslamatarihi.Text + "','" + vergimatrahi.Text + "','" + asgarigecikmeindirimi.Text + "','" + doktoralimi.Text + "','" + departman.Text + "','" + bes.Text + "','" + sagsigprtutari.Text + "','" + agiorani.Text + "','" + hayatsigpirimtutari.Text + "')";
                kayit.Connection = baglanti;
                kayit.ExecuteNonQuery();
                OleDbCommand kayit2 = new OleDbCommand();
                kayit2.CommandText = "INSERT INTO kimlikbilgi(babaadi,anaadi,dogumyeri,dogumtarihi,medenidurumu,cinsiyet,kizliksoyadi,nufusakayitliolduguil,nufusakayitliolduguilce,nufusakayitlioldugumah,uyrugu,ulke,ciltno,sirano,ailesirano,cuzdankayitno,verilistarihi,cuzdanserino,tckimlikno)VALUES('" + babaadi.Text + "','" + anaadi.Text + "','" + dogumyeri.Text + "','" + dogumtarihi.Text + "','" + medenidurumu.Text + "','" + cinsiyetkimlik.Text + "','" + kizliksoyadi.Text + "','" + nufusakayolduguil.Text + "','" + nufusakayolduguilce.Text + "','" + nufusakayoldugumah.Text + "','" + uyrugu.Text + "','" + ulke.Text + "','" + ciltno.Text + "','" + siranokimlik.Text + "','" + ailesirano.Text + "','" + cuzdankayitno.Text + "','" + verilistarihi.Text + "','" + cuzdanserino.Text + "','" + tckimliknokimlik.Text + "')";
                kayit2.Connection = baglanti;
                kayit2.ExecuteNonQuery();
                OleDbCommand kayit3 = new OleDbCommand();
                kayit3.CommandText = "INSERT INTO ogrenimadresbilgi(ogrenimdurumu,askerlikdurumu,askerlikbaslamatarihi,askerlikbitistarihi,sigortalilikturu,yaslilikayligi,istihdamdurumu,gorevkodu,gorevi,sosyalguvenlikkodu,meslekgrubu,meslekili,meslekilcesi,uyeoldugusendika,bedenolcusu,pantolonolcusu,ayakkabino,bankasubekodu,bankaadi,bankasubeadi,bankahesapno,musterino,musterinopersonel,ibannopersonel,mahalle,cadde,sokak,il,ilce,diskapino,ickapino,koy,postakodu,vergino,telefonu,cepno,eposta,sgk,bagkur,emksandigi,madsanbesyuzalti,adres)VALUES('" + ogrenimdurumu.Text + "','" + askerlikdurumu.Text + "','" + askerlikbaslamatarihi.Text + "','" + askerlikbitistarihi.Text + "','" + sigortalilikturu.Text + "','" + yaslilikayligi.Text + "','" + istihdamdurumu.Text + "','" + gorevkodu.Text + "','" + gorevi.Text + "','" + sosyalguvenlikkodu.Text + "','" + meslekgrubu.Text + "','" + meslekili.Text + "','" + meslekilcesi.Text + "','" + uyeoldugusendika.Text + "','" + bedenolcusu.Text + "','" + pantolonolcusu.Text + "','" + ayakkabino.Text + "','" + bankasubekodu.Text + "','" + bankaadi.Text + "','" + bankasubeadi.Text + "','" + bankahesapno.Text + "','" + musterino.Text + "','" + musterinopersonel.Text + "','" + ibannopersonel.Text + "','" + mahalle.Text + "','" + cadde.Text + "','" + sokak.Text + "','" + il.Text + "','" + ilce.Text + "','" + diskapino.Text + "','" + ickapino.Text + "','" + koy.Text + "','" + postakodu.Text + "','" + vergino.Text + "','" + telefonno.Text + "','" + cepno.Text + "','" + eposta.Text + "','" + sgksicilno.Text + "','" + bagkursicil.Text + "','" + sicilemksandigi.Text + "','" + maddesan506.Text + "','" + adres.Text + "')";
                kayit3.Connection = baglanti;
                kayit3.ExecuteNonQuery();
                OleDbCommand kayit4 = new OleDbCommand();
                kayit4.CommandText = "INSERT INTO muhasebebilgi(brutucretler,sigkesisverenpayi,issizliksigkesisverenpayi,fazlamesai,avans,damgavergisi,gelirstopaji,sigortakesintisi,issizliksigortakesintisi,mahsupedilecekagi,netucretler,gelirvergisiindirimi,gelirvergisiindirimikarsiths,sgkisverenindirimi,sgkisverenindirimikarsiths,bruttutar,bruttutarkidem,damgavergisimuhasebe,damgavergisikidem,nettutar,nettutarkidem,bruttutarihbar,bruttutarihbarkidem,damgavergisiihbar,damgavergisiihbarkidem,nettutarihbar,nettutarihbarkidem,gelirvergisiihbar,gelirvergisiihbarkidem)VALUES('" + brutucretler.Text + "','" + sigkesisverenpayi.Text + "','" + issizliksigkesisverenpayi.Text + "','" + fazlamesai.Text + "','" + avans.Text + "','" + damgavergisi.Text + "','" + gelirstopaji.Text + "','" + sigortakesintisi.Text + "','" + issizliksigortakesintisi.Text + "','" + mahsupedilecekagi.Text + "','" + netucretler.Text + "','" + gelirvergisiindirimi.Text + "','" + gelirvergisiindirimikarsit.Text + "','" + sgkisverenindirimi.Text + "','" + sgkisverenindirimikarsiths.Text + "','" + bruttutar.Text + "','" + bruttutarkidem.Text + "','" + damgavergisimuhasebe.Text + "','" + damgavergisikidem.Text + "','" + nettutar.Text + "','" + netttutarkidem.Text + "','" + bruttutarihbar.Text + "','" + bruttutarihbarkidem.Text + "','" + damgavergisiihbar.Text + "','" + damgavergisiihbarkidem.Text + "','" + nettutarihbar.Text + "','" + nettutarihbarkidem.Text + "','" + gelirvergisiihbar.Text + "','" + gelirvergisiihbarkidem.Text + "')";
                kayit4.Connection = baglanti;
                kayit4.ExecuteNonQuery();
               
                baglanti.Close();
                MessageBox.Show("kayıt tamam.");


            }
            catch (OleDbException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            
            // TODO: This line of code loads data into the 'bordroortaklarDataSet4.ekkesintibilgileri' table. You can move, or remove it, as needed.
            this.ekkesintibilgileriTableAdapter.Fill(this.bordroortaklarDataSet4.ekkesintibilgileri);
            // TODO: This line of code loads data into the 'bordroortaklarDataSet3.ekodemebilgileri' table. You can move, or remove it, as needed.
            this.ekodemebilgileriTableAdapter.Fill(this.bordroortaklarDataSet3.ekodemebilgileri);
            // TODO: This line of code loads data into the 'bordroortaklarDataSet2.puantajcetveli' table. You can move, or remove it, as needed.
            this.puantajcetveliTableAdapter.Fill(this.bordroortaklarDataSet2.puantajcetveli);
            // TODO: This line of code loads data into the 'bordroortaklarDataSet1.puantajbilgileri' table. You can move, or remove it, as needed.
            this.puantajbilgileriTableAdapter.Fill(this.bordroortaklarDataSet1.puantajbilgileri);
            yazi.Visible = false;
        }

        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
                    }
    }
}
