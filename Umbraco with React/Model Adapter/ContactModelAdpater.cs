using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class ContactModelAdpater:IModelAdapter<ContactModel>
    {
        public ContactModel Adapt(IPublishedContent content)
        {
            return  new ContactModel
            {
                PageTitle = content.GetPropertyValue<string>("pageTitle"),
                ContactIntro = content.GetPropertyValue<string>("contactIntro")
            };
        }
    }
}