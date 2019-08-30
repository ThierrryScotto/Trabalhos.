/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 10:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;

namespace Cadastros_de_Livros
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public class Login : AcessoAoBancoDeDados
	{
		public Login(string informacao) : base(informacao)
		{}
		
		//método utilizado para a verificação de login
		public bool VerificaLogin(string email, string senha)
		{
			bool verifica = false;   											//guarda o resultado da pesuisa dentro da tabela
			comando.CommandText = "select  email, senha from Login where email = '"+ email +"' and senha = '"+ senha +"';";
			
			try
			{
				conexao.Open();											//abre conexão com o banco
				MySqlDataReader leitura = comando.ExecuteReader();		//executa o comando
				verifica  = leitura.HasRows;								//recebe verificação se encontrou a informação no banco
				conexao.Close();										//fecha conexão com o banco
			}		
			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
			return Verificar(verifica);
		}

		//metodo verifica se o login foi encontrado no banco
		private bool Verificar(bool verificacao)
		{
			if(verificacao){
				Logado logado = new Logado();		//instania um Form de Home onde será executado a inclusã, exclusão de usuários
				logado.Show();						//Exibe o form home
				return true;
			}else{
				MessageBox.Show("E-mail ou Senha errado");
			}
			return false;
		}
	}
}
