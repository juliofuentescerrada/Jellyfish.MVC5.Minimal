namespace Jellyfish.MVC5.Minimal.Controllers
{
    using System.Web.Mvc;

    public class BlogController : Controller
    {
        [Route("{year}/{month}/{day}/{post}")]
        public ViewResult Post(int year, int month, int day, string post)
        {
            return this.View("post");
        }
    }
}