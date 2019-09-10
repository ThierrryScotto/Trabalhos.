namespace ArrayListTeste
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
            this.add_button = new System.Windows.Forms.Button();
            this.remover_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.primeiro_button = new System.Windows.Forms.Button();
            this.ultimo_button = new System.Windows.Forms.Button();
            this.buscar_button = new System.Windows.Forms.Button();
            this.verificar_button = new System.Windows.Forms.Button();
            this.vazio_button = new System.Windows.Forms.Button();
            this.Exibir_button = new System.Windows.Forms.Button();
            this.statistica_button = new System.Windows.Forms.Button();
            this.otimizar_button = new System.Windows.Forms.Button();
            this.saida_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entrada_textBox
            // 
            this.entrada_textBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada_textBox.Location = new System.Drawing.Point(60, 25);
            this.entrada_textBox.Name = "entrada_textBox";
            this.entrada_textBox.Size = new System.Drawing.Size(117, 22);
            this.entrada_textBox.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(183, 25);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(80, 26);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Adicionar";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // remover_button
            // 
            this.remover_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remover_button.Location = new System.Drawing.Point(12, 72);
            this.remover_button.Name = "remover_button";
            this.remover_button.Size = new System.Drawing.Size(80, 26);
            this.remover_button.TabIndex = 2;
            this.remover_button.Text = "Remover";
            this.remover_button.UseVisualStyleBackColor = true;
            this.remover_button.Click += new System.EventHandler(this.Remover_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "String";
            // 
            // primeiro_button
            // 
            this.primeiro_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiro_button.Location = new System.Drawing.Point(98, 72);
            this.primeiro_button.Name = "primeiro_button";
            this.primeiro_button.Size = new System.Drawing.Size(80, 26);
            this.primeiro_button.TabIndex = 4;
            this.primeiro_button.Text = "Primeiro";
            this.primeiro_button.UseVisualStyleBackColor = true;
            this.primeiro_button.Click += new System.EventHandler(this.Primeiro_button_Click);
            // 
            // ultimo_button
            // 
            this.ultimo_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimo_button.Location = new System.Drawing.Point(184, 72);
            this.ultimo_button.Name = "ultimo_button";
            this.ultimo_button.Size = new System.Drawing.Size(80, 26);
            this.ultimo_button.TabIndex = 5;
            this.ultimo_button.Text = "Ultimo";
            this.ultimo_button.UseVisualStyleBackColor = true;
            this.ultimo_button.Click += new System.EventHandler(this.Ultimo_button_Click);
            // 
            // buscar_button
            // 
            this.buscar_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_button.Location = new System.Drawing.Point(184, 104);
            this.buscar_button.Name = "buscar_button";
            this.buscar_button.Size = new System.Drawing.Size(80, 26);
            this.buscar_button.TabIndex = 8;
            this.buscar_button.Text = "Buscar";
            this.buscar_button.UseVisualStyleBackColor = true;
            this.buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // verificar_button
            // 
            this.verificar_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificar_button.Location = new System.Drawing.Point(98, 104);
            this.verificar_button.Name = "verificar_button";
            this.verificar_button.Size = new System.Drawing.Size(80, 26);
            this.verificar_button.TabIndex = 7;
            this.verificar_button.Text = "Verificar";
            this.verificar_button.UseVisualStyleBackColor = true;
            this.verificar_button.Click += new System.EventHandler(this.Verificar_button_Click);
            // 
            // vazio_button
            // 
            this.vazio_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vazio_button.Location = new System.Drawing.Point(12, 104);
            this.vazio_button.Name = "vazio_button";
            this.vazio_button.Size = new System.Drawing.Size(80, 26);
            this.vazio_button.TabIndex = 6;
            this.vazio_button.Text = "Vazio?";
            this.vazio_button.UseVisualStyleBackColor = true;
            this.vazio_button.Click += new System.EventHandler(this.Vazio_button_Click);
            // 
            // Exibir_button
            // 
            this.Exibir_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exibir_button.Location = new System.Drawing.Point(184, 136);
            this.Exibir_button.Name = "Exibir_button";
            this.Exibir_button.Size = new System.Drawing.Size(80, 26);
            this.Exibir_button.TabIndex = 11;
            this.Exibir_button.Text = "Exibir";
            this.Exibir_button.UseVisualStyleBackColor = true;
            this.Exibir_button.Click += new System.EventHandler(this.Exibir_button_Click);
            // 
            // statistica_button
            // 
            this.statistica_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistica_button.Location = new System.Drawing.Point(98, 136);
            this.statistica_button.Name = "statistica_button";
            this.statistica_button.Size = new System.Drawing.Size(80, 26);
            this.statistica_button.TabIndex = 10;
            this.statistica_button.Text = "Statistica";
            this.statistica_button.UseVisualStyleBackColor = true;
            this.statistica_button.Click += new System.EventHandler(this.Statistica_button_Click);
            // 
            // otimizar_button
            // 
            this.otimizar_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otimizar_button.Location = new System.Drawing.Point(12, 136);
            this.otimizar_button.Name = "otimizar_button";
            this.otimizar_button.Size = new System.Drawing.Size(80, 26);
            this.otimizar_button.TabIndex = 9;
            this.otimizar_button.Text = "Otimizar";
            this.otimizar_button.UseVisualStyleBackColor = true;
            this.otimizar_button.Click += new System.EventHandler(this.Otimizar_button_Click);
            // 
            // saida_textBox
            // 
            this.saida_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.saida_textBox.Enabled = false;
            this.saida_textBox.Location = new System.Drawing.Point(12, 169);
            this.saida_textBox.Multiline = true;
            this.saida_textBox.Name = "saida_textBox";
            this.saida_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.saida_textBox.Size = new System.Drawing.Size(251, 89);
            this.saida_textBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.add_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 269);
            this.Controls.Add(this.saida_textBox);
            this.Controls.Add(this.Exibir_button);
            this.Controls.Add(this.statistica_button);
            this.Controls.Add(this.otimizar_button);
            this.Controls.Add(this.buscar_button);
            this.Controls.Add(this.verificar_button);
            this.Controls.Add(this.vazio_button);
            this.Controls.Add(this.ultimo_button);
            this.Controls.Add(this.primeiro_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remover_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.entrada_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entrada_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remover_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button primeiro_button;
        private System.Windows.Forms.Button ultimo_button;
        private System.Windows.Forms.Button buscar_button;
        private System.Windows.Forms.Button verificar_button;
        private System.Windows.Forms.Button vazio_button;
        private System.Windows.Forms.Button Exibir_button;
        private System.Windows.Forms.Button statistica_button;
        private System.Windows.Forms.Button otimizar_button;
        private System.Windows.Forms.TextBox saida_textBox;
    }
}

