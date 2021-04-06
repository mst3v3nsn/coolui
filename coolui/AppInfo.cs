using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace coolui
{
    public class AppInfo
    {
        public string Info { get; set; }

        public AppInfo(string location) 
        {
            string path = location + "\\info.json";
            if (location != null)
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    AppInfo jsonObj = JsonConvert.DeserializeObject<AppInfo>(json);

                    this.Info = jsonObj.Info;
                }
            }
        }
    }
}
