using System.Text;

namespace UmbracoWithReactJs.Extensions
{
    public static class EncodingExtansions
    {
        public static string EncodeUtf8(this Encoding encoding, string text)
        {
            var bytes = Encoding.Default.GetBytes(text);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}