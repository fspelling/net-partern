using NetPatern.App.Strategy.Investimento;
using System;

namespace NetPatern.App.Strategy
{
    public class CalculadorInvestimento
    {
        public void CalcularInvestimento(InvestimentoBancario investimentoBank, IInvestimento investimento)
        {
            var resultInvestimento = investimento.Investir(investimentoBank);
            var conta = new ContaBancaria();

            conta.Depositar(resultInvestimento * 0.75);
            Console.WriteLine(resultInvestimento);
        }
    }
}
