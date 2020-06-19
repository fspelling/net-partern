using NetPaternContinue.App.Interpreter;
using System;

namespace NetPaternContinue.App.Visitor
{
    public class ImpressoraPreVisitor : IImpressoraVisitor
    {
        public void ImprimirNumero(Numero numero) => Console.Write(numero.Valor);

        public void ImprimirSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            soma.Esquerda.AceitarImpressaoVisitor(this);
            Console.Write(" ");
            soma.Direita.AceitarImpressaoVisitor(this);
            Console.Write(")");
        }

        public void ImprimirSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            subtracao.Esquerda.AceitarImpressaoVisitor(this);
            Console.Write(" ");
            subtracao.Direita.AceitarImpressaoVisitor(this);
            Console.Write(")");
        }
    }
}
