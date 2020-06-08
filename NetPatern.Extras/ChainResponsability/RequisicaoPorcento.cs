namespace NetPatern.Extras.ChainResponsability
{
    public class RequisicaoPorcento : IRequisicao
    {
        public IRequisicao Next { get; set; }

        public RequisicaoPorcento(IRequisicao next) => Next = next;

        public string Request(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
                return $"{conta.NomeTitular}%{conta.Saldo}";

            return Next?.Request(req, conta);
        }
    }
}