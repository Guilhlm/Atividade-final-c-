namespace previsao_tempo
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
            this.cbxCdds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxima = new System.Windows.Forms.Label();
            this.minima = new System.Windows.Forms.Label();
            this.sensacao = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.Label();
            this.cidadeNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCdds
            // 
            this.cbxCdds.FormattingEnabled = true;
            this.cbxCdds.Location = new System.Drawing.Point(12, 417);
            this.cbxCdds.Name = "cbxCdds";
            this.cbxCdds.Size = new System.Drawing.Size(121, 21);
            this.cbxCdds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "selecione algo ae";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "sensaçao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "max";
            // 
            // maxima
            // 
            this.maxima.AutoSize = true;
            this.maxima.Location = new System.Drawing.Point(77, 243);
            this.maxima.Name = "maxima";
            this.maxima.Size = new System.Drawing.Size(13, 13);
            this.maxima.TabIndex = 11;
            this.maxima.Text = "0";
            // 
            // minima
            // 
            this.minima.AutoSize = true;
            this.minima.Location = new System.Drawing.Point(77, 219);
            this.minima.Name = "minima";
            this.minima.Size = new System.Drawing.Size(13, 13);
            this.minima.TabIndex = 10;
            this.minima.Text = "0";
            // 
            // sensacao
            // 
            this.sensacao.AutoSize = true;
            this.sensacao.Location = new System.Drawing.Point(77, 196);
            this.sensacao.Name = "sensacao";
            this.sensacao.Size = new System.Drawing.Size(13, 13);
            this.sensacao.TabIndex = 9;
            this.sensacao.Text = "0";
            // 
            // temperatura
            // 
            this.temperatura.AutoSize = true;
            this.temperatura.Location = new System.Drawing.Point(77, 172);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(13, 13);
            this.temperatura.TabIndex = 8;
            this.temperatura.Text = "0";
            // 
            // cidadeNome
            // 
            this.cidadeNome.AutoSize = true;
            this.cidadeNome.Location = new System.Drawing.Point(77, 144);
            this.cidadeNome.Name = "cidadeNome";
            this.cidadeNome.Size = new System.Drawing.Size(13, 13);
            this.cidadeNome.TabIndex = 7;
            this.cidadeNome.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 474);
            this.Controls.Add(this.maxima);
            this.Controls.Add(this.minima);
            this.Controls.Add(this.sensacao);
            this.Controls.Add(this.temperatura);
            this.Controls.Add(this.cidadeNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCdds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCdds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label maxima;
        private System.Windows.Forms.Label minima;
        private System.Windows.Forms.Label sensacao;
        private System.Windows.Forms.Label temperatura;
        private System.Windows.Forms.Label cidadeNome;
    }
}

