using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class FooterHomeModelAdapter : IModelAdapter<FooterHomeModel>
    {
        public FooterHomeModel Adapt(IPublishedContent content)
        {
            return new FooterHomeModel
            {
                Header = content.GetPropertyValue<string>("footerHeader"),
                Description = content.GetPropertyValue<string>("footerDescription"),
                CallToActionCaption = content.GetPropertyValue<string>("footerCTACaption"),
                CallToActionLink = content.GetPropertyValue<string>("FooterCtalink")
            };
        }
    }
}