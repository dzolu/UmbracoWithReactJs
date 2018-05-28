using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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
                Content = content.GetPropertyValue<string>("bodyText"),
                FooterHomeModel = _footerModelAdapter.Adapt(content)
            };
        }
    }
}