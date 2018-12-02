using CompareRemedios.Dominio.Dtos;
using CompareRemedios.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.IRepositorios
{
    public interface IPrecoRepository
    {
        void SolicitarAjuste(Preco preco);
        void Aprovar(int id);
        List<PrecoDto> ObterTodosParaAprovacao();
        List<PrecoDto> ObterPrecosPorProduto(int idProduto);
        List<PrecoDto> ObterPrecosPorFarmacia(int idFarmacia);
    }
}
