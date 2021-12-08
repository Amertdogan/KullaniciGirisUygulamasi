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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text;
            string sifre = txtKullaniciSifresi.Text;

            Kulanici bulunanKullanici = SanalDatabase.KullaniciTaplosu.Find(i => i.kullaniciAdi == kullaniciadi && i.sifre == sifre);

            //kullaniciAdi="admin" && sifre="123"

            if (bulunanKullanici!=null)
            {
                AnaForm _anaForm = new AnaForm(bulunanKullanici);
                _anaForm.Show();
            }
            else
            {
                //windowa form içerisinde nasıl kullanıcıya bir popup gösteririz bunu çok ufak bir şekilde inceleyelim.
                MessageBox.Show("Hatali kullanici bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }

        private void txtKullaniciSifresi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Blue;
        }

        private void txtKullaniciSifresi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
