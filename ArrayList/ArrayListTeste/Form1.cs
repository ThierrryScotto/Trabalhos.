using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Coleção ArrayList
        ArrayList vetor = new ArrayList();

        //manipulador de evento para adicionar um novo valor dentro do ArrayList
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (VerificarTextBox())
            {
                vetor.Add(entrada_textBox.Text);
                saida_textBox.Text = entrada_textBox.Text + " Adicionado com sucesso";
            }
            else
                saida_textBox.Text = "Por favor preencha a caixa de texto";

            //limpa o textBox
            Limpar();
        }

        //evento para remover uma string do ArrayList
        private void Remover_button_Click(object sender, EventArgs e)
        {
            if (VerificarTextBox())
            {
                vetor.Remove(entrada_textBox.Text);
                saida_textBox.Text = entrada_textBox.Text + " Removido com sucesso";
            }
            else
                saida_textBox.Text = "Por favor preencha a caixa de texto";

            //limpa o textBox
            Limpar();
        }

        //Exibe o primeiro subscrito do array
        private void Primeiro_button_Click(object sender, EventArgs e)
        {
            try
            {
                saida_textBox.Text = (string)vetor[0];
            }

            catch (Exception)
            {
                saida_textBox.Text = "O array pode estar vazio";
            }

            finally
            {
                Limpar();
            }
        }

        //Exibe o ultimo subcrito do array
        private void Ultimo_button_Click(object sender, EventArgs e)
        {
            try
            {
                saida_textBox.Text = (string) vetor[vetor.Count - 1];
            }

            catch (Exception)
            {
                saida_textBox.Text = "O array pode estar vazio";
            }

            finally
            {
                Limpar();
            }
        }

        //verifica se o ArrayList está vazio
        private void Vazio_button_Click(object sender, EventArgs e)
        {
            saida_textBox.Text = (vetor.Count == 0) ? "Array Vazio" : "Array com informações";
        }

        //verifica se uma string está dentro do ArrayList
        private void Verificar_button_Click(object sender, EventArgs e)
        {
            saida_textBox.Text = (vetor.Contains(entrada_textBox.Text) == true) ? 
                entrada_textBox.Text+" está no ArrayList" : entrada_textBox.Text + " não está no ArrayList";
            Limpar();           
        }

        //busca uma string dentro do ArrayList
        private void Buscar_button_Click(object sender, EventArgs e)
        {
            if (VerificarTextBox())
            {
                int resul = vetor.IndexOf(entrada_textBox.Text);
                if (resul >= 0)
                    saida_textBox.Text = "O valor está no endereço: " + vetor.IndexOf(entrada_textBox.Text);
                else
                    saida_textBox.Text = "Valor não encontrado";
            }
            else
                saida_textBox.Text = "Por favor preencha a caixa de Texto";
        }

        //otimiza a capacidade do ArrayList
        private void Otimizar_button_Click(object sender, EventArgs e)
        {
            try
            {
                //verifica se o array não está vazio
                if (vetor[0] != null)
                    vetor.TrimToSize();
                saida_textBox.Text = "Array Otimizado";
            }

            catch (Exception)
            {
                saida_textBox.Text = "Array Vazio";
            }
        }

        //Exibe as informações do ArrayList
        private void Statistica_button_Click(object sender, EventArgs e)
        {
            saida_textBox.Text = "Quantidade de elementos no array " + vetor.Count +
                                    "\n\nCapacidade do ArrayList: " + vetor.Capacity;
        }

        //evento para exibir as informações contidas no array list
        private void Exibir_button_Click(object sender, EventArgs e)
        {
            saida_textBox.Text = null;
            if (vetor.Count != 0)
            {
                foreach (var nomes in vetor)
                    saida_textBox.Text += nomes + "\n\n";
            }
            else
                saida_textBox.Text = "array vazio";
        }

        //método para verificar se o TextBox está vazio
        private bool VerificarTextBox()
        {
            if (entrada_textBox.Text != "")
                return true;
            else
                return false;
        }

        //Limpa a entrada textBox
        private void Limpar()
        {
            entrada_textBox.Text = null;
        }
    }
}
