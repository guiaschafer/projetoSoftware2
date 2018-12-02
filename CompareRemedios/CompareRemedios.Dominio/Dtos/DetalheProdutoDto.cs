using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Dtos
{
    public class DetalheProdutoDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<PrecoDto> Precos { get; set; }
    }
}
