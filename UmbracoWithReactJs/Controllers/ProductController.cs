using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Controllers
{
    public class ProductController:DefaultController
    {
        private readonly IModelAdapter<ProductModel> _productModelAdapter;

        public ProductController(IModelAdapter<MasterModel> masterModelAdapter, 
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<ProductModel> productModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _productModelAdapter = productModelAdapter;
        }
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var productModel = _productModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = productModel;
            return initialState;
        }
    }
}