using System.Web.UI.WebControls;

namespace Umbraco_with_React.Models
{
    public class PersonModel : ContentModel
    {
        public DetailsModel DetailsModel { get; set; }
        public SocialModel Social { get; set; }
    }
}