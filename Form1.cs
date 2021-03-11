using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class form1 : Form
    {
        private Conta[] c;
        private int numeroDeContas;
        public void Adiconar(Conta cs)
        {
            this.c[this.numeroDeContas] = cs;
            comboContas.Items.Add(numeroDeContas + " - "+ c[numeroDeContas].Titular.Nome);
            this.numeroDeContas++; 
        }
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Conta[5];
            
            /*MessageBox.Show("" + numeroDeContas);
            c[0] = new Contapoupanca();
            Cliente cliente = new Cliente("Anderson");
            c[0].Titular = cliente;
            c[0].Numero = 1;

            /*
            //this.c[] = new Conta();
            
            c[1] = new Contapoupanca();
            c[1].Titular = new Cliente("Josenilton");
            c[1].Numero = 2;
            
            this.c[2] = new Contapoupanca();            
            this.c[2].Titular = new Cliente("Ana");
            this.c[2].Numero = 3;
            */



            foreach (Conta contas in c)
            {
                if(contas == null)
                {

                }
                else
                {
                    comboContas.Items.Add(contas.Titular.Nome);
                    comboContas2.Items.Add(contas.Titular.Nome);
                }
            }
            

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string RecebeValor = textValor.Text;
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            if (string.IsNullOrEmpty(textValor.Text))
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                double ValorOperacao = Convert.ToDouble(RecebeValor);
                this.c[indice].Deposita(ValorOperacao);
                textSaldo.Text = Convert.ToString(this.c[indice].Saldo);
                MessageBox.Show("Sucesso");
            }
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {            
            string RecebeValor = textValor.Text ;
            int indice = Convert.ToInt32(comboContas.SelectedIndex);            
            double ValorOperacao = Convert.ToDouble(RecebeValor);
            double ValorCalculado = this.c[indice].Saldo - (ValorOperacao + this.c[indice].Taxa);
            if (string.IsNullOrEmpty(textValor.Text))
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                MessageBox.Show(Convert.ToString(this.c[indice].validarSaldo(ValorOperacao)));
                if (this.c[indice].validarSaldo(ValorOperacao)) 
                {
                    this.c[indice].Sacar(ValorOperacao);
                }
                else if(this.c[indice].validarSaldo(ValorOperacao))
                {
                    MessageBox.Show("Não foi possível executar a operação");
                }

                textSaldo.Text = Convert.ToString(this.c[indice].Saldo);
            }
        }

        private void  comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            textTitular.Text = c[indice].Titular.Nome;
            textSaldo.Text = Convert.ToString(c[indice].Saldo);
            textNumero.Text = Convert.ToString(c[indice].Numero);
        }

        private void botaotransferencia_Click(object sender, EventArgs e)
        {
            string RecebeValor = textValor.Text;
            int destino = comboContas2.SelectedIndex;
            int origem = Convert.ToInt32(comboContas.SelectedIndex);
            if (string.IsNullOrEmpty(textValor.Text) && comboContas2 == null)
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                double ValorOperacao = Convert.ToDouble(RecebeValor);
                this.c[origem].Sacar(ValorOperacao);
                textSaldo.Text = Convert.ToString(this.c[origem].Saldo);
                ////////////////////Pegando o valor para transferir//////////////////////
                this.c[destino].Deposita(ValorOperacao);
                textSaldo.Text = Convert.ToString(this.c[destino].Saldo);
                MessageBox.Show("Sucesso");
            }
        }

        private void NovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}