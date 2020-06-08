using NetPatern.App.OrcamentoState;
using System.Collections.Generic;

namespace NetPatern.App.Strategy
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public List<Item> Itens { get; set; }
        public IOrcamentoState State { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            State = new EmAprovacao();
        }

        public void Adicionar(Item item) => Itens.Add(item);

        public void AplicarDescontoExtra() => State.AplicarDescontoExtra(this);

        #region mudanca_estado

        public void Aprovar() => State.ChangeAprovado(this);

        public void Reprovar() => State.ChangeReprovado(this);

        public void Finalizar() => State.ChangeFinalizado(this);

        #endregion
    }
}
