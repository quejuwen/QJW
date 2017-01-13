using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Utils
{

    public class ObjectGenerator
    {

        public static string GetSummary(PropertyInfo prop, Dictionary<string, string> summaryDict)
        {
            if (summaryDict == null || summaryDict.Count == 0) return string.Empty;
            var objType = prop.DeclaringType;
            var propName = prop.Name;
            var key = "P:" + objType.Namespace + "." + GetPrettyName(objType) + objType.Name + "." + propName;
            if (summaryDict.ContainsKey(key))
            {
                return summaryDict[key];
            }
            else
            {
                return "";
            }
        }
        private static string GetPrettyName(Type objType, string namespaceStr = "")
        {
            if (objType.DeclaringType != null)
            {
                return GetPrettyName(objType.DeclaringType, objType.DeclaringType.Name + "." + namespaceStr);
            }
            else
            {
                return namespaceStr;
            }
        }

        public static Tuple<object, object> GetObjectMapDict(Type type, PropertyInfo typeProp, Dictionary<string, string> summaryDict, HashSet<string> ignoreProps = null)
        {
            if (typeProp != null)
            {
                var p = typeProp;
            }
            // 
            if (type.IsPrimitive || type == typeof(decimal))
            {
                var v1 = Convert.ChangeType(0, type);
                var v2 = v1.ToString();
                if (typeProp != null)
                {
                    v2 = GetSummary(typeProp, summaryDict);
                }
                return new Tuple<object, object>(v1, v2);
            }
            else if (type == typeof(string))
            {
                var v1 = "str";
                var v2 = v1.ToString();
                if (typeProp != null)
                {
                    v2 = GetSummary(typeProp, summaryDict);
                }
                return new Tuple<object, object>(v1, v2);
            }
            else if (type == typeof(DateTime))
            {
                var v1 = DateTime.Now;
                var v2 = v1.ToString("yyyy-MM-dd HH:mm:ss");
                if (typeProp != null)
                {
                    v2 = GetSummary(typeProp, summaryDict);
                }
                return new Tuple<object, object>(v1, v2);

            }
            else if (type.IsArray)
            {
                var eleType = type.GetElementType();
                var arr = Array.CreateInstance(eleType, 1);
                var list = new List<object>();
                var ele_tuple = GetObjectMapDict(eleType, typeProp, summaryDict, ignoreProps);
                arr.SetValue(ele_tuple.Item1, 0);
                list.Add(ele_tuple.Item2);
                return new Tuple<object, object>(arr, list);

            }
            else if (type.Name.Equals("List`1"))
            {
                var list = (IList)Activator.CreateInstance(type);
                var list1 = new List<object>();
                var eleType = type.GetGenericArguments()[0];
                var ele_tuple = GetObjectMapDict(eleType, typeProp, summaryDict, ignoreProps);
                list.Add(ele_tuple.Item1);
                list1.Add(ele_tuple.Item2);
                return new Tuple<object, object>(list, list1);
            }
            else if (type.Name.Equals("Dictionary`2"))
            {
                var dict = (IDictionary)Activator.CreateInstance(type);
                var dict1 = new Dictionary<string, object>();
                var keyType = type.GetGenericArguments()[0];
                var valueType = type.GetGenericArguments()[1];
                var key = GetObjectMapDict(keyType, null, summaryDict, ignoreProps);
                var value = GetObjectMapDict(valueType, null, summaryDict, ignoreProps);
                dict.Add(key.Item1, value.Item1);
                dict1.Add(key.Item2.ToString(), value.Item2);

                return new Tuple<object, object>(dict, dict1);
            }
            else if (type.IsClass)
            {
                var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                try
                {
                    var obj = Activator.CreateInstance(type);
                    var dict = new Dictionary<string, object>();
                    foreach (var prop in props)
                    {
                        if (ignoreProps != null && ignoreProps.Contains(prop.Name))
                        {
                            continue;
                        }
                        var pType = DealNullable(prop.PropertyType);
                        var val = GetObjectMapDict(pType, prop, summaryDict, ignoreProps);
                        dict.Add(prop.Name, val.Item2);
                        var setter = prop.GetSetMethod(true);
                        if (setter != null)
                        {
                            prop.SetValue(obj, val.Item1, null);
                        }

                    }
                    return new Tuple<object, object>(obj, dict);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            else
            {
                try
                {
                    var obj = Activator.CreateInstance(type);
                    return new Tuple<object, object>(obj, obj);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        private static Type DealNullable(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return type.GetGenericArguments()[0];
            }
            return type;
        }
    }
    
}
