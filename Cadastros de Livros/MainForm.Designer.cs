/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 08:58
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Cadastros_de_Livros
{
	partial class Logado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView saida_dataGridView;
		private System.Windows.Forms.TabControl Atualizar;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox isbn_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox titulo_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox autor_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button deletar_button;
		private System.Windows.Forms.TextBox isbnD_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox id_textBox;
		private System.Windows.Forms.Label Id;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox tituloU_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label idU_textBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.saida_dataGridView = new System.Windows.Forms.DataGridView();
			this.Atualizar = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.isbn_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.titulo_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.autor_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.deletar_button = new System.Windows.Forms.Button();
			this.isbnD_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.id_textBox = new System.Windows.Forms.TextBox();
			this.Id = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.tituloU_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.idU_textBox = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.saida_dataGridView)).BeginInit();
			this.Atualizar.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// saida_dataGridView
			// 
			this.saida_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.saida_dataGridView.Location = new System.Drawing.Point(260, 13);
			this.saida_dataGridView.Name = "saida_dataGridView";
			this.saida_dataGridView.Size = new System.Drawing.Size(443, 256);
			this.saida_dataGridView.TabIndex = 0;
			// 
			// Atualizar
			// 
			this.Atualizar.Controls.Add(this.tabPage1);
			this.Atualizar.Controls.Add(this.tabPage2);
			this.Atualizar.Controls.Add(this.tabPage3);
			this.Atualizar.Location = new System.Drawing.Point(13, 13);
			this.Atualizar.Name = "Atualizar";
			this.Atualizar.SelectedIndex = 0;
			this.Atualizar.Size = new System.Drawing.Size(204, 230);
			this.Atualizar.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.isbn_textBox);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.titulo_textBox);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.autor_textBox);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(196, 204);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cadastrar";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(90, 137);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 29);
			this.button1.TabIndex = 6;
			this.button1.Text = "Cadastrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// isbn_textBox
			// 
			this.isbn_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isbn_textBox.Location = new System.Drawing.Point(68, 92);
			this.isbn_textBox.Name = "isbn_textBox";
			this.isbn_textBox.Size = new System.Drawing.Size(100, 22);
			this.isbn_textBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Isbn";
			// 
			// titulo_textBox
			// 
			this.titulo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo_textBox.Location = new System.Drawing.Point(68, 56);
			this.titulo_textBox.Name = "titulo_textBox";
			this.titulo_textBox.Size = new System.Drawing.Size(100, 22);
			this.titulo_textBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Titulo";
			// 
			// autor_textBox
			// 
			this.autor_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autor_textBox.Location = new System.Drawing.Point(68, 22);
			this.autor_textBox.Name = "autor_textBox";
			this.autor_textBox.Size = new System.Drawing.Size(100, 22);
			this.autor_textBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Autor";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.deletar_button);
			this.tabPage2.Controls.Add(this.isbnD_textBox);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.id_textBox);
			this.tabPage2.Controls.Add(this.Id);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(196, 204);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Deletar";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// deletar_button
			// 
			this.deletar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deletar_button.Location = new System.Drawing.Point(93, 145);
			this.deletar_button.Name = "deletar_button";
			this.deletar_button.Size = new System.Drawing.Size(78, 29);
			this.deletar_button.TabIndex = 13;
			this.deletar_button.Text = "Deletar";
			this.deletar_button.UseVisualStyleBackColor = true;
			this.deletar_button.Click += new System.EventHandler(this.Deletar_buttonClick);
			// 
			// isbnD_textBox
			// 
			this.isbnD_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isbnD_textBox.Location = new System.Drawing.Point(71, 64);
			this.isbnD_textBox.Name = "isbnD_textBox";
			this.isbnD_textBox.Size = new System.Drawing.Size(100, 22);
			this.isbnD_textBox.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(26, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Isbn";
			// 
			// id_textBox
			// 
			this.id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_textBox.Location = new System.Drawing.Point(71, 30);
			this.id_textBox.Name = "id_textBox";
			this.id_textBox.Size = new System.Drawing.Size(100, 22);
			this.id_textBox.TabIndex = 8;
			// 
			// Id
			// 
			this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Id.Location = new System.Drawing.Point(26, 32);
			this.Id.Name = "Id";
			this.Id.Size = new System.Drawing.Size(100, 23);
			this.Id.TabIndex = 7;
			this.Id.Text = "Id";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.tituloU_textBox);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.textBox2);
			this.tabPage3.Controls.Add(this.idU_textBox);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(196, 204);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Atualizar";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(93, 145);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 29);
			this.button2.TabIndex = 18;
			this.button2.Text = "Deletar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// tituloU_textBox
			// 
			this.tituloU_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tituloU_textBox.Location = new System.Drawing.Point(71, 64);
			this.tituloU_textBox.Name = "tituloU_textBox";
			this.tituloU_textBox.Size = new System.Drawing.Size(100, 22);
			this.tituloU_textBox.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Titulo";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(71, 30);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 15;
			// 
			// idU_textBox
			// 
			this.idU_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idU_textBox.Location = new System.Drawing.Point(26, 32);
			this.idU_textBox.Name = "idU_textBox";
			this.idU_textBox.Size = new System.Drawing.Size(100, 23);
			this.idU_textBox.TabIndex = 14;
			this.idU_textBox.Text = "Id";
			// 
			// Logado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 282);
			this.Controls.Add(this.Atualizar);
			this.Controls.Add(this.saida_dataGridView);
			this.Name = "Logado";
			this.Text = "Cadastros de Livros";
			((System.ComponentModel.ISupportInitialize)(this.saida_dataGridView)).EndInit();
			this.Atualizar.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
