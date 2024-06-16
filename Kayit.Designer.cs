namespace Uygulama
{
    partial class Kayit
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnUye = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Location = new System.Drawing.Point(228, 245);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 21);
            this.lblSifre.TabIndex = 22;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(228, 202);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(99, 21);
            this.lblKullanici.TabIndex = 21;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Location = new System.Drawing.Point(385, 242);
            this.txtSifre.MaxLength = 100;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.ShortcutsEnabled = false;
            this.txtSifre.Size = new System.Drawing.Size(174, 29);
            this.txtSifre.TabIndex = 20;
            this.txtSifre.WordWrap = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtKullanici.Location = new System.Drawing.Point(385, 199);
            this.txtKullanici.MaxLength = 100;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.ShortcutsEnabled = false;
            this.txtKullanici.Size = new System.Drawing.Size(174, 29);
            this.txtKullanici.TabIndex = 19;
            this.txtKullanici.WordWrap = false;
            // 
            // btnUye
            // 
            this.btnUye.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUye.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUye.Location = new System.Drawing.Point(232, 353);
            this.btnUye.Name = "btnUye";
            this.btnUye.Size = new System.Drawing.Size(332, 40);
            this.btnUye.TabIndex = 18;
            this.btnUye.Text = "Üye Ol";
            this.btnUye.UseVisualStyleBackColor = true;
            this.btnUye.Click += new System.EventHandler(this.btnUye_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(640, 490);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 40);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaat.Location = new System.Drawing.Point(40, 500);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(45, 21);
            this.lblSaat.TabIndex = 15;
            this.lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Location = new System.Drawing.Point(40, 470);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(48, 21);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(224, 75);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(335, 83);
            this.lblBaslik.TabIndex = 13;
            this.lblBaslik.Text = "Üyelik oluşturmak için gerekli yerleri doldurabilirsiniz. Üyelik işlemi tamamland" +
    "ıktan sonra oturum açabilrsiniz.";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(534, 490);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 40);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSifreTekrar.Location = new System.Drawing.Point(385, 285);
            this.txtSifreTekrar.MaxLength = 100;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '•';
            this.txtSifreTekrar.ShortcutsEnabled = false;
            this.txtSifreTekrar.Size = new System.Drawing.Size(174, 29);
            this.txtSifreTekrar.TabIndex = 24;
            this.txtSifreTekrar.WordWrap = false;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSifreTekrar.Location = new System.Drawing.Point(228, 288);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(92, 21);
            this.lblSifreTekrar.TabIndex = 25;
            this.lblSifreTekrar.Text = "Şifre Tekrar";
            // 
            // Kayit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.btnUye);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblBaslik);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Button btnUye;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label lblSifreTekrar;
    }
}

