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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Uygulama.DAL.SabitIslemler;

namespace Uygulama
{
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            if (IletisimFormDenetle())
            {
                Form frm = new Destek();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Şu anda her hangi bir destek talebi mevcut değil. (Hata Kodu: 1000)", "Destek Talebi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSatisTemizle_Click(object sender, EventArgs e)
        {
            if (SatisRaporDenetle())
            {
                if (MessageBox.Show("Tüm satış raporları silinecektir. Onaylıyor musunuz?", "Satış Raporu Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Connect();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = _conn;
                        cmd.CommandText = "TRUNCATE TABLE Rapor";
                        cmd.ExecuteNonQuery();
                        Disconnect(_conn);
                        MessageBox.Show("Tüm satış raporları başarıyla temizlendi. ", "Satış Raporu Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            else
            {
                MessageBox.Show("Şu anda her hangi bir satış işlemi mevcut değil. (Hata Kodu: 1000)", "Satış Raporu Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDestekTemizle_Click(object sender, EventArgs e)
        {
            if (IletisimFormDenetle())
            {
                if (MessageBox.Show("Tüm destek talepleri silinecektir. Onaylıyor musunuz?", "Satış Raporu Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Connect();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = _conn;
                        cmd.CommandText = "TRUNCATE TABLE Iletisim";
                        cmd.ExecuteNonQuery();
                        Disconnect(_conn);
                        MessageBox.Show("Tüm destek talepleri başarıyla temizlendi. ", "Destek Talebi Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            else
            {
                MessageBox.Show("Şu anda her hangi bir destek talebi mevcut değil. (Hata Kodu: 1000)", "Destek Talebi Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu sonlandırmak istediğinizden emin misiniz?", "Oturum Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form frm = new Giris();
                this.Hide();
                frm.ShowDialog();
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
