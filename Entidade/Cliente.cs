using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDataReader
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public UInt64 CPF { get; set; }

        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }


        public Cliente()
        {
            this.ID = 0;
            this.Nome = string.Empty;
            this.Email = string.Empty;
            this.CPF = 0;
            this.Endereco = new Endereco();
            this.Telefone = new Telefone();
        }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        }
    }

   

}
