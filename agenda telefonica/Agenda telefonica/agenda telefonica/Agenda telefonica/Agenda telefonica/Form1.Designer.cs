namespace Agenda_telefonica
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
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxtelefone = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.listviewgeral = new System.Windows.Forms.ListView();
            this.buttonpesquisa = new System.Windows.Forms.Button();
            this.buttonadicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(38, 248);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(100, 20);
            this.textBoxnome.TabIndex = 0;
            // 
            // textBoxtelefone
            // 
            this.textBoxtelefone.Location = new System.Drawing.Point(238, 248);
            this.textBoxtelefone.Name = "textBoxtelefone";
            this.textBoxtelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxtelefone.TabIndex = 1;
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(70, 215);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(38, 13);
            this.labelnome.TabIndex = 2;
            this.labelnome.Text = "Nome ";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(235, 215);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(100, 13);
            this.labeltelefone.TabIndex = 3;
            this.labeltelefone.Text = "Numero de telefone";
            // 
            // listviewgeral
            // 
            this.listviewgeral.HideSelection = false;
            this.listviewgeral.Location = new System.Drawing.Point(461, 12);
            this.listviewgeral.Name = "listviewgeral";
            this.listviewgeral.Size = new System.Drawing.Size(315, 426);
            this.listviewgeral.TabIndex = 4;
            this.listviewgeral.UseCompatibleStateImageBehavior = false;
            this.listviewgeral.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // buttonpesquisa
            // 
            this.buttonpesquisa.Location = new System.Drawing.Point(205, 329);
            this.buttonpesquisa.Name = "buttonpesquisa";
            this.buttonpesquisa.Size = new System.Drawing.Size(165, 109);
            this.buttonpesquisa.TabIndex = 5;
            this.buttonpesquisa.Text = "pesquisar";
            this.buttonpesquisa.UseVisualStyleBackColor = true;
            this.buttonpesquisa.Click += new System.EventHandler(this.buttonpesquisa_Click);
            // 
            // buttonadicionar
            // 
            this.buttonadicionar.Location = new System.Drawing.Point(12, 329);
            this.buttonadicionar.Name = "buttonadicionar";
            this.buttonadicionar.Size = new System.Drawing.Size(165, 109);
            this.buttonadicionar.TabIndex = 6;
            this.buttonadicionar.Text = "adicionar contato";
            this.buttonadicionar.UseVisualStyleBackColor = true;
            this.buttonadicionar.Click += new System.EventHandler(this.buttonadicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonadicionar);
            this.Controls.Add(this.buttonpesquisa);
            this.Controls.Add(this.listviewgeral);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.textBoxtelefone);
            this.Controls.Add(this.textBoxnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxtelefone;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.ListView listviewgeral;
        private System.Windows.Forms.Button buttonpesquisa;
        private System.Windows.Forms.Button buttonadicionar;
    }
}

