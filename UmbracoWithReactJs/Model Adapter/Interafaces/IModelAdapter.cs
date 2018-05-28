using Umbraco.Core.Models;

namespace Umbraco_with_React.Model_Adapter.Interafaces
{
    public interface IModelAdapter<T>
    {
        T Adapt(IPublishedContent content);
    }
}
