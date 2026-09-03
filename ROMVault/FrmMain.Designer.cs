namespace ROMVault
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            splitToolBarMain = new System.Windows.Forms.SplitContainer();
            sideButtons = new ROMVault.UIElements.UISideButtons();
            splitDatInfoGameInfo = new System.Windows.Forms.SplitContainer();
            splitDatInfoTree = new System.Windows.Forms.SplitContainer();
            ucDatInfo = new ROMVault.UIElements.UIDatInfo();
            ctrRvTree = new ROMVault.UIElements.UITree();
            splitGameInfoLists = new System.Windows.Forms.SplitContainer();
            ctrFilter = new ROMVault.UIElements.UIFilterOptions();
            ucGameInfo = new ROMVault.UIElements.UIGameInfo();
            splitListArt = new System.Windows.Forms.SplitContainer();
            splitGameListRomList = new System.Windows.Forms.SplitContainer();
            grdGame = new ROMVault.UIElements.UIGameGrid();
            grdRom = new ROMVault.UIElements.UIRomGrid();
            sidePannel = new ROMVault.UIElements.UISidePannel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsmUpdateDATs = new System.Windows.Forms.ToolStripMenuItem();
            updateNewDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            updateAllDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmScanROMs = new System.Windows.Forms.ToolStripMenuItem();
            tsmScanLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            tsmScanLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            tsmScanLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            tsmFindFixes = new System.Windows.Forms.ToolStripMenuItem();
            FixROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fixDatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fixReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            romVaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            directoryMappingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addToSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            torrentZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            visitHelpWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            colorKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutRomVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            tooltip = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitToolBarMain).BeginInit();
            splitToolBarMain.Panel1.SuspendLayout();
            splitToolBarMain.Panel2.SuspendLayout();
            splitToolBarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitDatInfoGameInfo).BeginInit();
            splitDatInfoGameInfo.Panel1.SuspendLayout();
            splitDatInfoGameInfo.Panel2.SuspendLayout();
            splitDatInfoGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitDatInfoTree).BeginInit();
            splitDatInfoTree.Panel1.SuspendLayout();
            splitDatInfoTree.Panel2.SuspendLayout();
            splitDatInfoTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitGameInfoLists).BeginInit();
            splitGameInfoLists.Panel1.SuspendLayout();
            splitGameInfoLists.Panel2.SuspendLayout();
            splitGameInfoLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitListArt).BeginInit();
            splitListArt.Panel1.SuspendLayout();
            splitListArt.Panel2.SuspendLayout();
            splitListArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitGameListRomList).BeginInit();
            splitGameListRomList.Panel1.SuspendLayout();
            splitGameListRomList.Panel2.SuspendLayout();
            splitGameListRomList.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitToolBarMain
            // 
            splitToolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitToolBarMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitToolBarMain.IsSplitterFixed = true;
            splitToolBarMain.Location = new System.Drawing.Point(0, 24);
            splitToolBarMain.Name = "splitToolBarMain";
            // 
            // splitToolBarMain.Panel1
            // 
            splitToolBarMain.Panel1.Controls.Add(sideButtons);
            // 
            // splitToolBarMain.Panel2
            // 
            splitToolBarMain.Panel2.Controls.Add(splitDatInfoGameInfo);
            splitToolBarMain.Size = new System.Drawing.Size(1370, 725);
            splitToolBarMain.SplitterDistance = 80;
            splitToolBarMain.TabIndex = 5;
            // 
            // sideButtons
            // 
            sideButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            sideButtons.Location = new System.Drawing.Point(0, 0);
            sideButtons.MaximumSize = new System.Drawing.Size(80, 0);
            sideButtons.MinimumSize = new System.Drawing.Size(80, 0);
            sideButtons.Name = "sideButtons";
            sideButtons.Size = new System.Drawing.Size(80, 725);
            sideButtons.TabIndex = 1;
            sideButtons.BtnUpdateDats_MouseUp += sideButtons_BtnUpdateDats_MouseUp;
            sideButtons.BtnScanRoms_MouseUp += sideButtons_BtnScanRoms_MouseUp;
            sideButtons.BtnFindFixes_MouseUp += sideButtons_BtnFindFixes_MouseUp;
            sideButtons.BtnFixFiles_MouseUp += sideButtons_BtnFixFiles_MouseUp;
            sideButtons.BtnReport_MouseUp += sideButtons_BtnReport_MouseUp;
            sideButtons.BtnDefault1_MouseUp += sideButtons_BtnDefault1_MouseUp;
            sideButtons.BtnDefault2_MouseUp += sideButtons_BtnDefault2_MouseUp;
            sideButtons.BtnDefault3_MouseUp += sideButtons_BtnDefault3_MouseUp;
            sideButtons.BtnDefault4_MouseUp += sideButtons_BtnDefault4_MouseUp;
            // 
            // splitDatInfoGameInfo
            // 
            splitDatInfoGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            splitDatInfoGameInfo.Location = new System.Drawing.Point(0, 0);
            splitDatInfoGameInfo.Name = "splitDatInfoGameInfo";
            // 
            // splitDatInfoGameInfo.Panel1
            // 
            splitDatInfoGameInfo.Panel1.Controls.Add(splitDatInfoTree);
            splitDatInfoGameInfo.Panel1MinSize = 450;
            // 
            // splitDatInfoGameInfo.Panel2
            // 
            splitDatInfoGameInfo.Panel2.BackColor = System.Drawing.SystemColors.Control;
            splitDatInfoGameInfo.Panel2.Controls.Add(splitGameInfoLists);
            splitDatInfoGameInfo.Size = new System.Drawing.Size(1286, 725);
            splitDatInfoGameInfo.SplitterDistance = 520;
            splitDatInfoGameInfo.TabIndex = 0;
            // 
            // splitDatInfoTree
            // 
            splitDatInfoTree.Dock = System.Windows.Forms.DockStyle.Fill;
            splitDatInfoTree.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitDatInfoTree.IsSplitterFixed = true;
            splitDatInfoTree.Location = new System.Drawing.Point(0, 0);
            splitDatInfoTree.Name = "splitDatInfoTree";
            splitDatInfoTree.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDatInfoTree.Panel1
            // 
            splitDatInfoTree.Panel1.Controls.Add(ucDatInfo);
            splitDatInfoTree.Panel1.Resize += splitContainer3_Panel1_Resize;
            // 
            // splitDatInfoTree.Panel2
            // 
            splitDatInfoTree.Panel2.Controls.Add(ctrRvTree);
            splitDatInfoTree.Size = new System.Drawing.Size(520, 725);
            splitDatInfoTree.SplitterDistance = 148;
            splitDatInfoTree.TabIndex = 0;
            // 
            // ucDatInfo
            // 
            ucDatInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            ucDatInfo.Location = new System.Drawing.Point(0, 0);
            ucDatInfo.Name = "ucDatInfo";
            ucDatInfo.Size = new System.Drawing.Size(520, 148);
            ucDatInfo.TabIndex = 0;
            // 
            // ctrRvTree
            // 
            ctrRvTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ctrRvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            ctrRvTree.Location = new System.Drawing.Point(0, 0);
            ctrRvTree.Name = "ctrRvTree";
            ctrRvTree.Size = new System.Drawing.Size(520, 573);
            ctrRvTree.TabIndex = 2;
            ctrRvTree.RvSelected += DirTreeRvSelected;
            ctrRvTree.RvChecked += DirTreeRvChecked;
            // 
            // splitGameInfoLists
            // 
            splitGameInfoLists.Dock = System.Windows.Forms.DockStyle.Fill;
            splitGameInfoLists.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitGameInfoLists.IsSplitterFixed = true;
            splitGameInfoLists.Location = new System.Drawing.Point(0, 0);
            splitGameInfoLists.Name = "splitGameInfoLists";
            splitGameInfoLists.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGameInfoLists.Panel1
            // 
            splitGameInfoLists.Panel1.Controls.Add(ctrFilter);
            splitGameInfoLists.Panel1.Controls.Add(ucGameInfo);
            splitGameInfoLists.Panel1.Resize += splitContainer4_Panel1_Resize;
            // 
            // splitGameInfoLists.Panel2
            // 
            splitGameInfoLists.Panel2.Controls.Add(splitListArt);
            splitGameInfoLists.Size = new System.Drawing.Size(762, 725);
            splitGameInfoLists.SplitterDistance = 148;
            splitGameInfoLists.TabIndex = 0;
            // 
            // ctrFilter
            // 
            ctrFilter.Location = new System.Drawing.Point(541, 3);
            ctrFilter.Name = "ctrFilter";
            ctrFilter.Size = new System.Drawing.Size(183, 133);
            ctrFilter.TabIndex = 22;
            ctrFilter.CheckedChanged += ctrFilter_CheckedChanged;
            ctrFilter.FilterTextChanged += ctrFilter_FilterTextChanged;
            // 
            // ucGameInfo
            // 
            ucGameInfo.Location = new System.Drawing.Point(3, 0);
            ucGameInfo.Name = "ucGameInfo";
            ucGameInfo.Size = new System.Drawing.Size(532, 147);
            ucGameInfo.TabIndex = 21;
            // 
            // splitListArt
            // 
            splitListArt.Dock = System.Windows.Forms.DockStyle.Fill;
            splitListArt.Location = new System.Drawing.Point(0, 0);
            splitListArt.Name = "splitListArt";
            // 
            // splitListArt.Panel1
            // 
            splitListArt.Panel1.Controls.Add(splitGameListRomList);
            // 
            // splitListArt.Panel2
            // 
            splitListArt.Panel2.Controls.Add(sidePannel);
            splitListArt.Size = new System.Drawing.Size(762, 573);
            splitListArt.SplitterDistance = 593;
            splitListArt.TabIndex = 1;
            // 
            // splitGameListRomList
            // 
            splitGameListRomList.Dock = System.Windows.Forms.DockStyle.Fill;
            splitGameListRomList.Location = new System.Drawing.Point(0, 0);
            splitGameListRomList.Name = "splitGameListRomList";
            splitGameListRomList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGameListRomList.Panel1
            // 
            splitGameListRomList.Panel1.Controls.Add(grdGame);
            // 
            // splitGameListRomList.Panel2
            // 
            splitGameListRomList.Panel2.Controls.Add(grdRom);
            splitGameListRomList.Size = new System.Drawing.Size(593, 573);
            splitGameListRomList.SplitterDistance = 244;
            splitGameListRomList.TabIndex = 0;
            // 
            // grdGame
            // 
            grdGame.Dock = System.Windows.Forms.DockStyle.Fill;
            grdGame.Location = new System.Drawing.Point(0, 0);
            grdGame.Name = "grdGame";
            grdGame.Size = new System.Drawing.Size(593, 244);
            grdGame.TabIndex = 0;
            // 
            // grdRom
            // 
            grdRom.Dock = System.Windows.Forms.DockStyle.Fill;
            grdRom.Location = new System.Drawing.Point(0, 0);
            grdRom.Name = "grdRom";
            grdRom.Size = new System.Drawing.Size(593, 325);
            grdRom.TabIndex = 0;
            // 
            // sidePannel
            // 
            sidePannel.Dock = System.Windows.Forms.DockStyle.Fill;
            sidePannel.Location = new System.Drawing.Point(0, 0);
            sidePannel.Name = "sidePannel";
            sidePannel.Size = new System.Drawing.Size(165, 573);
            sidePannel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmUpdateDATs, tsmScanROMs, tsmFindFixes, FixROMsToolStripMenuItem, reportsToolStripMenuItem, settingsToolStripMenuItem, addToSortToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1370, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmUpdateDATs
            // 
            tsmUpdateDATs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { updateNewDATsToolStripMenuItem, updateAllDATsToolStripMenuItem });
            tsmUpdateDATs.Name = "tsmUpdateDATs";
            tsmUpdateDATs.Size = new System.Drawing.Size(86, 20);
            tsmUpdateDATs.Text = "Update DATs";
            // 
            // updateNewDATsToolStripMenuItem
            // 
            updateNewDATsToolStripMenuItem.Name = "updateNewDATsToolStripMenuItem";
            updateNewDATsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            updateNewDATsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            updateNewDATsToolStripMenuItem.Text = "Update New DATs";
            updateNewDATsToolStripMenuItem.Click += updateNewDATsToolStripMenuItem_Click;
            // 
            // updateAllDATsToolStripMenuItem
            // 
            updateAllDATsToolStripMenuItem.Name = "updateAllDATsToolStripMenuItem";
            updateAllDATsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5;
            updateAllDATsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            updateAllDATsToolStripMenuItem.Text = "Refresh All DATs";
            updateAllDATsToolStripMenuItem.Click += updateAllDATsToolStripMenuItem_Click;
            // 
            // tsmScanROMs
            // 
            tsmScanROMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmScanLevel1, tsmScanLevel2, tsmScanLevel3 });
            tsmScanROMs.Name = "tsmScanROMs";
            tsmScanROMs.Size = new System.Drawing.Size(79, 20);
            tsmScanROMs.Text = "Scan ROMs";
            // 
            // tsmScanLevel1
            // 
            tsmScanLevel1.Name = "tsmScanLevel1";
            tsmScanLevel1.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6;
            tsmScanLevel1.Size = new System.Drawing.Size(353, 22);
            tsmScanLevel1.Text = "Scan ticked new ROMs headers only";
            tsmScanLevel1.Click += TsmScanLevel1Click;
            // 
            // tsmScanLevel2
            // 
            tsmScanLevel2.Name = "tsmScanLevel2";
            tsmScanLevel2.ShortcutKeys = System.Windows.Forms.Keys.F6;
            tsmScanLevel2.Size = new System.Drawing.Size(353, 22);
            tsmScanLevel2.Text = "Scan ticked new ROMs with full hash check";
            tsmScanLevel2.Click += TsmScanLevel2Click;
            // 
            // tsmScanLevel3
            // 
            tsmScanLevel3.Name = "tsmScanLevel3";
            tsmScanLevel3.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6;
            tsmScanLevel3.Size = new System.Drawing.Size(353, 22);
            tsmScanLevel3.Text = "ReScan All ticked ROMs with full hash check";
            tsmScanLevel3.Click += TsmScanLevel3Click;
            // 
            // tsmFindFixes
            // 
            tsmFindFixes.Name = "tsmFindFixes";
            tsmFindFixes.ShortcutKeys = System.Windows.Forms.Keys.F7;
            tsmFindFixes.Size = new System.Drawing.Size(70, 20);
            tsmFindFixes.Text = "Find Fixes";
            tsmFindFixes.Click += TsmFindFixesClick;
            // 
            // FixROMsToolStripMenuItem
            // 
            FixROMsToolStripMenuItem.Name = "FixROMsToolStripMenuItem";
            FixROMsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            FixROMsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            FixROMsToolStripMenuItem.Text = "Fix ROMs";
            FixROMsToolStripMenuItem.Click += FixFilesToolStripMenuItemClick;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fixDatReportToolStripMenuItem, fullReportToolStripMenuItem, fixReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // fixDatReportToolStripMenuItem
            // 
            fixDatReportToolStripMenuItem.Name = "fixDatReportToolStripMenuItem";
            fixDatReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            fixDatReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            fixDatReportToolStripMenuItem.Text = "Fix Dat Report";
            fixDatReportToolStripMenuItem.Click += fixDatReportToolStripMenuItem_Click;
            // 
            // fullReportToolStripMenuItem
            // 
            fullReportToolStripMenuItem.Name = "fullReportToolStripMenuItem";
            fullReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9;
            fullReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            fullReportToolStripMenuItem.Text = "Full Report";
            fullReportToolStripMenuItem.Click += fullReportToolStripMenuItem_Click;
            // 
            // fixReportToolStripMenuItem
            // 
            fixReportToolStripMenuItem.Name = "fixReportToolStripMenuItem";
            fixReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9;
            fixReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            fixReportToolStripMenuItem.Text = "Fix Report";
            fixReportToolStripMenuItem.Click += fixReportToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { romVaultSettingsToolStripMenuItem, directorySettingsToolStripMenuItem, directoryMappingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // romVaultSettingsToolStripMenuItem
            // 
            romVaultSettingsToolStripMenuItem.Name = "romVaultSettingsToolStripMenuItem";
            romVaultSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            romVaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            romVaultSettingsToolStripMenuItem.Text = "RomVault Settings";
            romVaultSettingsToolStripMenuItem.Click += RomVaultSettingsToolStripMenuItem_Click;
            // 
            // directorySettingsToolStripMenuItem
            // 
            directorySettingsToolStripMenuItem.Name = "directorySettingsToolStripMenuItem";
            directorySettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10;
            directorySettingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            directorySettingsToolStripMenuItem.Text = "Directory Dat Rules";
            directorySettingsToolStripMenuItem.Click += DirectorySettingsToolStripMenuItem_Click;
            // 
            // directoryMappingsToolStripMenuItem
            // 
            directoryMappingsToolStripMenuItem.Name = "directoryMappingsToolStripMenuItem";
            directoryMappingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10;
            directoryMappingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            directoryMappingsToolStripMenuItem.Text = "Directory Mappings";
            directoryMappingsToolStripMenuItem.Click += directoryMappingsToolStripMenuItem_Click;
            // 
            // addToSortToolStripMenuItem
            // 
            addToSortToolStripMenuItem.Name = "addToSortToolStripMenuItem";
            addToSortToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            addToSortToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            addToSortToolStripMenuItem.Text = "Add ToSort";
            addToSortToolStripMenuItem.Click += AddToSortToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { torrentZipToolStripMenuItem, visitHelpWikiToolStripMenuItem, colorKeyToolStripMenuItem, whatsNewToolStripMenuItem, aboutRomVaultToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // torrentZipToolStripMenuItem
            // 
            torrentZipToolStripMenuItem.Name = "torrentZipToolStripMenuItem";
            torrentZipToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            torrentZipToolStripMenuItem.Text = "Structured Archive Maker";
            torrentZipToolStripMenuItem.Click += torrentZipToolStripMenuItem_Click;
            // 
            // visitHelpWikiToolStripMenuItem
            // 
            visitHelpWikiToolStripMenuItem.Name = "visitHelpWikiToolStripMenuItem";
            visitHelpWikiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            visitHelpWikiToolStripMenuItem.Text = "Visit Help Wiki";
            visitHelpWikiToolStripMenuItem.Click += visitHelpWikiToolStripMenuItem_Click;
            // 
            // colorKeyToolStripMenuItem
            // 
            colorKeyToolStripMenuItem.Name = "colorKeyToolStripMenuItem";
            colorKeyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            colorKeyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            colorKeyToolStripMenuItem.Text = "Icon Key";
            colorKeyToolStripMenuItem.Click += colorKeyToolStripMenuItem_Click;
            // 
            // whatsNewToolStripMenuItem
            // 
            whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            whatsNewToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            whatsNewToolStripMenuItem.Text = "Whats New";
            whatsNewToolStripMenuItem.Click += whatsNewToolStripMenuItem_Click;
            // 
            // aboutRomVaultToolStripMenuItem
            // 
            aboutRomVaultToolStripMenuItem.Name = "aboutRomVaultToolStripMenuItem";
            aboutRomVaultToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            aboutRomVaultToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            aboutRomVaultToolStripMenuItem.Text = "About RomVault";
            aboutRomVaultToolStripMenuItem.Click += AboutRomVaultToolStripMenuItemClick;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 40F;
            dataGridViewImageColumn1.HeaderText = "Type";
            dataGridViewImageColumn1.MinimumWidth = 9;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewImageColumn2.HeaderText = "ROM Status";
            dataGridViewImageColumn2.MinimumWidth = 9;
            dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            dataGridViewImageColumn2.ReadOnly = true;
            dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewImageColumn2.Width = 300;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewImageColumn3.HeaderText = "Got";
            dataGridViewImageColumn3.MinimumWidth = 9;
            dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            dataGridViewImageColumn3.ReadOnly = true;
            dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dataGridViewImageColumn3.Width = 65;
            // 
            // timer1
            // 
            timer1.Interval = 8000;
            timer1.Tick += timer1_Tick;
            // 
            // tooltip
            // 
            tooltip.AutoPopDelay = 32767;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            // 
            // FrmMain
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1370, 749);
            Controls.Add(splitToolBarMain);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "RomVault (V3.0)";
            FormClosed += FrmMain_FormClosed;
            splitToolBarMain.Panel1.ResumeLayout(false);
            splitToolBarMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitToolBarMain).EndInit();
            splitToolBarMain.ResumeLayout(false);
            splitDatInfoGameInfo.Panel1.ResumeLayout(false);
            splitDatInfoGameInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDatInfoGameInfo).EndInit();
            splitDatInfoGameInfo.ResumeLayout(false);
            splitDatInfoTree.Panel1.ResumeLayout(false);
            splitDatInfoTree.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitDatInfoTree).EndInit();
            splitDatInfoTree.ResumeLayout(false);
            splitGameInfoLists.Panel1.ResumeLayout(false);
            splitGameInfoLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitGameInfoLists).EndInit();
            splitGameInfoLists.ResumeLayout(false);
            splitListArt.Panel1.ResumeLayout(false);
            splitListArt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitListArt).EndInit();
            splitListArt.ResumeLayout(false);
            splitGameListRomList.Panel1.ResumeLayout(false);
            splitGameListRomList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitGameListRomList).EndInit();
            splitGameListRomList.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitToolBarMain;
        private System.Windows.Forms.SplitContainer splitDatInfoGameInfo;
        private System.Windows.Forms.SplitContainer splitDatInfoTree;
        private System.Windows.Forms.SplitContainer splitGameInfoLists;

        private System.Windows.Forms.SplitContainer splitGameListRomList;
        private ROMVault.UIElements.UITree ctrRvTree;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateDATs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanROMs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel1;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel3;
        private System.Windows.Forms.ToolStripMenuItem tsmFindFixes;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRomVaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FixROMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixDatReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixReportToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitListArt;
        private System.Windows.Forms.ToolStripMenuItem colorKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romVaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorySettingsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem updateNewDATsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAllDATsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitHelpWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torrentZipToolStripMenuItem;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStripMenuItem directoryMappingsToolStripMenuItem;
        private UIElements.UIDatInfo ucDatInfo;
        private UIElements.UIGameInfo ucGameInfo;
        private UIElements.UIRomGrid grdRom;
        private UIElements.UIGameGrid grdGame;

        private UIElements.UISideButtons sideButtons;
        private UIElements.UISidePannel sidePannel;
        private UIElements.UIFilterOptions ctrFilter;
    }
}

