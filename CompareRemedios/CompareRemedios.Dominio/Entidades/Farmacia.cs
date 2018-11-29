using System;
using System.Collections.Generic;
using System.Text;

namespace CompareRemedios.Dominio.Entidades
{
    public class Farmacia
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
