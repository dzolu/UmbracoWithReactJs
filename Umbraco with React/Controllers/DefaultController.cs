using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;
using ActionResult = System.Web.Mvc.ActionResult;


namespace Umbraco_with_React.Controllers
{
    public class DefaultController :  Umbraco.Web.Mvc.RenderMvcController
    {
        private readonly IModelAdapter<MasterModel> _masterModelAdapter;

        public DefaultController(IModelAdapter<MasterModel> masterModelAdapter)
        {
            _masterModelAdapter = masterModelAdapter;
        }

        public override ActionResult Index(RenderModel model)
        {
            var isAjaxRequest = Request.IsAjaxRequest();
            return isAjaxRequest  ?  AjaxRequest(model.Content) : NonAjaxRequest(model.Content);
        }

        protected virtual ActionResult NonAjaxRequest(IPublishedContent content)
        {
            var masterInitialState = _masterModelAdapter.Adapt(content);            
            return View("Master", masterInitialState);
        }

        protected virtual ActionResult AjaxRequest(IPublishedContent content)
        {
            return Json(new { }, JsonRequestBehavior.AllowGet);
        }

        protected ActionResult NonAjaxRequest(InitialState initialState, IPublishedContent content)
        {
            var masterInitialState = _masterModelAdapter.Adapt(content);
            masterInitialState.InitialState = initialState;
            return View("Master", masterInitialState);
        }
       
    }
}