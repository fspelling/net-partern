using NetPaternContinue.App.Visitor;

namespace NetPaternContinue.App.Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; set; }

        public Numero(int valor) => Valor = valor;

        public int Interpretar() => Valor;

        public void AceitarImpressaoVisitor(IImpressoraVisitor visitor) => visitor.ImprimirNumero(this);
    }
}
