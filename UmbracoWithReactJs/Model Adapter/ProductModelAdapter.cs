using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class ProductModelAdapter : IModelAdapter<ProductModel>
    {
        private readonly IModelAdapter<ProductDetailsModel> _productDetailsModelAdapter;
        private readonly IModelAdapter<FeatureModel> _featureModelAdapter;

        public ProductModelAdapter(IModelAdapter<ProductDetailsModel> productDetailsModelAdapter,
            IModelAdapter<FeatureModel> featureModelAdapter)
        {
            _productDetailsModelAdapter = productDetailsModelAdapter;
            _featureModelAdapter = featureModelAdapter;
        }

        public ProductModel Adapt(IPublishedContent content)
        {
            return new ProductModel
            {
                ProductDetails = _productDetailsModelAdapter.Adapt(content),
                Features = content.GetPropertyValue<IEnumerable<IPublishedContent>>("features")
                    .Select(x => _featureModelAdapter.Adapt(x))
            };
        }
    }
}