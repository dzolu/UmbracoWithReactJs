using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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
                DetailsModel = _detailsModelAdapter.Adapt(content),
                Social = _socialModelAdapter.Adapt(content)

            };
        }
    }
}