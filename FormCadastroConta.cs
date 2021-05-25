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
    public partial class FormCadastroConta : Form
    {
        //Ponte para colocar as informações cadastradas aqui no Form1
        private form1 formPrincipal;
        private List<string> devedores; 

        public FormCadastroConta(form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            this.devedores = new List<string>();
            this.devedores.Add("Clarissa");

        }
        //Fim da ponte

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {            
            //textNumero.Text = Convert.ToString(formPrincipal.numeroDeContas);
            textNumero.Text = Convert.ToString(formPrincipal.getContas());
            comboTipodeConta.Items.Add("Corrente");
            comboTipodeConta.Items.Add("Poupança");
        }

        private void NovaConta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+this.devedores.Count());
            bool devedor = this.devedores.Contains(textTitular.Text);
            if(devedor == false) { 
            if (comboTipodeConta.SelectedIndex == 0)
            {                
                Conta conta = new ContaCorrente();
                conta.Numero = Convert.ToInt32(textNumero.Text);
                conta.Titular = new Cliente(textTitular.Text);
                formPrincipal.Adiconar(conta); //Este método usa a ponte para acessar o Form1
            }
            else if (comboTipodeConta.SelectedIndex == 1)
            {
                Conta conta = new Contapoupanca();
                conta.Numero = Convert.ToInt32(textNumero.Text);
                conta.Titular = new Cliente(textTitular.Text);
                formPrincipal.Adiconar(conta); //Este método usa a ponte para acessar o Form1
            }
            
            MessageBox.Show("Conta criada com sucesso!");
            this.Close();
            }
            else
            {
                MessageBox.Show("É devedor");
            }
        }

        private void comboTipodeConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textNumero.Text = Convert.ToString(formPrincipal.numeroDeContas);
            textNumero.Text = Convert.ToString(formPrincipal.getContas());
        }

        
    }
}
