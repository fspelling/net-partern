using NetPaternContinue.App.Visitor;

namespace NetPaternContinue.App.Interpreter
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Interpretar() => Esquerda.Interpretar() + Direita.Interpretar();

        public void AceitarImpressaoVisitor(IImpressoraVisitor visitor) => visitor.ImprimirSoma(this);
    }
}
