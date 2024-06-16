namespace Uygulama
{
    partial class AlbumSatis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCover = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.dgAlbum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new Uygulama.Dataset();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.albumTableAdapter = new Uygulama.DatasetTableAdapters.AlbumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCover
            // 
            this.lblCover.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCover.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblCover.Location = new System.Drawing.Point(30, 22);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(250, 25);
            this.lblCover.TabIndex = 0;
            this.lblCover.Text = "Albüm Kapağı";
            this.lblCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAlbum
            // 
            this.lblAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlbum.Location = new System.Drawing.Point(305, 71);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(420, 25);
            this.lblAlbum.TabIndex = 3;
            this.lblAlbum.Text = "Albüm Adı:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.Location = new System.Drawing.Point(305, 99);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(600, 222);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Albüm Açıklaması:";
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(30, 71);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(250, 250);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 1;
            this.pbCover.TabStop = false;
            // 
            // dgAlbum
            // 
            this.dgAlbum.AllowUserToAddRows = false;
            this.dgAlbum.AllowUserToDeleteRows = false;
            this.dgAlbum.AllowUserToResizeColumns = false;
            this.dgAlbum.AllowUserToResizeRows = false;
            this.dgAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgAlbum.AutoGenerateColumns = false;
            this.dgAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAlbum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgAlbum.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAlbum.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgAlbum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAlbum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgAlbum.DataSource = this.albumBindingSource;
            this.dgAlbum.GridColor = System.Drawing.SystemColors.Control;
            this.dgAlbum.Location = new System.Drawing.Point(30, 372);
            this.dgAlbum.MultiSelect = false;
            this.dgAlbum.Name = "dgAlbum";
            this.dgAlbum.ReadOnly = true;
            this.dgAlbum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgAlbum.RowHeadersVisible = false;
            this.dgAlbum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgAlbum.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAlbum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlbum.ShowCellErrors = false;
            this.dgAlbum.ShowCellToolTips = false;
            this.dgAlbum.ShowEditingIcon = false;
            this.dgAlbum.ShowRowErrors = false;
            this.dgAlbum.Size = new System.Drawing.Size(780, 190);
            this.dgAlbum.StandardTab = true;
            this.dgAlbum.TabIndex = 5;
            this.dgAlbum.Click += new System.EventHandler(this.dgAlbum_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SANATCI";
            this.dataGridViewTextBoxColumn2.HeaderText = "SANATCI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 96;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ALBUM";
            this.dataGridViewTextBoxColumn3.HeaderText = "ALBUM";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 87;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "YIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "YIL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 56;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TUR";
            this.dataGridViewTextBoxColumn5.HeaderText = "TUR";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 64;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BITRATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "BITRATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 91;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FIYAT";
            this.dataGridViewTextBoxColumn7.HeaderText = "FIYAT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 72;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ACIKLAMA";
            this.dataGridViewTextBoxColumn8.HeaderText = "ACIKLAMA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstSepet
            // 
            this.lstSepet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstSepet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSepet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 21;
            this.lstSepet.Location = new System.Drawing.Point(971, 71);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(251, 168);
            this.lstSepet.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(971, 262);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(1147, 262);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTutar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(967, 311);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(255, 25);
            this.lblTutar.TabIndex = 10;
            this.lblTutar.Text = "Fiyat:";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(30, 655);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 40);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSatis.Location = new System.Drawing.Point(1122, 655);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(100, 40);
            this.btnSatis.TabIndex = 12;
            this.btnSatis.Text = "Satın Al";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // AlbumSatis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.dgAlbum);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lblCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "AlbumSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albüm Satış";
            this.Load += new System.EventHandler(this.AlbumSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridView dgAlbum;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSatis;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private DatasetTableAdapters.AlbumTableAdapter albumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

