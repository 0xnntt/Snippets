//check internet connection
        public static bool HTTP_status()     //return OK or NO
        {
            bool s = false;
            WebClient wb = new WebClient();
            try
            {
                string g = wb.DownloadString("http://www.google.com/robots.txt");
                if (g.ToString().Contains("User-agent"))
                {
                    s = true;
                }
                else
                {
                    s = false;
                }
            }
            catch { }
            return s;
        }
