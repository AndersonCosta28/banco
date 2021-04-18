using System;

namespace banco
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public static int nn { get; private set; } //calcular números de contas com STATIC
        protected double Taxa = 0;
        protected bool tributavel; //Forma que costumo usar para ter controle para usar o interface ITributavel, estou usando nos construtores das classes filhas
        public bool tri { get; private set; }  //Forma opcional, não estou usando, mas existe uma função para habilita-las nas classes filhas no fim do código dessa classe
        public string TipoDeConta;
        public bool validarSaldo(double valorCalculado)
        {            
            double resultado = this.Saldo - valorCalculado;            
            bool verificador = (resultado >= 0);
            if (verificador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Sacar(double valorOperacao)
        {
            if(valorOperacao == null)
            {
                throw new CampoVazioException();
            }
            if(validarSaldo(valorOperacao + getTaxa()) == false)
            {
                throw new SaldoInsuficienteExpection();
            }
            if(valorOperacao < 0)
            {
                throw new ValorNegativoExpection();
            }

            this.Saldo -= (valorOperacao +Taxa);
        }

        public double getTaxa()
        {
            return Taxa;
        }

        public bool getTributavel()
        {
            return tributavel;
        }
        public int Setnn() => nn++;
        protected bool setTri() => tri = true;
    }
}
