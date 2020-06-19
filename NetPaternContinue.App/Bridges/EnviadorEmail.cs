using System;

namespace NetPaternContinue.App.Bridges
{
    public class EnviadorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine(mensagem.Formatar());
        }
    }
}
