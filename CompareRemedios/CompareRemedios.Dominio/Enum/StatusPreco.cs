using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareRemedios.Dominio.Enum
{
    public enum StatusPreco
    {
        [Description("Em aprovação")]
        EmAprovacao = 0,
        [Description("Aprovado")]
        Aprovado = 1,
        [Description("Cancelado")]
        Cancelado = 2
    }
}
