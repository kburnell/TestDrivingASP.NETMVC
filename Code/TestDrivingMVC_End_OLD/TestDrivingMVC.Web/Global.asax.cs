using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StructureMap;
using TestDrivingMVC.Web.Utility;

namespace TestDrivingMVC.Web {

    public class MvcApplication : HttpApplication {

        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            WireUpDependencyInjection();
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
        }

        /// <summary>
        ///   Wire up our dependency's with StructureMap We are using StructureMap's scanning and convention 
        ///   over configuration abilities here. Basically StructureMap scans every directory when it finds 
        ///   an Interface (ex. IFoo) it looks for a corresponding class named "Foo" based on the naming 
        ///   convention that concrete implementations of a class are named exactly the same as there 
        ///   interface minus the leading "I"
        /// </summary>
        private void WireUpDependencyInjection() {

            ObjectFactory.Initialize(registry => registry.Scan(x => {
                x.AssembliesFromApplicationBaseDirectory();
                x.WithDefaultConventions();
            }));
        }

    }
}