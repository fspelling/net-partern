using System.Collections.Generic;
using System.Linq;

namespace NetPatern.Extras.Decorator.FiltroBank
{
    public class FiltroMaior : Filtro
    {
        public FiltroMaior() : base() { }
        public FiltroMaior(Filtro filtro) : base(filtro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtroResult = contas.Where(c => c.Saldo >= 500).ToList();
            filtroResult.AddRange(FiltraFiltro(contas));

            return filtroResult;
        }
    }
}
