using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.IRepositorios;
using CompareRemedios.Dominio.Repositorio;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace CompareRemedios.Portal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = new Container();

            container.Register<IFarmaciaRepository, FarmaciaRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
            container.Register<IProdutoRepository, ProdutoRepository>();
            container.Register<IPrecoRepository, PrecoRepository>();
            container.Register<DataBaseContext>(Lifestyle.Singleton);


            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
