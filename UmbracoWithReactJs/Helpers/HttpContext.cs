namespace UmbracoWithReactJs.Helpers
{
    public class  HttpContext : IHttpContext
    {
        public string AbsolutePath()
        {
            return System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        }
    }
}