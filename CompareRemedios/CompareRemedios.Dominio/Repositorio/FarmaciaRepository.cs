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

        public List<Farmacia> Obter()
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
