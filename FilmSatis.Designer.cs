namespace Uygulama
{
    partial class FilmSatis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCover = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dgFilm = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fILMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yONETMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUBLAJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new Uygulama.Dataset();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.filmTableAdapter = new Uygulama.DatasetTableAdapters.FilmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
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
            this.lblCover.Text = "Film Kapağı";
            this.lblCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFilm
            // 
            this.lblFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFilm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFilm.Location = new System.Drawing.Point(305, 71);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(420, 25);
            this.lblFilm.TabIndex = 3;
            this.lblFilm.Text = "Film Adı:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.Location = new System.Drawing.Point(305, 99);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(600, 222);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Film Açıklaması:";
            // 
            // dgFilm
            // 
            this.dgFilm.AllowUserToAddRows = false;
            this.dgFilm.AllowUserToDeleteRows = false;
            this.dgFilm.AllowUserToResizeColumns = false;
            this.dgFilm.AllowUserToResizeRows = false;
            this.dgFilm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgFilm.AutoGenerateColumns = false;
            this.dgFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgFilm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgFilm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgFilm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFilm.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgFilm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.fILMDataGridViewTextBoxColumn,
            this.yONETMENDataGridViewTextBoxColumn,
            this.yILDataGridViewTextBoxColumn,
            this.tURDataGridViewTextBoxColumn,
            this.dUBLAJDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn});
            this.dgFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgFilm.DataSource = this.filmBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFilm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFilm.GridColor = System.Drawing.SystemColors.Control;
            this.dgFilm.Location = new System.Drawing.Point(30, 470);
            this.dgFilm.MultiSelect = false;
            this.dgFilm.Name = "dgFilm";
            this.dgFilm.ReadOnly = true;
            this.dgFilm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFilm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFilm.RowHeadersVisible = false;
            this.dgFilm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgFilm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFilm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFilm.ShowCellErrors = false;
            this.dgFilm.ShowCellToolTips = false;
            this.dgFilm.ShowEditingIcon = false;
            this.dgFilm.ShowRowErrors = false;
            this.dgFilm.Size = new System.Drawing.Size(900, 190);
            this.dgFilm.StandardTab = true;
            this.dgFilm.TabIndex = 5;
            this.dgFilm.Click += new System.EventHandler(this.dgFilm_Click);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 50;
            // 
            // fILMDataGridViewTextBoxColumn
            // 
            this.fILMDataGridViewTextBoxColumn.DataPropertyName = "FILM";
            this.fILMDataGridViewTextBoxColumn.HeaderText = "FILM";
            this.fILMDataGridViewTextBoxColumn.Name = "fILMDataGridViewTextBoxColumn";
            this.fILMDataGridViewTextBoxColumn.ReadOnly = true;
            this.fILMDataGridViewTextBoxColumn.Width = 69;
            // 
            // yONETMENDataGridViewTextBoxColumn
            // 
            this.yONETMENDataGridViewTextBoxColumn.DataPropertyName = "YONETMEN";
            this.yONETMENDataGridViewTextBoxColumn.HeaderText = "YONETMEN";
            this.yONETMENDataGridViewTextBoxColumn.Name = "yONETMENDataGridViewTextBoxColumn";
            this.yONETMENDataGridViewTextBoxColumn.ReadOnly = true;
            this.yONETMENDataGridViewTextBoxColumn.Width = 117;
            // 
            // yILDataGridViewTextBoxColumn
            // 
            this.yILDataGridViewTextBoxColumn.DataPropertyName = "YIL";
            this.yILDataGridViewTextBoxColumn.HeaderText = "YIL";
            this.yILDataGridViewTextBoxColumn.Name = "yILDataGridViewTextBoxColumn";
            this.yILDataGridViewTextBoxColumn.ReadOnly = true;
            this.yILDataGridViewTextBoxColumn.Width = 56;
            // 
            // tURDataGridViewTextBoxColumn
            // 
            this.tURDataGridViewTextBoxColumn.DataPropertyName = "TUR";
            this.tURDataGridViewTextBoxColumn.HeaderText = "TUR";
            this.tURDataGridViewTextBoxColumn.Name = "tURDataGridViewTextBoxColumn";
            this.tURDataGridViewTextBoxColumn.ReadOnly = true;
            this.tURDataGridViewTextBoxColumn.Width = 64;
            // 
            // dUBLAJDataGridViewTextBoxColumn
            // 
            this.dUBLAJDataGridViewTextBoxColumn.DataPropertyName = "DUBLAJ";
            this.dUBLAJDataGridViewTextBoxColumn.HeaderText = "DUBLAJ";
            this.dUBLAJDataGridViewTextBoxColumn.Name = "dUBLAJDataGridViewTextBoxColumn";
            this.dUBLAJDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUBLAJDataGridViewTextBoxColumn.Width = 91;
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            this.fIYATDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIYATDataGridViewTextBoxColumn.Width = 72;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            this.aCIKLAMADataGridViewTextBoxColumn.ReadOnly = true;
            this.aCIKLAMADataGridViewTextBoxColumn.Visible = false;
            this.aCIKLAMADataGridViewTextBoxColumn.Width = 110;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.dataset;
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
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(30, 60);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(250, 375);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 1;
            this.pbCover.TabStop = false;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // FilmSatis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.dgFilm);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lblCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "FilmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Satış";
            this.Load += new System.EventHandler(this.FilmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridView dgFilm;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSatis;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private DatasetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fILMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yONETMENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUBLAJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
    }
}

