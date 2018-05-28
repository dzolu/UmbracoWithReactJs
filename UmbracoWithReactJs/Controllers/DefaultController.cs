﻿using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;
using ActionResult = System.Web.Mvc.ActionResult;


namespace UmbracoWithReactJs.Controllers
{
    public class DefaultController :  Umbraco.Web.Mvc.RenderMvcController
    {
        private readonly IModelAdapter<MasterModel> _masterModelAdapter;
        protected readonly IModelAdapter<InitialState> InitialStateModelAdapter;


        public DefaultController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter)
        {
            _masterModelAdapter = masterModelAdapter;
            InitialStateModelAdapter = initialStateModelAdapter;
        }

        public override ActionResult Index(RenderModel model)
        {
            var isAjaxRequest = Request.IsAjaxRequest();
            return isAjaxRequest  ?  AjaxRequest(model.Content) : NonAjaxRequest(model.Content);
        }


        private ActionResult AjaxRequest(IPublishedContent content)
        {
            var initialState = CreateInitialState(content);
            initialState.Request.IsAjaxRequest = true;
            return Json(initialState, JsonRequestBehavior.AllowGet);
        }

        private ActionResult NonAjaxRequest(IPublishedContent content)
        {
            var initialState = CreateInitialState(content);   
            var masterInitialState = _masterModelAdapter.Adapt(content);
            masterInitialState.InitialState = initialState;
            return View("Master", masterInitialState);
        }
       
        protected virtual InitialState CreateInitialState(IPublishedContent content)
        {
            var initialState = InitialStateModelAdapter.Adapt(content);
            return initialState;
        }

    }
}