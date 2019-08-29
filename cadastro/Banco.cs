/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 29/08/2019
 * Hora: 15:50
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace cadastro
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco
	{
		//Contrutor
		public Banco(string acesso)
		{
			conexao.ConnectionString = acesso;
		}
		//Fim Contrutor
		
		//Exibe a tabela
		public DataTable Exibir()
		{
			try
			{
				buffer.Clear();															//limpa o dataset
				ponte = new MySqlDataAdapter("SELECT * FROM Livro", conexao);			//Vai exercura o comando dentro do banco de dados
				ponte.Fill(buffer, "Livro");											//coloca as informações dentro do DataSet
				return buffer.Tables["Livro"];											//retorna a tabela de entro do DataSet
			}
			
			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
			return null;
		}
		
		//Adiciona um novo livro no banco 
		public void AdicionaLivro(string titulo, int isbn, string autor, string data)
		{
			try
			{
				string comando = "INSERT INTO Livro(titulo, isbn, autor, lancamento) values ('"+ titulo +"',"+ isbn +",'"+ autor +"','"+ data +"')";
				MySqlCommand comandoBanco = new MySqlCommand(comando, conexao);				//executar o comando no banco de dados
				conexao.Open();
				comandoBanco.ExecuteNonQuery();
				conexao.Close();
			}
			
			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
		
		//Deleta um livro do banco 
		public void Deletar(int id, int isbn)
		{
			try
			{
				string comando = "delete from Livro where Id_livro = "+ id +" and isbn = "+ isbn +"";
				MySqlCommand comandoBanco = new MySqlCommand(comando, conexao);				//executar o comando no banco de dados
				conexao.Open();
				comandoBanco.ExecuteNonQuery();
				conexao.Close();
			}
			
			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
			
		//objetos de instacia
		//objeto de conexao
		MySqlConnection conexao = new MySqlConnection();
		
		//vai armazenar o banco como buffer
		DataSet buffer = new DataSet();
		
		//ojeto utilizado como ponte para dataset
		MySqlDataAdapter ponte;
		
	}
}
