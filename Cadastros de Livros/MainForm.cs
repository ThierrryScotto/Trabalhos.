/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 08:58
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastros_de_Livros
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Logado : Form
	{
		public Logado()
		{
			InitializeComponent();
			Exibir();
		}
		
		//objeto para acesso ao banco
		AcessoAoBancoDeDados acesso = new AcessoAoBancoDeDados("Server=127.0.0.1; Uid=root; Pwd=Scotto1997; Database=Biblioteca");
		
		//evento para atualizar um livro do sistema
		void Button2Click(object sender, EventArgs e)
		{
			acesso.Atualizar(int.Parse(id_textBox.Text), tituloU_textBox.Text);
			Exibir();
			Limpar();
		}
		
		//evento para cadastrar o livro no sistema
		void Button1Click(object sender, EventArgs e)
		{
			acesso.Adicionar(autor_textBox.Text, titulo_textBox.Text, int.Parse(isbn_textBox.Text));
			Exibir();
			Limpar();
		}
		
		//evento para deletar um livro do sistema
		void Deletar_buttonClick(object sender, EventArgs e)
		{
			acesso.Deletar(int.Parse(id_textBox.Text), int.Parse(isbnD_textBox.Text));
			Exibir();
			Limpar();
		}
		
		//método para exibir a tabela sempre atualizada
		private void Exibir()
		{
			saida_dataGridView.DataSource = acesso.Exibir();
		}
		
		//metodo para limpar as TextBox
		private void Limpar()
		{
			id_textBox.Text = idU_textBox.Text = 	 null;
			autor_textBox =							 null;
			isbn_textBox.Text = isbnD_textBox.Text = null;
			titulo_textBox = tituloU_textBox =		 null;
		}
	}
}
