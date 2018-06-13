namespace UmbracoWithReactJs.Models
{
    public class PersonModel : ContentModel
    {
        public string Name { get; set; }
        public DetailsModel DetailsModel { get; set; }
        public SocialModel Social { get; set; }
    }
}