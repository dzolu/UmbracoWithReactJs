using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
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
}