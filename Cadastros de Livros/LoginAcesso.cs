/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 11:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastros_de_Livros
{
	/// <summary>
	/// Description of LoginAcesso.
	/// </summary>
	public partial class LoginAcesso : Form
	{
		public LoginAcesso()
		{
			InitializeComponent();
		}
		
		//evento responsavel pelo login
		void Logar_buttonClick(object sender, EventArgs e)
		{
			try
			{
				Login logar = new Login("Server=127.0.0.1; Uid=root; Pwd=Scotto1997; Database=Biblioteca");
				
				if(logar.VerificaLogin(email_textBox.Text, senha_textBox.Text) == true)
					this.Hide();						//fecha o Form de Login
			}
			
			catch(Exception erro)
			{
				MessageBox.Show(erro.Message);
			}
		}
	}
}
