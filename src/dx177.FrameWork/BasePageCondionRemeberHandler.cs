using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace dx177.FrameWork
{
	/// <summary>
	/// 页面返回时,用来记录上一个页面的条件
	/// </summary>
	public class BasePageCondionRemeberHandler
	{
        private string FielderSplitChar = "γ";
        private string EqualChar = "ζ";

		public BasePageCondionRemeberHandler()
		{
			EvaluateProperty("");
		}
        public BasePageCondionRemeberHandler(string condionString)
        {
            EvaluateProperty(condionString);
        }

        /// <summary>
        /// 通过条件参数给属性赋值
        /// </summary>
        /// <param name="condionString">条件参数</param>
        private void EvaluateProperty(string condionString)
        {
            PropertyInfo[] propertys = this.GetType().GetProperties();
            
            foreach(PropertyInfo property in propertys)
            {
                property.SetValue(this, "", null);
            }
            if (condionString!=string.Empty)
            {
                string[] fields = Regex.Split(condionString, this.FielderSplitChar);
                
                foreach (string field in fields)
                {
                    if (!field.Equals(string.Empty))
                    {
                        string[] val = Regex.Split(field, this.EqualChar);   
                        foreach(PropertyInfo property in propertys)
                        {
                            if (property.Name == val[0])
                            {
                                property.SetValue(this, val[1], null);
                            }
                        }
                    }
                }
            }

        }

        /// <summary>
        /// 通过属性,得到条件参数
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            PropertyInfo[] propertys = this.GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            foreach(PropertyInfo property in propertys)
            {
                sb.Append(property.Name);
                sb.Append(this.EqualChar);
                sb.Append(property.GetValue(this, null));
                sb.Append(this.FielderSplitChar);
            } 
            return sb.ToString();
        }



	}

    public interface IBindCondtion
    {
        string GetConditionString();

        void BingCondition(string conditionString);
    }
}
