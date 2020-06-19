using NetPaternContinue.App.Visitor;

namespace NetPaternContinue.App.Interpreter
{
    public interface IExpressao
    {
        int Interpretar();
        void AceitarImpressaoVisitor(IImpressoraVisitor visitor);
    }
}
