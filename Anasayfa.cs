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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            this.Icon = Properties.Resources.icon;

            if (OturumAcanKullanıcı == "Furkan Çakmak")
            {
                lblKullanici.Text = "Hoşgeldiniz " + OturumAcanKullanıcı;
                btnAdmin.Enabled = true;
            }
            else
            {
                lblKullanici.Text = "Hoşgeldiniz " + OturumAcanKullanıcı + ". Keyifli alışverişler dileriz.";
                btnAdmin.Hide();
            }
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Start();
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Form frm = new KitapSatis();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            Form frm = new FilmSatis();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            Form frm = new Iletisim();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Form frm = new AlbumSatis();
            this.Hide();
            frm.ShowDialog();
        }


        private void btnRapor_Click(object sender, EventArgs e)
        {
            Form frm = new Rapor();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form frm = new AdminAnasayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu sonlandırmak istediğinizden emin misiniz?", "Oturum Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form frm = new Giris();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
