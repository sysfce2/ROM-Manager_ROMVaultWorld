namespace ROMVault.UIElements
{
    partial class UIRomGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            RomGrid = new System.Windows.Forms.DataGridView();
            CGot = new System.Windows.Forms.DataGridViewImageColumn();
            CRom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CMerge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CCRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CAltSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CAltCRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CAltSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CAltMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CFileModDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CZipIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CInstanceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)RomGrid).BeginInit();
            SuspendLayout();
            // 
            // RomGrid
            // 
            RomGrid.AllowUserToAddRows = false;
            RomGrid.AllowUserToDeleteRows = false;
            RomGrid.AllowUserToResizeRows = false;
            RomGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CGot, CRom, CMerge, CSize, CCRC32, CSHA1, CMD5, CAltSize, CAltCRC32, CAltSHA1, CAltMD5, CStatus, CFileModDate, CZipIndex, CInstanceCount });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            RomGrid.DefaultCellStyle = dataGridViewCellStyle2;
            RomGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            RomGrid.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            RomGrid.Location = new System.Drawing.Point(0, 0);
            RomGrid.MultiSelect = false;
            RomGrid.Name = "RomGrid";
            RomGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            RomGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RomGrid.RowHeadersVisible = false;
            RomGrid.RowHeadersWidth = 72;
            RomGrid.RowTemplate.Height = 19;
            RomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            RomGrid.ShowCellErrors = false;
            RomGrid.ShowEditingIcon = false;
            RomGrid.ShowRowErrors = false;
            RomGrid.Size = new System.Drawing.Size(592, 372);
            RomGrid.TabIndex = 22;
            RomGrid.VirtualMode = true;
            RomGrid.CellFormatting += RomGridCellFormatting;
            RomGrid.CellValueNeeded += RomGridCellValueNeeded;
            RomGrid.ColumnHeaderMouseClick += RomGridColumnHeaderMouseClick;
            RomGrid.DataError += RomGrid_DataError;
            RomGrid.SelectionChanged += RomGridSelectionChanged;
            RomGrid.MouseUp += RomGridMouseUp;
            // 
            // CGot
            // 
            CGot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            CGot.HeaderText = "Got";
            CGot.MinimumWidth = 9;
            CGot.Name = "CGot";
            CGot.ReadOnly = true;
            CGot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            CGot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CGot.Width = 65;
            // 
            // CRom
            // 
            CRom.HeaderText = "ROM (File)";
            CRom.MinimumWidth = 9;
            CRom.Name = "CRom";
            CRom.ReadOnly = true;
            CRom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CRom.Width = 150;
            // 
            // CMerge
            // 
            CMerge.HeaderText = "Merge";
            CMerge.MinimumWidth = 9;
            CMerge.Name = "CMerge";
            CMerge.ReadOnly = true;
            CMerge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CMerge.Width = 60;
            // 
            // CSize
            // 
            CSize.HeaderText = "Size";
            CSize.MinimumWidth = 9;
            CSize.Name = "CSize";
            CSize.ReadOnly = true;
            CSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CSize.Width = 60;
            // 
            // CCRC32
            // 
            CCRC32.HeaderText = "CRC32";
            CCRC32.MinimumWidth = 9;
            CCRC32.Name = "CCRC32";
            CCRC32.ReadOnly = true;
            CCRC32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CCRC32.Width = 175;
            // 
            // CSHA1
            // 
            CSHA1.HeaderText = "SHA1";
            CSHA1.MinimumWidth = 9;
            CSHA1.Name = "CSHA1";
            CSHA1.ReadOnly = true;
            CSHA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CSHA1.Width = 150;
            // 
            // CMD5
            // 
            CMD5.HeaderText = "MD5";
            CMD5.MinimumWidth = 9;
            CMD5.Name = "CMD5";
            CMD5.ReadOnly = true;
            CMD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CMD5.Width = 150;
            // 
            // CAltSize
            // 
            CAltSize.HeaderText = "AltSize";
            CAltSize.MinimumWidth = 9;
            CAltSize.Name = "CAltSize";
            CAltSize.ReadOnly = true;
            CAltSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CAltSize.Visible = false;
            CAltSize.Width = 60;
            // 
            // CAltCRC32
            // 
            CAltCRC32.HeaderText = "AltCRC32";
            CAltCRC32.MinimumWidth = 9;
            CAltCRC32.Name = "CAltCRC32";
            CAltCRC32.ReadOnly = true;
            CAltCRC32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CAltCRC32.Visible = false;
            CAltCRC32.Width = 175;
            // 
            // CAltSHA1
            // 
            CAltSHA1.HeaderText = "AltSHA1";
            CAltSHA1.MinimumWidth = 9;
            CAltSHA1.Name = "CAltSHA1";
            CAltSHA1.ReadOnly = true;
            CAltSHA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CAltSHA1.Visible = false;
            CAltSHA1.Width = 150;
            // 
            // CAltMD5
            // 
            CAltMD5.HeaderText = "AltMD5";
            CAltMD5.MinimumWidth = 9;
            CAltMD5.Name = "CAltMD5";
            CAltMD5.ReadOnly = true;
            CAltMD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CAltMD5.Visible = false;
            CAltMD5.Width = 150;
            // 
            // CStatus
            // 
            CStatus.HeaderText = "Status";
            CStatus.MinimumWidth = 9;
            CStatus.Name = "CStatus";
            CStatus.ReadOnly = true;
            CStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CStatus.Width = 175;
            // 
            // CFileModDate
            // 
            CFileModDate.HeaderText = "Modified Date/Time";
            CFileModDate.MinimumWidth = 9;
            CFileModDate.Name = "CFileModDate";
            CFileModDate.ReadOnly = true;
            CFileModDate.Width = 175;
            // 
            // CZipIndex
            // 
            CZipIndex.HeaderText = "ZipIndex";
            CZipIndex.MinimumWidth = 9;
            CZipIndex.Name = "CZipIndex";
            CZipIndex.ReadOnly = true;
            CZipIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CZipIndex.Width = 175;
            // 
            // CInstanceCount
            // 
            CInstanceCount.HeaderText = "Instance Count";
            CInstanceCount.MinimumWidth = 6;
            CInstanceCount.Name = "CInstanceCount";
            CInstanceCount.ReadOnly = true;
            CInstanceCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CInstanceCount.Width = 125;
            // 
            // RomGird
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(RomGrid);
            Name = "RomGird";
            Size = new System.Drawing.Size(592, 372);
            ((System.ComponentModel.ISupportInitialize)RomGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView RomGrid;
        private System.Windows.Forms.DataGridViewImageColumn CGot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltCRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFileModDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZipIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstanceCount;
    }
}
