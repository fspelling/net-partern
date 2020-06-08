using System.Collections.Generic;

namespace NetPatern.Extras.Decorator.FiltroBank
{
    public abstract class Filtro
    {
        protected Filtro _filtro;

        public Filtro() => _filtro = null;
        public Filtro(Filtro filtro) => _filtro = filtro;

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> FiltraFiltro(IList<Conta> contas)
        {
            if (_filtro != null)
                return _filtro.Filtra(contas);

            return new List<Conta>();
        }
    }
}
