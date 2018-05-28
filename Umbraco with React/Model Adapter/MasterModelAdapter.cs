using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class MasterModelAdapter : IModelAdapter<MasterModel>
    {
        public MasterModel Adapt(IPublishedContent content)
        {
            return new MasterModel
            {
     
            };
        }
    }
}