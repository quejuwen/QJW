using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Utils
{
    /// <summary>
    /// 简单对象映射类，根据相同属性名称复制
    /// </summary>
    public static class SimpleMapper
    {
        public static TOutput Map<TInput, TOutput>(TInput input) where TOutput : new()
        {
            return Map<TInput, TOutput>(input, null);
        }

        public static TOutput Map<TInput, TOutput>(TInput input, Action<TInput, TOutput> fixFun) where TOutput : new()
        {
            if (input == null) return default(TOutput);

            var inputAccessor = SimpleAccessor.GetInfo<TInput>();
            var outputAccessor = SimpleAccessor.GetInfo<TOutput>();
            TOutput output = default(TOutput);
            try
            {
                output = map(input, inputAccessor, outputAccessor);
            }
            catch
            {
                ;//映射出错自己处理
            }
            if (fixFun != null)
            {
                fixFun(input, output);
            }
            return output;
        }

        public static List<TOutput> Map<TInput, TOutput>(List<TInput> inputList) where TOutput : new()
        {
            return Map<TInput, TOutput>(inputList, null);
        }
        public static List<TOutput> Map<TInput, TOutput>(List<TInput> inputList, Action<TInput, TOutput> fixFun) where TOutput : new()
        {
            List<TOutput> outList = new List<TOutput>();
            if (inputList == null || inputList.Count == 0)
            {
                return outList;
            }
            var inputAccessor = SimpleAccessor.GetInfo<TInput>();
            var outputAccessor = SimpleAccessor.GetInfo<TOutput>();

            foreach (var input in inputList)
            {
                TOutput output = map(input, inputAccessor, outputAccessor);
                if (fixFun != null)
                {
                    fixFun(input, output);
                }
                outList.Add(output);
            }
            return outList;
        }

        static private TOutput map<TInput, TOutput>(TInput input, ReflectionInfo<TInput> inputAccessor, ReflectionInfo<TOutput> outputAccessor)
        {
            var output = outputAccessor.NewInstance();
            foreach (var kv in inputAccessor.Accessors)
            {
                if (kv.Value != null)
                {
                    var accessor = outputAccessor.GetAccessor(kv.Key);
                    if (accessor != null && accessor.Prop != null)
                    {
                        if (accessor.Prop.PropertyType == kv.Value.Prop.PropertyType || accessor.Prop.PropertyType.IsAssignableFrom(kv.Value.Prop.PropertyType))
                        {
                            accessor.Set(output, kv.Value.Get(input));
                        }
                        //处理枚举 和基础类型
                        if (accessor.Prop.PropertyType.IsEnum && accessor.Prop.PropertyType.GetEnumUnderlyingType() == kv.Value.Prop.PropertyType)
                        {
                            accessor.Set(output, kv.Value.Get(input));
                        }
                        if (kv.Value.Prop.PropertyType.IsEnum && kv.Value.Prop.PropertyType.GetEnumUnderlyingType() == accessor.Prop.PropertyType)
                        {
                            accessor.Set(output, kv.Value.Get(input));
                        }
                    }
                }
            }
            return output;
        }
    }
}
