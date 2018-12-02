using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Dtos
{
    public class DetalhesFarmaciaDto
    {
        public int Id{ get; set; }
        public string NomeFantasia { get; set; }
        public List<PrecoDto> Produtos { get; set; }

    }
}
