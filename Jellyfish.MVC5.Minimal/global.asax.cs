namespace Jellyfish.MVC5.Minimal
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            MvcHandler.DisableMvcResponseHeader = true;

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            RouteTable.Routes.AppendTrailingSlash = true;
            RouteTable.Routes.LowercaseUrls = true;
            RouteTable.Routes.MapMvcAttributeRoutes();
        }
    }
}