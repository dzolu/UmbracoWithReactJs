using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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