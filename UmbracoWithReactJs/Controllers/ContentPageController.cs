using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
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
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = contentPageModel;
            return initialState;
        }
    }
}