using CompareRemedios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IRepositorios
{
    public interface IFarmaciaRepository
    {
        void Inserir(Farmacia farmacia);
    }
}
