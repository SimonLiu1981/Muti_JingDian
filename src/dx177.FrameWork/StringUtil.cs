/*
��Ȩ���У���Ȩ����(C) 2005������ͨѶ
�ļ���ţ�
�ļ����ƣ�StringUitl.cs
ϵͳ��ţ�Z0003007
ϵͳ���ƣ�ͨ�ð칫
ģ���ţ�M09
ģ�����ƣ�����Э��
����ĵ���ioa.mdl
������ڣ�2005.6.22
�������ߣ�����
����ժҪ���ļ��а���һ���� StringUitl

�޸���־��

�޸ļ�¼1
�޸���  �� �ſ���
�޸�ʱ�䣺 2007-9-26
�޸����ݣ� CMMDB00354103
*/
using System;
using System.Text.RegularExpressions;
using System.Text;
namespace dx177.FrameWork
{
    /// <summary>
    /// ����ժҪ���ļ��а���һ���� StringUtil
    /// ������Ա��������
    /// ������ڣ�2007-9-13
    /// </summary>
    public class StringUtil
    {
        /// <summary>
        /// ���ݿ��Ĭ��ʱ��
        /// </summary>
        public static DateTime DBDefualtDateTime = DateTime.Parse("1900-1-1");

        /// <summary>
        /// ���ݿ��Ĭ��ʱ�䴮
        /// </summary>
        public static string DBDefualtDateTimeString = "1900-1-1";
        //�ֶηָ��
        //	CMMDB00354103	�ſ��� 2007-9-26 ��ʼ
        //public static string FieldSplit = Convert.ToString((char) 5) ;
        public static string FieldSplit = "��";
        //	CMMDB00354103	�ſ��� 2007-9-26 ����
        //��¼�ָ���
        //public static string FieldSplit = Convert.ToString((char) 6) ;
        public static string RecordSplit = "��";

        /// <summary>
        /// ���ı�תΪhtml��ʽ
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
        /// �ж��ַ����Ƿ�Ϊ��
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsEmpty(string str)
        {
            return (str == null || str.Trim().Length == 0);
        }

        /// <summary>
        /// �ж��ַ����Ƿ�Ϊ����
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsNotEmpty(string str)
        {
            return (str != null && str.Trim().Length > 0);
        }
        /// <summary>
        /// �ж��ַ��������Ƿ�Ϊ��
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsEmpty(string[] str)
        {
            return (str == null || str.Length == 0);
        }
        /// <summary>
        /// �ж��ַ��������Ƿ�Ϊ����
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        static public bool IsNotEmpty(string[] str)
        {
            return (str != null && str.Length > 0);
        }
        /// <summary>
        /// ȡ�ַ����Ӵ�
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
        /// ȡ�ַ����Ӵ�
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
        /// ���ַ�����������к���(char &lt;= 32)���ַ�
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string Clean(string str)
        {
            return (str == null ? String.Empty : str.Trim());
        }
        /// <summary>
        /// ���ַ�����������к���(char &lt;= 32)���ַ�
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        static public string Trim(string str)
        {
            return (str == null ? null : str.Trim());
        }
        /// <summary>
        /// �Ƿ�������
        /// </summary>
        /// <param name="val">�����ַ���</param>
        static public bool IsValidInt(string val)
        {
            return Regex.IsMatch(val, @"^[1-9]\d*\.?[0]*$");

        }
        /// <summary>
        /// ȡ�ַ�������
        /// </summary>
        /// <param name="val">�ַ���</param>
        static public int Length(string val)
        {
            if (IsEmpty(val))
            {
                return 0;
            }
            return val.Length;

        }

        /// <summary>
        /// ��ȡguidֵ����ΪΨһ��
        /// </summary>
        /// <param name="val">��ȡguidֵ����ΪΨһ��</param>
        static public string getGuid()
        {
            return System.Guid.NewGuid().ToString();
        }


        /// <summary>
        /// ��������: StringToDecimal
        /// ����ժҪ: ����ֵ���ַ�ת��Ϊ˫������
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
        /// ��������: StringToInteger
        /// ����ժҪ: ����ֵ���ַ�ת��Ϊ����
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
        /// ��������: StringToLong
        /// ����ժҪ: ����ֵ���ַ�ת��Ϊ������
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
        /// ��������: StringToDateTime
        /// ����ժҪ: ���������ַ�ת��Ϊ��������
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
        /// ��ȡָ�������ַ�
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
        /// ��ȡָ�������ַ�
        /// </summary>
        /// <param name="inputStr"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public string CutString(string inputStr, int len)
        {
            return CutString(inputStr, len, "...");
        }

