using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Dtos
{
    public class PrecoDto
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdFarmacia { get; set; }
        public string Preco { get; set; }
        public string NomeFarmacia { get; set; }
        public string NomeRemedio { get; set; }

    }
}
