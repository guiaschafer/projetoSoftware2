using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entidades
{
    public class Preco
    {
        public int Id { get; set; }
        public virtual Farmacia Farmacia { get; set; }
        public virtual Produto Produto { get; set; }
        public decimal Valor { get; set; }
    }
}
