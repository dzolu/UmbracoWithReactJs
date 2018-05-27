using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class ProductDetailsModelAdapter:IModelAdapter<ProductDetailsModel>
    {
        private readonly IModelAdapter<ImageModel> _imageModelAdapter;

        public ProductDetailsModelAdapter(IModelAdapter<ImageModel> imageModelAdapter)
        {
            _imageModelAdapter = imageModelAdapter;
        }

        public ProductDetailsModel Adapt(IPublishedContent content)
        {
            return new ProductDetailsModel
            {
                Name = content.GetPropertyValue<string>("productName"),
                Price = content.GetPropertyValue<double>("price"),
                Category = content.GetPropertyValue<IEnumerable<string>>("category"),
                Description = content.GetPropertyValue<string>("description"),
                Sku = content.GetPropertyValue<string>("sku"),
                Photos = content.GetPropertyValue<IEnumerable<IPublishedContent>>("photos").Select(x=>_imageModelAdapter.Adapt(x))
                
            };
        }
    }
}