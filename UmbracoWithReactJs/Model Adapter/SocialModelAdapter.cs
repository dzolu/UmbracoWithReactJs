using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class SocialModelAdapter : IModelAdapter<SocialModel>
    {
        public SocialModel Adapt(IPublishedContent content)
        {
            return new SocialModel
            {
                TwitterUsername = content.GetPropertyValue<string>("twitterUsername"),
                InstagramUsername = content.GetPropertyValue<string>("linkedInUsername"),
                LinkedInUsername = content.GetPropertyValue<string>("instagramUsername"),
                FacebookUsername = content.GetPropertyValue<string>("facebookUsername")
            };
        }
    }
}