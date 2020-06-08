namespace NetPatern.Extras.State
{
    public class ContaPositivo : IContaState
    {
        public void Depositar(Conta conta, double valor) => conta.Saldo += valor * 0.95;

        public void Sacar(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            conta.Status = conta.Saldo < 0 ? new ContaNegativo() : conta.Status;
        }
    }
}
