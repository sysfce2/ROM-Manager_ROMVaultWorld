using RomVaultCore.RvDB;
using System;
using System.Diagnostics;
using System.IO;

namespace RomVaultCore.Utils
{
    public static class EmulatorLaunch
    {

        public static EmulatorInfo FindEmulatorInfo(RvFile tGame)
        {
            string path = tGame.Parent.DatTreeFullName;
            if (Settings.rvSettings?.EInfo == null)
                return null;
            if (path == "Error")
                return null;
            if (path.Length <= 8)
                return null;

            foreach (EmulatorInfo ei in Settings.rvSettings.EInfo)
            {
                if (!string.Equals(path.Substring(8), ei.TreeDir, StringComparison.CurrentCultureIgnoreCase))
                    continue;

                if (string.IsNullOrWhiteSpace(ei.CommandLine))
                    continue;

                if (!File.Exists(ei.ExeName))
                    continue;
                return ei;
            }
            return null;
        }

        public static void LaunchEmulator(RvFile tGame)
        {
            EmulatorInfo ei = FindEmulatorInfo(tGame);
            if (ei == null)
                return;

            string commandLineOptions = ei.CommandLine;
            string dirname = tGame.Parent.FullName;
            if (dirname.StartsWith("RomRoot\\"))
                dirname = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), dirname);

            commandLineOptions = commandLineOptions.Replace("{gamename}", Path.GetFileNameWithoutExtension(tGame.Name));
            commandLineOptions = commandLineOptions.Replace("{gamefilename}", tGame.Name);
            commandLineOptions = commandLineOptions.Replace("{gamedirectory}", dirname);

            string workingDir = ei.WorkingDirectory;
            if (string.IsNullOrWhiteSpace(workingDir))
                workingDir = Path.GetDirectoryName(ei.ExeName);

            using (Process exeProcess = new Process())
            {
                exeProcess.StartInfo.WorkingDirectory = workingDir;
                exeProcess.StartInfo.FileName = ei.ExeName;
                exeProcess.StartInfo.Arguments = commandLineOptions;
                exeProcess.StartInfo.UseShellExecute = false;
                exeProcess.StartInfo.CreateNoWindow = true;
                exeProcess.Start();
            }
        }

    }
}
