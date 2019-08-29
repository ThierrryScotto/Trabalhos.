/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 29/08/2019
 * Hora: 15:43
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace cadastro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox titulo_textBox;
		private System.Windows.Forms.TextBox isbn_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox lancamento_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox autor_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView saida_dataGridView;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button cadastrar_button;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox isbnDell_textBox;
		private System.Windows.Forms.Button deletar_button;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox id_textBox;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.saida_dataGridView = new System.Windows.Forms.DataGridView();
			this.add_button = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.lancamento_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.autor_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.isbn_textBox = new System.Windows.Forms.TextBox();
			this.cadastrar_button = new System.Windows.Forms.Button();
			this.titulo_textBox = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.isbnDell_textBox = new System.Windows.Forms.TextBox();
			this.deletar_button = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.id_textBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.saida_dataGridView)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titulo";
			// 
			// saida_dataGridView
			// 
			this.saida_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.saida_dataGridView.Location = new System.Drawing.Point(280, 12);
			this.saida_dataGridView.Name = "saida_dataGridView";
			this.saida_dataGridView.Size = new System.Drawing.Size(519, 215);
			this.saida_dataGridView.TabIndex = 8;
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(295, 488);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(75, 23);
			this.add_button.TabIndex = 9;
			this.add_button.Text = "Adicionar";
			this.add_button.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(262, 215);
			this.tabControl1.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.lancamento_textBox);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.autor_textBox);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.isbn_textBox);
			this.tabPage1.Controls.Add(this.cadastrar_button);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.titulo_textBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(254, 189);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Cadastrar";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(135, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 14);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lançamento";
			// 
			// lancamento_textBox
			// 
			this.lancamento_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lancamento_textBox.Location = new System.Drawing.Point(135, 86);
			this.lancamento_textBox.Name = "lancamento_textBox";
			this.lancamento_textBox.Size = new System.Drawing.Size(100, 22);
			this.lancamento_textBox.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(135, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "Autor";
			// 
			// autor_textBox
			// 
			this.autor_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autor_textBox.Location = new System.Drawing.Point(135, 31);
			this.autor_textBox.Name = "autor_textBox";
			this.autor_textBox.Size = new System.Drawing.Size(100, 22);
			this.autor_textBox.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 14);
			this.label2.TabIndex = 3;
			this.label2.Text = "Isbn";
			// 
			// isbn_textBox
			// 
			this.isbn_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isbn_textBox.Location = new System.Drawing.Point(6, 86);
			this.isbn_textBox.Name = "isbn_textBox";
			this.isbn_textBox.Size = new System.Drawing.Size(100, 22);
			this.isbn_textBox.TabIndex = 4;
			// 
			// cadastrar_button
			// 
			this.cadastrar_button.Location = new System.Drawing.Point(151, 126);
			this.cadastrar_button.Name = "cadastrar_button";
			this.cadastrar_button.Size = new System.Drawing.Size(84, 32);
			this.cadastrar_button.TabIndex = 2;
			this.cadastrar_button.Text = "Cadastrar";
			this.cadastrar_button.UseVisualStyleBackColor = true;
			this.cadastrar_button.Click += new System.EventHandler(this.Cadastrar_buttonClick);
			// 
			// titulo_textBox
			// 
			this.titulo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo_textBox.Location = new System.Drawing.Point(6, 31);
			this.titulo_textBox.Name = "titulo_textBox";
			this.titulo_textBox.Size = new System.Drawing.Size(100, 22);
			this.titulo_textBox.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.isbnDell_textBox);
			this.tabPage2.Controls.Add(this.deletar_button);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.id_textBox);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(254, 189);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Excluir";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 14);
			this.label7.TabIndex = 12;
			this.label7.Text = "Isbn";
			// 
			// isbnDell_textBox
			// 
			this.isbnDell_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.isbnDell_textBox.Location = new System.Drawing.Point(13, 94);
			this.isbnDell_textBox.Name = "isbnDell_textBox";
			this.isbnDell_textBox.Size = new System.Drawing.Size(100, 22);
			this.isbnDell_textBox.TabIndex = 13;
			// 
			// deletar_button
			// 
			this.deletar_button.Location = new System.Drawing.Point(13, 140);
			this.deletar_button.Name = "deletar_button";
			this.deletar_button.Size = new System.Drawing.Size(84, 32);
			this.deletar_button.TabIndex = 11;
			this.deletar_button.Text = "Deletar";
			this.deletar_button.UseVisualStyleBackColor = true;
			this.deletar_button.Click += new System.EventHandler(this.Deletar_buttonClick);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 14);
			this.label8.TabIndex = 9;
			this.label8.Text = "Id";
			// 
			// id_textBox
			// 
			this.id_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_textBox.Location = new System.Drawing.Point(13, 39);
			this.id_textBox.Name = "id_textBox";
			this.id_textBox.Size = new System.Drawing.Size(100, 22);
			this.id_textBox.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 243);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.add_button);
			this.Controls.Add(this.saida_dataGridView);
			this.Name = "MainForm";
			this.Text = "cadastro";
			((System.ComponentModel.ISupportInitialize)(this.saida_dataGridView)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
