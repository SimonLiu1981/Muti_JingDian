using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using dx177_building.Model;

namespace dx177_building
{
    public class BuildTable
    {

        public static  string CreateTableList(DataTable dt, XmlTableMod h)
        {
            int tempRowCount = 1;
            int Colcount = 1;
            string TempTd = "";
            string TempTrHtml = "";
            string TempTableHtml = "";
            bool isEmpty = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string strTdCode = string.Empty ;
                if (!string.IsNullOrEmpty(h.SpecifyColName) && !string.IsNullOrEmpty(h.SpecifyColValue) && dt.Rows[i][h.SpecifyColName].ToString().ToUpper() == h.SpecifyColValue.ToUpper())
                {
                    strTdCode = h.SpecifyColcode;
                }
                else
                {
                    strTdCode = GetTdCode(Colcount, h);
                }

                TempTrHtml += DataToHtml.DataRowToHtml(dt.Rows[i], strTdCode);
                if (tempRowCount > h.RowCount) break;//超过已经设定的行数
                if (Colcount >= h.ColCount)//列数不能大于设定的列数
                {
                    //记录最后的时候，判断是否TR里的的列数是否需要空的TD来补
                    if (i == dt.Rows.Count)
                    {
                        TempTrHtml += EmptTD(Colcount, h);
                    }
                    TempTableHtml += string.Format(h.TrCode, TempTrHtml);
                    TempTrHtml = "";
                    Colcount = 1;
                    tempRowCount++;
                }
                else
                {
                    if (dt.Rows.Count - 1 == i) isEmpty = true;
                    Colcount++;
                }
            }
            //最后的行不够列不齐
            if (isEmpty)
            {
                TempTrHtml += EmptTD(Colcount - 1, h);
                TempTableHtml += string.Format(h.TrCode, TempTrHtml);
            } 
            
            return string.Format(h.TableCode, TempTableHtml);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="ColCount"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        private static string GetTdCode(int ColCount, XmlTableMod h)
        {
            if (h.SpecialTdColCount > 0 && h.SpecialTdColCount == ColCount)
            {
                return h.SpecialTdCode;
            }
            else
            {
                return h.TdCode;
            }
        }

        private static string EmptTD(int Colcount, XmlTableMod h)
        {
            string temp = "";
            if (!string.IsNullOrEmpty(h.EmptyTdCode) && h.ColCount > Colcount)
            {
                for (int i = Colcount + 1; i <= h.ColCount; i++)
                {
                    temp += h.EmptyTdCode;
                }
            }
            return temp;
        }
    }
}
