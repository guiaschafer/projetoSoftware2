using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.IRepositorios;
using CompareRemedios.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class FarmaciaController : Controller
    {
        public IFarmaciaRepository farmaciaRepositorio;

        public FarmaciaController(IFarmaciaRepository farm)
        {
            farmaciaRepositorio = farm;
        }
        // GET: Farmacia
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Editar(string id)
        {
            var f = farmaciaRepositorio.Obter(1);
            return View("Cadastrar", f);
        }

        public ActionResult PesquisarFarmacia()
        {
            return PartialView("_Farmacias", farmaciaRepositorio.Obter());
        }


        public ActionResult Salvar(Farmacia farm)
        {
            try
            {
                farmaciaRepositorio.Inserir(farm);
                return RedirectToAction("Pesquisar");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(farm);
            }
        }

        public ActionResult Pesquisar()
        {
            return View();
        }
    }
}