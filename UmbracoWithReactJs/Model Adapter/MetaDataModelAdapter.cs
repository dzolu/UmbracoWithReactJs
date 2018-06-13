using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class MetaDataModelAdapter : IModelAdapter<MetaData>
    {
        public MetaData Adapt(IPublishedContent content)
        {
            return new MetaData
            {
                PageName = content.Name,
                PageId = content.Id,
                PageTitle = content.GetPropertyValue<string>("pageTitle") ?? "",
                SiteDescription = content.GetPropertyValue<string>("seoMetaDescription") ?? "",
                PageURL = content.Url
            };
        }
    }
}