# datareader-desconectado
Trabalhando com DataReader em .net desconectado do banco de dados

Em outras palavras, um CRUD na qual retorna um objeto IDataReader sem depender de uma conexão ativa, reduzindo a quantidade de conexões ativas e evitando o problema de conexões excedidas.


## 1.  Crie o Banco de dados
Necessário para o caso de teste

	CREATE DATABASE POC;
	USE POC;

	DROP TABLE TB_CLIENTE;
	CREATE TABLE TB_CLIENTE
	(
	ID INT IDENTITY PRIMARY KEY,
	NOME VARCHAR(60),
	EMAIL VARCHAR(80),
	CPF BIGINT,
	END_LOGRADOURO VARCHAR(60),
	END_NUMERO VARCHAR(5),
	END_CEP VARCHAR(9),
	END_CIDADE VARCHAR(60),
	END_ESTADO VARCHAR(20),
	TEL_DDD TINYINT,
	TEL_NUMERO BIGINT
	);
	SELECT * FROM TB_CLIENTE order by id desc;

## 2. Habilite a geração de massa de dados 
	static void Main(string[] args)
	{
		gerarDados = true;
	}

##3. Ative/Desative o modo conectado

	public static DbDataReader ExecuteReader(string strSQL)
	{
		conectado = true;
	}




https://pandao.github.io/editor.md/en.html