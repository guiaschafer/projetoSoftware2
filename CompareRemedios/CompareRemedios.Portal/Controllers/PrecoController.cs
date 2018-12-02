using AutoMapper;
using CompareRemedios.Dominio.Dtos;
using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompareRemedios.Portal.Framework.Controllers
{
    public class PrecoController : Controller
    {
        private IProdutoRepository produtoRepositorio;
        private IFarmaciaRepository farmaciaRepository;
        private IPrecoRepository precoRepository;
        public PrecoController(IProdutoRepository produtoRepositorio, 
            IFarmaciaRepository farmaciaRepository, 
            IPrecoRepository precoRepository)
        {
            this.produtoRepositorio = produtoRepositorio;
            this.farmaciaRepository = farmaciaRepository;
            this.precoRepository = precoRepository;
        }
        // GET: Preco
        public ActionResult AprovarAjuste()
        {
            return View(precoRepository.ObterTodosParaAprovacao());
        }

        public ActionResult Aprovar(int id)
        {
            precoRepository.Aprovar(id);
            return RedirectToAction("Pesquisar","Produto");
        }

        public ActionResult SolicitarAjuste()
        {
            ViewBag.Farmacias = new SelectList(farmaciaRepository.ObterTodos(), "Id", "NomeFantasia");
            ViewBag.Produtos = new SelectList(produtoRepositorio.ObterTodos(), "Id", "Descricao");
            return View();
        }

        public ActionResult SalvarSolicitarAjuste(PrecoDto precoDto)
        {
            precoRepository.SolicitarAjuste(Mapper.Map<PrecoDto, Preco>(precoDto));
            return RedirectToAction("Pesquisar", "Produto");
        }
    }
}