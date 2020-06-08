using NetPatern.App.Strategy;
using System;

namespace NetPatern.App.OrcamentoState
{
    public class EmAprovacao : IOrcamentoState
    {
        public bool DescontoAplicado { get; set; }

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (DescontoAplicado) throw new Exception("Desconto ja aplicado");

            orcamento.Valor -= orcamento.Valor * 0.5;
            DescontoAplicado = true;
        }

        public void ChangeAprovado(Orcamento orcamento) => orcamento.State = new Aprovado();

        public void ChangeFinalizado(Orcamento orcamento) => throw new Exception("Mudanca para o estado finalizado nao permitido");

        public void ChangeReprovado(Orcamento orcamento) => orcamento.State = new Reprovado();
    }
}
