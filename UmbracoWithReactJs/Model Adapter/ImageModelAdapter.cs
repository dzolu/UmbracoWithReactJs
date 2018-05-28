using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class ImageModelAdapter : IModelAdapter<ImageModel>
    {
        public ImageModel Adapt(IPublishedContent content)
        {
         
            return new ImageModel
            {
                Source = content.Url,
                Width = content.GetPropertyValue<int>("width"),
                Height = content.GetPropertyValue<int>("height"),
                AltText = content.GetPropertyValue<string>("alternativeText")
            };
        }
    }
}