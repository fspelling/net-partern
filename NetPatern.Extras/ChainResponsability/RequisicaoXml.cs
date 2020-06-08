namespace NetPatern.Extras.ChainResponsability
{
    public class RequisicaoXml : IRequisicao
    {
        public IRequisicao Next { get; set; }

        public RequisicaoXml(IRequisicao next) => Next = next;

        public string Request(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
                return $"<nome>${conta.NomeTitular}</nome><saldo>{conta.Saldo}</saldo>";

            return Next?.Request(req, conta);
        }
    }
}
