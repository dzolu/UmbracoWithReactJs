using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class PeopleModel : ContentModel
    {
        public IEnumerable<PersonModel> People { get; set; }
    }
}