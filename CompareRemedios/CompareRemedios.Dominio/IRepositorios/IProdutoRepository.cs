using CompareRemedios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.IRepositorios
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto prod);
    }
}
