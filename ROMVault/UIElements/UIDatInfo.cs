using RomVaultCore.RvDB;
using RVUtils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class UIDatInfo : UserControl
    {
        private float _scaleFactorX = 1;

        public UIDatInfo()
        {
            InitializeComponent();
        }

        public void UpdateDatMetaData(RvFile tDir)
        {
            lblDITName.Text = tDir.Name;


            RvDat tDat = null;
            if (tDir.Dat != null)
                tDat = tDir.Dat;
            else if (tDir.DirDatCount == 1)
                tDat = tDir.DirDat(0);

            if (tDat != null)
            {
                if (lblDITName.Text != tDat.GetData(RvDat.DatData.DatName))
                    lblDITName.Text += $":  {tDat.GetData(RvDat.DatData.DatName)}";

                string DatId = tDat.GetData(RvDat.DatData.Id);
                if (!string.IsNullOrWhiteSpace(DatId))
                    lblDITName.Text += $" (ID:{DatId})";


                lblDITDescription.Text = tDat.GetData(RvDat.DatData.Description);
                lblDITCategory.Text = tDat.GetData(RvDat.DatData.Category);
                lblDITVersion.Text = tDat.GetData(RvDat.DatData.Version);
                lblDITAuthor.Text = tDat.GetData(RvDat.DatData.Author);
                lblDITDate.Text = tDat.GetData(RvDat.DatData.Date);
                string header = tDat.GetData(RvDat.DatData.Header);
                if (!string.IsNullOrWhiteSpace(header))
                    lblDITName.Text += " (" + header + ")";

            }
            else
            {
                lblDITDescription.Text = "";
                lblDITCategory.Text = "";
                lblDITVersion.Text = "";
                lblDITAuthor.Text = "";
                lblDITDate.Text = "";
            }

            lblDITPath.Text = tDir.FullName;

            lblDITRomsGot.Text = tDir.DirStatus.CountCorrect().ToRvString();
            if (tDir.DirStatus.CountFoundMIA() > 0) { lblDITRomsGot.Text += $"  -  {tDir.DirStatus.CountFoundMIA().ToRvString()} Found MIA"; }
            lblDITRomsMissing.Text = tDir.DirStatus.CountMissing().ToRvString();
            if (tDir.DirStatus.CountMIA() > 0) { lblDITRomsMissing.Text += $"  -  {tDir.DirStatus.CountMIA().ToRvString()} MIA"; }
            lblDITRomsFixable.Text = tDir.DirStatus.CountFixesNeeded().ToRvString();
            lblDITRomsUnknown.Text = (tDir.DirStatus.CountUnknown() + tDir.DirStatus.CountInToSort()).ToRvString();
        }


        private void gbDatInfo_Resize(object sender, EventArgs e)
        {
            const int leftPos = 89;
            int rightPos = (int)(gbDatInfo.Width / _scaleFactorX) - 15;


            int width = rightPos - leftPos;
            int widthB1 = (int)((double)width * 120 / 340);
            int leftB2 = rightPos - widthB1;


            int backD = 97;

            width = (int)(width * _scaleFactorX);
            widthB1 = (int)(widthB1 * _scaleFactorX);
            leftB2 = (int)(leftB2 * _scaleFactorX);
            backD = (int)(backD * _scaleFactorX);


            lblDITName.Width = width;
            lblDITDescription.Width = width;

            lblDITCategory.Width = widthB1;
            lblDITAuthor.Width = widthB1;

            lblDIVersion.Left = leftB2 - backD;
            lblDIDate.Left = leftB2 - backD;

            lblDITVersion.Left = leftB2;
            lblDITVersion.Width = widthB1;
            lblDITDate.Left = leftB2;
            lblDITDate.Width = widthB1;

            lblDITPath.Width = width;

            lblDITRomsGot.Width = widthB1;
            lblDITRomsMissing.Width = widthB1;

            lblDIRomsFixable.Left = leftB2 - backD;
            lblDIRomsUnknown.Left = leftB2 - backD;

            lblDITRomsFixable.Left = leftB2;
            lblDITRomsFixable.Width = widthB1;
            lblDITRomsUnknown.Left = leftB2;
            lblDITRomsUnknown.Width = widthB1;
        }



        public void SetScaleFactor(SizeF factor)
        {
            _scaleFactorX *= factor.Width;
        }
    }
}
