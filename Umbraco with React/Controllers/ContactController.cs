using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class ContactController:DefaultController
    {
        private readonly IModelAdapter<ContactModel> _contactModelAdapter;

        public ContactController(IModelAdapter<MasterModel> masterModelAdapter,
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<ContactModel> contactModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _contactModelAdapter = contactModelAdapter;
        }
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var contactModel=_contactModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = contactModel;
            return initialState;
        }
        
        
    }
}