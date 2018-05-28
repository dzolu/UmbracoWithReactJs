using Umbraco.Core.Models;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
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