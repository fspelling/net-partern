namespace NetPatern.Extras.ChainResponsability
{
    public interface IRequisicao
    {
        public IRequisicao Next { get; set; }

        string Request(Requisicao req, Conta conta);
    }
}
