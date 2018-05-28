using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
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