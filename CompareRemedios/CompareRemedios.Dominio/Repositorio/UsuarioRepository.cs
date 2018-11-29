using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.IRepositorios;

namespace CompareRemedios.Dominio.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DataBaseContext context;

        public UsuarioRepository()
        {
            context = new DataBaseContext();
        }

        public void Cadastrar(Usuario user)
        {
            context.Usuarios.Add(user);
            context.SaveChanges();


        }
    }
}
