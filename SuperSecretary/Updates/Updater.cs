using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Xml.Serialization;

namespace SuperSecretary.Updates
{
    public class Updater
    {
        const string UPDATE_URL = "http://codecalculated.com/products/supersecretary/updates.xml";
        const string SITE_URL = "http://codecalculated.com/products/supersecretary";

        public Update Latest;

        public bool UpdatesAvailable
        {
            get
            {
                if (Latest != null && !String.IsNullOrEmpty(Latest.Version))
                {
                    var v = new Version(Latest.Version);
                    return v > Assembly.GetExecutingAssembly().GetName().Version;
                }
                return false;
            }
        }

        public Updater()
        {
            using (WebClient wc = new WebClient())
            {
                string data = wc.DownloadString(UPDATE_URL);
                var xs = new XmlSerializer(typeof(Update));
                using (var sr = new StringReader(data))
                {
                    Latest = (Update)xs.Deserialize(sr);
                }
            }
        }

        public void OpenInBrowser()
        {
            Process.Start(SITE_URL);
        }

        public string Download()
        {
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string downloadsFolder = Path.Combine(userFolder, "Downloads");
            string destination = Path.Combine(downloadsFolder, Latest.FileName);
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(Latest.Url, destination);
            }
            return destination;
        }

        public void DownloadAndInstall()
        {
            string file = this.Download();
            Process.Start(file);
        }
    }
}
