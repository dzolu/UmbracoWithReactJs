namespace Umbraco_with_React.Models
{
    using System.Collections.Generic;

    public class ProductModel : ContentModel
    {
        public ProductDetailsModel ProductDetails { get; set; }
        public IEnumerable<FeatureModel> Features { get; set; }
    }
}