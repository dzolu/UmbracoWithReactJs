using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Extensions;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class HeroModelAdapter : IModelAdapter<HeroModel>
    {
        private readonly IModelAdapter<ImageModel> _imageModelAdapter;

        public HeroModelAdapter(IModelAdapter<ImageModel> imageModelAdapter)
        {
            _imageModelAdapter = imageModelAdapter;
        }

        public HeroModel Adapt(IPublishedContent content)
        {
            return new HeroModel
            {
                Header = content.GetPropertyValue<string>("heroHeader"),
                Description = content.GetPropertyValue<string>("heroDescription"),
                CallToActionCaption = content.GetPropertyValue<string>("heroCTACaption"),
                CallToActionLink = content.GetPropertyValue<string>("HeroCtalink"),
                HeroBackground = _imageModelAdapter.Adapt(content.GetTypedMediaByAlias("HeroBackgroundImage"))
            };
        }
    }
}