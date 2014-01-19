using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace dx177_building
{
  public  class XmlData
    {
  
    /// <summary>
    /// xml序列化成字符串
    /// </summary>
    /// <param name="obj">对象</param>
    /// <returns>xml字符串</returns>
      public static void Serialize(object obj1, string path)
      {
          //用webinfo这个类造一个XmlSerializer 
          try
          {
              path = System.Web.HttpContext.Current.Server.MapPath(path);
              XmlSerializer ser = new XmlSerializer(obj1.GetType());
              Stream file = new FileStream(path, FileMode.Create, FileAccess.Write);
              ser.Serialize(file, obj1);
              if (file != null)
                  file.Close();
          }
          catch (Exception ex)
          {
              throw ex;
          }
      }

    public static object XmlDeserialize(Type type, string filename)
    {
        FileStream fs = null;
        try
        {
            filename = System.Web.HttpContext.Current.Server.MapPath(filename);
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlSerializer serializer = new XmlSerializer(type);
            return serializer.Deserialize(fs) ;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }

 
    }
}
