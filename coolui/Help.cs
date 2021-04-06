using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace coolui
{
    public class Help
    {
        public List <string> items { get; set; }

        public Help()
        {
            string json = File.ReadAllText(String.Format(@"{0}", AppDomain.CurrentDomain.BaseDirectory + "help.json"));
            List <string> jsonObj = JsonConvert.DeserializeObject<List<string>>(json);
            this.items = jsonObj;
        }
    }
}
