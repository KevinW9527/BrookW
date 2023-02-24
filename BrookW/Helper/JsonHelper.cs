
namespace BrookW.Helper
{
    using System.Text.Json;

    public static class JsonHelper
    {
        public static string ToJson<T>(this T t)
        {
            return JsonSerializer.Serialize(t);
        }

        public static T? ToObject<T>(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return default;
            }
            return JsonSerializer.Deserialize<T>(str);
        }

    }



}
