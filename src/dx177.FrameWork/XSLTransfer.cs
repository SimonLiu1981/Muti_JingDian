using System;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.IO;
namespace dx177.FrameWork
{
    /// <summary>
    /// Class1 的摘要说明
    /// </summary>
    public class XSLTransfer
    {
        public XSLTransfer()
        {

        }

        public enum XmlType
        {
            File = 1, String, Stream
        }

        public string InvokeTransfer(Object xmlfile, string xslfile)
        {

            return InvokeTransfer(xmlfile, xslfile, XmlType.File);
        }

        public string InvokeTransfer(Object xmlfile, string xslfile, XmlType XmlTypeP)
        {

            return this.InvokeTransfer(xmlfile, xslfile, XmlTypeP, null);
        }


        

        public string InvokeTransfer(Object xmlfile, string xslfile, XmlType XmlTypeP, XsltArgumentList Args)
        {
            XmlReader Xr = null, XmlReadLock = null;
            try
            {
             
                
                //Create a new XslTransform object.
                XslTransform xslt = new XslTransform();
                XPathDocument mydata = null;
                xslt.Load(xslfile);
                if (XmlTypeP == XmlType.File)
                {            
                    mydata = new XPathDocument((string)xmlfile);
                
                }
                else if (XmlTypeP == XmlType.Stream)
                {
                    mydata = new XPathDocument((Stream)xmlfile);
                }
                else if (XmlTypeP == XmlType.String)
                {
                    Stream   s   =   new   MemoryStream(ASCIIEncoding.Default.GetBytes((string)xmlfile));   
                    mydata = new XPathDocument(s);
                }

                //Create an XmlTextWriter which outputs to the console.
                //XmlWriter writer = new XmlTextWriter(Console.Out);
                Stream outs = new MemoryStream();              

                //Transform the data and send the output to the console.
                xslt.Transform(mydata,null,outs, null);
            
                byte[]   b   =new   byte[outs.Length];   
                outs.Read(b,0,b.Length);
                string   tempString  =   UTF8Encoding.Default.GetString(b);
                return tempString;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                if (null != Xr) Xr.Close();
                if (null != XmlReadLock) XmlReadLock.Close();
            }
        }

    }
}
