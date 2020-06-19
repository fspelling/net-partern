using System;

namespace NetPaternContinue.App.Bridges
{
    public class EnviadorSms : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por sms");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
