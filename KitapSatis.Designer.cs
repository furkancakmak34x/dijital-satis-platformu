namespace Uygulama
{
    partial class KitapSatis
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
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.dgKitap = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kITAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yAZARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yAYINEVIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new Uygulama.Dataset();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.kitapTableAdapter = new Uygulama.DatasetTableAdapters.KitapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
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
            this.lblCover.Text = "Kitap Kapağı";
            this.lblCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKitap
            // 
            this.lblKitap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKitap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKitap.Location = new System.Drawing.Point(305, 71);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(420, 25);
            this.lblKitap.TabIndex = 3;
            this.lblKitap.Text = "Kitap Adı:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.Location = new System.Drawing.Point(305, 99);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(600, 222);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Kitap Açıklaması:";
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
            // dgKitap
            // 
            this.dgKitap.AllowUserToAddRows = false;
            this.dgKitap.AllowUserToDeleteRows = false;
            this.dgKitap.AllowUserToResizeColumns = false;
            this.dgKitap.AllowUserToResizeRows = false;
            this.dgKitap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgKitap.AutoGenerateColumns = false;
            this.dgKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKitap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgKitap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgKitap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgKitap.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgKitap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKitap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kITAPDataGridViewTextBoxColumn,
            this.yAZARDataGridViewTextBoxColumn,
            this.yILDataGridViewTextBoxColumn,
            this.tURDataGridViewTextBoxColumn,
            this.yAYINEVIDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn});
            this.dgKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgKitap.DataSource = this.kitapBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKitap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgKitap.GridColor = System.Drawing.SystemColors.Control;
            this.dgKitap.Location = new System.Drawing.Point(30, 470);
            this.dgKitap.MultiSelect = false;
            this.dgKitap.Name = "dgKitap";
            this.dgKitap.ReadOnly = true;
            this.dgKitap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKitap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgKitap.RowHeadersVisible = false;
            this.dgKitap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgKitap.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgKitap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKitap.ShowCellErrors = false;
            this.dgKitap.ShowCellToolTips = false;
            this.dgKitap.ShowEditingIcon = false;
            this.dgKitap.ShowRowErrors = false;
            this.dgKitap.Size = new System.Drawing.Size(780, 190);
            this.dgKitap.StandardTab = true;
            this.dgKitap.TabIndex = 5;
            this.dgKitap.Click += new System.EventHandler(this.dgKitap_Click);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 50;
            // 
            // kITAPDataGridViewTextBoxColumn
            // 
            this.kITAPDataGridViewTextBoxColumn.DataPropertyName = "KITAP";
            this.kITAPDataGridViewTextBoxColumn.HeaderText = "KITAP";
            this.kITAPDataGridViewTextBoxColumn.Name = "kITAPDataGridViewTextBoxColumn";
            this.kITAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.kITAPDataGridViewTextBoxColumn.Width = 74;
            // 
            // yAZARDataGridViewTextBoxColumn
            // 
            this.yAZARDataGridViewTextBoxColumn.DataPropertyName = "YAZAR";
            this.yAZARDataGridViewTextBoxColumn.HeaderText = "YAZAR";
            this.yAZARDataGridViewTextBoxColumn.Name = "yAZARDataGridViewTextBoxColumn";
            this.yAZARDataGridViewTextBoxColumn.ReadOnly = true;
            this.yAZARDataGridViewTextBoxColumn.Width = 82;
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
            // yAYINEVIDataGridViewTextBoxColumn
            // 
            this.yAYINEVIDataGridViewTextBoxColumn.DataPropertyName = "YAYINEVI";
            this.yAYINEVIDataGridViewTextBoxColumn.HeaderText = "YAYINEVI";
            this.yAYINEVIDataGridViewTextBoxColumn.Name = "yAYINEVIDataGridViewTextBoxColumn";
            this.yAYINEVIDataGridViewTextBoxColumn.ReadOnly = true;
            this.yAYINEVIDataGridViewTextBoxColumn.Width = 99;
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
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.dataset;
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
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // KitapSatis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.dgKitap);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.lblCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "KitapSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Satış";
            this.Load += new System.EventHandler(this.KitapSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridView dgKitap;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnSatis;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private DatasetTableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kITAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yAZARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yAYINEVIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
    }
}

