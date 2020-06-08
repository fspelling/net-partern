using System;

namespace NetPatern.App.Strategy.Investimento
{
    public class Moderado : IInvestimento
    {
        public double Investir(InvestimentoBancario investimento)
        {
            double investimentoCalc;

            if (new Random().Next(101) <= 50)
                investimentoCalc = investimento.Valor * 0.025;
            else
                investimentoCalc = investimento.Valor * 0.07;

            return investimentoCalc;
        }
    }
}
