using System.Collections.Generic;
using System.Linq;
using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Entity;
using CompareRemedios.Dominio.IRepositorios;

namespace CompareRemedios.Dominio.Repositorio
{
    public class FarmaciaRepository : IFarmaciaRepository
    {
        private readonly DataBaseContext context;
        public FarmaciaRepository(DataBaseContext context)
        {
            this.context = context;
        }

        public void Inserir(Farmacia farmacia)
        {
            context.Farmacias.Add(farmacia);
            context.SaveChanges();

        }

        public List<Farmacia> ObterPorNome(string nome)
        {
            if(string.IsNullOrEmpty(nome))
                return context.Farmacias.ToList();

            return context.Farmacias.Where(f => f.NomeFantasia.ToUpper().Contains(nome.ToUpper())).ToList();
        }

        public List<Farmacia> ObterTodos()
        {
            var x = context.Farmacias.ToList();
            return x;
        }

        public Farmacia Obter(int id)
        {
            return context.Farmacias.FirstOrDefault(t => t.Id == id);
        }
    }
}
