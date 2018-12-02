using AutoMapper;
using CompareRemedios.Dominio.Dtos;
using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.Enum;
using CompareRemedios.Dominio.IRepositorios;
using System.Collections.Generic;
using System.Linq;

namespace CompareRemedios.Dominio.Repositorio
{
    public class PrecoRepository : IPrecoRepository
    {
        private DataBaseContext context;

        public PrecoRepository()
        {
            context = new DataBaseContext();
        }

        public void Aprovar(int id)
        {
            var precoDb = context.Precos.FirstOrDefault(p => p.Id == id);
            var precos = context.Precos.Where(p => p.IdFarmacia == precoDb.IdFarmacia
            && p.IdProduto == precoDb.IdProduto
            && p.Status == StatusPreco.Aprovado);

            foreach (var p in precos)
            {
                p.Status = StatusPreco.Cancelado;                
            }            

            precoDb.Status = StatusPreco.Aprovado;
            context.SaveChanges();
        }

        public List<PrecoDto> ObterPrecosPorProduto(int idProduto)
        {
            var precos = context.Precos
                .Include("Produto")
                .Include("Farmacia");

            return Mapper.Map<List<Preco>, List<PrecoDto>>(precos.Where(p => p.Produto.Id == idProduto && p.Status == StatusPreco.Aprovado).ToList());
        }

        public List<PrecoDto> ObterPrecosPorFarmacia(int idFarmacia)
        {
            var precos = context.Precos
                .Include("Produto")
                .Include("Farmacia");

            var remedios = precos.Where(p => p.Farmacia.Id == idFarmacia && p.Status == StatusPreco.Aprovado).ToList();
            return Mapper.Map<List<Preco>, List<PrecoDto>>(remedios);
        }

        public List<PrecoDto> ObterTodosParaAprovacao()
        {
            var precos = context.Precos.Where(p => p.Status == StatusPreco.EmAprovacao).ToList();
            return Mapper.Map<List<Preco>, List<PrecoDto>>(precos);
        }

        public void SolicitarAjuste(Preco preco)
        {
            preco.Status = StatusPreco.EmAprovacao;
            context.Precos.Add(preco);
            context.SaveChanges();
        }


    }
}
