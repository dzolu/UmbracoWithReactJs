namespace UmbracoWithReactJs.Models
{
    public class HomeModel : ContentModel
    {
        public HeroModel Hero { get; set; }

        public string Content { get; set; }

        public FooterHomeModel FooterHomeModel { get; set; }
    }
}