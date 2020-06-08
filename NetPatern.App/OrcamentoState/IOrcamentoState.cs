using NetPatern.App.Strategy;

namespace NetPatern.App.OrcamentoState
{
    public interface IOrcamentoState
    {
        void AplicarDescontoExtra(Orcamento orcamento);
        void ChangeAprovado(Orcamento orcamento);
        void ChangeReprovado(Orcamento orcamento);
        void ChangeFinalizado(Orcamento orcamento);
    }
}