        /// <summary>
        /// ���ݲ�ֱ�ʶ������ַ���Ϊ�ַ�����
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
        /// �ж�ȫ��
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
                // ch Ϊ���ֻ�ȫ���ַ�
                return true;
            }
            else
            {
                return false;
            }

        }//end public  bool IsChinese(char str)


        /// <summary>
        /// �ж��Ƿ�����
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
        //		/// �ж��Ƿ�ȫ��
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
        /// �ж��Ƿ���������ַ�
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
        /// ��������: GetLengthString
        /// ����ժҪ: ��ȡʵ�ʳ��ȵ��ַ�������
        /// </summary>
        /// <param name="pSource">Դ�Է���</param>
        /// <param name="pLength">��Ҫ���ַ�����</param>
        /// <param name="pSeparator">ʵ��ת��ʱ���ַ����Ȳ���ʱ���ķ���</param>
        static public string getLengthStr(string pSource, int pLength, string pSeparator)
        {
            if (pSource == null || pSource == string.Empty)
            {
                return string.Empty;
            }
            int n = 0;//��¼Сд��ĸ�ȵĸ���
            bool isAddSeparator = false;//��־���Ƿ�Ҫ��������
            StringBuilder str = new StringBuilder(string.Empty);
            if (pSource.Length > pLength) //Դ�ַ������ȴ�����Ҫ���ַ�������ʱ����������н�ȡ
            {
                string pSource0 = pSource.Substring(0, pLength);

                int pSourceLength = pSource.Length;//Դ�����ַ�����
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

                if (n > 0) //pSource0����Сд��ĸ�ȣ��ٽ�ȡһ�����ַ������в���
                {
                    string strPsource1 = pSource.Substring(pLength, pSourceLength - pLength);//Դ�ַ�����ȡpLength���ַ�����´�

                    foreach (char chr in strPsource1)
                    {
                        if (n >= -1)//(�����������һ��Сд��ĸ�ļ��)
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

                //�ж��Ƿ�Ҫ��������
                if (isAddSeparator)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        str.Append(pSeparator);
                    }
                }

            }
            else//Դ�ַ�������С����Ҫ���ַ�����ʱ��ֱ�ӷ���
            {
                str.Append(pSource);
            }
            return str.ToString();
        }

        /// <summary>
        /// ��ʽ���ַ���ΪOralce���ݿ���Խ��ܵı���ģʽ
        /// </summary>
        /// <param name="sqlSource">��Ҫ��ʽ�����ַ���</param>
        /// <returns>��ʽ������ַ���</returns>
        static public string FormatSqlStr(string sqlSource)
        {
            string sqlTarget;
            if (sqlSource == null)
            {
                return string.Empty;
            }
            sqlTarget = sqlSource.Replace("'", "''");
            return sqlTarget;
        } //public  string FormatSqlStr ����

        /// <summary>
        /// ΪORACLE��ʽ���ַ���
        /// </summary>
        /// <param name="ParameterStr">��Ҫ��ʽ�����ַ���</param>
        /// <returns>��ʽ������ַ���</returns>
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
        /// �ж��ַ��Ƿ���ֵ
        /// </summary>
        /// <param name="sString">��Ҫ�жϵ��ַ���</param>
        /// <returns>�Ƿ���Чֵ</returns>
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
        } //public  string FormatSqlStr ����

        /// <summary>
        /// ��ֵ�͵���string��trim,��ֵ��ֱ�ӷ���
        /// </summary>
        /// <param name="sString">��Ҫ�жϵ��ַ���</param>
        /// <returns>�Ƿ���Чֵ</returns>
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
        } //public  string FormatSqlStr ����


        ///<summary>
        ///�ַ����ȷֲ���ָ��������,��ʹ���ڱ���ʾʱ����(��Ҫ���NOTES����ʾ���ʱʹ��)
        ///</summary>
        ///<param name="sString">Ҫ������ַ���</param>
        ///<param name="Number">�ȷֵķ���</param>
        ///<param name="Char">Ҫ���������</param>
        ///<param name="flag">��ֱ�־</param>
        ///<return>���ز���br����ַ���</return>
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
        /// ���� 
        /// code_type : System.Text.Encoding.UTF8.EncodingName
        /// </summary>
        /// <param name="code_type">ԭʼ����</param>
        /// <param name="code">��Ҫ������ַ���</param>
        /// <returns>����Ľ��</returns>
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
        /// ����
        /// code_type : System.Text.Encoding.UTF8.EncodingName
        /// </summary>
        /// <param name="code_type">ת���ı���</param>
        /// <param name="code">��Ҫ������ַ���</param>
        /// <returns>������</returns>
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
        /// ��������: GetLengthString
        /// ����ժҪ: ��ȡʵ�ʳ��ȵ��ַ�������
        /// </summary>
        /// <param name="pSource">Դ�ַ�������</param>
        /// <param name="pLength">��ȡ��ʵ�ʳ���</param>
        /// <param name="pSeparator">������Ҫ������ַ�</param>
        /// <returns></returns>
        public static string GetLengthString(string pSource, int pLength, string pSeparator)
        {
            StringBuilder sbString = new StringBuilder(string.Empty);
            int iTrueLen = 0;                     //�Ѿ���ȡ���ַ�ʵ�ʳ���
            int iStrLen = 0;                     //�Ѿ���ȡ���ַ�������ȡ����
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
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }
                            else
                            {
                                if (IsChinese(sSource.Substring(iStrLen - 3, 1)[0]))//�ж�ǰ�����ַ��Ƿ��Ǻ��� 
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + " ".PadRight(4, '.'));
                                }
                                else
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + string.Empty.PadRight(3, '.'));
                                }
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���

                            break;
                        }
                        else if (iTrueLen == pLength)
                        {
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + " ".PadRight(4, '.'));
                            }
                            else
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���
                            break;
                        }
                    }//end  if (IsChinese(chr))
                    else
                    {
                        iTrueLen = iTrueLen + 1;
                        if (iTrueLen == pLength)
                        {
                            if (IsChinese(sSource.Substring(iStrLen - 2, 1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���
                            {
                                sbString.Append(sSource.Substring(0, iStrLen - 2) + string.Empty.PadRight(3, '.'));
                            }
                            else
                            {
                                if (IsChinese(sSource.Substring(iStrLen - 3, 1)[0]))//�ж�ǰ�����ַ��Ƿ��Ǻ��� 
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + " ".PadRight(4, '.'));
                                }
                                else
                                {
                                    sbString.Append(sSource.Substring(0, iStrLen - 3) + string.Empty.PadRight(3, '.'));
                                }
                            }//end if (IsChinese(sSource.Substring(iStrLen - 2,1)[0]))//�ж�ǰһ���ַ��Ƿ��Ǻ���
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
        /// ���ַ�����תΪ�ַ���
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
        /// �����ַ���ʽ��(���ڶԱ�ϵͳ��������%,_,?�Ĵ��� �磺"?" --> (char)6 )
        /// </summary>
        /// <param name="sString">��Ҫ��ʽ�����ַ���</param>
        /// <returns>��ʽ������ַ���</returns>
        static public string FormatSpecialChar(string sString)
        {
            //string strValue = string.Empty;
            if (sString != null)
            {
                sString = sString.Replace("?", Convert.ToString((char)6)); // ����IBatis����,?��Ibatis���Ǳ�����
                sString = sString.Replace("_", Convert.ToString((char)5)); // _��Oracle���Ǳ�����
                sString = sString.Replace("%", Convert.ToString((char)1)); // _��Oracle���Ǳ�����
            }

            return sString;
        }

        /// <summary>
        /// �����ַ�����(���ڶԱ�ϵͳ��������%,_,?�Ĵ��� �磺(char)6 --> "?")
        /// </summary>
        /// <param name="sString">��Ҫ�������ַ���</param>
        /// <returns>��������ַ���</returns>
        static public string TransferSpecialChar(string sString)
        {
            //string strValue = string.Empty;
            if (sString != null)
            {
                sString = sString.Replace(Convert.ToString((char)6), "?"); // ����IBatis����,?��Ibatis���Ǳ�����
                sString = sString.Replace(Convert.ToString((char)5), "_"); // _��Oracle���Ǳ�����
                sString = sString.Replace(Convert.ToString((char)1), "%"); // _��Oracle���Ǳ�����
            }

            return sString;
        }

        /// <summary>
        /// �ж�һ���ַ����Ƿ����������һ���ַ�������
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
        /// ��ʽ���ַ�������Ϊ�������������ַ���
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
        /// �޸�URL���棬ָ���Ĳ���
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
                //�������Ҫ��ֵ�Ĳ���
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
        /// �Ƴ�URL���棬ָ���Ĳ���
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
                //�������Ҫ��ֵ�Ĳ���
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

        //�޸ļ�¼02 begin

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
        //�޸ļ�¼02 end
        /// <summary>
        /// �ʼ�������ָ��λ�ò��� <P>��ǩ�����ǵ�����A��ǩʱ���������ݲ�Ҫ����<P>
        /// </summary>
        /// <param name="position">ָ��λ��</param>
        /// <param name="strSource">Դ��</param>
        /// <returns>����P��ǩ�Ĵ�</returns>
        public static string InsertTagForMail(int position, string strSource)
        {
            string strTag = "<p>";
            if (strSource == null || strSource == string.Empty)
            {
                return string.Empty;
            }
            string strBakup = strSource;
            strSource = MapContent(strSource, "<a[^<]*>(?'property'[^\"]*?)</a>");//�滻<a></a>��ǩ
            string brString = "��";
            string emptyString = "��";
            //����FreeTextBox�ؼ��󣬰ѿո�����&nbsp;,���Ի�Ҫ��������ĳ���Ϊ1��������6
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
                sbReturnString = sbReturnString.Replace(emptyString, "&nbsp;");//��ԭ�ո�

                return sbReturnString.ToString();
            }
            catch
            {
                return strBakup;
            }
        }

        /// <summary>
        /// ��ָ����λ��ǿ��д�� һָ���ı�ǩ�����ʼ�����ʹ��
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
            string brString = "��";
            string strTag16 = "��";//�����滻strTag�ı�ǩ
            string emptyString = "��";
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
        /// ���ַ�����ɾ��ǰ���ĳ��ָ�����ַ���
        /// </summary>
        /// <param name="source">ԭ��</param>
        /// <param name="target">Ŀ¼��</param>
        /// <returns>���</returns>
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
