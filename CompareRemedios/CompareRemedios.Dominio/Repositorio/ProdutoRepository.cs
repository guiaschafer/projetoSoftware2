using System.Collections.Generic;
using System.Linq;
using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.IRepositorios;

namespace CompareRemedios.Dominio.Repositorio
{
    public class ProdutoRepository : IProdutoRepository
    {
        private DataBaseContext context;

        public ProdutoRepository()
        {
            context = new DataBaseContext();
        }

        public void Cadastrar(Produto prod)
        {
            context.Produtos.Add(prod);
            context.SaveChanges();
        }

        public Produto Obter(int id)
        {
            return context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public List<Produto> ObterTodos()
        {
            return context.Produtos.ToList();
        }

        public List<Produto> ObterPorNome(string nome)
        {
            return context.Produtos.Where(f => f.Descricao.ToUpper().Contains(nome.ToUpper())).ToList();
        }
    }
}
