using CompareRemedios.Dominio.Entidades;
using CompareRemedios.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entidades
{
    public class Preco
    {
        public int Id { get; set; }
        public int IdFarmacia { get; set; }
        public int IdProduto { get; set; }
        public virtual Farmacia Farmacia { get; set; }
        public virtual Produto Produto { get; set; }
        public decimal Valor { get; set; }
        public StatusPreco Status { get; set; }
    }
}
