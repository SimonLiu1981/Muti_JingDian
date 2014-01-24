using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace AnalyzeCatchTool.Models
{
    public static class CurrentConfiguration
    {
        public static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "myProfile.xml");

        public static ConfigurationEntity Value
        {
            get
            {
                return ce;
            }
        }
 
        static ConfigurationEntity ce = null;

        public static void Load()
        {             
            
            if (File.Exists(path))
            {                
                
                string xml = File.ReadAllText(path);

                ce =Serializer.ConvertToObject<ConfigurationEntity>(xml);
            }
            else
            {
                ce = new ConfigurationEntity();
            }
        }

        public static void Save()
        {
            string xml = Serializer.ConvertToXml<ConfigurationEntity>(ce);
            File.WriteAllText(path, xml);
        }
    }
}
