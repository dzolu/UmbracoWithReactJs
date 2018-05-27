using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class InitialStateModelAdapter:IModelAdapter<InitialState>
    {
        private readonly IModelAdapter<MetaDataModel> _metaModelAdapter;
        private readonly IModelAdapter<RequestModel> _requestModelAdapter;

        public InitialStateModelAdapter(IModelAdapter<MetaDataModel> metaModelAdapter,
            IModelAdapter<RequestModel> requestModelAdapter)
        {
            _metaModelAdapter = metaModelAdapter;
            _requestModelAdapter = requestModelAdapter;
        }

        public InitialState Adapt(IPublishedContent content)
        {
            return new InitialState
            {              
                MetaData = _metaModelAdapter.Adapt(content),
                Request = _requestModelAdapter.Adapt(content)
            };
        }
    }
}