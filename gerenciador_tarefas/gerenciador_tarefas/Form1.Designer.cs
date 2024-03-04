namespace gerenciador_tarefas
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
            this.TXT_CONTEUDO = new System.Windows.Forms.TextBox();
            this.DTPICKER = new System.Windows.Forms.DateTimePicker();
            this.BNT_SALVAR = new System.Windows.Forms.Button();
            this.BTN_LIMPAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_TITULO = new System.Windows.Forms.TextBox();
            this.DGView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_CONTEUDO
            // 
            this.TXT_CONTEUDO.Location = new System.Drawing.Point(12, 368);
            this.TXT_CONTEUDO.Name = "TXT_CONTEUDO";
            this.TXT_CONTEUDO.Size = new System.Drawing.Size(321, 20);
            this.TXT_CONTEUDO.TabIndex = 0;
            // 
            // DTPICKER
            // 
            this.DTPICKER.Location = new System.Drawing.Point(214, 306);
            this.DTPICKER.Name = "DTPICKER";
            this.DTPICKER.Size = new System.Drawing.Size(223, 20);
            this.DTPICKER.TabIndex = 2;
            // 
            // BNT_SALVAR
            // 
            this.BNT_SALVAR.Location = new System.Drawing.Point(15, 415);
            this.BNT_SALVAR.Name = "BNT_SALVAR";
            this.BNT_SALVAR.Size = new System.Drawing.Size(75, 23);
            this.BNT_SALVAR.TabIndex = 3;
            this.BNT_SALVAR.Text = "ADD";
            this.BNT_SALVAR.UseVisualStyleBackColor = true;
            this.BNT_SALVAR.Click += new System.EventHandler(this.BNT_SALVAR_Click);
            // 
            // BTN_LIMPAR
            // 
            this.BTN_LIMPAR.Location = new System.Drawing.Point(114, 415);
            this.BTN_LIMPAR.Name = "BTN_LIMPAR";
            this.BTN_LIMPAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_LIMPAR.TabIndex = 4;
            this.BTN_LIMPAR.Text = "limpar";
            this.BTN_LIMPAR.UseVisualStyleBackColor = true;
            this.BTN_LIMPAR.Click += new System.EventHandler(this.BTN_LIMPAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "conteudo <3";
            // 
            // TXT_TITULO
            // 
            this.TXT_TITULO.Location = new System.Drawing.Point(12, 306);
            this.TXT_TITULO.Name = "TXT_TITULO";
            this.TXT_TITULO.Size = new System.Drawing.Size(193, 20);
            this.TXT_TITULO.TabIndex = 9;
            // 
            // DGView
            // 
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Location = new System.Drawing.Point(15, 12);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(491, 264);
            this.DGView.TabIndex = 10;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.TXT_TITULO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_LIMPAR);
            this.Controls.Add(this.BNT_SALVAR);
            this.Controls.Add(this.DTPICKER);
            this.Controls.Add(this.TXT_CONTEUDO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_CONTEUDO;
        private System.Windows.Forms.DateTimePicker DTPICKER;
        private System.Windows.Forms.Button BNT_SALVAR;
        private System.Windows.Forms.Button BTN_LIMPAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_TITULO;
        private System.Windows.Forms.DataGridView DGView;
    }
}

