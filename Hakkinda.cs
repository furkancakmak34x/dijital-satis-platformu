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
using Uygulama.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Uygulama.DAL.SabitIslemler;

namespace Uygulama
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void Hakkinda_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
