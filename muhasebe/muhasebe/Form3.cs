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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gelirGiderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dokasoft.com");
        }

        private void tahsilFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 b = new Form5();
            b.Show();
        }

        private void tediyeFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 c = new Form6();
            c.Show();
        }

        private void açılışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 d = new Form7();
            d.Show();
        }

        private void mahsupFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 g = new Form8();
            g.Show();
        }

        private void kapanışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 ab = new Form9();
            ab.Show();
        }

        private void eskiFişlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 ac = new Form10();
            ac.Show();
        }

        private void versiyonBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
        }

        private void kapatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
                Application.Exit();
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form71 a = new Form71();
            a.Show();
        }

        private void aHesaplarınYansıtılmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void bHesaplarınYansıtılmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
        }

        private void kiraTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
        }

        private void gelirBütçesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 a = new Form14();
            a.Show();
        }

        private void giderBütçesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            a.Show();
        }

        private void aylıkMizanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 a = new Form16();
            a.Show();
        }

        private void kapanışFişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form17 a = new Form17();
            a.Show();
        }

        private void kesinMizanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 a = new Form18();
            a.Show();
        }

        private void zamanlanmışFişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void topluFişYazdırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fişHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yevmiyeDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 a = new Form19();
            a.Show();
        }

        private void yardımcıDefterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 a = new Form20();
            a.Show();
        }

        private void hesapPlanıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form21 a = new Form21();
            a.Show();
        }

        private void kebirDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 a = new Form22();
            a.Show();
        }

        private void stokTanımlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 a = new Form23();
            a.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 a = new Form24();
            a.Show();
        }

        private void özetBilançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 a = new Form25();
            a.Show();
        }

        private void ayrıntılıBilançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form26 a = new Form26();
            a.Show();
        }

        private void stokEnvanteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form27 a = new Form27();
            a.Show();
        }

        private void stokHareketRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 a = new Form28();
            a.Show();
        }

        private void maliyetHesaplamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 a = new Form29();
            a.Show();
        }

        private void aHesaplarınKapatılmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form30 a = new Form30();
            a.Show();
        }

        private void bHesaplarınKapatılmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 a = new Form31();
            a.Show();
        }

        private void kDVTahakkukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form32 a = new Form32();
            a.Show();
        }

        private void virmanHesabınaAktarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form33 a = new Form33();
            a.Show();
        }

        private void karZararHesaplamalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form34 a = new Form34();
            a.Show();
        }

        private void öncekiDönemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form35 a = new Form35();
            a.Show();
        }

        private void satışMaliyetleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form36 a = new Form36();
            a.Show();
        }

        private void kDVListeleriniSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form37 a = new Form37();
            a.Show();
        }

        private void kiraListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form38 a = new Form38();
            a.Show();
        }

        private void serbestMeslekMakbuzuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form39 a = new Form39();
            a.Show();
        }

        private void makbuzListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form40 a = new Form40();
            a.Show();
        }

        private void makbuzSabitleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form41 a = new Form41();
            a.Show();
        }

        private void özetTabloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form42 a = new Form42();
            a.Show();
        }

        private void ayrıntılıTabloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form43 a = new Form43();
            a.Show();
        }

        private void eskiFişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
        }

        private void kDVBeyanname1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form44 a = new Form44();
            a.Show();
        }

        private void kDVBeyanname2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form45 a = new Form45();
            a.Show();
        }

        private void formBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BFORMU düzenlemesinde bütün para alanları TL cinsinden olmalıdır. Kesinlikle kuruş bilgisi girilmeyecektir. Sayı yuvarlanmayacaktır. Örneğin : 123456,78 TL >>> 123456 TL şeklinde olmalıdır.","ÖNEMLİ UYARI!!!");
            Form46 a = new Form46();
            a.Show();
        }

        private void formBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BFORMU düzenlemesinde bütün para alanları TL cinsinden olmalıdır. Kesinlikle kuruş bilgisi girilmeyecektir. Sayı yuvarlanmayacaktır. Örneğin : 123456,78 TL >>> 123456 TL şeklinde olmalıdır.", "ÖNEMLİ UYARI!!!");
            Form47 a = new Form47();
            a.Show();
        }

        private void muhtasarBeyannameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form48 a = new Form48();
            a.Show();
        }

        private void gelirVergisiMükellefleriİçinGeçiciBeyannameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form49 a = new Form49();
            a.Show();
        }

        private void damgaVergisiBeyannamesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form50 a = new Form50();
            a.Show();
        }

        private void yıllıkGelirVergisiBeyannamesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6111 Sayılı Kanuna Göre Matrah Artırımında Bulunmuş İseniz Artırımda Bulunduğunuz Yıla Ait Zararın Yarısını Yazabilirsiniz!","UYARI");
            
            Form51 a = new Form51();
            a.Show();
        }

        private void kesinMizanBildirimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form52 a = new Form52();
            a.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
           
                Application.Exit();
            
        }

        private void yeniFirmaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form62 a = new Form62();

            a.Show();
        }

        private void kayıtlıFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form63 a = new Form63();
            a.Show();

        }

        private void kayıtlıBeyannamelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form70 a = new Form70();
            a.Show();
        }

        private void cariHesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form71 a = new Form71();
            a.Show();
        }

        private void cariMizanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form72 a = new Form72();
            a.Show();
        }

        private void beyannameGöndermeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme sürümünde beyanname gönderme işlemi yapılamamaktadır.","Uyarı");
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyanname kaydı bulunamadı.","Uyarı");
        }

        private void iVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyanname kaydı bulunamadı.", "Uyarı");
        }

        private void genelMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void veresiyeDefterimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form109 a = new Form109();
            a.Show();
        }

        private void ziyaretçiDefterimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sonraki demo sürüm güncellemesinde eklenecektir.","Uyarı");
        }

        private void demirbaşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sonraki demo sürüm güncellemesinde eklenecektir.", "Uyarı");
        }

        private void demirbaşToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form110 a = new Form110();
            a.Show();
        }

        private void üretimSiparişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uretimsiparisleri a = new uretimsiparisleri();
            a.Show();
        }

        private void sUTÜPMüşteriTakipSistemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form111 a = new Form111();
            a.Show();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void stokTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 a = new Form23();
            a.Show();
        }

        private void stokEnvanteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form27 a = new Form27();
            a.Show();
        }

        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 a = new Form28();
            a.Show();
        }

        private void cariMizanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form72 a = new Form72();
            a.Show();
        }

        private void işEmirleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isemirleri a = new isemirleri();
            a.Show();
        }

        private void üretimReçeteleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uretimreceteleri a = new uretimreceteleri();
            a.Show();
        }

        private void malzemePlanlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            malzemeplanlama a = new malzemeplanlama();
            a.Show();
        }

        private void makineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makine a = new makine();
            a.Show();
        }

        private void kaliyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalite a = new kalite();
            a.Show();
        }

        private void üretimKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uretimkayitlari a = new uretimkayitlari();
            a.Show();
        }

        private void maliyetTeklifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maliyetteklif a = new maliyetteklif();
            a.Show();
        }

        private void depoSevkİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deposevk a = new deposevk();
            a.Show();
        }

        private void fasonİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fasonislemleri a = new fasonislemleri();
            a.Show();
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departmanlar a = new departmanlar();
            a.Show();
        }

        private void stokHareketFişleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irsaliyestok a = new irsaliyestok();
            a.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Normal == WindowState)
            {
                Hide();
                notifyIcon1.BalloonTipText = "Genel Muhasebe Smart' a Hoşgeldiniz!";
                notifyIcon1.ShowBalloonTip(5); //Mesajı 5sn. goruntuler
            }
            else if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon1.BalloonTipText = "Genel Muhasebe Smart simge durumuna küçültüldü!";
                notifyIcon1.ShowBalloonTip(5); //Mesajı 5sn. goruntuler
            }
        }

        private void basitUsülGelirVergisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basitusulgelirvergisi a = new basitusulgelirvergisi();
            a.Show();
        }

        private void geçiciVergiBeyannamesiKurumlarVergisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kurumlarvergisibeyannamesi a = new kurumlarvergisibeyannamesi();
            a.Show();
        }
    }
}
