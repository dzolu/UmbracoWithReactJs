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
        private readonly IModelAdapter<InitialState> _initialStateModelAdapter;


        public HomeController(IModelAdapter<MasterModel> masterModelAdapter, 
            IModelAdapter<HomeModel> homeModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter) : base(masterModelAdapter)
        {
            _homeModelAdapter = homeModelAdapter;
            _initialStateModelAdapter = initialStateModelAdapter;
        }
        
        protected override ActionResult AjaxRequest(IPublishedContent content)
        {
            var initialState = CreateInitialState(content);
            initialState.Request.IsAjaxRequest = true;
            return Json(initialState, JsonRequestBehavior.AllowGet);
        }

       
        protected override ActionResult NonAjaxRequest(IPublishedContent content)
        {
            var initialState = CreateInitialState(content);          
            return base.NonAjaxRequest(initialState, content);

        }
        private InitialState CreateInitialState(IPublishedContent content)
        {
            var homeModel=_homeModelAdapter.Adapt(content);
            var initialState = _initialStateModelAdapter.Adapt(content);
            initialState.Content = homeModel;
            return initialState;
        }

    }
}