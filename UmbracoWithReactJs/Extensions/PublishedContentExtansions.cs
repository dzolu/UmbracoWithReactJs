using Umbraco.Core.Models;
using Umbraco.Web;

namespace UmbracoWithReactJs.Extensions
{
    public static class PublishedContentExtansions{
        public static IPublishedContent GetTypedMediaByAlias(this IPublishedContent content, string name)
        {
            return new UmbracoHelper(UmbracoContext.Current).TypedMedia(content.GetPropertyValue<int>(name));
        }
    }
}