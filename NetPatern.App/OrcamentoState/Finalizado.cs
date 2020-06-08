using NetPatern.App.Strategy;
using System;

namespace NetPatern.App.OrcamentoState
{
    public class Finalizado : IOrcamentoState
    {
        public void AplicarDescontoExtra(Orcamento orcamento) => 
            throw new Exception($"O Estado {nameof(Finalizado)} não recebem desconto extra");

        public void ChangeAprovado(Orcamento orcamento) => throw new Exception("Mudanca para o estado aprovado nao permitido");

        public void ChangeFinalizado(Orcamento orcamento) => throw new Exception("O estado ja esta em finalizado");

        public void ChangeReprovado(Orcamento orcamento) => throw new Exception("Mudanca para o estado reprovado nao permitido");
    }
}
