using CompareRemedios.Dominio.Entidades;
using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades
{
    public class PerfilUsuario
    {
        public Usuario User { get; set; }
        public PerfilEnum Perfi { get; set; }
    }
}
