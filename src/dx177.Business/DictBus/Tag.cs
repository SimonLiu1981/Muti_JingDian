using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections.Specialized;
using dx177.Model;
using dx177.FrameWork;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.Business.DictBus
{
   public class Tag
	{
	
		const string  TagEnumStr = "TagEnum";

		


		
		/// <summary>
		/// 多语言Enum数据
		/// </summary>
		private HybridDictionary  TagEnumData
		{
			get
			{ 
				if (Dict.CacheData[CacheName.LanguageDictTag] == null)
				{ 
					HybridDictionary hd = new HybridDictionary();
                    DataTable dt = BaseDictTagBLL.GetInstance().GetDataTable("select * from Base_Dict_Tag");
					hd.Add(TagEnumStr, dt);
					Dict.CacheData[CacheName.LanguageDictTag] = hd;
				} 
				return  Dict.CacheData[CacheName.LanguageDictTag] as HybridDictionary; 
			}
		}
		/// <summary>
		/// 获取多语言化标签
		/// </summary>
		/// <remarks> 
		/// 实现流程： 
		///		1.使用TagEnumDictView查询  
		///		2.返回标签   
		///		3.结束    
		/// </remarks> 
		/// <exception cref="Exception">
		/// 异常描述：出现数据库异常,抛出并回滚事务  
		/// </exception>
		/// <param name="StateEnum">枚举</param>
		/// <returns>标签字符串</returns>
		public string this[Enum StateEnum]
		{
			get
			{ 
				//                int StateNo =(int)Enum.Parse(StateEnum.GetType(),StateEnum.ToString());
				string StateNo =((int)Enum.Parse(StateEnum.GetType(),StateEnum.ToString())).ToString();
				return this[StateEnum.GetType().Name, StateNo, AppContext.LCID];
			}
		}

		/// <summary>
		/// 获取多语言化标签
		/// </summary>
		/// <remarks> 
		/// 实现流程： 
		///		1.使用TagEnumDictView查询  
		///		2.返回标签   
		///		3.结束    
		/// </remarks> 
		/// <exception cref="Exception">
		/// 异常描述：出现数据库异常,抛出并回滚事务  
		/// </exception>
		/// <returns>标签字符串</returns>
		public string this[string EnumType, string EnumValue, int LanguageType]
		{
			get
			{
                if (EnumType.ToLower() == "area")
                {
                    EnumValue = string.IsNullOrEmpty(EnumValue) ? "0" : EnumValue;
                    JingquArea jq = JingquAreaBLL.GetInstance().Get(new JingquArea.Key(int.Parse(EnumValue)));
                    if (jq != null)
                    {
                        return jq.Areaname;
                    }
                    return string.Empty;
                }
                else if (EnumType.ToLower() == "issue")
                {
                    EnumValue = string.IsNullOrEmpty(EnumValue) ? "0" : EnumValue;
                    BusIssueType jq = BusIssueTypeBLL.GetInstance().Get(new BusIssueType.Key(int.Parse(EnumValue)));
                    if (jq != null)
                    {
                        return jq.BusIssueTypeName;
                    }
                    return string.Empty;
                }
                else
                {

                    string tag = string.Empty;
                    int LCID = AppContext.LCID;
                    DataRowView[] drv = TagEnumDictView("LCID=" + LCID, "ENUM_TYPE_NAME,ENUM_VALUE")
                        .FindRows(new string[] { EnumType, EnumValue });
                    if (drv.Length > 0)
                    {
                        tag = drv[0]["TAG_NAME"].ToString();
                    }
                    return tag;
                }
			}
		}
                  
        /// <summary>
        /// 类型排序视图
        /// </summary>
        private DataView ViewByType
        {
            get
            {
                return   TagEnumDictView("LCID=" + AppContext.LCID, "ENUM_TYPE_NAME");
            }
        }
                         
        /// <summary>
        /// 根据类别绑定数据控件
        /// </summary>
        /// <remarks> 
        /// 实现流程： 
        ///		1.使用GetTypeView查询  
        ///		2.返回标签集会   
        ///		3.绑定     
        /// </remarks> 
        /// <param name="listContrl">列表控件</param>
        /// <param name="enumType">枚举类型</param>
        public void BindListControl(ListControl listContrl, Enum enumType, string jqcode)
        {
            BindListControl(listContrl , enumType.ToString(), jqcode);
        }
   
        /// <summary>
        /// 根据类别绑定数据控件
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enumTypeName">Exp:typeof(CodeMag).Name</param>
        public void BindListControl(ListControl control, string enumTypeName, string jqcode)
        {
            if (enumTypeName.ToLower() == "area")
            {

                control.DataSource = JingquAreaBLL.GetInstance().GetByJingqucode(jqcode);
                control.DataTextField = "AreaName";
                control.DataValueField = "JingQuAreaId";
                control.DataBind();
            }
            else if (enumTypeName.ToLower() == "issue")
            {

                control.DataSource = BusIssueTypeBLL.GetInstance().GetByJingqucode(jqcode);
                control.DataTextField = "Bus_Issue_Type_Name";
                control.DataValueField = "Bus_Issue_Type_Id";
                control.DataBind();
            }
            else 
            {
                control.DataSource = ViewByType.FindRows(enumTypeName);
                control.DataTextField = "TAG_NAME";
                control.DataValueField = "ENUM_VALUE";
                control.DataBind();
            }
        }
 

        public DataRowView[] GetViewByTypeName(string enumTypeName)
        {
            
            DataRowView[] datas = ViewByType.FindRows(enumTypeName);
            

           return datas;
        }


         
		/// <summary>
		/// 多语言数据
		/// </summary>
		/// <param name="filter">过滤字串</param>
		/// <param name="sort">排序</param>
		/// <returns>视图</returns>
		private DataView TagEnumDictView(string filter, string sort)
		{  
			HybridDictionary hd = TagEnumData;
			int LCID = AppContext.LCID; 
			string key = filter + sort + LCID;
			if (hd[key] == null)
			{
				hd[key] = new DataView(hd[TagEnumStr] as DataTable, filter , sort ,DataViewRowState.CurrentRows);
			}
			return hd[key] as DataView; 
		}
	}
}
