/*
 * Criado por SharpDevelop.
 * Usuário: thierry-santos
 * Data: 30/08/2019
 * Hora: 11:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Cadastros_de_Livros
{
	partial class LoginAcesso
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button logar_button;
		private System.Windows.Forms.TextBox email_textBox;
		private System.Windows.Forms.TextBox senha_textBox;
		private System.Windows.Forms.Label label2;
		
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
			this.logar_button = new System.Windows.Forms.Button();
			this.email_textBox = new System.Windows.Forms.TextBox();
			this.senha_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "E-mail";
			// 
			// logar_button
			// 
			this.logar_button.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logar_button.Location = new System.Drawing.Point(141, 182);
			this.logar_button.Name = "logar_button";
			this.logar_button.Size = new System.Drawing.Size(84, 30);
			this.logar_button.TabIndex = 1;
			this.logar_button.Text = "Logar";
			this.logar_button.UseVisualStyleBackColor = true;
			this.logar_button.Click += new System.EventHandler(this.Logar_buttonClick);
			// 
			// email_textBox
			// 
			this.email_textBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email_textBox.Location = new System.Drawing.Point(43, 56);
			this.email_textBox.Name = "email_textBox";
			this.email_textBox.Size = new System.Drawing.Size(182, 26);
			this.email_textBox.TabIndex = 2;
			// 
			// senha_textBox
			// 
			this.senha_textBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.senha_textBox.Location = new System.Drawing.Point(43, 126);
			this.senha_textBox.Name = "senha_textBox";
			this.senha_textBox.PasswordChar = '*';
			this.senha_textBox.Size = new System.Drawing.Size(182, 26);
			this.senha_textBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// LoginAcesso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 237);
			this.Controls.Add(this.senha_textBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.email_textBox);
			this.Controls.Add(this.logar_button);
			this.Controls.Add(this.label1);
			this.Name = "LoginAcesso";
			this.Text = "LoginAcesso";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
