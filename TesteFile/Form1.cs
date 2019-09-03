using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TesteFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_button_Click(object sender, EventArgs e)
        {
            //Limpa a saída
            saida_textBox.Text = null;

            //verifica se o nome do arquivo existe
            if (File.Exists(entrada_textBox.Text + ".txt"))
            {
                //variavel responsavel por guardar o nome do arquivo ou diretorio com seu formato adequado
                string pastaOuArquivo = entrada_textBox.Text + ".txt";

                //retorna a hora em que o arquivo foi criado
                saida_textBox.Text += "Hora da criação: " + File.GetCreationTime(pastaOuArquivo) + "\n\n";

                //retorna informaçãoes de quando o arquivo teve um ultimo acesso
                saida_textBox.Text += "Utimo acesso" + File.GetLastAccessTimeUtc(pastaOuArquivo) + "\n\n";

                try
                {
                    //retorna o conteudo dentro do arquivo
                    StreamReader leitura = new StreamReader(pastaOuArquivo);
                    //metodo lé o arquivo até o final
                    saida_textBox.Text += leitura.ReadToEnd();
                }

                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if(Directory.Exists(entrada_textBox.Text))
            {
                //recebe os subdiretorio de um determinado diretorio
                string[] subdiretorios;

                try
                {
                    //exibe a data e a hora em que o diretorio foi criado
                    saida_textBox.Text += Directory.GetCreationTime(entrada_textBox.Text);

                    //retorna os subdiretorios do diretorio especificado
                    subdiretorios = Directory.GetDirectories(entrada_textBox.Text);

                    foreach (var nomes in subdiretorios)
                        saida_textBox.Text += nomes + "\n";
                }
                catch (IOException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Não existe arquivo ou diretorio com este nome" + "Erro" + MessageBoxIcon.Error);
            }
                

        }
    }
}
