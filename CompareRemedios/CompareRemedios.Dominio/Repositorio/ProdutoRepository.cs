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
    }
}
