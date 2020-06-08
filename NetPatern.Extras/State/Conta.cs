namespace NetPatern.Extras.State
{
    public class Conta
    {
        public double Saldo { get; set; }
        public IContaState Status { get; set; }

        public Conta() => Status = new ContaPositivo();

        public void Depositar(double valor) => Status.Depositar(this, valor);

        public void Sacar(double valor) => Status.Sacar(this, valor);
    }
}
