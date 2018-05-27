﻿using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class BlogController:DefaultController
    {
        private readonly IModelAdapter<BlogModel> _blogModelAdapter;

        public BlogController(IModelAdapter<MasterModel> masterModelAdapter, 
            IModelAdapter<BlogModel> blogModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _blogModelAdapter = blogModelAdapter;
   
        }
      
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var blogModel=_blogModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = blogModel;
            return initialState;
        }
    }

    public class BlogpostController:DefaultController
    {
        public BlogpostController(IModelAdapter<MasterModel> masterModelAdapter, IModelAdapter<InitialState> initialStateModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
        }
    }
}