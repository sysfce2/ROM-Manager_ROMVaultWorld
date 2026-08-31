namespace ROMVault.UIElements
{
    partial class UIGameGrid
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
            GameGrid = new System.Windows.Forms.DataGridView();
            CType = new System.Windows.Forms.DataGridViewImageColumn();
            CGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CROMStatus = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)GameGrid).BeginInit();
            SuspendLayout();
            // 
            // GameGrid
            // 
            GameGrid.AllowUserToAddRows = false;
            GameGrid.AllowUserToDeleteRows = false;
            GameGrid.AllowUserToResizeRows = false;
            GameGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GameGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { CType, CGame, CDescription, CDateTime, CROMStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            GameGrid.DefaultCellStyle = dataGridViewCellStyle2;
            GameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            GameGrid.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            GameGrid.Location = new System.Drawing.Point(0, 0);
            GameGrid.MultiSelect = false;
            GameGrid.Name = "GameGrid";
            GameGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GameGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GameGrid.RowHeadersVisible = false;
            GameGrid.RowHeadersWidth = 72;
            GameGrid.RowTemplate.Height = 19;
            GameGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            GameGrid.ShowCellErrors = false;
            GameGrid.ShowCellToolTips = false;
            GameGrid.ShowEditingIcon = false;
            GameGrid.ShowRowErrors = false;
            GameGrid.Size = new System.Drawing.Size(697, 411);
            GameGrid.TabIndex = 5;
            GameGrid.VirtualMode = true;
            GameGrid.CellFormatting += GameGridCellFormatting;
            GameGrid.CellValueNeeded += GameGridCellValueNeeded;
            GameGrid.ColumnHeaderMouseClick += GameGridColumnHeaderMouseClick;
            GameGrid.DataError += GameGrid_DataError;
            GameGrid.SelectionChanged += GameGridSelectionChanged;
            GameGrid.MouseDoubleClick += GameGridMouseDoubleClick;
            GameGrid.MouseUp += GameGridMouseUp;
            // 
            // CType
            // 
            CType.FillWeight = 40F;
            CType.HeaderText = "Type";
            CType.MinimumWidth = 9;
            CType.Name = "CType";
            CType.ReadOnly = true;
            CType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CType.Width = 40;
            // 
            // CGame
            // 
            CGame.HeaderText = "Game (Directory / Zip)";
            CGame.MinimumWidth = 9;
            CGame.Name = "CGame";
            CGame.ReadOnly = true;
            CGame.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CGame.Width = 220;
            // 
            // CDescription
            // 
            CDescription.HeaderText = "Description";
            CDescription.MinimumWidth = 9;
            CDescription.Name = "CDescription";
            CDescription.ReadOnly = true;
            CDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CDescription.Width = 220;
            // 
            // CDateTime
            // 
            CDateTime.HeaderText = "Modified";
            CDateTime.MinimumWidth = 8;
            CDateTime.Name = "CDateTime";
            CDateTime.ReadOnly = true;
            CDateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            CDateTime.Width = 150;
            // 
            // CROMStatus
            // 
            CROMStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            CROMStatus.FillWeight = 450F;
            CROMStatus.HeaderText = "ROM Status";
            CROMStatus.MinimumWidth = 200;
            CROMStatus.Name = "CROMStatus";
            CROMStatus.ReadOnly = true;
            CROMStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UIGameGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(GameGrid);
            Name = "UIGameGrid";
            Size = new System.Drawing.Size(697, 411);
            ((System.ComponentModel.ISupportInitialize)GameGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.DataGridViewImageColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDateTime;
        private System.Windows.Forms.DataGridViewImageColumn CROMStatus;
    }
}
