using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository produtoRepositorio;


        public ProdutoController(IProdutoRepository produtoRepositorio)
        {
            this.produtoRepositorio = produtoRepositorio;
        }
        // GET: Produto
        public ActionResult Cadastrar(Produto prod)
        {
            try
            {
                produtoRepositorio.Cadastrar(prod);
                return RedirectToAction("Pesquisar");

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(prod);
            }
        }
        public ActionResult Pesquisar()
        {
            return View();
        }
        public ActionResult Aprovar()
        {
            return View();
        }
    }
}