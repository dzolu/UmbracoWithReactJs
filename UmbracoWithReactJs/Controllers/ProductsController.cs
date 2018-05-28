using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Controllers
{
    public class ProductsController:DefaultController
    {
        private readonly IModelAdapter<ProductsModel> _productsModelAdapter;

        public ProductsController(IModelAdapter<MasterModel> masterModelAdapter, 
            IModelAdapter<InitialState> initialStateModelAdapter,
            IModelAdapter<ProductsModel> productsModelAdapter) : base(masterModelAdapter, initialStateModelAdapter)
        {
            _productsModelAdapter = productsModelAdapter;
        }
        protected override InitialState CreateInitialState(IPublishedContent content)
        {
            var productModel = _productsModelAdapter.Adapt(content);
            var initialState = InitialStateModelAdapter.Adapt(content);
            initialState.Content = productModel;
            return initialState;
        }
    }
}