using NetPatern.App.Strategy;
using System;

namespace NetPatern.App.OrcamentoState
{
    public class Aprovado : IOrcamentoState
    {
        public bool DescontoAplicado { get; set; }

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado) throw new Exception("Desconto ja aplicado");

            orcamento.Valor -= orcamento.Valor * 0.2;
            DescontoAplicado = true;
        }

        public void ChangeAprovado(Orcamento orcamento) => throw new Exception("O estado ja esta em aprovado");

        public void ChangeFinalizado(Orcamento orcamento) => orcamento.State = new Finalizado();

        public void ChangeReprovado(Orcamento orcamento) => throw new Exception("Mudanca para o estado reprovado nao permitido");
    }
}
