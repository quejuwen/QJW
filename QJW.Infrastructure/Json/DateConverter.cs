using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QJW.Infrastructure.Json
{
    [JsonConverter(typeof(CustomDateConverter))]
    /// <summary>
    /// 日期格式化器
    /// </summary>
    public class CustomDateConverter : DateTimeConverterBase
    {
        private IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { };
        public CustomDateConverter(string format)
        {
            dtConverter.DateTimeFormat = format;
           
        }
        public CustomDateConverter() : this("yyyy-MM-dd") { }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return dtConverter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dtConverter.WriteJson(writer, value, serializer);
        }
    }
}
