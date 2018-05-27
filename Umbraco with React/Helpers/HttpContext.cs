namespace Umbraco_with_React.Helpers
{
    public class  HttpContext : IHttpContext
    {
        public string AbsolutePath()
        {
            return System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        }
    }
}