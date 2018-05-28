using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class ProductDetailsModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public IEnumerable<string> Category { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public IEnumerable<ImageModel> Photos { get; set; }
    }
}