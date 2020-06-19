using NetPaternContinue.App.Interpreter;

namespace NetPaternContinue.App.Visitor
{
    public interface IImpressoraVisitor
    {
        void ImprimirSoma(Soma soma);
        void ImprimirSubtracao(Subtracao subtracao);
        void ImprimirNumero(Numero numero);
    }
}
