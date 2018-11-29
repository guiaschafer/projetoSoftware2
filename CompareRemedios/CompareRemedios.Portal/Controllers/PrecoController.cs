using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class PrecoController : Controller
    {

        public PrecoController()
        {

        }
        // GET: Preco
        public ActionResult AprovarAjuste()
        {
            return View();
        }

        public ActionResult SolicitarAjuste()
        {
            return View();
        }
    }
}