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
    public class ProdutoController : Controller
    {
        private IProdutoRepository produtoRepositorio;
        private IFarmaciaRepository farmaciaRepository;
        private IPrecoRepository precoRepository;

        public ProdutoController(IProdutoRepository produtoRepositorio, 
            IFarmaciaRepository farmaciaRepository,
            IPrecoRepository precoRepository)
        {
            this.produtoRepositorio = produtoRepositorio;
            this.farmaciaRepository = farmaciaRepository;
            this.precoRepository = precoRepository;
        }
        public ActionResult Cadastrar()
        {
            //ViewBag.Farmacias = new SelectList(farmaciaRepository.ObterTodos(), "Id", "NomeFantasia");
            return View();
        }

        // GET: Produto
        public ActionResult Salvar(ProdutoDto prod)
        {
            try
            {
                var produto = Mapper.Map<ProdutoDto, Produto>(prod);

                produtoRepositorio.Cadastrar(produto);
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

        public ActionResult PesquisarProdutos(string nome)
        {
            var remedios = Mapper.Map<List<Produto>, List<ProdutoDto>>(produtoRepositorio.ObterPorNome(nome));
            return PartialView("_Produtos", remedios);
        }
        public ActionResult Aprovar()
        {
            return View();
        }

        public ActionResult Detalhes(int id)
        {
            var produto = produtoRepositorio.Obter(id);
            var detalhes = new DetalheProdutoDto();
            detalhes.Id = id;
            detalhes.Descricao = produto.Descricao;
            detalhes.Precos = precoRepository.ObterPrecosPorProduto(id);
            return View(detalhes);
        }
    }
}