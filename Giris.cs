using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulama.DAL;
using static Uygulama.DAL.SabitIslemler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Uygulama
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            this.Icon = Properties.Resources.icon;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Start();
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullanici.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ya da şifre kısmı boş bırakılamaz. (Hata Kodu: 1000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                if (OturumAc(kullanici, sifre))
                {
                    if (kullanici == "Furkan Çakmak")
                    {
                        MessageBox.Show("Oturum Açma Başarılı! Hoşgeldiniz " + kullanici + ".", " Oturum Açılıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OturumAcanKullanıcı = kullanici;
                        Form frm = new AdminAnasayfa();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Oturum Açma Başarılı! Hoşgeldiniz " + kullanici + ".", " Oturum Açılıyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OturumAcanKullanıcı = kullanici;
                        Form frm = new Anasayfa();
                        this.Hide();
                        frm.ShowDialog();
                    }
                }
                
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifrenizi yanlış girdiniz. Tekrar deneyin ya da yeni bir üyelik oluşturun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            Form frm = new Kayit();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış işlemini onaylıyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
