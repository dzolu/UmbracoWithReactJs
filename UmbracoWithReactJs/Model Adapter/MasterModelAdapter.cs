using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class MasterModelAdapter : IModelAdapter<MasterModel>
    {
        private readonly IModelAdapter<MetaData> _metaDataModelAdapter;


        public MasterModelAdapter(IModelAdapter<MetaData> metaDataModelAdapter)
        {
            _metaDataModelAdapter = metaDataModelAdapter;
        }

        public MasterModel Adapt(IPublishedContent content)
        {
            return new MasterModel
            {
                TopNavigation = content.AncestorsOrSelf(1).First().Children().Where(x => x.IsVisible())
                    .Select(x => _metaDataModelAdapter.Adapt(x))
            };
        }
    }
}