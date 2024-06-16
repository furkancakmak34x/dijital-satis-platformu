namespace Uygulama
{
    partial class Rapor
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgRapor = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new Uygulama.Dataset();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.raporTableAdapter = new Uygulama.DatasetTableAdapters.RaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(1122, 655);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(100, 40);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgRapor
            // 
            this.dgRapor.AllowUserToAddRows = false;
            this.dgRapor.AllowUserToDeleteRows = false;
            this.dgRapor.AllowUserToResizeColumns = false;
            this.dgRapor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRapor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgRapor.AutoGenerateColumns = false;
            this.dgRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgRapor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgRapor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgRapor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgRapor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgRapor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ıDDataGridViewTextBoxColumn,
            this.mUSTERIDataGridViewTextBoxColumn,
            this.uRUNDataGridViewTextBoxColumn,
            this.tUTARDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dgRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgRapor.DataSource = this.raporBindingSource;
            this.dgRapor.GridColor = System.Drawing.SystemColors.Control;
            this.dgRapor.Location = new System.Drawing.Point(147, 179);
            this.dgRapor.MultiSelect = false;
            this.dgRapor.Name = "dgRapor";
            this.dgRapor.ReadOnly = true;
            this.dgRapor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgRapor.RowHeadersVisible = false;
            this.dgRapor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgRapor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRapor.ShowCellErrors = false;
            this.dgRapor.ShowCellToolTips = false;
            this.dgRapor.ShowEditingIcon = false;
            this.dgRapor.ShowRowErrors = false;
            this.dgRapor.Size = new System.Drawing.Size(995, 400);
            this.dgRapor.StandardTab = true;
            this.dgRapor.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 50;
            // 
            // mUSTERIDataGridViewTextBoxColumn
            // 
            this.mUSTERIDataGridViewTextBoxColumn.DataPropertyName = "MUSTERI";
            this.mUSTERIDataGridViewTextBoxColumn.HeaderText = "MUSTERI";
            this.mUSTERIDataGridViewTextBoxColumn.Name = "mUSTERIDataGridViewTextBoxColumn";
            this.mUSTERIDataGridViewTextBoxColumn.ReadOnly = true;
            this.mUSTERIDataGridViewTextBoxColumn.Width = 99;
            // 
            // uRUNDataGridViewTextBoxColumn
            // 
            this.uRUNDataGridViewTextBoxColumn.DataPropertyName = "URUN";
            this.uRUNDataGridViewTextBoxColumn.HeaderText = "URUN";
            this.uRUNDataGridViewTextBoxColumn.Name = "uRUNDataGridViewTextBoxColumn";
            this.uRUNDataGridViewTextBoxColumn.ReadOnly = true;
            this.uRUNDataGridViewTextBoxColumn.Width = 79;
            // 
            // tUTARDataGridViewTextBoxColumn
            // 
            this.tUTARDataGridViewTextBoxColumn.DataPropertyName = "TUTAR";
            this.tUTARDataGridViewTextBoxColumn.HeaderText = "TUTAR";
            this.tUTARDataGridViewTextBoxColumn.Name = "tUTARDataGridViewTextBoxColumn";
            this.tUTARDataGridViewTextBoxColumn.ReadOnly = true;
            this.tUTARDataGridViewTextBoxColumn.Width = 81;
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            this.tARIHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tARIHDataGridViewTextBoxColumn.Width = 77;
            // 
            // raporBindingSource
            // 
            this.raporBindingSource.DataMember = "Rapor";
            this.raporBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "Dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(142, 71);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1000, 60);
            this.lblBaslik.TabIndex = 33;
            this.lblBaslik.Text = "Satın almış olduğunuz ürünleri buradan kontrol edebilirsiniz. Aşağıdaki listede t" +
    "üm detaylar mevcuttur, olası bir sıkıntıda iletişim formumuzdan bize ulaşabilirs" +
    "iniz.";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raporTableAdapter
            // 
            this.raporTableAdapter.ClearBeforeFill = true;
            // 
            // Rapor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgRapor);
            this.Controls.Add(this.btnGeri);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 768);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dgRapor;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private Dataset dataset;
        private System.Windows.Forms.BindingSource raporBindingSource;
        private DatasetTableAdapters.RaporTableAdapter raporTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
    }
}

