namespace Uygulama
{
    partial class Iletisim
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
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnHakkinda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKonu.Location = new System.Drawing.Point(35, 200);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(48, 21);
            this.lblKonu.TabIndex = 22;
            this.lblKonu.Text = "Konu";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(35, 146);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(103, 21);
            this.lblKullanici.TabIndex = 21;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // txtKonu
            // 
            this.txtKonu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtKonu.Location = new System.Drawing.Point(102, 197);
            this.txtKonu.MaxLength = 50;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.ShortcutsEnabled = false;
            this.txtKonu.Size = new System.Drawing.Size(174, 29);
            this.txtKonu.TabIndex = 20;
            this.txtKonu.WordWrap = false;
            // 
            // btnGonder
            // 
            this.btnGonder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGonder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGonder.Location = new System.Drawing.Point(640, 193);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 40);
            this.btnGonder.TabIndex = 17;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(40, 37);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(700, 83);
            this.lblBaslik.TabIndex = 13;
            this.lblBaslik.Text = "Şikayetleriniz ve diğer geribildirimleriniz için bize buradan ulaşabilirsiniz. Gö" +
    "rüşleriniz ve fikirleriniz bizim için önemlidir.";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(39, 490);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 40);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtAciklama.Location = new System.Drawing.Point(39, 261);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ShortcutsEnabled = false;
            this.txtAciklama.Size = new System.Drawing.Size(701, 199);
            this.txtAciklama.TabIndex = 25;
            this.txtAciklama.WordWrap = false;
            // 
            // btnHakkinda
            // 
            this.btnHakkinda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHakkinda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnHakkinda.Location = new System.Drawing.Point(640, 490);
            this.btnHakkinda.Name = "btnHakkinda";
            this.btnHakkinda.Size = new System.Drawing.Size(100, 40);
            this.btnHakkinda.TabIndex = 26;
            this.btnHakkinda.Text = "Hakkında";
            this.btnHakkinda.UseVisualStyleBackColor = true;
            this.btnHakkinda.Click += new System.EventHandler(this.btnHakkinda_Click);
            // 
            // Iletisim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHakkinda);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.lblBaslik);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Iletisim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İletişim";
            this.Load += new System.EventHandler(this.Iletisim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnHakkinda;
    }
}

