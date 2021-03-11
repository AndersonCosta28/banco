using System;

namespace banco
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo  { get; private set; }
        public Cliente Titular { get; set; }
        public double Taxa = 0;
        public bool validarSaldo(double valorOperacao)
        {
            double resultado = this.Saldo - (valorOperacao + (this.Taxa * this.Saldo));
            bool verificador = (resultado >= 0);// || (resultado > 0) ;
            if (verificador)
            {
                System.Windows.Forms.MessageBox.Show("Valor de resultado: " + resultado);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Valor de resultado: " + resultado);
                return false;                
            }
        }
        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Sacar(double valorOperacao)
        {
            this.Saldo -= (valorOperacao + (Saldo*Taxa));
        }
    }
}