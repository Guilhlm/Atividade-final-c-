namespace relogio_digital
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
            this.components = new System.ComponentModel.Container();
            this.LBLHORAS = new System.Windows.Forms.Label();
            this.LBLMINUTOS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLSEGUNDOS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBLHORAS
            // 
            this.LBLHORAS.AutoSize = true;
            this.LBLHORAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHORAS.Location = new System.Drawing.Point(23, 46);
            this.LBLHORAS.Name = "LBLHORAS";
            this.LBLHORAS.Size = new System.Drawing.Size(106, 76);
            this.LBLHORAS.TabIndex = 0;
            this.LBLHORAS.Text = "00";
            // 
            // LBLMINUTOS
            // 
            this.LBLMINUTOS.AutoSize = true;
            this.LBLMINUTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMINUTOS.Location = new System.Drawing.Point(148, 46);
            this.LBLMINUTOS.Name = "LBLMINUTOS";
            this.LBLMINUTOS.Size = new System.Drawing.Size(106, 76);
            this.LBLMINUTOS.TabIndex = 0;
            this.LBLMINUTOS.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 76);
            this.label3.TabIndex = 1;
            this.label3.Text = ":";
            // 
            // LBLSEGUNDOS
            // 
            this.LBLSEGUNDOS.AutoSize = true;
            this.LBLSEGUNDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSEGUNDOS.Location = new System.Drawing.Point(281, 46);
            this.LBLSEGUNDOS.Name = "LBLSEGUNDOS";
            this.LBLSEGUNDOS.Size = new System.Drawing.Size(106, 76);
            this.LBLSEGUNDOS.TabIndex = 0;
            this.LBLSEGUNDOS.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 76);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 162);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBLSEGUNDOS);
            this.Controls.Add(this.LBLMINUTOS);
            this.Controls.Add(this.LBLHORAS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RELOGIN_DOS_CRIAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHORAS;
        private System.Windows.Forms.Label LBLMINUTOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLSEGUNDOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
    }
}

