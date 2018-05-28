using System.Linq;
using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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
                Persons = content.Children.Select(x=>_personModelAdapter.Adapt(x))
            };
        }
    }
}