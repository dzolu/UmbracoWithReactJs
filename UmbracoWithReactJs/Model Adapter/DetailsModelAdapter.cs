using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Extensions;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class DetailsModelAdapter : IModelAdapter<DetailsModel>
    {
        private readonly IModelAdapter<ImageModel> _imageModelAdapter;

        public DetailsModelAdapter(IModelAdapter<ImageModel> imageModelAdapter)
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