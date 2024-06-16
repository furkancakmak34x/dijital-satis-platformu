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
using Uygulama.Model;
using static Uygulama.DAL.SabitIslemler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Uygulama
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        private void Rapor_Load(object sender, EventArgs e)
        {
            this.raporTableAdapter.Fill(this.dataset.Rapor);
            this.Icon = Properties.Resources.icon;

            if (OturumAcanKullanıcı == "Furkan Çakmak")
            {
                dgRapor.DataSource = AdminRaporla();
            }

            else
            {
                dgRapor.DataSource = Raporla();
                dgRapor.Columns[1].Visible = false;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }
    }
}

