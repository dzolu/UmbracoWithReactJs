using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;
using UmbracoWithReactJs.Models;
using UmbracoWithReactJs.Model_Adapter.Interafaces;

namespace UmbracoWithReactJs.Model_Adapter
{
    public class BlogPostModelAdapter:IModelAdapter<BlogPostModel>
    {
        public BlogPostModel Adapt(IPublishedContent content)
        {
            return new BlogPostModel
            {
                PageTitle = content.GetPropertyValue<string>("pageTitle"),
                Categories = content.GetPropertyValue<IEnumerable<string>>("categories"),
                Excerpt = content.GetPropertyValue<string>("excerpt"),
                Content = content.GetPropertyValue<string>("bodyText"),
                CreatedData = content.CreateDate.ToShortDateString()
            };
        }
    }
}