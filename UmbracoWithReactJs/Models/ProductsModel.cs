using System.Collections.Generic;

namespace Umbraco_with_React.Models
{
    public class ProductsModel : ContactModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}