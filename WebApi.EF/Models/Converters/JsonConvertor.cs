using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;

namespace WebApi8.FisstApp.Models.Converters
{
    public class JsonObjectConverter<T> : ValueConverter<T, string>
    {
        public JsonObjectConverter() : base
            (
                jsonObj => ConvertToJsonStr(jsonObj),
                jsonStr => ConvertToJsonObj(jsonStr)
            )
        { }

        private static string ConvertToJsonStr(T jsonObj)
        {
            if (jsonObj == null)
                return default!;
            
            return JsonSerializer.Serialize(jsonObj);
        }


        private static T ConvertToJsonObj(string jsonStr)
        {
            if (string.IsNullOrWhiteSpace(jsonStr))
                return default(T)!;

            return JsonSerializer.Deserialize<T>(jsonStr)!;
        }

    }
}
