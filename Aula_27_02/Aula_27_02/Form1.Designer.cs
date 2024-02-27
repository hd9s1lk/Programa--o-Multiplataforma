namespace Aula_27_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.Caixa_Valor_1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Caixa_Valor_2 = new System.Windows.Forms.TextBox();
            this.Button_Calcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Caixa_Valor_1
            // 
            this.Caixa_Valor_1.Location = new System.Drawing.Point(151, 66);
            this.Caixa_Valor_1.Name = "Caixa_Valor_1";
            this.Caixa_Valor_1.Size = new System.Drawing.Size(112, 22);
            this.Caixa_Valor_1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // Caixa_Valor_2
            // 
            this.Caixa_Valor_2.Location = new System.Drawing.Point(151, 98);
            this.Caixa_Valor_2.Name = "Caixa_Valor_2";
            this.Caixa_Valor_2.Size = new System.Drawing.Size(112, 22);
            this.Caixa_Valor_2.TabIndex = 3;
            // 
            // Button_Calcula
            // 
            this.Button_Calcula.Location = new System.Drawing.Point(168, 138);
            this.Button_Calcula.Name = "Button_Calcula";
            this.Button_Calcula.Size = new System.Drawing.Size(75, 23);
            this.Button_Calcula.TabIndex = 4;
            this.Button_Calcula.Text = "Mover";
            this.Button_Calcula.UseVisualStyleBackColor = true;
            this.Button_Calcula.Click += new System.EventHandler(this.Button_Calcula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Calcula);
            this.Controls.Add(this.Caixa_Valor_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caixa_Valor_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Caixa_Valor_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Caixa_Valor_2;
        private System.Windows.Forms.Button Button_Calcula;
    }
}

