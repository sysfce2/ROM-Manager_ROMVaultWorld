namespace ROMVault.UIElements
{
    partial class UIGameInfo
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
            gbSetInfo = new System.Windows.Forms.GroupBox();
            SuspendLayout();
            // 
            // gbSetInfo
            // 
            gbSetInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gbSetInfo.Location = new System.Drawing.Point(0, 0);
            gbSetInfo.Name = "gbSetInfo";
            gbSetInfo.Size = new System.Drawing.Size(532, 147);
            gbSetInfo.TabIndex = 5;
            gbSetInfo.TabStop = false;
            gbSetInfo.Text = "Game Info :";
            gbSetInfo.Resize += gbSetInfo_Resize;
            // 
            // GameInfo
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(gbSetInfo);
            Name = "GameInfo";
            Size = new System.Drawing.Size(532, 147);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetInfo;
    }
}
