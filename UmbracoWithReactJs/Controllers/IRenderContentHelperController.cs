using System.Web.Mvc;

namespace Umbraco_with_React.Controllers
{
    public interface IRenderContentHelperController
    {
        ViewResult RenderPartial(string templateName, dynamic model);
    }
}