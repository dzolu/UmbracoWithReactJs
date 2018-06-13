using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
{
    public class BlogpostController : DefaultController
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
            var blogPostModel = _blogpostModelAdapter.Adapt(content);
            return AdaptInitialState(content, blogPostModel);
        }
    }
}