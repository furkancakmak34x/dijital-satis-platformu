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
    public partial class Destek : Form
    {
        public Destek()
        {
            InitializeComponent();
        }

        private void Destek_Load(object sender, EventArgs e)
        {
            this.iletisimTableAdapter.Fill(this.dataset.Iletisim);
            this.Icon = Properties.Resources.icon;
            lblKullanici.Text = "Kullanıcı Adı: " + dgDestek.CurrentRow.Cells[1].Value.ToString();
            lblKonu.Text = "Konu: " + dgDestek.CurrentRow.Cells[2].Value.ToString();
            lblAciklama.Text = "Açıklama: " + dgDestek.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form frm = new AdminAnasayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void dgDestek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblKullanici.Text = "Kullanıcı Adı: " + dgDestek.CurrentRow.Cells[1].Value.ToString();
            lblKonu.Text = "Konu: " + dgDestek.CurrentRow.Cells[2].Value.ToString();
            lblAciklama.Text = "Açıklama: " + dgDestek.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
