namespace Uygulama
{
    partial class Hakkinda
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.pbHakkinda = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblSurum = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHakkinda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(640, 490);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 40);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // pbHakkinda
            // 
            this.pbHakkinda.BackgroundImage = global::Uygulama.Properties.Resources.logo;
            this.pbHakkinda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHakkinda.InitialImage = global::Uygulama.Properties.Resources.logo;
            this.pbHakkinda.Location = new System.Drawing.Point(30, 30);
            this.pbHakkinda.Name = "pbHakkinda";
            this.pbHakkinda.Size = new System.Drawing.Size(200, 200);
            this.pbHakkinda.TabIndex = 24;
            this.pbHakkinda.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(256, 30);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(282, 37);
            this.lblBaslik.TabIndex = 25;
            this.lblBaslik.Text = "Dijital Satış Platformu";
            // 
            // lblSurum
            // 
            this.lblSurum.AutoSize = true;
            this.lblSurum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSurum.Location = new System.Drawing.Point(259, 80);
            this.lblSurum.Name = "lblSurum";
            this.lblSurum.Size = new System.Drawing.Size(164, 21);
            this.lblSurum.TabIndex = 26;
            this.lblSurum.Text = "Sürüm: v0.5.2 (Alpha)";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.Location = new System.Drawing.Point(26, 509);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(209, 21);
            this.lblCopyright.TabIndex = 27;
            this.lblCopyright.Text = "®2024 Tüm Hakları Saklıdır.";
            // 
            // Hakkinda
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblSurum);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pbHakkinda);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.Name = "Hakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.Hakkinda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHakkinda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.PictureBox pbHakkinda;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSurum;
        private System.Windows.Forms.Label lblCopyright;
    }
}

