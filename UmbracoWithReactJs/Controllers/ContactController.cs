using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
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
            return AdaptInitialState(content, contactModel);
        }
        
        
    }
}