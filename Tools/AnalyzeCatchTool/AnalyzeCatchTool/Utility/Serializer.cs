using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AnalyzeCatchTool
{
    public static class Serializer
    {
        public static T ConvertToObject<T>(string xml)
        {
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                // serialise to object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                stream = new StringReader(xml); // read xml data
                reader = new XmlTextReader(stream);  // create reader
                // covert reader to object
                return (T)serializer.Deserialize(reader);
            }
            catch
            {
                return default(T);
            }
            finally
            {
                if (stream != null) stream.Close();
                if (reader != null) reader.Close();
            }
        }

        public static string ConvertToXml<T>(T emp)
        {
            MemoryStream stream = null;
            TextWriter writer = null;
            try
            {
                stream = new MemoryStream(); // read xml in memory
                writer = new StreamWriter(stream, Encoding.Unicode);
                // get serialise object
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, emp); // read object
                int count = (int)stream.Length; // saves object in memory stream
                byte[] arr = new byte[count];
                stream.Seek(0, SeekOrigin.Begin);
                // copy stream contents in byte array
                stream.Read(arr, 0, count);
                UnicodeEncoding utf = new UnicodeEncoding(); // convert byte array to string
                return utf.GetString(arr).Trim();
            }
            catch
            {
                return string.Empty;
            }
            finally
            {
                if (stream != null) stream.Close();
                if (writer != null) writer.Close();
            }
        }
    }
}
