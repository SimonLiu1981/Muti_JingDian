    /*
    ��Ȩ���У���Ȩ����(C) 2006������ͨѶ
    �ļ���ţ�M00_HtmlBuilder.cs
    �ļ����ƣ�HtmlBuilder.cs
    ϵͳ��ţ�Z0003010
    ϵͳ���ƣ����߰칫Э��
    ģ���ţ�M00
    ģ�����ƣ�ϵͳ���
    ����ĵ���M00ϵͳ���.mdx		  
    ������ڣ�2006-6-19 16:00
    �������ߣ������֡�
    ����ժҪ���ô����ļ�����һ����HtmlBuilder
              ��Ҫ�����������ܹ����ֻ���ֱ����ʾ��HTML���룬�������һ��HTML����Ȳ�����
    */

    /*
        �޸ļ�¼1:
        �޸�����:2006-11-1
        �޸���:������
        �޸�����:
        ��Ӷ������ļ����ݵ��Զ����ʽ
    */

    using System;
    using System.Collections;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Xsl;
    using System.IO;
    using System.Web.UI;

    namespace dx177.FrameWork
    {
        /// <summary> 
        /// �� �� �ţ�M00_HtmlBuilder
        /// �� �� �ƣ�HtmlBuilder
        /// ����ժҪ: �����ܹ����ֻ���ֱ����ʾ��HTML���롣
        /// ������Ա���ų���
        /// ������ڣ�2006-6-19
        /// </summary>
        public class HtmlBuilder:Page
        {
            #region ������
            //������������Xml����
            private static Hashtable _languageXml = new Hashtable();
            #endregion

            #region ������

            /// <summary>
            /// ������������Xml����,LanguageXml["Global.zh-chs"].ToString() �õ�Xml�ַ���
            /// </summary>
            public static Hashtable LanguageXml
            {
                get
                {
                    return HtmlBuilder._languageXml;
                }
            }

            #endregion

            #region ��������ʼ
 
            /// <summary>
            /// ���캯��
            /// </summary>      
            public HtmlBuilder()
            {		   
            }

            /// <summary>
            /// ����Html����
            /// </summary>
            /// <param name="doc">XML����</param>
            /// <param name="xslFileName">XSL�ļ�·��</param>
            /// <returns>Html����</returns>
            public string BuildHtml(XmlDocument doc, string xslFileName)
            {   
                XslTransform xslt = new XslTransform();
                xslt.Load(xslFileName);
                MemoryStream ms = new MemoryStream();                    
                xslt.Transform(doc,null,ms);	
                
                byte[] bytes= ms.ToArray();                   
                string htmlCode = Encoding.UTF8.GetString(bytes);                   
                ms.Close();
                xslt = null;
                return Server.HtmlDecode(htmlCode);
            }

            /// <summary>
            /// ����������Html����
            /// </summary>
            /// <param name="xslFileName">XSL�ļ�·��</param>
            /// <returns>Html����</returns>
            public string BuildHtml(string xslFileName)
            {
                XmlDocument doc = new XmlDocument();
                StringBuilder sb = new StringBuilder();
                sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");                
                sb.Append("<ServiceData>");           
                sb.Append("</ServiceData>");
                doc.LoadXml(sb.ToString());
                return BuildHtml(doc, xslFileName);
            }

            /// <summary>
            /// ���ɿհ׵�XML�ĵ�
            /// </summary>
            /// <returns></returns>
            public XmlDocument MakeBlankXML()
            {
                XmlDocument doc = new XmlDocument();
                StringBuilder sb = new StringBuilder();
                sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");                
                sb.Append("<ServiceData>");           
                sb.Append("</ServiceData>");
                doc.LoadXml(sb.ToString());
                return doc;
            }

            /// <summary>
            /// ����ӽڵ�
            /// </summary>
            /// <param name="doc">XML�ĵ�����</param>
            /// <param name="key">�ڵ�����</param>
            /// <param name="val">�ڵ�����</param>
            /// <returns>XML�ĵ�����</returns>
            public XmlDocument AppendChild(XmlDocument doc, string key, string val)
            {
                XmlNode node = doc.CreateNode(XmlNodeType.Element,"", key, "");
                node.InnerText = val;            
                doc.ChildNodes[1].AppendChild(node);
                return doc;
            }

            /// <summary>
            /// ����ӽڵ�
            /// </summary>
            /// <param name="doc">XML�ĵ�����</param>
            /// <param name="key">�ڵ�����</param>
            /// <param name="val">�ڵ�����</param>
            /// <param name="val">�Ƿ�������</param>
            /// <returns>XML�ĵ�����</returns>
            public XmlDocument AppendChild(XmlDocument doc, string key, string val, bool isData)
            {
                XmlNode node = doc.CreateNode(XmlNodeType.Element,"", key, "");
                if (isData == true)
                {
                    node.InnerXml = "<![CDATA[" + val + "]]>";
                }
                else
                {
                    node.InnerXml = val;
                }
                doc.ChildNodes[1].AppendChild(node);
                return doc;
            }

            #endregion ����������
        }
    }
