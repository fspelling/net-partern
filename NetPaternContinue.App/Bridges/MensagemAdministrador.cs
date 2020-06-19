namespace NetPaternContinue.App.Bridges
{
    public class MensagemAdministrador : IMensagem
    {
        private string _nome;

        public MensagemAdministrador(string nome) => _nome = nome;

        public IEnviador Enviador { get; set; }

        public void Enviar() => Enviador.Enviar(this);

        public string Formatar() => $"Mensagem administrativa para {_nome}";
    }
}
