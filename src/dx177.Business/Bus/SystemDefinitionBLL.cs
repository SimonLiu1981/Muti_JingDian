using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using dx177.Model.Bus;
using dx177.DataAccess.Access;

namespace dx177.Business.Bus
{
    public class SystemDefinitionBLL
    {
        static Dictionary<string, SystemDefinition> SdCache = new Dictionary<string, SystemDefinition>();
        public SystemDefinition GetByBrandingCode(string bc)
        {
            if (SdCache.ContainsKey(bc))
            {
                return SdCache[bc];
            }

            DataTable dt = DBTool.ExecuteDataTable("select * from SystemDefinion where BrandingCode = '" + bc + "'");
            if (dt.Rows.Count == 0)
            {
                DBTool.ExecuteNonQuery("INSERT INTO [SystemDefinion]([BrandingCode])     VALUES ('" + bc.Replace("'", "''") + "')");
                dt = DBTool.ExecuteDataTable("select * from SystemDefinion where BrandingCode = '" + bc.Replace("'", "''") + "'");
            }
            else
            {
                dt = DBTool.ExecuteDataTable("select * from SystemDefinion where BrandingCode = '" + bc.Replace("'", "''") + "'");
            }

           SystemDefinition sd = new SystemDefinition { BrandingCode = bc, Value = dt.Rows[0]["Value"].ToString(), Description = dt.Rows[0]["Description"].ToString() };
           SdCache.Add(bc, sd);

            return  SdCache[bc];
        }


        public void UpdateSystemDefinition(SystemDefinition sd)
        {
            DBTool.ExecuteNonQuery(string.Format("UPDATE [SystemDefinion]   SET [Value] = '{0}',[Description] = '{1}' WHERE  [BrandingCode] = '{2}'", sd.Value.Replace("'", "''"), sd.Description.Replace("'", "''"), sd.BrandingCode.Replace("'", "''")));

            if (SdCache.ContainsKey(sd.BrandingCode))
            {
                SdCache[sd.BrandingCode] = sd;
            }
            else
            {
                SdCache.Add(sd.BrandingCode, sd);
            }
        }
    }
}
