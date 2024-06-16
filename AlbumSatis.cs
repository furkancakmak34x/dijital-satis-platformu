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
    public partial class AlbumSatis : Form
    {
        public AlbumSatis()
        {
            InitializeComponent();
        }

        private void AlbumSatis_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            this.albumTableAdapter.Fill(this.dataset.Album);
            lblAlbum.Text = "Albüm Adı: " + dgAlbum.CurrentRow.Cells[2].Value.ToString();
            lblAciklama.Text = "Albüm Açıklaması: " + dgAlbum.CurrentRow.Cells[7].Value.ToString();
            pbCover.Image = Properties.Resources.theslowrush;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (lstSepet.Items.Contains(dgAlbum.CurrentRow.Cells[2].Value.ToString())) 
            {
                MessageBox.Show("Ürün zaten sepette mevcut. (Hata Kodu: 1010)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
            }

            else
            {
                lstSepet.Items.Add(dgAlbum.CurrentRow.Cells[2].Value.ToString());
                Fiyat += Convert.ToInt32(dgAlbum.CurrentRow.Cells[6].Value);
                lblTutar.Text = "Fiyat: " + Fiyat.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedIndex == -1)
            {
                MessageBox.Show("Önce sepetten bir ürün seçmelisiniz. (Hata Kodu: 1000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
            else if (lstSepet.SelectedItem.ToString() == "The Slow Rush")
            {
                Fiyat -= 299;
            }

            else if (lstSepet.SelectedItem.ToString() == "HEROES & VILLAINS")
            {
                Fiyat -= 199;
            }

            else if (lstSepet.SelectedItem.ToString() == "My Beautiful Dark Twisted Fantasy")
            {   
                Fiyat -= 299;
            }   

            else if (lstSepet.SelectedItem.ToString() == "good kid, m.A.A.d city (Deluxe)")
            {
                Fiyat -= 329;
            }

            else if (lstSepet.SelectedItem.ToString() == "A Great Chaos")
            {
                Fiyat -= 199;
            }

            lstSepet.Items.Remove(lstSepet.SelectedItem);
            lblTutar.Text = "Fiyat: " + Fiyat.ToString();
            
            if (lstSepet.SelectedIndex == -1 && lstSepet.Items.Count > 0)
            {
                lstSepet.SelectedIndex = 0;
            }
        }

        private void dgAlbum_Click(object sender, EventArgs e)
        {
            lblAlbum.Text = "Albüm Adı: " + dgAlbum.CurrentRow.Cells[2].Value.ToString();
            lblAciklama.Text = "Albüm Açıklaması: " + dgAlbum.CurrentRow.Cells[7].Value.ToString();
            lstSepet.SelectedItem = dgAlbum.SelectedRows[0];

            if (Convert.ToInt32(dgAlbum.CurrentRow.Cells[0].Value) == 1)
            {
                pbCover.Image = Properties.Resources.theslowrush;
            }

            else if (Convert.ToInt32(dgAlbum.CurrentRow.Cells[0].Value) == 2)
            {
                pbCover.Image = Properties.Resources.heroes;
            }

            else if (Convert.ToInt32(dgAlbum.CurrentRow.Cells[0].Value) == 3)
            {
                pbCover.Image = Properties.Resources.mbdtf;
            }

            else if (Convert.ToInt32(dgAlbum.CurrentRow.Cells[0].Value) == 4)
            {
                pbCover.Image = Properties.Resources.gkmc;
            }

            else if (Convert.ToInt32(dgAlbum.CurrentRow.Cells[0].Value) == 5)
            {
                pbCover.Image = Properties.Resources.agc;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Fiyat = 0;
            Form frm = new Anasayfa();
            this.Hide();
            frm.ShowDialog();
        }
        private string[] Sepet()
        {
            string[] sepetIcerik = new string[lstSepet.Items.Count];

            for (int i = 0; i < lstSepet.Items.Count; i++)
            {
                sepetIcerik[i] = lstSepet.Items[i].ToString();
            }

            return sepetIcerik;
        }

        private string SepetOlustur()
        {
            string[] sepetIcerik = Sepet();
            string sepet = "";

            foreach (string item in sepetIcerik)
            {
                sepet += item + " - ";
            }

            sepet = sepet.TrimEnd(' ');
            sepet = sepet.TrimEnd('-');
            sepet = sepet.TrimEnd(' ');
            return sepet;
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş, satın alma işlemi için öncelikle sepete ürün ekleyin. (Hata Kodu: 1000)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (MessageBox.Show("Seçili ürünler satın alınacaktır. Onaylıyor musunuz?", "Satın Alma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Connect();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = _conn;
                        cmd.Parameters.AddWithValue("@musteri", OturumAcanKullanıcı);
                        cmd.Parameters.AddWithValue("@fiyat", Fiyat);
                        cmd.Parameters.AddWithValue("@sepet", SepetOlustur());
                        cmd.Parameters.AddWithValue("@tarih", TarihSaat); 
                        cmd.CommandText = "INSERT INTO Rapor (MUSTERI, URUN, TUTAR, TARIH) VALUES (@musteri, @sepet, @fiyat, @tarih)";
                        cmd.ExecuteNonQuery();
                        Disconnect(_conn);

                        MessageBox.Show("Seçili ürünler başarıyla satın alındı.", "Satış Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Fiyat = 0;
                        Form frm = new Anasayfa();
                        this.Hide();
                        frm.ShowDialog();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata Kodu: 1015", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Disconnect(_conn);
                    }
                }

                else
                {
                    MessageBox.Show("İşlem iptal edildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Disconnect(_conn);
                }
            }
        }
    }
}
