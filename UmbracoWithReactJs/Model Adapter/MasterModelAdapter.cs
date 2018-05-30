using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class MasterModelAdapter : IModelAdapter<MasterModel>
    {
        private readonly IModelAdapter<ContentModel> _contentModelAdapter;
        public MasterModelAdapter(IModelAdapter<ContentModel> contentModelAdapter)
        {
            _contentModelAdapter = contentModelAdapter;
        }
        public MasterModel Adapt(IPublishedContent content)
        {
            return new MasterModel
            {
                TopNavigation = content.AncestorsOrSelf(1).First().Children().Select(x=>_contentModelAdapter.Adapt(x))
            };
        }
    }
}