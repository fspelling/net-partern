using NetPaternContinue.App.Visitor;

namespace NetPaternContinue.App.Interpreter
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Interpretar() => Esquerda.Interpretar() + Direita.Interpretar();

        public void AceitarImpressaoVisitor(IImpressoraVisitor visitor) => visitor.ImprimirSubtracao(this);
    }
}
