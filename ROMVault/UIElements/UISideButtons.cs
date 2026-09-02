using System.Windows.Forms;

namespace ROMVault.UIElements
{
    public partial class UISideButtons : UserControl
    {
        public event MouseEventHandler BtnUpdateDats_MouseUp;
        public event MouseEventHandler BtnScanRoms_MouseUp;
        public event MouseEventHandler BtnFindFixes_MouseUp;
        public event MouseEventHandler BtnFixFiles_MouseUp;
        public event MouseEventHandler BtnReport_MouseUp;

        public event MouseEventHandler BtnDefault1_MouseUp;
        public event MouseEventHandler BtnDefault2_MouseUp;
        public event MouseEventHandler BtnDefault3_MouseUp;
        public event MouseEventHandler BtnDefault4_MouseUp;

        public UISideButtons()
        {
            InitializeComponent();

            SetButtonsPos();

            btnUpdateDats.BackgroundImage = rvImages.GetBitmap("btnUpdateDats_Enabled");
            btnScanRoms.BackgroundImage = rvImages.GetBitmap("btnScanRoms_Enabled");
            btnFindFixes.BackgroundImage = rvImages.GetBitmap("btnFindFixes_Enabled");
            btnFixFiles.BackgroundImage = rvImages.GetBitmap("btnFixFiles_Enabled");
            btnReport.BackgroundImage = rvImages.GetBitmap("btnReport_Enabled");

            btnDefault1.BackgroundImage = rvImages.GetBitmap("default1");
            btnDefault2.BackgroundImage = rvImages.GetBitmap("default2");
            btnDefault3.BackgroundImage = rvImages.GetBitmap("default3");
            btnDefault4.BackgroundImage = rvImages.GetBitmap("default4");


            tooltip.SetToolTip(btnDefault1, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault2, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault3, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault4, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");

            tooltip.SetToolTip(btnUpdateDats, "Left Click: Dat Update\nShift Left Click: Full Dat Rescan\n\nRight Click: Open DatVault");
            tooltip.SetToolTip(btnFixFiles, "Left Click: Fix Files\nRight Click: Scan / Find Fix / Fix");
        }

        public void Enable()
        {
            btnUpdateDats.BackgroundImage = rvImages.GetBitmap("btnUpdateDats_Enabled");
            btnScanRoms.BackgroundImage = rvImages.GetBitmap("btnScanRoms_Enabled");
            btnFindFixes.BackgroundImage = rvImages.GetBitmap("btnFindFixes_Enabled");
            btnFixFiles.BackgroundImage = rvImages.GetBitmap("btnFixFiles_Enabled");
            btnReport.BackgroundImage = rvImages.GetBitmap("btnReport_Enabled");

            btnDefault1.Enabled = true;
            btnDefault2.Enabled = true;
            btnDefault3.Enabled = true;
            btnDefault4.Enabled = true;

            btnUpdateDats.Enabled = true;
            btnScanRoms.Enabled = true;
            btnFindFixes.Enabled = true;
            btnFixFiles.Enabled = true;
            btnReport.Enabled = true;
        }
        public void Disable()
        {
            btnUpdateDats.Enabled = false;
            btnScanRoms.Enabled = false;
            btnFindFixes.Enabled = false;
            btnFixFiles.Enabled = false;
            btnReport.Enabled = false;

            btnDefault1.Enabled = false;
            btnDefault2.Enabled = false;
            btnDefault3.Enabled = false;
            btnDefault4.Enabled = false;

            btnUpdateDats.BackgroundImage = rvImages.GetBitmap("btnUpdateDats_Disabled");
            btnScanRoms.BackgroundImage = rvImages.GetBitmap("btnScanRoms_Disabled");
            btnFindFixes.BackgroundImage = rvImages.GetBitmap("btnFindFixes_Disabled");
            btnFixFiles.BackgroundImage = rvImages.GetBitmap("btnFixFiles_Disabled");
            btnReport.BackgroundImage = rvImages.GetBitmap("btnReport_Disabled");
        }

        private void btnUpdateDats_MouseUp(object sender, MouseEventArgs e)
        {
            BtnUpdateDats_MouseUp?.Invoke(sender, e);
        }

        private void btnScanRoms_MouseUp(object sender, MouseEventArgs e)
        {
            BtnScanRoms_MouseUp?.Invoke(sender, e);
        }

        private void btnFindFixes_MouseUp(object sender, MouseEventArgs e)
        {
            BtnFindFixes_MouseUp?.Invoke(sender, e);
        }

        private void btnFixFiles_MouseUp(object sender, MouseEventArgs e)
        {
            BtnFixFiles_MouseUp?.Invoke(sender, e);
        }

        private void btnReport_MouseUp(object sender, MouseEventArgs e)
        {
            BtnReport_MouseUp?.Invoke(sender, e);
        }


        private void btnDefault1_MouseUp(object sender, MouseEventArgs e)
        {
            BtnDefault1_MouseUp?.Invoke(sender, e);
        }

        private void btnDefault2_MouseUp(object sender, MouseEventArgs e)
        {
            BtnDefault2_MouseUp?.Invoke(sender, e);
        }

        private void btnDefault3_MouseUp(object sender, MouseEventArgs e)
        {
            BtnDefault3_MouseUp?.Invoke(sender, e);
        }

        private void btnDefault4_MouseUp(object sender, MouseEventArgs e)
        {
            BtnDefault4_MouseUp?.Invoke(sender, e);
        }

        private void UISideButtons_Resize(object sender, System.EventArgs e)
        {
            SetButtonsPos();
        }

        private void SetButtonsPos()
        {
            int pH = Height;
            if (pH < 550)
                pH = 550;

            lblTreePreSets.Top = pH - 98;
            btnDefault1.Top = pH - 82;
            btnDefault2.Top = pH - 82;
            btnDefault3.Top = pH - 42;
            btnDefault4.Top = pH - 42;
        }
    }
}
