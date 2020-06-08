using System;
using System.Collections.Generic;
using System.Linq;

namespace NetPatern.Extras.Decorator.FiltroBank
{
    public class FiltroAbertura : Filtro
    {
        public FiltroAbertura() : base() { }
        public FiltroAbertura(Filtro filtro) : base(filtro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtroResult = contas.Where(c => c.Abertura.Month == DateTime.Now.Month &&
                                                 c.Abertura.Year == DateTime.Now.Year).ToList();

            filtroResult.AddRange(FiltraFiltro(contas));
            return filtroResult;
        }
    }
}
