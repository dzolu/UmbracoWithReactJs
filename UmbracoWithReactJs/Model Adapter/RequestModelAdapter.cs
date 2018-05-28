using Umbraco.Core.Models;
using UmbracoWithReactJs.Helpers;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
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