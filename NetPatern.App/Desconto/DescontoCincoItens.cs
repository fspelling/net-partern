﻿using NetPatern.App.Strategy;

namespace NetPatern.App.Desconto
{
    public class DescontoCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5)
                return orcamento.Valor * 0.1;

            return Proximo.Descontar(orcamento);
        }
    }
}
