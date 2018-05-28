using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
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