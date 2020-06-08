namespace NetPatern.Extras.ChainResponsability
{
    public class RequisicaoCsv : IRequisicao
    {
        public IRequisicao Next { get; set; }

        public RequisicaoCsv(IRequisicao next) => Next = next;

        public string Request(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
                return $"{conta.NomeTitular};{conta.Saldo}";

            return Next?.Request(req, conta);
        }
    }
}
