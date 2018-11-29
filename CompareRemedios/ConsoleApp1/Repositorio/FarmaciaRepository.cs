using ConsoleApp1.Entity;
using ConsoleApp1.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompareRemedios.Dominio.Entidades;

namespace ConsoleApp1.Repositorio
{
    public class FarmaciaRepository : IFarmaciaRepository
    {
        private DataBaseContext context;

        public void Inserir(Farmacia farmacia)
        {
            context.Farmacias
        }
    }
}
