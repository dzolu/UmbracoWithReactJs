using System.Linq;
using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class ProductsModelAdapter : IModelAdapter<ProductsModel>
    {
        private readonly IModelAdapter<ProductModel> _productModelAdapter;

        public ProductsModelAdapter(IModelAdapter<ProductModel> productModelAdapter)
        {
            _productModelAdapter = productModelAdapter;
        }

        public ProductsModel Adapt(IPublishedContent content)
        {
            return new ProductsModel
            {
                Products = content.Children.Select(x => _productModelAdapter.Adapt(x))
            };
        }
    }
}