/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 29/08/2019
 * Hora: 15:43
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cadastro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ExibirTabela();
		}
		
		//objeto para acessar a classe que tem acesso ao banco
		Banco banco = new Banco(@"Server=127.0.0.1; Uid=root; Pwd=Scotto1997; Database=Biblioteca");
		
		//método para exibir a tabela
		private void ExibirTabela()
		{
			saida_dataGridView.DataSource = banco.Exibir();			//chama o método da classe para exibir a tabela
			saida_dataGridView.Refresh();
		}
		
		//objeto para acessar a classe que tem acesso ao banco
		void Cadastrar_buttonClick(object sender, EventArgs e)
		{
			banco.AdicionaLivro(titulo_textBox.Text, int.Parse(isbn_textBox.Text), autor_textBox.Text, lancamento_textBox.Text);
			ExibirTabela();
		}
		
		//vento para deletar um livro do sistema
		void Deletar_buttonClick(object sender, EventArgs e)
		{
			banco.Deletar(int.Parse(id_textBox.Text), int.Parse(isbnDell_textBox.Text));
			ExibirTabela();
		}
	}
}
