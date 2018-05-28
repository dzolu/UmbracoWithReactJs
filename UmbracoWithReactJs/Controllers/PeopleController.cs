using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class PeopleController : DefaultController
    {
        private readonly IModelAdapter<PeopleModel> _peopleModelAdapter;

        public PeopleController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<PeopleModel> peopleModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _peopleModelAdapter = peopleModelAdapter;
        }
        
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var peopleModel = _peopleModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = peopleModel;
            return initialState;
        }
    }
}