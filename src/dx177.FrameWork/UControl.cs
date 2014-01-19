using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Data;

namespace dx177.FrameWork
{
   public   class UControl
    {
        public static void BindDropList(ListControl droplist, DataTable dt, string DataValueField, string DataTextField)
        {
            string strDefalut = "";
            droplist.DataSource = dt;
            droplist.DataValueField = DataValueField;
            droplist.DataTextField = DataTextField;
            droplist.DataBind();
        }


        /// <summary>
        /// 给CheckList赋值
        /// </summary>
        /// <param name="chklist"></param>
        /// <param name="svalue"></param>
        public static void SetCheckListValue(CheckBoxList chklist, string svalue)
        {
            string[] arr = svalue.Split(',');
            if (arr != null && arr.Length > 0)
            {
                foreach (string s in arr)
                {
                    for (int i = 0; i < chklist.Items.Count; i++)
                    {
                        if (chklist.Items[i].Value == s)
                        {
                            chklist.Items[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取CheckList的值
        /// </summary>
        /// <param name="chklist"></param>
        /// <param name="svalue"></param>
        public static string GetCheckListValue(CheckBoxList chklist)
        {
            string strValue = "";
            for (int i = 0; i < chklist.Items.Count; i++)
            {
                if (chklist.Items[i].Selected)
                {
                    strValue += chklist.Items[i].Value + ",";
                }
            }
            strValue = strValue.Trim(',');
            return strValue;
        }

        public static void SetDropDownlistValue(DropDownList drp, string Value)
        {
            drp.SelectedIndex = drp.Items.IndexOf(drp.Items.FindByValue(Value));
        }


        public static void CopyControlToEntity(Control Ctrl, object entity)
        {
            Type type = entity.GetType();
            CopyControlToEntity(Ctrl, type, entity);
        }


        public static void CopyControlToEntity(Control Ctrl, Type type, object entity)
        {
            if (type != null)
            {
                PropertyInfo[] properties = type.GetProperties();
                try
                {
                    foreach (PropertyInfo info in properties)
                    {
                        Control ctrl = Ctrl.FindControl("txt" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is TextBox)
                            {
                                if (info.PropertyType == typeof(string))
                                {
                                    info.SetValue(entity, (ctrl as TextBox).Text, null);
                                }
                                else
                                {
                                    if ((ctrl as TextBox).Text.Trim() != string.Empty)
                                    {
                                        info.SetValue(entity, Convert.ChangeType((ctrl as TextBox).Text.Trim(), info.PropertyType), null);
                                    }
                                }
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("drp" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.PropertyType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as DropDownList).SelectedValue, null);
                            }
                            else
                            {
                                if ((ctrl as DropDownList).SelectedValue != null && (ctrl as DropDownList).SelectedValue != string.Empty)
                                {
                                    info.SetValue(entity, Convert.ChangeType((ctrl as DropDownList).SelectedValue, info.PropertyType), null);
                                }

                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("rbt" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.PropertyType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as RadioButtonList).SelectedValue, null);
                            }
                            else
                            {
                                if ((ctrl as RadioButtonList).SelectedValue != null && (ctrl as RadioButtonList).SelectedValue != string.Empty)
                                {
                                    info.SetValue(entity, Convert.ChangeType((ctrl as RadioButtonList).SelectedValue, info.PropertyType), null);
                                }

                            }
                            continue;
                        }


                        ctrl = Ctrl.FindControl("date" + info.Name);
                        if (ctrl != null)
                        {
                            if ((ctrl as My97.DateTextBox).Text != string.Empty)
                            {
                                info.SetValue(entity, Convert.ToDateTime((ctrl as My97.DateTextBox).Text.Trim()), null);
                            }

                            continue;
                        }

                       

                        ctrl = Ctrl.FindControl("chklist" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.PropertyType == typeof(string))
                            {
                                info.SetValue(entity, GetCheckListValue((ctrl as CheckBoxList)), null);
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("chk" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.PropertyType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as CheckBox).Checked ? "1" : "0", null);
                            }
                            else if (info.PropertyType == typeof(int))
                            {

                                info.SetValue(entity, (ctrl as CheckBox).Checked ? 1 : 0, null);
                            }
                            continue;
                        }

                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }




        public static void CopyControlToEntityFields(Control Ctrl, object entity)
        {
            Type type = entity.GetType();
            if (type != null)
            {
                FieldInfo[] properties = type.GetFields();
                try
                {
                    foreach (FieldInfo info in properties)
                    {
                        Control ctrl = Ctrl.FindControl("txt" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is TextBox)
                            {
                                if (info.FieldType == typeof(string))
                                {
                                    info.SetValue(entity, (ctrl as TextBox).Text.Trim());
                                }
                                else
                                {
                                    if ((ctrl as TextBox).Text.Trim() != string.Empty)
                                    {
                                        info.SetValue(entity, Convert.ChangeType((ctrl as TextBox).Text.Trim(), info.FieldType));
                                    }
                                }
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("drp" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.FieldType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as DropDownList).SelectedValue);
                            }
                            else
                            {
                                info.SetValue(entity, Convert.ChangeType((ctrl as DropDownList).SelectedValue, info.FieldType));
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("rbt" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.FieldType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as RadioButtonList).SelectedValue);
                            }
                            else
                            {
                                info.SetValue(entity, Convert.ChangeType((ctrl as RadioButtonList).SelectedValue, info.FieldType));
                            }
                            continue;
                        }


                        ctrl = Ctrl.FindControl("date" + info.Name);
                        if (ctrl != null)
                        {
                            if ((ctrl as My97.DateTextBox).Text != string.Empty)
                            {
                                info.SetValue(entity, Convert.ToDateTime((ctrl as My97.DateTextBox).Text));
                            }

                            continue;
                        }
 

                        ctrl = Ctrl.FindControl("chklist" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.FieldType == typeof(string))
                            {
                                info.SetValue(entity, GetCheckListValue((ctrl as CheckBoxList)));
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("chk" + info.Name);
                        if (ctrl != null)
                        {
                            if (info.FieldType == typeof(string))
                            {
                                info.SetValue(entity, (ctrl as CheckBox).Checked ? "1" : "0");
                            }
                            else if (info.FieldType == typeof(int))
                            {

                                info.SetValue(entity, (ctrl as CheckBox).Checked ? 1 : 0);
                            }
                            continue;
                        }
                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        public static void CopyEntityToControl(Control Ctrl, object entity)
        {
            Type type = entity.GetType();
            CopyEntityToControl(Ctrl, type, entity);
        }

        public static void CopyEntityToControl(Control Ctrl, Type type, object entity)
        {
            if (type != null)
            {
                PropertyInfo[] properties = type.GetProperties();
                try
                {
                    foreach (PropertyInfo info in properties)
                    {
                        Control ctrl = Ctrl.FindControl("txt" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is TextBox)
                            {
                                (ctrl as TextBox).Text = "";
                                object obj2 = info.GetValue(entity, null);
                                (ctrl as TextBox).Text = (obj2 == null ? string.Empty : obj2.ToString());
                            }

                            if (ctrl is HiddenField)
                            {
                                (ctrl as HiddenField).Value = "";
                                object obj2 = info.GetValue(entity, null);
                                (ctrl as HiddenField).Value = (obj2 == null ? string.Empty : obj2.ToString());
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("drp" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is DropDownList)
                            {
                                object obj2 = info.GetValue(entity, null);
                                SetDropDownlistValue((ctrl as DropDownList), obj2.ToString());
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("rbt" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is RadioButtonList)
                            {
                                object obj2 = info.GetValue(entity, null);
                                (ctrl as RadioButtonList).SelectedValue = obj2.ToString();
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("date" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity, null);
                            (ctrl as My97.DateTextBox).Text = "";
                            if (obj2 != null)
                            {
                                DateTime data = DateTime.Parse(obj2.ToString());
                                if (data.ToString("yyyy-MM-dd") != "1900-01-01")
                                {


                                    if (ctrl is My97.DateTextBox)
                                    {


                                        object fromatString = (ctrl as My97.DateTextBox).Attributes[GlobalVariable.CONTROL_DATE_FORMAT];

                                        if (fromatString != null)
                                        {
                                            (ctrl as My97.DateTextBox).Text = string.Format("{0:" + fromatString.ToString() + "}", data);
                                        }
                                        else
                                        {
                                            //(ctrl as My97.DateTextBox).Text = ((DateTime)obj2).ToString();
                                            (ctrl as My97.DateTextBox).Text = data.ToString("yyyy-MM-dd");
                                        }

                                    }
                                }
                                continue;
                            }
                        }

                        

                        ctrl = Ctrl.FindControl("chklist" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity, null);
                            if (obj2 != null && obj2.ToString() != string.Empty)
                            {
                                if (ctrl is CheckBoxList)
                                {
                                    SetCheckListValue((ctrl as CheckBoxList), obj2.ToString());
                                }
                                continue;
                            }
                        }

                        ctrl = Ctrl.FindControl("chk" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity, null);
                            if (obj2 != null)
                            {
                                if (ctrl is CheckBox)
                                {
                                    (ctrl as CheckBox).Checked = (obj2.ToString() == "1");
                                }
                                continue;
                            }
                        }

                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        public static void CoypInfoToControl(Control Ctrl, object entity)
        {
            Type type = entity.GetType();
            if (type != null)
            {
                FieldInfo[] properties = type.GetFields();
                try
                {
                    foreach (FieldInfo info in properties)
                    {
                        Control ctrl = Ctrl.FindControl("txt" + info.Name);
                        if (ctrl != null)
                        {
                            if (ctrl is TextBox)
                            {
                                object obj2 = info.GetValue(entity);
                                (ctrl as TextBox).Text = (obj2 == null ? string.Empty : obj2.ToString());
                                continue;
                            }
                        }

                        ctrl = Ctrl.FindControl("drp" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity);
                            if (obj2 != null)
                            {
                                SetDropDownlistValue((ctrl as DropDownList), obj2.ToString());
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("rbt" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity);
                            if (obj2 != null && obj2.ToString() != string.Empty)
                            {
                                (ctrl as RadioButtonList).SelectedValue = obj2.ToString();
                            }
                            continue;
                        }

                        ctrl = Ctrl.FindControl("date" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity);
                            if (obj2 != null)
                            {
                                (ctrl as My97.DateTextBox).Text = ((DateTime)obj2).ToString();
                                continue;
                            }
                        }
                       
                        ctrl = Ctrl.FindControl("chklist" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity);
                            if (obj2 != null && obj2.ToString() != string.Empty)
                            {
                                SetCheckListValue((ctrl as CheckBoxList), obj2.ToString());
                                continue;
                            }
                        }

                        ctrl = Ctrl.FindControl("chk" + info.Name);
                        if (ctrl != null)
                        {
                            object obj2 = info.GetValue(entity);
                            if (obj2 != null)
                            {
                                (ctrl as CheckBox).Checked = (obj2.ToString() == "1");
                                continue;
                            }
                        }

                    }
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }


        public static bool Compare(object o, string strvalue)
        {
            if (o == null && string.IsNullOrEmpty(strvalue))
            {
                return true;
            }
            else if (o != null)
            {
                if (o.ToString() != strvalue)
                {
                    return false;
                }
            }
            return true;
        }


        public static string GetDropListTextByValue(DropDownList dr, string strvalue)
        {
            ListItem listitem = dr.Items.FindByValue(strvalue);
            if (listitem != null)
            {
                return listitem.Text;
            }
            return "原来value：" + strvalue;
        }

    }
}
