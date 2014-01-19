/*
版权所有：版权所有(C) 2005，中兴通讯
文件编号：
文件名称：StringUitl.cs
系统编号：Z0003007
系统名称：通用办公
模块编号：M09
模块名称：调度协调
设计文档：ioa.mdl
完成日期：2005.6.22
作　　者：夏磊
内容摘要：文件中包含一个类 StringUitl

修改日志：

修改记录1
修改人  ： 古俊峰
修改时间： 2007-9-26
修改内容： CMMDB00354103
*/
using System;
using System.Text.RegularExpressions;
using System.Text;
namespace dx177.FrameWork
{
    /// <summary>
    /// 内容摘要：文件中包含一个类 StringUtil
    /// 编码人员：刘建新
    /// 完成日期：2007-9-13
    /// </summary>
    public class StringUtil
    {
        /// <summary>
        /// 数据库的默认时间
        /// </summary>
        public static DateTime DBDefualtDateTime = DateTime.Parse("1900-1-1");

        /// <summary>
        /// 数据库的默认时间串
        /// </summary>
        public static string DBDefualtDateTimeString = "1900-1-1";
        //字段分割符
        //	CMMDB00354103	古俊峰 2007-9-26 开始
        //public static string FieldSplit = Convert.ToString((char) 5) ;
        public static string FieldSplit = "а";
        //	CMMDB00354103	古俊峰 2007-9-26 结束
        //记录分隔符
        //public static string FieldSplit = Convert.ToString((char) 6) ;
        public static string RecordSplit = "н";

        /// <summary>
        /// 将文本转为html格式
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public string Text2Html(string html)
        {
            if (IsEmpty(html))
            {
                return String.Empty;
            }
            html = html.Replace("\r\n", "<br>");
            html = html.Replace("\n", "<br>");
            return html;
        }
        /// <summary>
        /// 判断字符串是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsEmpty(string str)
        {
            return (str == null || str.Trim().Length == 0);
        }

        /// <summary>
        /// 判断字符串是否为不空
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsNotEmpty(string str)
        {
            return (str != null && str.Trim().Length > 0);
        }
        /// <summary>
        /// 判断字符串数组是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsEmpty(string[] str)
        {
            return (str == null || str.Length == 0);
        }
        /// <summary>
        /// 判断字符串数组是否为不空
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsNotEmpty(string[] str)
        {
            return (str != null && str.Length > 0);
        }
        /// <summary>
        /// 取字符串子串
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string SubString(string str, int start)
        {
            if (IsEmpty(str))
            {
                return String.Empty;
            }

            if (start < 0)
            {
                start = str.Length + start; // remember start is negative
            }

            if (start < 0)
            {
                start = 0;
            }
            if (start > str.Length)
            {
                return String.Empty;
            }

            return str.Substring(start);
        }
        /// <summary>
        /// 取字符串子串
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string SubString(string str, int start, int end)
        {
            if (IsEmpty(str))
            {
                return String.Empty;
            }
            if (end < 0)
            {
                end = str.Length + end;
            }
            if (start < 0)
            {
                start = str.Length + start;
            }


            if (end > str.Length)
            {
                end = str.Length;
            }

            if (start > end)
            {
                return String.Empty;
            }

            if (start < 0)
            {
                start = 0;
            }
            if (end < 0)
            {
                end = 0;
            }
            return str.Substring(start, end);
        }
        /// <summary>
        /// 从字符串中清除所有含有(char &lt;= 32)的字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string Clean(string str)
        {
            return (str == null ? String.Empty : str.Trim());
        }
        /// <summary>
        /// 从字符串中清除所有含有(char &lt;= 32)的字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string Trim(string str)
        {
            return (str == null ? null : str.Trim());
        }
        /// <summary>
        /// 是否是数字
        /// </summary>
        /// <param name="val">数字字符串</param>
        static public bool IsValidInt(string val)
        {
            return Regex.IsMatch(val, @"^[1-9]\d*\.?[0]*$");

        }
        /// <summary>
        /// 取字符串长度
        /// </summary>
        /// <param name="val">字符串</param>
        static public int Length(string val)
        {
            if (IsEmpty(val))
            {
                return 0;
            }
            return val.Length;

        }

