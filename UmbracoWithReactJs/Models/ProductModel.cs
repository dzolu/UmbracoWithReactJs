using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class ProductModel : ContentModel
    {
        public ProductDetailsModel ProductDetails { get; set; }
        public IEnumerable<FeatureModel> Features { get; set; }
    }
}