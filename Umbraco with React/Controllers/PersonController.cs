using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class PersonController : DefaultController
    {
        private readonly IModelAdapter<PersonModel> _personModelAdapter;


        public PersonController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<PersonModel> personModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _personModelAdapter = personModelAdapter;
        }

        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var personModel = _personModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = personModel;
            return initialState;
        }
    }
}