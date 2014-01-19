using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace dx177.ZhuNaAPI.Utility
{
    public class XmlHelper:ISerializer
    {


        public string Serialize<T>(T obj)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            s.Serialize(ms, obj);            
            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }

        public T Deserialize<T>(string xml)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);
            XmlNodeReader reader = new XmlNodeReader(xdoc.DocumentElement);
            T obj = (T)s.Deserialize(reader);
            return obj;
        }
    }
}
