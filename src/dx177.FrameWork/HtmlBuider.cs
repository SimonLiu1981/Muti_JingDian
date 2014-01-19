    /*
    版权所有：版权所有(C) 2006，中兴通讯
    文件编号：M00_HtmlBuilder.cs
    文件名称：HtmlBuilder.cs
    系统编号：Z0003010
    系统名称：无线办公协议
    模块编号：M00
    模块名称：系统框架
    设计文档：M00系统框架.mdx		  
    完成日期：2006-6-19 16:00
    作　　者：刘建林　
    内容摘要：该代码文件包括一个类HtmlBuilder
              主要功能是生成能够在手机上直接显示的HTML代码，包括添加一行HTML代码等操作。
    */

    /*
        修改记录1:
        修改日期:2006-11-1
        修改人:刘永凌
        修改内容:
        添加多语言文件内容到自定义版式
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
        /// 类 编 号：M00_HtmlBuilder
        /// 类 名 称：HtmlBuilder
        /// 内容摘要: 生成能够在手机上直接显示的HTML代码。
        /// 编码人员：张朝亮
        /// 完成日期：2006-6-19
        /// </summary>
        public class HtmlBuilder:Page
        {
            #region 变量区
            //保存多语言相关Xml内容
            private static Hashtable _languageXml = new Hashtable();
            #endregion

            #region 属性区

            /// <summary>
            /// 保存多语言相关Xml内容,LanguageXml["Global.zh-chs"].ToString() 得到Xml字符串
            /// </summary>
            public static Hashtable LanguageXml
            {
                get
                {
                    return HtmlBuilder._languageXml;
                }
            }

            #endregion

            #region 方法区开始
 
            /// <summary>
            /// 构造函数
            /// </summary>      
            public HtmlBuilder()
            {		   
            }

            /// <summary>
            /// 生成Html代码
            /// </summary>
            /// <param name="doc">XML数据</param>
            /// <param name="xslFileName">XSL文件路径</param>
            /// <returns>Html代码</returns>
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
            /// 无数据生成Html代码
            /// </summary>
            /// <param name="xslFileName">XSL文件路径</param>
            /// <returns>Html代码</returns>
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
            /// 生成空白的XML文档
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
            /// 添加子节点
            /// </summary>
            /// <param name="doc">XML文档对象</param>
            /// <param name="key">节点名称</param>
            /// <param name="val">节点内容</param>
            /// <returns>XML文档对象</returns>
            public XmlDocument AppendChild(XmlDocument doc, string key, string val)
            {
                XmlNode node = doc.CreateNode(XmlNodeType.Element,"", key, "");
                node.InnerText = val;            
                doc.ChildNodes[1].AppendChild(node);
                return doc;
            }

            /// <summary>
            /// 添加子节点
            /// </summary>
            /// <param name="doc">XML文档对象</param>
            /// <param name="key">节点名称</param>
            /// <param name="val">节点内容</param>
            /// <param name="val">是否是数据</param>
            /// <returns>XML文档对象</returns>
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

            #endregion 方法区结束
        }
    }
