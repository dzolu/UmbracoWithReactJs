using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class BlogController:DefaultController
    {
        private readonly IModelAdapter<BlogModel> _blogModelAdapter;
        private readonly IModelAdapter<InitialState> _initialStateModelAdapter;


        public BlogController(IModelAdapter<MasterModel> masterModelAdapter, 
            IModelAdapter<BlogModel> blogModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter) : base(masterModelAdapter)
        {
            _blogModelAdapter = blogModelAdapter;
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
            var blogModel=_blogModelAdapter.Adapt(content);
            var initialState = _initialStateModelAdapter.Adapt(content);
            initialState.Content = blogModel;
            return initialState;
        }
    }
}