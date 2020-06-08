using System;

namespace NetPatern.App.Fiscal
{
    public class EnvioEmail : INotaFiscalObserver
    {
        public void Execute(NotaFiscal notaFiscal) => Console.WriteLine("Envio de email...");
    }
}
