using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace dx177.FrameWork
{
	/// <summary>
	/// ҳ�淵��ʱ,������¼��һ��ҳ�������
	/// </summary>
	public class BasePageCondionRemeberHandler
	{
        private string FielderSplitChar = "��";
        private string EqualChar = "��";

		public BasePageCondionRemeberHandler()
		{
			EvaluateProperty("");
		}
        public BasePageCondionRemeberHandler(string condionString)
        {
            EvaluateProperty(condionString);
        }

        /// <summary>
        /// ͨ���������������Ը�ֵ
        /// </summary>
        /// <param name="condionString">��������</param>
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
        /// ͨ������,�õ���������
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
