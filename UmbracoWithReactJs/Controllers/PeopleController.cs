using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
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
            var people = _peopleModelAdapter.Adapt(content);
            return AdaptInitialState(content, people);
        }
    }
}