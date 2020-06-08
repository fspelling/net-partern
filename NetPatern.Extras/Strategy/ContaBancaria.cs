namespace NetPatern.App.Strategy
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public void Depositar(double valor) => Saldo += valor;
    }
}
