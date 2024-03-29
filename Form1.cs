﻿using System;
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
        private List<Conta> contas;
        public Dictionary<int, Conta> dicionario;
        public int getContas()
        {
            int numeroDeContas = Convert.ToInt32(contas.Count);
            return numeroDeContas;
        }
        //public int numeroDeContas; //Calcular números de conta com a função do FORM
        public void Adiconar(Conta cs)
        {
            //this.c[this.numeroDeContas] = cs;
            //comboContas.Items.Add(numeroDeContas + " - "+ c[numeroDeContas].Titular.Nome);
            //comboContas2.Items.Add(numeroDeContas + " - " + c[numeroDeContas].Titular.Nome);
            //this.numeroDeContas++;
            this.contas.Add(cs);
            comboContas.Items.Add(this.contas.Count + " - " + cs.Titular.Nome);
            comboContas2.Items.Add(this.contas.Count + " - " + cs.Titular.Nome);
            
        }

        public form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();
            this.dicionario = new Dictionary<int, Conta>();
            int i=0;
            c = new Conta[5];            

            c[0] = new ContaCorrente();
            Cliente cliente = new Cliente("Anderson");
            c[0].Titular = cliente;
            c[0].Numero = 1;    
            
            c[1] = new Contapoupanca();
            c[1].Titular = new Cliente("Josenilton");
            c[1].Numero = 2;
            
            c[2] = new Contapoupanca();            
            c[2].Titular = new Cliente("Ana");
            c[2].Numero = 3;
            
            //this.c[] = new Conta();            
            foreach (Conta contas in c)
            {                
                if(contas == null)
                {
                    //numeroDeContas = i;
                }
                else
                {
                    comboContas.Items.Add(i + " - " + contas.Titular.Nome);
                    comboContas2.Items.Add(i + " - " + contas.Titular.Nome);
                    this.contas.Add(contas);
                    this.dicionario.Add(contas.Numero,contas);
                    i++;
                }
                
            }
            //NovaConta.Enabled = false; desativar botão
            var filtrados = from c in this.contas
                            where c.Saldo == 0
                            where c.Titular.Nome.Equals("Anderson")
                            select c;
            foreach(var c in filtrados)
            {
               MessageBox.Show(Convert.ToString(c.Numero + c.Saldo));
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
                textValor.Text = null;
                comboContas2.SelectedIndex = -1;
            }
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {            
            string RecebeValor = textValor.Text;
            int indice = Convert.ToInt32(comboContas.SelectedIndex);            
            double ValorOperacao = Convert.ToDouble(RecebeValor);
            double ValorCalculado = (ValorOperacao + this.c[indice].getTaxa());
            //if (string.IsNullOrEmpty(textValor.Text))
            //{
            //    MessageBox.Show("Insira um valor!");
            //}
            //else
            //{                
            //    if (c[indice].validarSaldo(ValorCalculado)) 
            //    {
            //        this.c[indice].Sacar(ValorOperacao);
            //        MessageBox.Show("Sucesso, verifique seu Saldo atual");
            //        textValor.Text = null;
            //    }
            //    else 
            //    {
            //        MessageBox.Show("Não foi possível executar a operação");
            //    }

            //    textSaldo.Text = Convert.ToString(this.c[indice].Saldo);
            //}
            try
            {               
                    this.c[indice].Sacar(ValorOperacao);
                    c[indice].validarSaldo(ValorCalculado);
                    MessageBox.Show("Sucesso, verifique seu Saldo atual");
                    textValor.Text = null;
                    textSaldo.Text = Convert.ToString(c[indice].Saldo);
            }
            catch (SaldoInsuficienteExpection)
            {
                MessageBox.Show("Não possui saldo para realizar a operação");
            }
            catch (ValorNegativoExpection)
            {
                MessageBox.Show("Valor de operação não pode ser negativo");
            }
            catch
            {
                MessageBox.Show("O Campo de operação não pode estar vazio");
            }
        }

        private void  comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            textTitular.Text = c[indice].Titular.Nome;
            textSaldo.Text = Convert.ToString(c[indice].Saldo);
            textNumero.Text = Convert.ToString(c[indice].Numero);
            textTipoDeConta.Text = c[indice].TipoDeConta;
            comboContas2.SelectedIndex = -1;
            textValor.Text = null;
            PagarTributos.Enabled = c[indice].getTributavel();
        }

        private void botaotransferencia_Click(object sender, EventArgs e)
        {
            string RecebeValor = textValor.Text;
            int destino = comboContas2.SelectedIndex;
            int origem = comboContas.SelectedIndex;
            if (string.IsNullOrEmpty(textValor.Text) && comboContas2 == null)
            {
                MessageBox.Show("Insira um valor!");
            }
            else
            {
                double ValorOperacao = Convert.ToDouble(RecebeValor);
                if (c[origem].validarSaldo(ValorOperacao) && origem != destino)
                {
                    c[origem].Sacar(ValorOperacao);
                    ////////////////////Pegando o valor para transferir//////////////////////
                    c[destino].Deposita(ValorOperacao);
                    MessageBox.Show("Sucesso, verifique seu Saldo atual");
                    comboContas2.SelectedIndex = -1; //Zera o campo da conta destino
                    textSaldo.Text = Convert.ToString(c[origem].Saldo); //mostra o novo saldo
                }
                else
                {
                    MessageBox.Show("Não foi possível executar a operação");
                }
            }
        }

        private void NovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void PagarTributos_Click(object sender, EventArgs e)
        {

        }

        private void PagarTributos_Click_1(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valor;
            ITributacao t = (ITributacao)c[indice];
            valor = t.CalcularTributo();
            MessageBox.Show("O imposto pago por essa conta = " + t.CalcularTributo());
            c[indice].Sacar(valor);
            MessageBox.Show("Sucesso, verifique seu Saldo atual");
            textSaldo.Text = Convert.ToString(c[indice].Saldo);
        }

        private void BotaoBuscarConta_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBuscaNumero.Text);
            
            try 
            { 
            Conta conta = dicionario[numero];
            textNumero.Text = Convert.ToString(conta.Numero);
            textTitular.Text = conta.Titular.Nome;
            textSaldo.Text = Convert.ToString(conta.Saldo);
            textTipoDeConta.Text = conta.TipoDeConta;
            comboContas2.SelectedIndex = -1;
            textValor.Text = null;
            PagarTributos.Enabled = conta.getTributavel();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Numero de conta inválida");
            }
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio(this.contas);
            form.ShowDialog();
        }
    }
}