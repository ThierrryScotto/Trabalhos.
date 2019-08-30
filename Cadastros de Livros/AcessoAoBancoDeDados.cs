/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 09:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastros_de_Livros
{
	/// <summary>
	/// Description of AcessoAoBancoDeDados.
	/// </summary>
	public class AcessoAoBancoDeDados
	{
		//construtor
		public AcessoAoBancoDeDados(string informacoesBanco)
		{
			conexao.ConnectionString = informacoesBanco;			//recebe informações de acesso ao banco
			comando.Connection = conexao;							//objeto de comando estabelece conexão com o objeto de conexão
		}
		//fim construtor

		//adicionar livro no banco de dados
		public void Adicionar(string autor, string titulo, int isbn)
		{
			comando.CommandText = "INSERT INTO Livro(autor, titulo, isbn) VALUES ('"+ autor +"', '"+ titulo +"', "+ isbn +")";
			Executar();
		}

		//deleta um livro do sistema
		public void Deletar(int id, int isbn)
		{
			comando.CommandText = "DELETE FROM Livro WHERE id_livro = "+ id +" and isbn = "+ isbn +"";
			Executar();
		}

		//atualizar livro do banco de dados
		public void Atualizar(int id, string titulo)
		{
			comando.CommandText = "UPDATE Livro SET titulo = '"+ titulo +"' WHERE id_livro = "+ id +"";
			Executar();
		}

		//metodo para exibir a tabela
		public DataTable Exibir()
		{
			comando.CommandText = "SELECT * FROM Livro";
			
			try
			{
				conexao.Open();											//abre conexão
				MySqlDataReader leitura = comando.ExecuteReader();		//executa o comando e retorna a tabela
				DataTable tabela = new DataTable();						//Objeto para receber a tabela	
				tabela.Load(leitura);	
				conexao.Close();										//fecha conexão com o banco de dados
				return tabela;											//retorna a tabela de acordo com o comando
			}

			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
			return null;												//no caso de algum erro retorna null
		}

		//metodo para acessar ao banco e executar a instrução SQL
		private void Executar()
		{
			try
			{
				conexao.Open();											//abre conexão
				comando.ExecuteNonQuery();								//executa o comando
				conexao.Close();										//fecha conexão
			}

			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
				conexao.Close();										//fecha conexão
			}
		}

		//objetos de instância
		//objeto para a conexão com o banco de dados
		protected MySqlConnection conexao = new MySqlConnection();

		//responsavel por executar o comando
		protected MySqlCommand comando = new MySqlCommand();
	}
}
