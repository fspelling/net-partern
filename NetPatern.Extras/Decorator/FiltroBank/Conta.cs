using System;

namespace NetPatern.Extras.Decorator.FiltroBank
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string NomeTitular { get; private set; }
        public DateTime Abertura { get; private set; }

        public Conta(double saldo, string nomeTitular, DateTime abertura)
        {
            Saldo = saldo;
            NomeTitular = nomeTitular;
            Abertura = abertura;
        }
    }
}
