
namespace banco
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listResultados = new System.Windows.Forms.ListBox();
            this.botaoFiltro = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelSaldo2 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listResultados
            // 
            this.listResultados.FormattingEnabled = true;
            this.listResultados.Location = new System.Drawing.Point(12, 12);
            this.listResultados.Name = "listResultados";
            this.listResultados.Size = new System.Drawing.Size(296, 95);
            this.listResultados.TabIndex = 0;
            this.listResultados.SelectedIndexChanged += new System.EventHandler(this.listResultados_SelectedIndexChanged);
            // 
            // botaoFiltro
            // 
            this.botaoFiltro.Location = new System.Drawing.Point(97, 135);
            this.botaoFiltro.Name = "botaoFiltro";
            this.botaoFiltro.Size = new System.Drawing.Size(130, 23);
            this.botaoFiltro.TabIndex = 1;
            this.botaoFiltro.Text = "Filtro de 0 saldo";
            this.botaoFiltro.UseVisualStyleBackColor = true;
            this.botaoFiltro.Click += new System.EventHandler(this.botaoFiltro_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(40, 179);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(92, 13);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Número da conta:";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(40, 207);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(34, 13);
            this.labelSaldo.TabIndex = 3;
            this.labelSaldo.Text = "Saldo";
            // 
            // labelSaldo2
            // 
            this.labelSaldo2.AutoSize = true;
            this.labelSaldo2.Location = new System.Drawing.Point(157, 207);
            this.labelSaldo2.Name = "labelSaldo2";
            this.labelSaldo2.Size = new System.Drawing.Size(34, 13);
            this.labelSaldo2.TabIndex = 5;
            this.labelSaldo2.Text = "Saldo";
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(157, 179);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(89, 13);
            this.labelNumero2.TabIndex = 4;
            this.labelNumero2.Text = "Número da conta";
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 262);
            this.Controls.Add(this.labelSaldo2);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.botaoFiltro);
            this.Controls.Add(this.listResultados);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResultados;
        private System.Windows.Forms.Button botaoFiltro;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelSaldo2;
        private System.Windows.Forms.Label labelNumero2;
    }
}