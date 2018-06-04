using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public  class PersonModelAdapter:IModelAdapter<PersonModel>
    {
        private readonly IModelAdapter<SocialModel> _socialModelAdapter;
        private readonly IModelAdapter<DetailsModel> _detailsModelAdapter;

        public PersonModelAdapter(IModelAdapter<SocialModel> socialModelAdapter,
            IModelAdapter<DetailsModel> detailsModelAdapter)
        {
            _socialModelAdapter = socialModelAdapter;
            _detailsModelAdapter = detailsModelAdapter;
        }

        public PersonModel Adapt(IPublishedContent content)
        {
            return new PersonModel
            {
                Name= content.Name,
                Id= content.Id,
                Url = content.Url,
                DetailsModel = _detailsModelAdapter.Adapt(content),
                Social = _socialModelAdapter.Adapt(content)

            };
        }
    }
}