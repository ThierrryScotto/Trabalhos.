namespace TesteFile
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.entrada_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verificar_button = new System.Windows.Forms.Button();
            this.saida_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entrada_textBox
            // 
            this.entrada_textBox.Location = new System.Drawing.Point(12, 49);
            this.entrada_textBox.Name = "entrada_textBox";
            this.entrada_textBox.Size = new System.Drawing.Size(146, 20);
            this.entrada_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arquivo ou Diretório";
            // 
            // verificar_button
            // 
            this.verificar_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_button.Location = new System.Drawing.Point(200, 46);
            this.verificar_button.Name = "verificar_button";
            this.verificar_button.Size = new System.Drawing.Size(75, 31);
            this.verificar_button.TabIndex = 3;
            this.verificar_button.Text = "Verificar";
            this.verificar_button.UseVisualStyleBackColor = true;
            this.verificar_button.Click += new System.EventHandler(this.Verificar_button_Click);
            // 
            // saida_textBox
            // 
            this.saida_textBox.Location = new System.Drawing.Point(1, 106);
            this.saida_textBox.Multiline = true;
            this.saida_textBox.Name = "saida_textBox";
            this.saida_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.saida_textBox.Size = new System.Drawing.Size(379, 179);
            this.saida_textBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 286);
            this.Controls.Add(this.saida_textBox);
            this.Controls.Add(this.verificar_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrada_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox entrada_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button verificar_button;
        private System.Windows.Forms.TextBox saida_textBox;
    }
}

