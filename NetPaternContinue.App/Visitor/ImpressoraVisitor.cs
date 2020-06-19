using NetPaternContinue.App.Interpreter;
using System;

namespace NetPaternContinue.App.Visitor
{
    public class ImpressoraVisitor : IImpressoraVisitor
    {
        public void ImprimirSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.AceitarImpressaoVisitor(this);
            Console.Write("+");
            soma.Direita.AceitarImpressaoVisitor(this);
            Console.Write(")");
        }

        public void ImprimirSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.AceitarImpressaoVisitor(this);
            Console.Write("-");
            subtracao.Direita.AceitarImpressaoVisitor(this);
            Console.Write(")");
        }

        public void ImprimirNumero(Numero numero) => Console.Write(numero.Valor);
    }
}
