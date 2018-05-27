using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class BlogpostController:DefaultController
    {
        private readonly IModelAdapter<BlogPostModel> _blogpostModelAdapter;

        public BlogpostController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<BlogPostModel> blogpostModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _blogpostModelAdapter = blogpostModelAdapter;
        }
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var blogModel=_blogpostModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = blogModel;
            return initialState;
        }
        
    }
}