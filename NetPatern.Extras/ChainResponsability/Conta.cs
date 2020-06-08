namespace NetPatern.Extras.ChainResponsability
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string NomeTitular { get; private set; }

        public Conta(double saldo, string nomeTitular)
        {
            Saldo = saldo;
            NomeTitular = nomeTitular;
        }
    }
}
