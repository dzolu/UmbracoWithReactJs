using System.Collections.Generic;

namespace Umbraco_with_React.Models
{
    public class PeopleModel : ContentModel
    {
        public IEnumerable<PersonModel> Persons { get; set; }
    }
}