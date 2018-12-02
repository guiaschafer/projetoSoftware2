using CompareRemedios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.IRepositorios
{
    public interface IFarmaciaRepository
    {
        void Inserir(Farmacia farmacia);
        List<Farmacia> ObterTodos();
        Farmacia Obter(int id);
        List<Farmacia> ObterPorNome(string nome);
    }
}
