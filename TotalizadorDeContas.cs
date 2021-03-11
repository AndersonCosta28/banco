namespace banco
{
    public class TotalizadorDeContas
    {
        public TotalizadorDeContas()
        {
        }

        public double ValorTotal { get; private set; }

        public void Somar(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
            
    }
}