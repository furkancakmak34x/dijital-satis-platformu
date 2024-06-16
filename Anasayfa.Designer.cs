namespace Uygulama
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnIletisim = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnOturum = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(224, 75);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(335, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Dijital Satış Platformu";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Location = new System.Drawing.Point(40, 470);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(48, 21);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaat.Location = new System.Drawing.Point(40, 500);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(45, 21);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "Saat:";
            // 
            // btnKitap
            // 
            this.btnKitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKitap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKitap.Location = new System.Drawing.Point(512, 225);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(140, 50);
            this.btnKitap.TabIndex = 3;
            this.btnKitap.Text = "Kitap Satış";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilm.Location = new System.Drawing.Point(322, 225);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(140, 50);
            this.btnFilm.TabIndex = 4;
            this.btnFilm.Text = "Film Satış";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnIletisim
            // 
            this.btnIletisim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIletisim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIletisim.Location = new System.Drawing.Point(136, 325);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(140, 50);
            this.btnIletisim.TabIndex = 5;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.UseVisualStyleBackColor = true;
            this.btnIletisim.Click += new System.EventHandler(this.btnIletisim_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlbum.Location = new System.Drawing.Point(136, 225);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(140, 50);
            this.btnAlbum.TabIndex = 6;
            this.btnAlbum.Text = "Albüm Satış";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnOturum
            // 
            this.btnOturum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOturum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOturum.Location = new System.Drawing.Point(322, 325);
            this.btnOturum.Name = "btnOturum";
            this.btnOturum.Size = new System.Drawing.Size(140, 50);
            this.btnOturum.TabIndex = 7;
            this.btnOturum.Text = "Oturumu Kapat";
            this.btnOturum.UseVisualStyleBackColor = true;
            this.btnOturum.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRapor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRapor.Location = new System.Drawing.Point(512, 325);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(140, 50);
            this.btnRapor.TabIndex = 8;
            this.btnRapor.Text = "Satış Raporları";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(132, 144);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(520, 64);
            this.lblKullanici.TabIndex = 9;
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.Location = new System.Drawing.Point(512, 470);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(140, 50);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Yönetim Paneli";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnOturum);
            this.Controls.Add(this.btnAlbum);
            this.Controls.Add(this.btnIletisim);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Anasayfa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijital Satış Platformu";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnIletisim;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnOturum;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnAdmin;
    }
}

