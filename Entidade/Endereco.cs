using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDataReader
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public Endereco()
        {
            this.Logradouro = string.Empty;
            this.Numero = string.Empty;
            this.CEP = string.Empty;
            this.Cidade = string.Empty;
            this.Estado = string.Empty;

        }
    }
}
