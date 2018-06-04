using System.Linq;
using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class PeopleModelAdapter:IModelAdapter<PeopleModel>
    {
        private readonly IModelAdapter<PersonModel> _personModelAdapter;

        public PeopleModelAdapter (IModelAdapter<PersonModel> personModelAdapter)
        {
            _personModelAdapter = personModelAdapter;
        }

        public PeopleModel Adapt(IPublishedContent content)
        {
            return new PeopleModel
            {
                People = content.Children.Select(x=>_personModelAdapter.Adapt(x))
            };
        }
    }
}