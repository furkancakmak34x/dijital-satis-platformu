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
using System.Security.Policy;

namespace Uygulama
{
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }
        private void Iletisim_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            lblKullanici.Text = "Kullanıcı Adı: " + OturumAcanKullanıcı;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            Form frm = new Hakkinda();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKonu.Text) || string.IsNullOrEmpty(txtAciklama.Text))
            {
                MessageBox.Show("Konu ya da açıklama kısmı boş bırakılamaz. (Hata Kodu: 1000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (MessageBox.Show("Form gönderilecektir. Onaylıyor musunuz?", "Destek", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string kullanici = OturumAcanKullanıcı;
                    string konu = txtKonu.Text;
                    string aciklama = txtAciklama.Text;

                    try
                    {
                        Connect();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = _conn;
                        cmd.Parameters.AddWithValue("@kullanici", kullanici);
                        cmd.Parameters.AddWithValue("@konu", konu);
                        cmd.Parameters.AddWithValue("@aciklama", aciklama);
                        cmd.Parameters.AddWithValue("@tarih", TarihSaat);
                        cmd.CommandText = "INSERT INTO Iletisim (KULLANICI, KONU, ACIKLAMA, TARIH) VALUES (@kullanici, @konu, @aciklama, @tarih)";
                        cmd.ExecuteNonQuery();
                        Disconnect(_conn);

                        MessageBox.Show("Destek talebiniz başarıyla alınmıştır. İyi günler dileriz.", "Destek Talebi Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
