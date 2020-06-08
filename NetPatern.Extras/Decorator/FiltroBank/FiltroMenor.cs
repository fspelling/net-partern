using System.Collections.Generic;
using System.Linq;

namespace NetPatern.Extras.Decorator.FiltroBank
{
    public class FiltroMenor : Filtro
    {
        public FiltroMenor() : base() { }
        public FiltroMenor(Filtro filtro) : base(filtro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtroResult = contas.Where(c => c.Saldo <= 100).ToList();
            filtroResult.AddRange(FiltraFiltro(contas));

            return filtroResult;
        }
    }
}
