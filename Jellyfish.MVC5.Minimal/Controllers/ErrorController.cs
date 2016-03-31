namespace Jellyfish.MVC5.Minimal.Controllers
{
    using System;
    using System.Net;
    using System.Web.Mvc;

    using Jellyfish.MVC5.Minimal.ViewModels;

    [AllowAnonymous]
    [RoutePrefix("error")]
    public class ErrorController : Controller
    {
        [Route]
        [OutputCache(CacheProfile = "ErrorPage")]
        public ActionResult Error()
        {
            this.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var model = new ErrorViewModel("Oops", "No se puede mostrar la página. Error interno en el servidor.");

            return this.View("error", model);
        }

        [Route("401")]
        [OutputCache(CacheProfile = "ErrorPage")]
        public ActionResult Error401()
        {
            this.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

            var model = new ErrorViewModel("Oops", "No tiene permiso para ver este directorio o esta página.");

            return this.View("error", model);
        }

        [Route("403")]
        [OutputCache(CacheProfile = "ErrorPage")]
        public ActionResult Error403()
        {
            this.Response.StatusCode = (int)HttpStatusCode.Forbidden;

            var model = new ErrorViewModel("Oops", "Acceso denegado");

            return this.View("error", model);
        }

        [Route("404")]
        [OutputCache(CacheProfile = "ErrorPage")]
        public ActionResult Error404()
        {
            this.Response.StatusCode = (int)HttpStatusCode.NotFound;

            var model = new ErrorViewModel("Oops", "Se ha quitado el recurso que está buscando, se le ha cambiado el nombre o no está disponible en estos momentos.");

            return this.View("error", model);
        }

        [Route("exception")]
        public ActionResult ThrowException()
        {
            throw new Exception("error intencionado");
        }
    }
}