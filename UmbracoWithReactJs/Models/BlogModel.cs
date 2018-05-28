using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class BlogModel:ContentModel
    {
        public IEnumerable<BlogPostModel> BlogPost { get; set; }
    }
}