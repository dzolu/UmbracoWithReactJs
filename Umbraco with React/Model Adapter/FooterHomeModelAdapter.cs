using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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
                CallToActionLink = content.GetPropertyValue<string>("FooterCtalink"),
                Address = content.GetPropertyValue<string>("footerAddress")
            };
        }
    }
}