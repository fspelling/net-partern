using System;

namespace NetPatern.App.Fiscal
{
    public class EnvioSms : INotaFiscalObserver
    {
        public void Execute(NotaFiscal notaFiscal) => Console.WriteLine("Envio de sms...");
    }
}
