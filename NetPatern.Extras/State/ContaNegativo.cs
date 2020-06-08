using System;

namespace NetPatern.Extras.State
{
    public class ContaNegativo : IContaState
    {
        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            conta.Status = conta.Saldo >= 0 ? new ContaPositivo() : conta.Status;
        }

        public void Sacar(Conta conta, double valor)
        {
            if (conta.Saldo < 0)
                throw new Exception("Nao eh possivel realizar saque com saldo negativo");
        }
    }
}
