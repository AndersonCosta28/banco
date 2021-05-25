
namespace banco
{
    partial class form1
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
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Titular = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorOperacao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTipoDeConta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PagarTributos = new System.Windows.Forms.Button();
            this.botaotransferencia = new System.Windows.Forms.Button();
            this.comboContas2 = new System.Windows.Forms.ComboBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NovaConta = new System.Windows.Forms.Button();
            this.textBuscaNumero = new System.Windows.Forms.TextBox();
            this.BotaoBuscarConta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoRelatorio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(100, 29);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 0;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(100, 55);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 1;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(100, 81);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 2;
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(129, 28);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sacar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // Titular
            // 
            this.Titular.AutoSize = true;
            this.Titular.Location = new System.Drawing.Point(59, 32);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(36, 13);
            this.Titular.TabIndex = 6;
            this.Titular.Text = "Titular";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(50, 58);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 7;
            this.Numero.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Saldo";
            // 
            // ValorOperacao
            // 
            this.ValorOperacao.AutoSize = true;
            this.ValorOperacao.Location = new System.Drawing.Point(18, 31);
            this.ValorOperacao.Name = "ValorOperacao";
            this.ValorOperacao.Size = new System.Drawing.Size(105, 13);
            this.ValorOperacao.TabIndex = 9;
            this.ValorOperacao.Text = "Valor para Operação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textTipoDeConta);
            this.groupBox1.Controls.Add(this.textSaldo);
            this.groupBox1.Controls.Add(this.textTitular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.Numero);
            this.groupBox1.Controls.Add(this.Titular);
            this.groupBox1.Location = new System.Drawing.Point(55, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de Conta";
            // 
            // textTipoDeConta
            // 
            this.textTipoDeConta.Location = new System.Drawing.Point(100, 107);
            this.textTipoDeConta.Name = "textTipoDeConta";
            this.textTipoDeConta.Size = new System.Drawing.Size(100, 20);
            this.textTipoDeConta.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PagarTributos);
            this.groupBox2.Controls.Add(this.botaotransferencia);
            this.groupBox2.Controls.Add(this.comboContas2);
            this.groupBox2.Controls.Add(this.textValor);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ValorOperacao);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(55, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 181);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // PagarTributos
            // 
            this.PagarTributos.Location = new System.Drawing.Point(23, 146);
            this.PagarTributos.Name = "PagarTributos";
            this.PagarTributos.Size = new System.Drawing.Size(206, 23);
            this.PagarTributos.TabIndex = 15;
            this.PagarTributos.Text = "Pagar tributos anuais";
            this.PagarTributos.UseVisualStyleBackColor = true;
            this.PagarTributos.Click += new System.EventHandler(this.PagarTributos_Click_1);
            // 
            // botaotransferencia
            // 
            this.botaotransferencia.Location = new System.Drawing.Point(143, 101);
            this.botaotransferencia.Name = "botaotransferencia";
            this.botaotransferencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botaotransferencia.Size = new System.Drawing.Size(75, 23);
            this.botaotransferencia.TabIndex = 14;
            this.botaotransferencia.Text = "Transferir";
            this.botaotransferencia.UseVisualStyleBackColor = true;
            this.botaotransferencia.Click += new System.EventHandler(this.botaotransferencia_Click);
            // 
            // comboContas2
            // 
            this.comboContas2.FormattingEnabled = true;
            this.comboContas2.Location = new System.Drawing.Point(6, 100);
            this.comboContas2.Name = "comboContas2";
            this.comboContas2.Size = new System.Drawing.Size(121, 21);
            this.comboContas2.TabIndex = 13;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(101, 25);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 12;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pesquisar conta";
            // 
            // NovaConta
            // 
            this.NovaConta.Location = new System.Drawing.Point(256, 23);
            this.NovaConta.Name = "NovaConta";
            this.NovaConta.Size = new System.Drawing.Size(75, 23);
            this.NovaConta.TabIndex = 14;
            this.NovaConta.Text = "Nova Conta";
            this.NovaConta.UseVisualStyleBackColor = true;
            this.NovaConta.Click += new System.EventHandler(this.NovaConta_Click);
            // 
            // textBuscaNumero
            // 
            this.textBuscaNumero.Location = new System.Drawing.Point(101, 52);
            this.textBuscaNumero.Name = "textBuscaNumero";
            this.textBuscaNumero.Size = new System.Drawing.Size(121, 20);
            this.textBuscaNumero.TabIndex = 15;
            // 
            // BotaoBuscarConta
            // 
            this.BotaoBuscarConta.Location = new System.Drawing.Point(256, 52);
            this.BotaoBuscarConta.Name = "BotaoBuscarConta";
            this.BotaoBuscarConta.Size = new System.Drawing.Size(75, 23);
            this.BotaoBuscarConta.TabIndex = 16;
            this.BotaoBuscarConta.Text = "Buscar";
            this.BotaoBuscarConta.UseVisualStyleBackColor = true;
            this.BotaoBuscarConta.Click += new System.EventHandler(this.BotaoBuscarConta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nº de conta";
            // 
            // botaoRelatorio
            // 
            this.botaoRelatorio.Location = new System.Drawing.Point(131, 462);
            this.botaoRelatorio.Name = "botaoRelatorio";
            this.botaoRelatorio.Size = new System.Drawing.Size(75, 23);
            this.botaoRelatorio.TabIndex = 18;
            this.botaoRelatorio.Text = "Relatório";
            this.botaoRelatorio.UseVisualStyleBackColor = true;
            this.botaoRelatorio.Click += new System.EventHandler(this.botaoRelatorio_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 481);
            this.Controls.Add(this.botaoRelatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotaoBuscarConta);
            this.Controls.Add(this.textBuscaNumero);
            this.Controls.Add(this.NovaConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Titular;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValorOperacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button botaotransferencia;
        private System.Windows.Forms.ComboBox comboContas2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NovaConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTipoDeConta;
        private System.Windows.Forms.Button PagarTributos;
        private System.Windows.Forms.TextBox textBuscaNumero;
        private System.Windows.Forms.Button BotaoBuscarConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoRelatorio;
    }
}

