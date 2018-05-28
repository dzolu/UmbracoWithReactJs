using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
{
    public class HomeController : DefaultController
    {
        private readonly IModelAdapter<HomeModel> _homeModelAdapter;

        public HomeController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<HomeModel> homeModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _homeModelAdapter = homeModelAdapter;
        }

        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var homeModel = _homeModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = homeModel;
            return initialState;
        }
    }
}