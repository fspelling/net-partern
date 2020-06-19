namespace NetPaternContinue.App.Bridges
{
    public class MensagemCliente : IMensagem
    {
        private string _nome;

        public MensagemCliente(string nome) => _nome = nome;

        public IEnviador Enviador { get; set; }

        public void Enviar() => Enviador.Enviar(this);

        public string Formatar() => $"Mensagem cliente para {_nome}";
    }
}
