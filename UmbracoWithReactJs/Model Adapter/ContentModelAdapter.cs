using Umbraco.Core.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Models
{
    public class ContentModelAdapter:IModelAdapter<ContentModel>
    {
        public ContentModel Adapt(IPublishedContent content)
        {
            return new ContentModel
            {
                Id = content.Id,
                Name = content.Name,
                Url = content.Url
            };
        }
    }
}