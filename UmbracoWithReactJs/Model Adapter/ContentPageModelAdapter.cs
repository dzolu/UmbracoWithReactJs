using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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