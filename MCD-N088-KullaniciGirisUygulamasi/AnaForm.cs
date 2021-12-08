using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_N088_KullaniciGirisUygulamasi
{
    public partial class AnaForm : Form
    {
        public AnaForm(Kulanici bulunanKullanici)
        {
            InitializeComponent();

            txtİsim.Text = bulunanKullanici.isim;
            txtSoyİism.Text = bulunanKullanici.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtSifre.Text = bulunanKullanici.sifre;
            txtaciklama.Text = bulunanKullanici.aciklama;
            btngüncelle.Tag = bulunanKullanici.Id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            //Buton btngüncelle =(Buton) sender,
            int id =(int) btngüncelle.Tag;
            int index = SanalDatabase.KullaniciTaplosu.FindIndex(i => i.Id == id);
            SanalDatabase.KullaniciTaplosu[index].isim = txtİsim.Text;
            SanalDatabase.KullaniciTaplosu[index].soyisim = txtSoyİism.Text;
            SanalDatabase.KullaniciTaplosu[index].kullaniciAdi = txtKullaniciAdi.Text;
            SanalDatabase.KullaniciTaplosu[index].sifre = txtSifre.Text;
            SanalDatabase.KullaniciTaplosu[index].aciklama = txtaciklama.Text;
            MessageBox.Show("Hesaabınız Güncellendi.");
        }
    }
}
