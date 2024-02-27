namespace agenda_telefonica
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
            this.listView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.BTN_REMOVER = new System.Windows.Forms.Button();
            this.TXT_TELEFONE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_SALVAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(11, 197);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(399, 241);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME ou ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "AGENDA_TELEFONICA";
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Location = new System.Drawing.Point(77, 123);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(247, 20);
            this.TXT_NOME.TabIndex = 4;
            // 
            // BTN_REMOVER
            // 
            this.BTN_REMOVER.Location = new System.Drawing.Point(335, 149);
            this.BTN_REMOVER.Name = "BTN_REMOVER";
            this.BTN_REMOVER.Size = new System.Drawing.Size(75, 27);
            this.BTN_REMOVER.TabIndex = 5;
            this.BTN_REMOVER.Text = "REMOVER";
            this.BTN_REMOVER.UseVisualStyleBackColor = true;
            this.BTN_REMOVER.Click += new System.EventHandler(this.BTN_REMOVER_Click);
            // 
            // TXT_TELEFONE
            // 
            this.TXT_TELEFONE.Location = new System.Drawing.Point(77, 149);
            this.TXT_TELEFONE.Name = "TXT_TELEFONE";
            this.TXT_TELEFONE.Size = new System.Drawing.Size(247, 20);
            this.TXT_TELEFONE.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TELEFONE";
            // 
            // BTN_SALVAR
            // 
            this.BTN_SALVAR.Location = new System.Drawing.Point(335, 119);
            this.BTN_SALVAR.Name = "BTN_SALVAR";
            this.BTN_SALVAR.Size = new System.Drawing.Size(75, 27);
            this.BTN_SALVAR.TabIndex = 8;
            this.BTN_SALVAR.Text = "CADASTAR";
            this.BTN_SALVAR.UseVisualStyleBackColor = true;
            this.BTN_SALVAR.Click += new System.EventHandler(this.BTN_SALVAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.BTN_SALVAR);
            this.Controls.Add(this.TXT_TELEFONE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_REMOVER);
            this.Controls.Add(this.TXT_NOME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AGENDINHA_EHEH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.Button BTN_REMOVER;
        private System.Windows.Forms.TextBox TXT_TELEFONE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_SALVAR;
    }
}

