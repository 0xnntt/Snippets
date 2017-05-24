public static void DeviceInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            string all = "";
            foreach (DriveInfo d in allDrives)
            {
                
                string b_info = string.Format("Drive {0} {1}\tFile type: {2}", d.Name, Environment.NewLine, d.DriveType);
                all = all + b_info + Environment.NewLine;
                if (d.IsReady == true)
                {
                    string f_info = string.Format("\tVolume label: {0} {1}\tFile system: {2}{1}\tfreeSpace: {3, 15} bytes{1}\ttotalSpace: {4, 15} bytes{1}\tTotal:{5, 15} bytes", d.VolumeLabel, Environment.NewLine, d.DriveFormat, d.AvailableFreeSpace, d.TotalFreeSpace, d.TotalSize);
                    all = all + f_info + Environment.NewLine;
                }
            }
            Console.WriteLine(all);

        }
