
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class HomeModelAdapter : IModelAdapter<HomeModel>
    {
        private readonly IModelAdapter<HeroModel> _heroModelAdapter;
        private readonly IModelAdapter<FooterHomeModel> _footerModelAdapter;

        public HomeModelAdapter(IModelAdapter<HeroModel> heroModelAdapter,
            IModelAdapter<FooterHomeModel> footerModelAdapter
        )
        {
            _heroModelAdapter = heroModelAdapter;
            _footerModelAdapter = footerModelAdapter;
        }

        public HomeModel Adapt(IPublishedContent content)
        {
            
            return new HomeModel
            {
                Hero = _heroModelAdapter.Adapt(content),
                Content = content.GetGridHtml("bodyText", "bootstrap3-fluid").ToHtmlString() ,
                FooterHomeModel = _footerModelAdapter.Adapt(content)
            };
        }
    }
}