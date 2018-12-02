using CompareRemedios.Dominio.Dtos;
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
        public IPrecoRepository precoRepository;

        public FarmaciaController(IFarmaciaRepository farm,
            IPrecoRepository precoRepository)
        {
            farmaciaRepositorio = farm;
            this.precoRepository = precoRepository;
        }
        // GET: Farmacia
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Editar(string id)
        {
            var f = farmaciaRepositorio.Obter(Int32.Parse(id));
            return View("Cadastrar", f);
        }

        public ActionResult PesquisarFarmacia(string nome)
        {
            return PartialView("_Farmacias", farmaciaRepositorio.ObterPorNome(nome));
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

        public ActionResult Detalhes(int id)
        {
            var farmacia = farmaciaRepositorio.Obter(id);
            var detalhes = new DetalhesFarmaciaDto();
            detalhes.Id = id;
            detalhes.NomeFantasia = farmacia.NomeFantasia;
            detalhes.Produtos = precoRepository.ObterPrecosPorFarmacia(id);
            return View(detalhes);
        }
    }
}