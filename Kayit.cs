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
using Uygulama.Model;

namespace Uygulama
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void Kayit_Load(object sender, EventArgs e)
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

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form frm = new Giris();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnUye_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanici.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtSifreTekrar.Text))
            {
                MessageBox.Show("Kullanıcı adı ya da şifre kısmı boş bırakılamaz. (Hata Kodu: 1000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Girilen şifreler aynı değil, tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (KullaniciDenetle(txtKullanici.Text))
            {
                MessageBox.Show("Bu kullanıcı zaten mevcut, başka bir kullanıcı adı ile tekrar deneyin. (Hata Kodu: 1010)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show("Üyelik oluşturulacaktır. Onaylıyor musunuz?", "Üyelik İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kullanici = txtKullanici.Text;
                string sifre = txtSifre.Text;

                try
                {
                    Connect();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _conn;
                    cmd.Parameters.AddWithValue("@kullanici", kullanici);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    cmd.CommandText = "INSERT INTO Musteri (KULLANICI, SIFRE) VALUES (@kullanici, @sifre)";
                    cmd.ExecuteNonQuery();
                    Disconnect(_conn);

                    MessageBox.Show("Üyelik işleminiz başarıyla tamamlanmıştır. Giriş sayfasına yönlendiriliyorsunuz...", "Üyelik Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form frm = new Giris();
                    this.Hide();
                    frm.ShowDialog();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Üyelik işlemi iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
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