        /// <summary>
        /// 获取guid值，做为唯一键
        /// </summary>
        /// <param name="val">获取guid值，做为唯一键</param>
        static public string getGuid()
        {
            return System.Guid.NewGuid().ToString();
        }


        /// <summary>
        /// 方法名称: StringToDecimal
        /// 内容摘要: 把数值型字符转换为双精度型
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public decimal StringToDecimal(string text)
        {
            if ((text != null) && (text != string.Empty))
            {
                return decimal.Parse(text.Trim());
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 方法名称: StringToInteger
        /// 内容摘要: 把数值型字符转换为整型
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public int StringToInteger(string text)
        {
            if ((text != null) && (text != string.Empty))
            {
                return int.Parse(text.Trim());
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 方法名称: StringToLong
        /// 内容摘要: 把数值型字符转换为长整型
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public long StringTolong(string text)
        {
            if ((text != null) && (text != string.Empty))
            {
                return long.Parse(text.Trim());
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 方法名称: StringToDateTime
        /// 内容摘要: 把日期型字符转换为日期类型
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static public DateTime StringToDateTime(string text)
        {
            if ((text != null) && (text != string.Empty))
            {
                return DateTime.Parse(text.Trim());
            }
            else
            {
                return DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }

        /// <summary>
        /// 截取指定长度字符
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public string CutString(string inputStr, int len, string addString)
        {
            if (inputStr != null && inputStr != string.Empty)
            {
                byte[] byteArry = System.Text.Encoding.Default.GetBytes(inputStr);
                if (byteArry.Length > len)
                {
                    //return System.Text.Encoding.Default.GetString(byteArry, 0, len-3) + "..." ; 

                    int cout = 0;
                    int curIdx = 0;
                    string temp = "";
                    while (cout < len - 3)
                    {
                        temp += inputStr.Substring(curIdx, 1);
                        curIdx++;
                        byteArry = System.Text.Encoding.Default.GetBytes(temp);
                        cout = byteArry.Length;
                    }
                    return temp + addString;

                }
                return inputStr;
            }
            else
            {
                return inputStr;
            }

        }

        /// <summary>
        /// 截取指定长度字符
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public string CutString(string inputStr, int len)
        {
            return CutString(inputStr, len, "...");
        }

        /// <summary>
        /// 根据拆分标识，拆分字符串为字符数组
        /// </summary>
        /// <param name="toSplitString"></param>
        /// <param name="splitFlag"></param>
        /// <returns></returns>
        static public string[] SplitString(string toSplitString, char splitFlag)
        {
            string[] returnArray = null;
            if (toSplitString != null && toSplitString.Length > 0)
            {
                if (toSplitString.EndsWith(splitFlag.ToString()))
                {
                    toSplitString = toSplitString.Substring(0, toSplitString.Length - 1);
                }
                returnArray = toSplitString.Split(splitFlag);
            }
            return returnArray;
        }

        /// <summary>
        /// 判断全角
        /// </summary>
        /// <param name="chr"></param>
        /// <returns></returns>
        static public bool IsChinese(char chr)
        {
            //            if((int)chr>=0x4E00 && (int)chr<=0x9FA5)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //                return false;
            //            }


            if ((int)chr >= 255)
            {
                // ch 为汉字或全角字符
                return true;
            }
            else
            {
                return false;
            }

        }//end public  bool IsChinese(char str)


        /// <summary>
        /// 判断是否中文
        /// </summary>
        /// <param name="chr"></param>
        /// <returns></returns>
        static public bool IsChineseChar(char chr)
        {
            if ((int)chr >= 0x4E00 && (int)chr <= 0x9FA5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end static public  bool IsChineseChar(char chr)

        //		/// <summary>
        //		/// 判断是否全角
        //		/// </summary>
        //		/// <param name="chr"></param>
        //		/// <returns></returns>
        //		static public  bool IsSBCcaseChar(char chr)
        //		{
        //			if((int)chr>=x00 && (int)chr<=xff)
        //			{
        //				return true;
        //			}
        //			else
        //			{
        //				return false;
        //			} 
        //		}//end static public  bool IsChineseChar(char chr)


        /// <summary>
        /// 判断是否包含中文字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static public bool haveChineseChar(string str)
        {
            char[] q = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)q[i] >= 0x4E00 && (int)q[i] <= 0x9FA5)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 方法名称: GetLengthString
        /// 内容摘要: 获取实际长度的字符串长度
        /// </summary>
        /// <param name="pSource">源自符串</param>
        /// <param name="pLength">需要的字符长度</param>
        /// <param name="pSeparator">实际转换时当字符长度不足时填充的符号</param>
        static public string getLengthStr(string pSource, int pLength, string pSeparator)
        {
            if (pSource == null || pSource == string.Empty)
            {
                return string.Empty;
            }
            int n = 0;//记录小写字母等的个数
            bool isAddSeparator = false;//标志，是否要加填充符号
            StringBuilder str = new StringBuilder(string.Empty);
            if (pSource.Length > pLength) //源字符串长度大于需要的字符串长度时，分情况进行截取
            {
                string pSource0 = pSource.Substring(0, pLength);

                int pSourceLength = pSource.Length;//源串的字符个数
                foreach (char chr in pSource0)
                {
                    if (IsChinese(chr) == false)
                    {
                        if (char.IsLower(chr) || char.IsDigit(chr) || char.IsPunctuation(chr) || char.IsSymbol(chr)
                            || char.IsSeparator(chr) || char.IsWhiteSpace(chr) || char.IsControl(chr))
                        {
                            n = n + 1;
                        }
                    }
                }
                str.Append(pSource0);

                if (n > 0) //pSource0中有小写字母等，再截取一部分字符串进行补偿
                {
                    string strPsource1 = pSource.Substring(pLength, pSourceLength - pLength);//源字符串截取pLength个字符后的新串

                    foreach (char chr in strPsource1)
                    {
                        if (n >= -1)//(最差情况，误差一个小写字母的间踞)
                        {
                            if (IsChinese(chr) == false)
                            {
                                if (char.IsLower(chr) || char.IsDigit(chr) || char.IsPunctuation(chr) || char.IsSymbol(chr)
                                    || char.IsSeparator(chr) || char.IsWhiteSpace(chr) || char.IsControl(chr))
                                {
                                    n = n - 1;
                                }
                                else
                                {
                                    n = n - 2;
                                }
                            }
                            else
                            {
                                n = n - 2;
                            }
                            str.Append(chr);
                        }
                    }
                    if (str.Length < pSource.Length)
                    {
                        isAddSeparator = true;

                    }
                }
                else //(n<0)
                {
                    isAddSeparator = true;

                }

                //判断是否要加填充符号
                if (isAddSeparator)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        str.Append(pSeparator);
                    }
                }

            }
            else//源字符串长度小于需要的字符长度时，直接返回
            {
                str.Append(pSource);
            }
            return str.ToString();
        }

        /// <summary>
        /// 格式化字符串为Oralce数据库可以接受的保存模式
        /// </summary>
        /// <param name="sqlSource">需要格式化的字符串</param>
        /// <returns>格式化后的字符串</returns>
        static public string FormatSqlStr(string sqlSource)
        {
            string sqlTarget;
            if (sqlSource == null)
            {
                return string.Empty;
            }
            sqlTarget = sqlSource.Replace("'", "''");
            return sqlTarget;
        } //public  string FormatSqlStr 结束

        /// <summary>
        /// 为ORACLE格式化字符串
        /// </summary>
        /// <param name="ParameterStr">需要格式化的字符串</param>
        /// <returns>格式化后的字符串</returns>
        static public string OracleParameterConversion(string ParameterStr)
        {
            char[] Parameter_character = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '-', '+', '|', '=' };
            string outstr = string.Empty;
            string ConvertStr;
            for (int i = 0; i < ParameterStr.Length; i++)
            {
                ConvertStr = ParameterStr[i].ToString();
                if (ParameterStr[i].ToString() != "'")
                {
                    foreach (char character in Parameter_character)
                    {
                        string character_str = character.ToString();
                        if (ParameterStr[i].ToString() == character_str)
                            ConvertStr = "'||'" + character_str + "'||'";
                    }
                    outstr += ConvertStr;
                }
                else
                {
                    ConvertStr = "''";
                    outstr += ConvertStr;
                }
            }
            return outstr;
        }

        /// <summary>
        /// 判断字符是否有值
        /// </summary>
        /// <param name="sString">需要判断的字符串</param>
        /// <returns>是否有效值</returns>
        static public bool HaveValue(string sString)
        {
            bool blValue = false;
            if (sString == String.Empty || sString == null)
            {
                blValue = false;
            }
            else
            {
                blValue = true;
            }
            return blValue;
        } //public  string FormatSqlStr 结束

        /// <summary>
        /// 有值就调用string的trim,无值就直接返回
        /// </summary>
        /// <param name="sString">需要判断的字符串</param>
        /// <returns>是否有效值</returns>
        static public string StringTrim(string sString)
        {
            string strValue;
            if (sString == String.Empty || sString == null)
            {
                strValue = sString;
            }
            else
            {
                strValue = sString.Trim();
            }
            return strValue;
        } //public  string FormatSqlStr 结束


        ///<summary>
        ///字符串等分插入指定的内容,以使其在被显示时换行(主要针对NOTES中显示表格时使用)
        ///</summary>
        ///<param name="sString">要处理的字符串</param>
        ///<param name="Number">等分的份数</param>
        ///<param name="Char">要插入的内容</param>
        ///<param name="flag">拆分标志</param>
        ///<return>返回插入br后的字符串</return>
        static public string InsertChar(string sString, int Number, char flag, string Char)
        {
            string back = sString;
            try
            {
                if (sString.Trim() == string.Empty)
                {
                    return sString;
                }
                string[] TempArray = null;
                string reString = string.Empty;
                TempArray = SplitString(sString, flag);
                for (int j = 0; j < TempArray.Length; j++)
                {
                    int temp = TempArray[j].IndexOf("<br>");
                    TempArray[j].Remove(0, 4);
                    TempArray[j] += ",";

                }
                int i = (int)(TempArray.Length / Number);
                if (i >= 1)
                {
                    for (int j = 1; j < i; j++)
                    {
                        TempArray[j * Number - 1] += Char;
                    }
                    if (i * Number < TempArray.Length)
                    {
                        TempArray[i * Number - 1] += "<br>";
                    }
                }

                for (int j = 0; j < TempArray.Length; j++)
                {
                    reString += TempArray[j];
                }
                return reString;
            }
            catch
            {
                return back;
            }


        }

        /// <summary>
        /// 编码 
        /// code_type : System.Text.Encoding.UTF8.EncodingName
        /// </summary>
        /// <param name="code_type">原始编码</param>
        /// <param name="code">需要编码的字符串</param>
        /// <returns>编码的结果</returns>
        public static string EncodeBase64(string code_type, string code)
        {
            string encode = string.Empty;
            byte[] bytes = Encoding.GetEncoding(code_type).GetBytes(code);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        /// <summary>
        /// 解码
        /// code_type : System.Text.Encoding.UTF8.EncodingName
        /// </summary>
        /// <param name="code_type">转换的编码</param>
        /// <param name="code">需要解码的字符串</param>
        /// <returns>解码结果</returns>
        public static string DecodeBase64(string code_type, string code)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        /// <summary>
        /// 方法名称: GetLengthString
        /// 内容摘要: 获取实际长度的字符串长度
        /// </summary>
        /// <param name="pSource">源字符串长度</param>
        /// <param name="pLength">截取的实际长度</param>
        /// <param name="pSeparator">不足需要补齐的字符</param>
        /// <returns></returns>
        public static string GetLengthString(string pSource, int pLength, string pSeparator)
        {
            StringBuilder sbString = new StringBuilder(string.Empty);
            int iTrueLen = 0;                     //已经读取的字符实际长度
            int iStrLen = 0;                     //已经读取的字符函数读取长度
            string sSource = pSource.Trim();


            if ((sSource != null) && (sSource != string.Empty))
            {
                foreach (char chr in sSource)
                {
                    iStrLen = iStrLen + 1;
                    if (IsChinese(chr))
                    {
                        iTrueLen = iTrueLen + 2;
                        if (iTrueLen > pLength)
                        {
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//判断前一个字符是否是汉字
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }
                            else
                            {
                                if (IsChinese(sSource.Substring(iStrLen - 3, 1)[0]))//判断前二个字符是否是汉字 
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + " ".PadRight(4, '.'));
                                }
                                else
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + string.Empty.PadRight(3, '.'));
                                }
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//判断前一个字符是否是汉字

                            break;
                        }
                        else if (iTrueLen == pLength)
                        {
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//判断前一个字符是否是汉字
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + " ".PadRight(4, '.'));
                            }
                            else
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//判断前一个字符是否是汉字
                            break;
                        }
                    }//end  if (IsChinese(chr))
                    else
                    {
                        iTrueLen = iTrueLen + 1;
                        if (iTrueLen == pLength)
                        {
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//判断前一个字符是否是汉字
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }
                            else
                            {
                                if (IsChinese(sSource.Substring(iStrLen - 3, 1)[0]))//判断前二个字符是否是汉字 
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + " ".PadRight(4, '.'));
                                }
                                else
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + string.Empty.PadRight(3, '.'));
                                }
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//判断前一个字符是否是汉字
                            break;
                        }
                    }//end  if (IsChinese(chr))

                }// end foreach
            } //if ((sSource != null)&&(sSource != string.Empty))

            if (sbString.Length == 0)
            {
                if (pSeparator == null || pSeparator == string.Empty)
                {
                    sbString.Append(sSource);
                }
                else
                {
                    sbString.Append(sSource + string.Empty.PadRight(pLength - iTrueLen, pSeparator[0]));
                }
            }//end if (sbString.Length == 0)

            return sbString.ToString();
        }//end static public string GetLengthString(string pString,int pLength)


        /// <summary>
        /// 把字符数组转为字符串
        /// </summary>
        /// <param name="strArr"></param>
        /// <returns></returns>
        public static string StrArrToStr(string[] strArr)
        {
            string strReturn = string.Empty;
            if (strArr != null)
            {
                for (int i = 0; i < strArr.Length; i++)
                {
                    strReturn += strArr[i] + ",";
                }
            }

            strReturn = strReturn.Substring(0, strReturn.Length - 1);

            return strReturn;
        }
        /// <summary>
        /// 特殊字符格式化(用于对本系统保留字如%,_,?的处理 如："?" --> (char)6 )
        /// </summary>
        /// <param name="sString">需要格式化的字符串</param>
        /// <returns>格式化后的字符串</returns>
        static public string FormatSpecialChar(string sString)
        {
            //string strValue = string.Empty;
            if (sString != null)
            {
                sString = sString.Replace("?", Convert.ToString((char)6)); // 处理IBatis报错,?在Ibatis中是保留字
                sString = sString.Replace("_", Convert.ToString((char)5)); // _在Oracle中是保留字
                sString = sString.Replace("%", Convert.ToString((char)1)); // _在Oracle中是保留字
            }

            return sString;
        }

        /// <summary>
        /// 特殊字符解析(用于对本系统保留字如%,_,?的处理 如：(char)6 --> "?")
        /// </summary>
        /// <param name="sString">需要解析的字符串</param>
        /// <returns>解析后的字符串</returns>
        static public string TransferSpecialChar(string sString)
        {
            //string strValue = string.Empty;
            if (sString != null)
            {
                sString = sString.Replace(Convert.ToString((char)6), "?"); // 处理IBatis报错,?在Ibatis中是保留字
                sString = sString.Replace(Convert.ToString((char)5), "_"); // _在Oracle中是保留字
                sString = sString.Replace(Convert.ToString((char)1), "%"); // _在Oracle中是保留字
            }

            return sString;
        }

        /// <summary>
        /// 判断一个字符串是否包含在另外一个字符数组中
        /// </summary>
        public static bool IsIncludeArray(string sCheckStr, string[] arrSource)
        {
            bool bResult = false;
            foreach (string sTmpStr in arrSource)
            {
                if (sTmpStr == sCheckStr)
                {
                    bResult = true;
                    break;
                }
            }

            return bResult;
        }

        /// <summary>
        /// 格式化字符串数组为“，”隔开的字符串
        /// </summary>
        public static string FormatStringArray(string[] arrSource)
        {
            string sResult = string.Empty;
            if (arrSource == null)
            {
                return string.Empty;
            }
            foreach (string sSource in arrSource)
            {
                if (sSource != string.Empty)
                {
                    sResult += sSource + ",";
                }
            }

            if (sResult != string.Empty)
            {
                sResult = sResult.Substring(0, sResult.Length - 1);
            }

            return sResult;
        }

        /// <summary>
        /// 修改URL里面，指定的参数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramName"></param>
        /// <param name="paramValue"></param>
        /// <returns></returns>
        public static string SetPageUrlParamer(string url, string paramName, string paramValue)
        {
            //System.Collections.Hashtable ht = new System.Collections.Hashtable();
            System.Text.StringBuilder sbParam = new StringBuilder();
            string[] ParaArr = url.Split("&".ToCharArray());

            foreach (string s in ParaArr)
            {
                string[] StrArr = s.Split("=".ToCharArray());
                //如果不是要改值的参数
                if (StrArr[0] != paramName)
                {
                    sbParam.Append(StrArr[0] + "=" + StrArr[1] + "&");
                }
                else
                {
                    sbParam.Append(StrArr[0] + "=" + paramValue + "&");
                }
            }

            string strTmp = sbParam.ToString();
            return strTmp.Substring(strTmp.Length - 1);

        }

        /// <summary>
        /// 移除URL里面，指定的参数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramName"></param>
        /// <returns></returns>
        public static string RemovePageUrlParamer(string url, string paramName)
        {
            System.Text.StringBuilder sbParam = new StringBuilder();
            string[] ParaArr = url.Split("&".ToCharArray());

            foreach (string s in ParaArr)
            {
                string[] StrArr = s.Split("=".ToCharArray());
                //如果不是要改值的参数
                if (StrArr[0] != paramName)
                {
                    sbParam.Append(StrArr[0] + "=" + StrArr[1] + "&");
                }
            }

            string strTmp = sbParam.ToString();
            if (strTmp != string.Empty)
            {
                return strTmp.Substring(0, strTmp.Length - 1);
            }
            else
                return string.Empty;

        }

        //修改记录02 begin

        /// <summary>
        /// Maps a business object's properties to placeholders
        /// of the submitted content.
        /// </summary>
        /// <param name="content">A string containing placeholder tags. Check
        /// the class summary to get the proper placeholder format.</param>
        /// <returns></returns>
        private static string MapContent(string content, string pattern)
        {
            StringBuilder builder = new StringBuilder(content);

            return Regex.Replace(content, pattern, new MatchEvaluator(RegexMatchEvaluation), RegexOptions.ExplicitCapture);
        }

        /// <summary>
        /// Retrieves the property name from a placeholder and
        /// tries to get a property value from the business
        /// object.
        /// </summary>
        /// <param name="match">Regex match.</param>
        /// <returns>The property value, if existing. If the property
        /// is <c>null</c>, <c>String.Empty</c> is being returned. If
        /// no property is available, the unchanged placeholder is
        /// returned.</returns>
        private static string RegexMatchEvaluation(Match match)
        {
            //get the property name (named group of the regex)
            string propertyName = match.Groups["property"].Value;
            return System.Web.HttpUtility.HtmlEncode(propertyName);

        }
        //修改记录02 end
        /// <summary>
        /// 邮件答复内容指定位置插入 <P>标签。但是当出现A标签时，里面内容不要插入<P>
        /// </summary>
        /// <param name="position">指定位置</param>
        /// <param name="strSource">源串</param>
        /// <returns>插入P标签的串</returns>
        public static string InsertTagForMail(int position, string strSource)
        {
            string strTag = "<p>";
            if (strSource == null || strSource == string.Empty)
            {
                return string.Empty;
            }
            string strBakup = strSource;
            strSource = MapContent(strSource, "<a[^<]*>(?'property'[^\"]*?)</a>");//替换<a></a>标签
            string brString = "н";
            string emptyString = "ω";
            //用了FreeTextBox控件后，把空格变成了&nbsp;,所以还要计算这个的长度为1，而不是6
            strSource = strSource.Replace("&nbsp;", emptyString);
            strSource = strSource.Replace("<br>", brString);
            strSource = strSource.Replace("<BR>", brString);//FreeTextBox			
            strSource = strSource.Replace("\r\n", brString);

            try
            {
                int i = 0;
                //string returnString = string.Empty;
                string tmp = string.Empty;
                StringBuilder sbReturnString = new StringBuilder();
                string cutString = string.Empty;
                bool exitHtmlTag = false;
                bool redAdd = true;
                while (strSource.Length > 0)
                {
                    cutString = strSource.Substring(0, 1);
                    if (cutString == "<")
                    {
                        exitHtmlTag = true;
                        redAdd = false;
                    }
                    if (exitHtmlTag && cutString == ">")
                    {
                        redAdd = true;
                    }

                    if (redAdd)
                    {
                        i += System.Text.UnicodeEncoding.Default.GetByteCount(cutString);
                    }

                    tmp += cutString;
                    strSource = strSource.Substring(1);
                    if (cutString == brString)
                    {
                        sbReturnString.Append(tmp);
                        tmp = "";
                        i = 0;
                        continue;
                    }

                    if (i >= position)
                    {
                        sbReturnString.Append(tmp);
                        sbReturnString.Append(strTag);
                        tmp = "";
                        i = 0;
                        continue;
                    }
                }

                if (tmp != string.Empty)
                {

                    sbReturnString.Append(tmp);
                }
                sbReturnString = sbReturnString.Replace(brString, strTag);
                sbReturnString = sbReturnString.Replace(emptyString, "&nbsp;");//还原空格

                return sbReturnString.ToString();
            }
            catch
            {
                return strBakup;
            }
        }

        /// <summary>
        /// 在指定的位置强制写入 一指定的标签，供邮件换行使用
        /// </summary>
        /// <param name="position"></param>
        /// <param name="strSource"></param>
        /// <param name="strTag"></param>
        /// <returns></returns>
        public static string InsertTagAt(int position, string strSource, string strTag)
        {
            if (strSource == null || strSource == string.Empty)
            {
                return string.Empty;
            }
            string strBakup = strSource;
            string brString = "н";
            string strTag16 = "ξ";//用来替换strTag的标签
            string emptyString = "ω";
            strSource = strSource.Replace("<br>", brString);
            strSource = strSource.Replace("\r\n", brString);
            strSource = strSource.Replace("&nbsp;", emptyString);

            try
            {
                int i = 0;
                StringBuilder sbReturnString = new StringBuilder();
                string tmp = string.Empty;
                while (strSource.Length > 0)
                {
                    string cutString = strSource.Substring(0, 1);
                    strSource = strSource.Substring(1);

                    tmp += cutString;
                    i += System.Text.UnicodeEncoding.Default.GetByteCount(cutString);

                    if (cutString == brString)
                    {
                        sbReturnString.Append(tmp);
                        tmp = "";
                        i = 0;
                        continue;
                    }

                    if (i >= position)
                    {
                        sbReturnString.Append(tmp);
                        sbReturnString.Append(strTag16);
                        tmp = "";
                        i = 0;
                        continue;
                    }
                }
                if (tmp != string.Empty)
                {
                    sbReturnString.Append(tmp);
                }

                string returnVal = sbReturnString.ToString();
                returnVal = returnVal.Replace(emptyString, " ");

                return System.Web.HttpUtility.HtmlEncode(returnVal).Replace(brString, "<br>").Replace(strTag16, strTag);

            }
            catch
            {
                return strBakup;
            }
        }

        /// <summary>
        /// 从字符串中删除前后的某个指定的字符串
        /// </summary>
        /// <param name="source">原串</param>
        /// <param name="target">目录串</param>
        /// <returns>结果</returns>
        public static string TrimString(string source, string target)
        {
            source = source + string.Empty;
            if (source.ToUpper().StartsWith(target.ToUpper()))
            {
                source = source.Substring(target.Length);
            }
            if (source.ToUpper().EndsWith(target.ToUpper()))
            {
                source = source.Substring(0, source.Length - target.Length);
            }
            return source;

        }
    }//end class
}// end namespace
