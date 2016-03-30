namespace Jellyfish.MVC5.Minimal.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        [Route("~/")]
        public ViewResult Index()
        {
            return this.View("index");
        }
    }
}