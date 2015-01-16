using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = System.Xml.Formatting;

namespace Store.Parser
{
    public static class Json
    {
        public static string ToJson<T>(this T obj) where T : class, new()
        {
            if (obj == null) obj = new T();

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(obj, (Newtonsoft.Json.Formatting)Formatting.None, serializerSettings);
        }
    }
}