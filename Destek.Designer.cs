namespace Uygulama
{
    partial class Destek
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgDestek = new System.Windows.Forms.DataGridView();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dataset = new Uygulama.Dataset();
            this.ıletisimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iletisimTableAdapter = new Uygulama.DatasetTableAdapters.IletisimTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kULLANICIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kONUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDestek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıletisimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(232, 485);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(332, 40);
            this.btnGeri.TabIndex = 18;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgDestek
            // 
            this.dgDestek.AllowUserToAddRows = false;
            this.dgDestek.AllowUserToDeleteRows = false;
            this.dgDestek.AllowUserToResizeColumns = false;
            this.dgDestek.AllowUserToResizeRows = false;
            this.dgDestek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgDestek.AutoGenerateColumns = false;
            this.dgDestek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDestek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgDestek.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDestek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDestek.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgDestek.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDestek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDestek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDestek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.kULLANICIDataGridViewTextBoxColumn,
            this.kONUDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dgDestek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgDestek.DataSource = this.ıletisimBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDestek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDestek.GridColor = System.Drawing.SystemColors.Control;
            this.dgDestek.Location = new System.Drawing.Point(12, 31);
            this.dgDestek.MultiSelect = false;
            this.dgDestek.Name = "dgDestek";
            this.dgDestek.ReadOnly = true;
            this.dgDestek.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDestek.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDestek.RowHeadersVisible = false;
            this.dgDestek.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgDestek.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDestek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgDestek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDestek.ShowCellErrors = false;
            this.dgDestek.ShowCellToolTips = false;
            this.dgDestek.ShowEditingIcon = false;
            this.dgDestek.ShowRowErrors = false;
            this.dgDestek.Size = new System.Drawing.Size(760, 196);
            this.dgDestek.StandardTab = true;
            this.dgDestek.TabIndex = 19;
            this.dgDestek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDestek_CellContentClick);
            this.dgDestek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDestek_CellContentClick);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKullanici.Location = new System.Drawing.Point(12, 249);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(342, 25);
            this.lblKullanici.TabIndex = 20;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // lblKonu
            // 
            this.lblKonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKonu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblKonu.Location = new System.Drawing.Point(360, 249);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(412, 25);
            this.lblKonu.TabIndex = 21;
            this.lblKonu.Text = "Konu:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.Location = new System.Drawing.Point(12, 291);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(760, 181);
            this.lblAciklama.TabIndex = 22;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıletisimBindingSource
            // 
            this.ıletisimBindingSource.DataMember = "Iletisim";
            this.ıletisimBindingSource.DataSource = this.dataset;
            // 
            // iletisimTableAdapter
            // 
            this.iletisimTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 50;
            // 
            // kULLANICIDataGridViewTextBoxColumn
            // 
            this.kULLANICIDataGridViewTextBoxColumn.DataPropertyName = "KULLANICI";
            this.kULLANICIDataGridViewTextBoxColumn.HeaderText = "KULLANICI";
            this.kULLANICIDataGridViewTextBoxColumn.Name = "kULLANICIDataGridViewTextBoxColumn";
            this.kULLANICIDataGridViewTextBoxColumn.ReadOnly = true;
            this.kULLANICIDataGridViewTextBoxColumn.Width = 111;
            // 
            // kONUDataGridViewTextBoxColumn
            // 
            this.kONUDataGridViewTextBoxColumn.DataPropertyName = "KONU";
            this.kONUDataGridViewTextBoxColumn.HeaderText = "KONU";
            this.kONUDataGridViewTextBoxColumn.Name = "kONUDataGridViewTextBoxColumn";
            this.kONUDataGridViewTextBoxColumn.ReadOnly = true;
            this.kONUDataGridViewTextBoxColumn.Width = 78;
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            this.aCIKLAMADataGridViewTextBoxColumn.ReadOnly = true;
            this.aCIKLAMADataGridViewTextBoxColumn.Width = 110;
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            this.tARIHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tARIHDataGridViewTextBoxColumn.Width = 77;
            // 
            // Destek
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.dgDestek);
            this.Controls.Add(this.btnGeri);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Destek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destek Talepleri";
            this.Load += new System.EventHandler(this.Destek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDestek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıletisimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgDestek;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblAciklama;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource ıletisimBindingSource;
        private DatasetTableAdapters.IletisimTableAdapter iletisimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kULLANICIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kONUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
    }
}

