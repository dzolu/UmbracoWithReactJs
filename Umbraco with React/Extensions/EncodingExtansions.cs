using System.Text;

namespace Umbraco_with_React.Extensions
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