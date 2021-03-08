using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDataReader
{

    public class Telefone
    {
        public UInt16 DDD { get; set; }
        public UInt64 Numero { get; set; }

        public Telefone()
        {
            this.DDD = 0;
            this.Numero = 0;
        }
    }
}
