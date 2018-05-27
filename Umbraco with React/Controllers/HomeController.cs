using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;
using ActionResult = System.Web.Mvc.ActionResult;

namespace Umbraco_with_React.Controllers
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