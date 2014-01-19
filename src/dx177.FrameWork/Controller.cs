using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Net;

namespace dx177.FrameWork
{
    public  class Controller
    {

        public static object InvokeMethod(Type targettype, string targetmethod, ref string Errmsg, object[] args)
        {
            //实例化类型。可扩展
            object instance = Activator.CreateInstance(targettype);
            //#region 设置用户
            //MethodInfo methodSetOpetor = targettype.GetMethod("SetOperator");
            //if (methodSetOpetor != null)
            //{
            //    methodSetOpetor.Invoke(instance, new object[1] { loginUserinfo });
            //}
            //#endregion

            object[] Args = null;
            MethodInfo method = targettype.GetMethod(targetmethod);
            ParameterInfo[] param = method.GetParameters();
            if (param.Length == 1 && param[0].ParameterType.IsArray && !param[0].ParameterType.GetElementType().IsValueType)
            {
                //单参数数组不能直接invoke，要转换；非值类型，如果是ValueType，无需转换
                Args = new object[1];
                Args[0] = args;
            }
            else
            {
                //参数个数校验
                //注：无参方法的param不为空，长度为0.
                if (param != null && param.Length > 0 && args != null && param.Length != args.Length)
                {
                    //参数个数不对
                    Log.WriteError("InvokeMethod", "参数个数不对");
                    //throw new SHOPException(MessageDefine.SYS_ERR_FUNCTION_NOT_SAMEPARM);
                }
                Args = args;
            }
            object result = null;

            if (method.IsStatic)
            {
                result = method.Invoke(null, Args);
            }
            else
            {
                result = method.Invoke(instance, Args);
            }
            return result;
        }
        public static TTypeToReturn Invoke<TTargetType, TTypeToReturn>(string targetmethod, ref string Errmsg, object[] args)
        {
            object obj = null;
            try
            {
                obj = InvokeMethod(typeof(TTargetType), targetmethod, ref Errmsg, args);
            }
            catch (TargetInvocationException tiex)
            {

            }
            catch (WebException ex)
            {
                Log.WriteError("InvokeMethod", ex.ToString());
                // CommonHelper.WriteError("InvokeMethod", ex.Message);
            }
            catch (Exception ex)
            {
                Log.WriteError("InvokeMethod", ex.Message);
                // CommonHelper.WriteError("InvokeMethod", ex.Message);
            }
            if (obj == null) return default(TTypeToReturn);
            return (TTypeToReturn)obj;
        }

        public static void Invoke<TTargetType>(string targetmethod, ref string Errmsg, object[] args)
        {
            InvokeMethod<TTargetType, object>(targetmethod, ref Errmsg, args);
        }

        public static TTypeToReturn InvokeMethod<TTargetType, TTypeToReturn>(string targetmethod, ref string Errmsg, params object[] args)
        {
            return Invoke<TTargetType, TTypeToReturn>(targetmethod, ref Errmsg, args);
        }
        public static TTypeToReturn InvokeMethod<TTargetType, TTypeToReturn>(string targetmethod, params object[] args)
        {
            string Errmsg = string.Empty;
            return Invoke<TTargetType, TTypeToReturn>(targetmethod, ref Errmsg, args);
        }
        public static void InvokeMethod<TTargetType>(string targetmethod, ref string Errmsg, params object[] args)
        {
            Invoke<TTargetType, object>(targetmethod, ref Errmsg, args);
        }
    }
}
