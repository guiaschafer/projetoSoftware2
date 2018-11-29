using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.IRepositorios;

namespace CompareRemedios.Dominio.Repositorio
{
    public class PrecoRepository : IPrecoRepository
    {
        private DataBaseContext context;

        public PrecoRepository()
        {
            context = new DataBaseContext();
        }

        public void Cadastrar(Preco preco)
        {
            context.Precos.Add(preco);
            context.SaveChanges();


        }
    }
}
