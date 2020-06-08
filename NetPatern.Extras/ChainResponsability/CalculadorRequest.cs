namespace NetPatern.Extras.ChainResponsability
{
    public class CalculadorRequest
    {
        public string CalcularRequest(Requisicao req, Conta conta)
        {
            var requestCsv = new RequisicaoCsv(new RequisicaoXml(new RequisicaoPorcento(null)));
            return requestCsv.Request(req, conta);
        }
    }
}
