using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class HeroModelAdapter : IModelAdapter<HeroModel>
    {
        public HeroModel Adapt(IPublishedContent content)
        {
            return new HeroModel
            {
                Header = content.GetPropertyValue<string>("heroHeader"),
                Description = content.GetPropertyValue<string>("heroDescription"),
                CallToActionCaption = content.GetPropertyValue<string>("heroCTACaption"),
                CallToActionLink = content.GetPropertyValue<string>("HeroCtalink"),
            };
        }
    }
}