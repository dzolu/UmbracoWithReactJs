using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class ContentPageModelAdapter : IModelAdapter<ContentPageModel>
    {
        public ContentPageModel Adapt(IPublishedContent content)
        {
            return new ContentPageModel
            {
                PageTitle = content.GetPropertyValue<string>("pageTitle"),
                Body = content.GetPropertyValue<string>("bodyText")
            };
        }
    }
}