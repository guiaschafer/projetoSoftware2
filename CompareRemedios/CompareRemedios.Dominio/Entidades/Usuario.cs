using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string NomeCompleto { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<Perfil> Perfis { get; set; }

    }
}
