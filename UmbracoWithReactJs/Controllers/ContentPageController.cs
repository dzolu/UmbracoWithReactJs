using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
{
    public class ContentPageController : DefaultController
    {
        private readonly IModelAdapter<ContentPageModel> _contentPageModelAdapter;

        public ContentPageController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<ContentPageModel> contentPageModelAdapter) : base(masterModelAdapter,
            initialStateModelAdapter)
        {
            _contentPageModelAdapter = contentPageModelAdapter;
        }

        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var contentPageModel = _contentPageModelAdapter.Adapt(content);
            return AdaptInitialState(content, contentPageModel);
        }
    }
}