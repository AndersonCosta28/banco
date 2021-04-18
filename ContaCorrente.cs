namespace banco
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            Setnn();
            tributavel = false;
            TipoDeConta = "Corrente";
        }
    }
}