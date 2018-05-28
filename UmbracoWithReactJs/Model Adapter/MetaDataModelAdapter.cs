using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class MetaDataModelAdapter:IModelAdapter<MetaDataModel>
    {
        public MetaDataModel Adapt(IPublishedContent content)
        {
            return new MetaDataModel
            {
                PageName = content.Name,
                PageId = content.Id,
                PageTitle = content.GetPropertyValue<string>("pageTitle"),
                SiteDescription = content.GetPropertyValue<string>("siteDescription")
            };
        }
    }
  
}