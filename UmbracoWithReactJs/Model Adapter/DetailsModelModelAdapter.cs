using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Extensions;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class DetailsModelModelAdapter : IModelAdapter<DetailsModel>
    {
        private readonly IModelAdapter<ImageModel> _imageModelAdapter;

        public DetailsModelModelAdapter(IModelAdapter<ImageModel> imageModelAdapter)
        {
            _imageModelAdapter = imageModelAdapter;
        }

        public DetailsModel Adapt(IPublishedContent content)
        {
            return new DetailsModel
            {
                Photo = _imageModelAdapter.Adapt(content.GetTypedMediaByAlias("photo")),
                Department = content.GetPropertyValue<string>("department"),
                Email = content.GetPropertyValue<string>("email")
            };
        }
    }
}