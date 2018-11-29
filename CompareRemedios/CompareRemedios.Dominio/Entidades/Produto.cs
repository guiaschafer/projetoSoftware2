using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdFarmacia { get; set; }
        public Farmacia Farmacia { get; set; }
    }
}
