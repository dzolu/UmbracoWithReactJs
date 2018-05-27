using Umbraco.Core.Models;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class RequestModelAdapter : IModelAdapter<RequestModel>
    {
        private readonly IHttpContext _httpContext;

        public RequestModelAdapter(IHttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        public RequestModel Adapt(IPublishedContent content)
        {
            return new RequestModel
            {
                Location = _httpContext.AbsolutePath(),
                IsAjaxRequest = false
            };
        }
    }
}