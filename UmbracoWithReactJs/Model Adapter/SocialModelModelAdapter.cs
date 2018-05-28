using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class SocialModelModelAdapter : IModelAdapter<SocialModel>
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