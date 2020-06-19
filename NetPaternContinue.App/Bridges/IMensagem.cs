namespace NetPaternContinue.App.Bridges
{
    public interface IMensagem
    {
        public IEnviador Enviador { get; set; }

        void Enviar();
        string Formatar();
    }
}
