using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class BlogPostModel:ContentModel
    {
        public string PageTitle { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string CreatedData { get; set; }
    }
}