using System;

namespace NetPatern.App.Fiscal
{
    public class ImpressaoNota : INotaFiscalObserver
    {
        private readonly int _fator;

        public ImpressaoNota(int fator) => _fator = fator;

        public void Execute(NotaFiscal notaFiscal) => Console.WriteLine($"Imprimindo valor fator {notaFiscal.ValorBruto * _fator}");
    }
}
