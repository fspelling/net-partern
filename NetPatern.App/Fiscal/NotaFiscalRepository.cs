using System;

namespace NetPatern.App.Fiscal
{
    class NotaFiscalRepository : INotaFiscalObserver
    {
        public void Execute(NotaFiscal notaFiscal) => Console.WriteLine("Envio de db...");
    }
}
