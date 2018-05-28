using System.Collections.Generic;

namespace Umbraco_with_React.Models
{
    public class BlogModel:ContentModel
    {
        public IEnumerable<BlogPostModel> BlogPost { get; set; }
    }
}