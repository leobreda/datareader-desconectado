using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDataReader
{
    static class Gerador
    {

        public static int Numero(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public static string Logradouro
        {
            get
            {
                string[] varA = { "Rua", "Av" };

                string[] varB = (
                    "Andre,Antonio,Amazonas,"
                    + "Barbosa,Bonifacio,"
                    + "Catarina,"
                    + "de Souza,de Piracicaba,de Maio,de Junho,de Setembro,"
                    + "Edgar,"
                    + "Flores,Fernandes,"
                    + "Horizonte,"
                    + "Inajar,Itaberaba,"
                    + "Jose,João,Joaquim,"
                    + "Magalhaes,"
                    + "Novembro,"
                    + "Pereira,Pinto,Pedro,"
                    + "Raimundo,Rita,"
                    + "Santa Rita,"
                    + "Tiradentes,"
                    + "Valente,Vieira").Split(',');

                Random rnd = new Random();
                string ret = string.Empty;

                ret += varA[rnd.Next(varA.Length)] + " ";
                ret += varB[rnd.Next(varB.Length)] + " ";
                ret += varB[rnd.Next(varB.Length)] + " ";
                ret += varB[rnd.Next(varB.Length)];

                return ret;
            }
        }

        public static string Estado
        {
            get
            {
                Random rnd = new Random();

                string[] varA = ("AC,SP,MG,RJ,PG,AM,AP,MS,MT,BA,PR,SC,RS").Split(',');

                return varA[rnd.Next(varA.Length)];
            }
        }



        public static string Cidade
        {
            get
            {
                Random rnd = new Random();

                string[] varA = ("Aracatuba,Aracariguama,Andradina,"
                                + "Boraceia,Belo Horizonte,Barueri,Braganca Paulista,"
                                + "Caraguatatuba,Campinas,"
                                + "Diamantina,Diadema,"
                                + "Eldorado,Echapora,Esteio,Estrela do Norte,Euclides da Cunha,"
                                + "Ferraz de Vasconcelos,Fartura,Faria,Ferros,"
                                + "Guarulhos,Goiatuba,Gonzaga,Guapore"
                                + "Havana,Heliopolis,Holambra,Horizonte,Heiodora,"
                                + "Igarata,Inajá,Ibiuna,Itaju,Itambe,"
                                + "Joao Pessoa,Jaboticabal,Jaboti,Jardim,Jarinu,Joinville,"
                                + "Londrina,Laje,Ladario,Lagarto,Lages,Lins,"
                                + "Matelandia,Maringa,Macae,Moema,Mogeiro,"
                                + "Navirai,Nova Lima,Navegantes,Nova Esperanca,Nova Uniao,Nova Friburgo,"
                                + "Ourinhos,Osasco,Olaria,Ouro Verde,Oliveira,"
                                + "Pres Prudente,Pres Venceslau,Pres Epitacio,"
                                + "Quadra,Quatro Barras,Quilombo,Quixabeira,Queiroz,"
                                + "Rolandia,Ribeirao Preto,Rio de Janeiro,"
                                + "Sao Roque,Sao Paulo,Santos,Santo Anastacio,São Carlos, São Bernardo do Campo,Santo André,Santo Inacio,"
                                + "Tatui,Telha,Tremedal,Tenebre,Teodoro Sampaio,Tabuleiro,Taboca,Tabira,"
                                + "Uchoa,Uniao do Sul,Urucara,Uniao,Uniao Bandeirante,"
                                + "Vinhedo,Vararia,Vera Cruz,Vila Nova,Vila Flores,Vila Boa,Valencia,"
                                + "Xique-Xique,Xanxere,Xapuri,Xavantina,"
                                + "Zabele,Zacarias,Zortea"
                                ).Split(',');

                return varA[rnd.Next(varA.Length)];
            }
        }


        public static string Nome
        {
            get
            {
                Random rnd = new Random();
                string ret = string.Empty;

                string[] varA = ("Andrea,Alice,Aline,Ana Paula,Anderson,Adao,Adelio,Ailton,"
                    + "Bruna,Benetida,Beto,Bill,Bruno,"
                    + "Camila,Cassia,Cleber,Clodoaldo,"
                    + "Damaris,Daniela,Daniel,Douglas,Denis,Dilva,"
                    + "Eduarda,Erica,Emilia,Eduardo,Eder,Emilio,"
                    + "Fernando,Fernanda,Fabio,Fabiana,"
                    + "Gisele,Giselda,Gomes,Gilmar,"
                    + "Henrique,Helio,"
                    + "Ivonete,Israel,Inacio,"
                    + "Jamile,Jose,Joao,Juliana,Jeremias,Jonas,"
                    + "Leonardo,Lucas,Lilian,Luciano,Luciana,"
                    + "Maria,Marcos,Miguel,"
                    + "Neusa,Nilton,Nadir,"
                    + "Osvaldo,Onofre,"
                    + "Paula,Paulo,Patricia,"
                    + "Roberto,Roberta,"
                    + "Samuel,Silmara,"
                    + "Talita,Tadeu,"
                    + "Vagner,Vilma,Valeria").Split(',');

                ret += varA[rnd.Next(varA.Length)] + " ";

                string[] varB = ("Alegre,"
                    + "Barbosa,Bezerra,Brito,Braga,Bragato,"
                    + "Costa,Correia,Cordeiro,Cruz,"
                    + "Ferreira,Fernandes,"
                    + "Gomes,Goncalves,"
                    + "Leite,Lima,"
                    + "Matos,Monteiro,Mendes,Machado,Miranda,"
                    + "Neves,Narciso,"
                    + "Oliveira,"
                    + "Rodrigues,Ribeiro,Ramos,"
                    + "Silva,Santos,Souza,Soares,Santana,Siqueira,Sanches,"
                    + "Teixeira,Tavares,Travassos,"
                    + "Vieira").Split(',');

                ret += varB[rnd.Next(varB.Length)];


                return ret;
            }

        }


        public static string Email(string nome)
        {
            Random rnd = new Random();
            string ret = string.Empty;

            string[] varA = ("@yahoo.com.br,@yahoo.com,@outlook.com,@gmail.com,@uol.com.br,@email.com.br,@hotmail.com").Split(',');


            return nome.ToLower().Trim().Replace(" ", ".") + new Random().Next(1, 9999) + varA[rnd.Next(varA.Length)];

        }
    }
}
