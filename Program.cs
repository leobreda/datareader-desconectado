using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ConsoleDataReader
{
    class Program
    {

        static void Main(string[] args)
        {
            Program instancia = new Program();


            // gerarDados = true para realizar a criação dos dados no banco de dados
            //              false para realizar a consulta ao banco de dados

            bool gerarDados = false;

            if (gerarDados)
            {
                instancia.GerarMassaDados();
            }
            else
            {
                List<Cliente> lista = instancia.ConsultarDados();
            }

            Console.WriteLine("Fim do programa");
            Console.ReadLine();
        }


        /// <summary>
        /// Insere 10.000 clientes no banco de dados
        /// </summary>
        public void GerarMassaDados()
        {
            string sqlCommand = "INSERT INTO TB_CLIENTE (NOME,EMAIL, CPF,END_LOGRADOURO,END_NUMERO, END_CEP, END_CIDADE, END_ESTADO, TEL_DDD, TEL_NUMERO) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},{9})";
            string sql = null;

            for (int i = 0; i < 10000; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = Gerador.Nome;
                cliente.Email = Gerador.Email(cliente.Nome);
                cliente.CPF = Convert.ToUInt64(String.Concat(Gerador.Numero(1, 999999999), Gerador.Numero(1, 99)));
                cliente.Endereco.Logradouro = Gerador.Logradouro;
                cliente.Endereco.Numero = Convert.ToString(Gerador.Numero(1, 999));

                cliente.Endereco.CEP = Gerador.Numero(1000000, 99999999).ToString().PadLeft(9, '0');
                cliente.Endereco.CEP = cliente.Endereco.CEP.Substring(0, 5) + "-" + cliente.Endereco.CEP.Substring(6);
                cliente.Endereco.Cidade = Gerador.Cidade;
                cliente.Endereco.Estado = Gerador.Estado;

                cliente.Telefone.DDD = Convert.ToUInt16(Gerador.Numero(11, 99));

                if ((cliente.Telefone.DDD % 10).Equals(0))
                    cliente.Telefone.DDD++;

                cliente.Telefone.Numero = Convert.ToUInt64(String.Concat(9, Gerador.Numero(11111111, 99999999)));


                Console.WriteLine(cliente.ToString());

                sql = string.Format(sqlCommand,
                    cliente.Nome,
                    cliente.Email,
                    cliente.CPF,
                    cliente.Endereco.Logradouro,
                    cliente.Endereco.Numero,
                    cliente.Endereco.CEP,
                    cliente.Endereco.Cidade,
                    cliente.Endereco.Estado,
                    cliente.Telefone.DDD,
                    cliente.Telefone.Numero);

                CRUD.ExecuteNonQuery(sql);


            }

        }



        public List<Cliente> ConsultarDados()
        {

            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;

            string sqlCommand = @"SELECT TOP 1000 ID,NOME, EMAIL, CPF, 
                                    END_LOGRADOURO, END_NUMERO, END_CEP, END_CIDADE, END_ESTADO, 
                                    TEL_DDD, TEL_NUMERO
                                    FROM TB_CLIENTE
                                    ORDER BY NEWID()";

            try
            {
                IDataReader dr = CRUD.ExecuteReader(sqlCommand);

                Console.WriteLine("Conexão com banco de dados realizada, e DataReader preenchido...");

                while (dr.Read())
                {
                    cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(dr["ID"].ToString());
                    cliente.Nome = dr["NOME"].ToString();
                    cliente.Email = dr["EMAIL"].ToString();
                    cliente.CPF = Convert.ToUInt64(dr["CPF"].ToString());
                    cliente.Endereco.Logradouro = dr["END_LOGRADOURO"].ToString();
                    cliente.Endereco.Numero = dr["END_NUMERO"].ToString();
                    cliente.Endereco.CEP = dr["END_CEP"].ToString();
                    cliente.Endereco.Cidade = dr["END_CIDADE"].ToString();
                    cliente.Endereco.Estado = dr["END_ESTADO"].ToString();
                    lista.Add(cliente);
                }

                dr.Close();
                dr.Dispose();

                dr = null;

                Console.WriteLine("Fim da leitura do DataReader...");

                return lista;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Opa! Sem conexão com o banco de dados...\n\nPressione ENTER para continuar...");
                Console.ReadLine();

            }
            return null;
        }

    }
}
