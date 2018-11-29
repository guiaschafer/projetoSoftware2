using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class UsuarioController : Controller
    {
        public UsuarioController()
        {

        }
        // GET: Usuario
        public ActionResult Cadastrar()
        {
            return View();
        }
        public ActionResult Pesquisar()
        {
            return View();
        }
    }
}