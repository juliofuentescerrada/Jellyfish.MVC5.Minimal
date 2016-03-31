namespace Jellyfish.MVC5.Minimal
{
    using System;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Autofac;
    using Autofac.Integration.Mvc;

    public class Global : HttpApplication
    {
        public static string Author { get; set; }

        protected void Application_Start(object sender, EventArgs e)
        {
            Author = "Julio Fuentes Cerrada";

            AutofacConfig();

            MvcHandler.DisableMvcResponseHeader = true;
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());

            RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.IgnoreRoute("scripts/{*pathInfo}");

            RouteTable.Routes.AppendTrailingSlash = true;
            RouteTable.Routes.LowercaseUrls = true;
            RouteTable.Routes.MapMvcAttributeRoutes();
        }

        private static void AutofacConfig()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}