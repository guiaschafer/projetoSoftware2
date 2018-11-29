using ConsoleApp1.IRepositorios;
using ConsoleApp1.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CompareRemedios.Portal.Framework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new SimpleInjector.Container();

            container.Register<IFarmaciaRepository, FarmaciaRepository>();
            container.Register<IUsuarioRepository, UsuarioRepository>();
            container.Register<IProdutoRepository, ProdutoRepository>();
            container.Register<IPrecoRepository, PrecoRepository>();
        }
    }
}
