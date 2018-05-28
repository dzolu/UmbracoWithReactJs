using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
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