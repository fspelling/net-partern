namespace NetPatern.Extras.State
{
    public interface IContaState
    {
        void Depositar(Conta conta, double valor);
        void Sacar(Conta conta, double valor);
    }
}
