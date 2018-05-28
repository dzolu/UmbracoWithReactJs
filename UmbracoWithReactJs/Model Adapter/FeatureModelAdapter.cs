using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class  FeatureModelAdapter:IModelAdapter<FeatureModel>
    {
        public FeatureModel Adapt(IPublishedContent content)
        {
            return new FeatureModel
            {
                Name = content.GetPropertyValue<string>("featureName"),
                Details = content.GetPropertyValue<string>("featureDetails")
            };
        }
    }
}