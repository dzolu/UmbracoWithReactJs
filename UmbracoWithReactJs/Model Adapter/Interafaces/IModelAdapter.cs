using Umbraco.Core.Models;

namespace UmbracoWithReactJs.Model_Adapter.Interafaces
{
    public interface IModelAdapter<T>
    {
        T Adapt(IPublishedContent content);
    }
}
