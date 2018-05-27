using Knowhere_CMS.Models;
using Umbraco.Core.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Knowhere_CMS.Model_Adapter
{
    public class MasterModelAdapter : IModelAdapter<MasterModel>
    {
        public MasterModelAdapter()
        { 
           
        }

        public MasterModel Adapt(IPublishedContent content)
        {
            return new MasterModel
            {
     
            };
        }
    }
}