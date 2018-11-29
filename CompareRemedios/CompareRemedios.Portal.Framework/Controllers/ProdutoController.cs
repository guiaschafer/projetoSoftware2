using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Aprovar()
        {
            return View();
        }
    }
}