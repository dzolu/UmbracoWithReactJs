using System.Collections.Generic;

namespace UmbracoWithReactJs.Models
{
    public class ProductsModel : ContactModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}