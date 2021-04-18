namespace banco
{
    class Contapoupanca : Conta, ITributacao
    {
        public Contapoupanca()
        {
            Setnn();
            tributavel = true;
            Taxa = 1;
            TipoDeConta = "Poupança";
        }

        

        public double CalcularTributo()
        {
            return this.Saldo* 0.03;
        }

        
    }
}
