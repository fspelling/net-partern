using NetPatern.App.Strategy;
using System;

namespace NetPatern.App.OrcamentoState
{
    public class Reprovado : IOrcamentoState
    {
        public void AplicarDescontoExtra(Orcamento orcamento) =>
            throw new Exception($"O Estado {nameof(Reprovado)} não recebem desconto extra");

        public void ChangeAprovado(Orcamento orcamento) => throw new Exception("Mudanca para o estado aprovado nao permitido");

        public void ChangeFinalizado(Orcamento orcamento) => orcamento.State = new Finalizado();

        public void ChangeReprovado(Orcamento orcamento) => throw new Exception("O estado ja esta em reprovado");
    }
}
