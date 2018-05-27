using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco_with_React.Models;
using Umbraco_with_React.Model_Adapter.Interafaces;

namespace Umbraco_with_React.Model_Adapter
{
    public class BlogModelAdapter: IModelAdapter<BlogModel>
    {
        private readonly IModelAdapter<BlogPostModel> _blodPostModelAdapter;

        public BlogModelAdapter(IModelAdapter<BlogPostModel> blodPostModelAdapter)
        {
            _blodPostModelAdapter = blodPostModelAdapter;
        }

        public BlogModel Adapt(IPublishedContent content)
        {
            var numberOfBlopostToShown = content.GetPropertyValue<int>("howManyPostsShouldBeShown");
            var blogPost=content.Children.OrderByDescending(x => x.CreateDate).Take(numberOfBlopostToShown)
                .Select(y=>_blodPostModelAdapter.Adapt(y));
            
            return new BlogModel
            {
                BlogPost=blogPost
            };
        }
    }
}