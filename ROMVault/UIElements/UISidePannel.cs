using RomVaultCore;
using RomVaultCore.RvDB;
using RVIO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROMVault.UIElements
{
    public partial class UISidePannel : UserControl
    {

        public delegate void ShowSide(bool visible);

        public ShowSide DisplaySide;

        public UISidePannel()
        {
            InitializeComponent();

            ShowPannel(false);

            tabArtWork_Resize(null, new EventArgs());
            tabMedium_Resize(null, new EventArgs());
            tabScreens_Resize(null, new EventArgs());
        }


        public void SetDefaults(defaults defaults)
        {
            if (defaults.nfo_FontSize != int.MinValue) trbFontSize.Value = defaults.nfo_FontSize;
        }

        public void PutDefaults(defaults defaults)
        {
            defaults.nfo_FontSize = trbFontSize.Value;
        }

        public void UpdateSidePannel(RvFile tGame)
        {

            if (tGame?.Game != null)
            {

                bool found = false;
                string path = tGame.Parent.DatTreeFullName;
                foreach (EmulatorInfo ei in Settings.rvSettings.EInfo)
                {
                    if (path.Length <= 8)
                        continue;

                    if (!string.Equals(path.Substring(8), ei.TreeDir, StringComparison.CurrentCultureIgnoreCase))
                        continue;

                    if (string.IsNullOrWhiteSpace(ei.ExtraPath))
                        continue;

                    if (ei.ExtraPath != null)
                    {
                        found = true;
                        if (ei.ExtraPath.Substring(0, 1) == "%")
                            LoadMameSLPannels(tGame, ei.ExtraPath.Substring(1));
                        else
                            LoadMamePannels(tGame, ei.ExtraPath);

                        break;
                    }
                }

                if (!found)
                    found = LoadNFOPannel(tGame);

                if (!found)
                    found = LoadC64Pannel(tGame);

                if (!found)
                    HidePannel();

            }

            else
            {
                HidePannel();
            }
        }

        private void ShowPannel(bool show)
        {
            DisplaySide?.Invoke(show);
        }

        private void HidePannel()
        {
            ShowPannel(false);

            picArtwork.ClearImage();
            picLogo.ClearImage();
            picMedium1.ClearImage();
            picMedium2.ClearImage();
            picScreenTitle.ClearImage();
            picScreenShot.ClearImage();
            txtInfo.ClearText();
            txtInfo2.ClearText();
        }

        private void tabArtWork_Resize(object sender, EventArgs e)
        {
            int imageWidth = tabArtWork.Width - 20;
            if (imageWidth < 2)
                imageWidth = 2;

            picArtwork.Left = 10;
            picArtwork.Width = imageWidth;
            picArtwork.Top = (int)(tabArtWork.Height * 0.05);
            picArtwork.Height = (int)(tabArtWork.Height * 0.4);

            picLogo.Left = 10;
            picLogo.Width = imageWidth;
            picLogo.Top = (int)(tabArtWork.Height * 0.55);
            picLogo.Height = (int)(tabArtWork.Height * 0.4);
        }

        private void tabMedium_Resize(object sender, EventArgs e)
        {
            int imageWidth = tabMedium.Width - 20;
            if (imageWidth < 2)
                imageWidth = 2;

            picMedium1.Left = 10;
            picMedium1.Width = imageWidth;
            picMedium1.Top = (int)(tabMedium.Height * 0.05);
            picMedium1.Height = (int)(tabMedium.Height * 0.4);

            picMedium2.Left = 10;
            picMedium2.Width = imageWidth;
            picMedium2.Top = (int)(tabMedium.Height * 0.55);
            picMedium2.Height = (int)(tabMedium.Height * 0.4);

        }

        private void tabScreens_Resize(object sender, EventArgs e)
        {
            int imageWidth = tabScreens.Width - 20;
            if (imageWidth < 2)
                imageWidth = 2;

            picScreenTitle.Left = 10;
            picScreenTitle.Width = imageWidth;
            picScreenTitle.Top = (int)(tabScreens.Height * 0.05);
            picScreenTitle.Height = (int)(tabScreens.Height * 0.4);

            picScreenShot.Left = 10;
            picScreenShot.Width = imageWidth;
            picScreenShot.Top = (int)(tabScreens.Height * 0.55);
            picScreenShot.Height = (int)(tabScreens.Height * 0.4);
        }


        private void trbFontSize_ValueChanged(object sender, EventArgs e)
        {
            txtInfo.Font = new Font(txtInfo.Font.FontFamily, trbFontSize.Value, txtInfo.Font.Style);
            if (trbFontSize2.Value != trbFontSize.Value)
                trbFontSize2.Value = trbFontSize.Value;
        }

        private void trbFontSize2_ValueChanged(object sender, EventArgs e)
        {
            txtInfo2.Font = new Font(txtInfo.Font.FontFamily, trbFontSize.Value, txtInfo.Font.Style);
            if (trbFontSize.Value != trbFontSize2.Value)
                trbFontSize.Value = trbFontSize2.Value;
        }


        private void LoadMamePannels(RvFile tGame, string extraPath)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);

            string[] path = extraPath.Split('\\');

            RvFile fExtra = DB.DirRoot.Child(0);

            foreach (string p in path)
            {
                if (fExtra.ChildNameSearch(FileType.Dir, p, out int pIndex) != 0)
                    return;
                fExtra = fExtra.Child(pIndex);
            }

            bool artLoaded = false;
            bool logoLoaded = false;

            bool titleLoaded = false;
            bool screenLoaded = false;

            bool storyLoaded = false;

            int index;

            if (fExtra.ChildNameSearch(FileType.Zip, "artpreview.zip", out index) == 0)
            {
                artLoaded = picArtwork.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }
            else if (fExtra.ChildNameSearch(FileType.Dir, "artpreviewsnap", out index) == 0)
            {
                artLoaded = picArtwork.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }

            if (fExtra.ChildNameSearch(FileType.Zip, "marquees.zip", out index) == 0)
            {
                logoLoaded = picLogo.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }
            else if (fExtra.ChildNameSearch(FileType.Dir, "marquees", out index) == 0)
            {
                logoLoaded = picLogo.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }


            if (fExtra.ChildNameSearch(FileType.Zip, "snap.zip", out index) == 0)
            {
                screenLoaded = picScreenShot.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }
            else if (fExtra.ChildNameSearch(FileType.Dir, "snap", out index) == 0)
            {
                screenLoaded = picScreenShot.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }

            if (fExtra.ChildNameSearch(FileType.Zip, "cabinets.zip", out index) == 0)
            {
                titleLoaded = picScreenTitle.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }
            else if (fExtra.ChildNameSearch(FileType.Dir, "cabinets", out index) == 0)
            {
                titleLoaded = picScreenTitle.TryLoadImage(fExtra.Child(index), Path.GetFileNameWithoutExtension(tGame.Name));
            }


            if (artLoaded || logoLoaded) tabSideArtwork.TabPages.Add(tabArtWork);
            if (titleLoaded || screenLoaded) tabSideArtwork.TabPages.Add(tabScreens);
            if (storyLoaded) tabSideArtwork.TabPages.Add(tabInfo);

            ShowPannel(artLoaded || logoLoaded || titleLoaded || screenLoaded || storyLoaded);
        }

        private void LoadMameSLPannels(RvFile tGame, string extraPath)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);
            tabSideArtwork.TabPages.Remove(tabInfo2);

            string[] path = extraPath.Split('\\');

            RvFile fExtra = DB.DirRoot.Child(0);

            foreach (string p in path)
            {
                if (fExtra.ChildNameSearch(FileType.Dir, p, out int pIndex) != 0)
                    return;
                fExtra = fExtra.Child(pIndex);
            }

            bool artLoaded = false;
            bool logoLoaded = false;

            bool titleLoaded = false;
            bool screenLoaded = false;

            bool storyLoaded = false;

            int index;



            string fname = tGame.Parent.Name + "/" + Path.GetFileNameWithoutExtension(tGame.Name);

            if (fExtra.ChildNameSearch(FileType.Zip, "covers_SL.zip", out index) == 0)
            {
                artLoaded = picArtwork.TryLoadImage(fExtra.Child(index), fname);
            }

            if (fExtra.ChildNameSearch(FileType.Zip, "snap_SL.zip", out index) == 0)
            {
                logoLoaded = picLogo.TryLoadImage(fExtra.Child(index), fname);
            }

            if (fExtra.ChildNameSearch(FileType.Zip, "titles_SL.zip", out index) == 0)
            {
                screenLoaded = picScreenShot.TryLoadImage(fExtra.Child(index), fname);
            }

            if (artLoaded || logoLoaded) tabSideArtwork.TabPages.Add(tabArtWork);
            if (titleLoaded || screenLoaded) tabSideArtwork.TabPages.Add(tabScreens);
            if (storyLoaded) tabSideArtwork.TabPages.Add(tabInfo);

            ShowPannel(artLoaded || logoLoaded || titleLoaded || screenLoaded || storyLoaded);
        }

        // need to only load new image if the RvFile has changed
        // to stop flickering on screen while system is processing
        private void LoadPannelFromRom(RvFile tRom)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);
            tabSideArtwork.TabPages.Remove(tabInfo2);

            string ext = Path.GetExtension(tRom.Name).ToLower();
            if (ext != ".png" && ext != ".jpg")
            {
                ShowPannel(false);
                return;
            }
            bool loaded = picArtwork.LoadImage(tRom.Parent, tRom.Name);
            if (loaded)
            {
                tabSideArtwork.TabPages.Add(tabArtWork);
                ShowPannel(true);
            }
            else
            {
                ShowPannel(false);
            }
        }

        private bool LoadC64Pannel(RvFile tGame)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);
            tabSideArtwork.TabPages.Remove(tabInfo2);

            bool artLoaded = picArtwork.TryLoadImage(tGame, "Front");
            bool logoLoaded = picLogo.TryLoadImage(tGame, "Extras/Cassette");


            bool titleLoaded = picScreenTitle.TryLoadImage(tGame, "Extras/Inlay");
            bool screenLoaded = picScreenShot.TryLoadImage(tGame, "Extras/Inlay_back");


            if (artLoaded || logoLoaded) tabSideArtwork.TabPages.Add(tabArtWork);
            if (titleLoaded || screenLoaded) tabSideArtwork.TabPages.Add(tabScreens);

            bool showP = (artLoaded || logoLoaded || titleLoaded || screenLoaded);
            ShowPannel(showP);
            return showP;
        }

        private bool LoadNFOPannel(RvFile tGame)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);
            tabSideArtwork.TabPages.Remove(tabInfo2);

            bool storyLoaded = txtInfo.LoadNFO(tGame, "*.nfo");
            if (storyLoaded)
            {
                tabInfo.Text = "NFO";
                tabSideArtwork.TabPages.Add(tabInfo);
            }

            bool storyLoaded2 = txtInfo2.LoadNFO(tGame, "*.diz");
            if (storyLoaded2)
            {
                tabInfo2.Text = "DIZ";
                tabSideArtwork.TabPages.Add(tabInfo2);
            }

            bool showP = storyLoaded || storyLoaded2;
            ShowPannel(showP);
            return showP;
        }


        private void LoadTruRipPannel(RvFile tGame)
        {
            tabSideArtwork.TabPages.Remove(tabArtWork);
            tabSideArtwork.TabPages.Remove(tabMedium);
            tabSideArtwork.TabPages.Remove(tabScreens);
            tabSideArtwork.TabPages.Remove(tabInfo);
            tabSideArtwork.TabPages.Remove(tabInfo2);

            /*
             * artwork_front.png
             * artowrk_back.png
             * logo.png
             * medium_front.png
             * screentitle.png
             * screenshot.png
             * story.txt
             *
             * System.Diagnostics.Process.Start(@"D:\stage\RomVault\RomRoot\SNK\Neo Geo CD (World) - SuperDAT\Games\Double Dragon (19950603)\video.mp4");
             *
             */

            bool artLoaded = picArtwork.TryLoadImage(tGame, "Artwork/artwork_front");
            bool logoLoaded = picLogo.TryLoadImage(tGame, "Artwork/logo");
            if (!logoLoaded)
                logoLoaded = picArtwork.TryLoadImage(tGame, "Artwork/artwork_back");

            bool medium1Loaded = picMedium1.TryLoadImage(tGame, "Artwork/medium_front*");
            bool medium2Loaded = picMedium2.TryLoadImage(tGame, "Artwork/medium_back*");
            bool titleLoaded = picScreenTitle.TryLoadImage(tGame, "Artwork/screentitle");
            bool screenLoaded = picScreenShot.TryLoadImage(tGame, "Artwork/screenshot");
            bool storyLoaded = txtInfo.LoadText(tGame, "Artwork/story.txt");
            if (storyLoaded)
                tabInfo.Text = "Story.txt";

            if (!storyLoaded)
            {
                storyLoaded = txtInfo.LoadNFO(tGame, "*.nfo");
                if (storyLoaded)
                    tabInfo.Text = "NFO";
            }


            if (artLoaded || logoLoaded) tabSideArtwork.TabPages.Add(tabArtWork);
            if (medium1Loaded || medium2Loaded) tabSideArtwork.TabPages.Add(tabMedium);
            if (titleLoaded || screenLoaded) tabSideArtwork.TabPages.Add(tabScreens);
            if (storyLoaded) tabSideArtwork.TabPages.Add(tabInfo);

            ShowPannel(artLoaded || logoLoaded || titleLoaded || screenLoaded || storyLoaded || medium1Loaded || medium2Loaded);
        }


    }
}
