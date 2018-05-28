using System.Web.Mvc;

namespace UmbracoWithReactJs.Controllers
{
    public interface IRenderContentHelperController
    {
        ViewResult RenderPartial(string templateName, dynamic model);
    }
}