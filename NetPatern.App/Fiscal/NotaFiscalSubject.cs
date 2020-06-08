using System.Collections.Generic;
using System.Linq;

namespace NetPatern.App.Fiscal
{
    public class NotaFiscalSubject
    {
        private readonly IList<INotaFiscalObserver> _observes;

        public NotaFiscalSubject() => _observes = new List<INotaFiscalObserver>();

        public void Subscribe(params INotaFiscalObserver[] observers) =>
            observers.ToList().ForEach(obs => _observes.Add(obs));

        public void Unsubscribe(INotaFiscalObserver observer) => _observes.Remove(observer);

        public void Notify(NotaFiscal notaFiscal) => _observes.ToList().ForEach(obs => obs.Execute(notaFiscal));
    }
}
