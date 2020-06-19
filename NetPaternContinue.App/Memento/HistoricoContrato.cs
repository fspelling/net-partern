using System.Collections.Generic;

namespace NetPaternContinue.App.Memento
{
    public class HistoricoContrato
    {
        private IList<ContratoMemento> _mementos = new List<ContratoMemento>();

        public ContratoMemento GetLast()
        {
            var contratoMemento = _mementos[_mementos.Count - 1];
            _mementos.Remove(contratoMemento);

            return contratoMemento;
        }

        public void CreateMemento(ContratoMemento contratoMemento) => _mementos.Add(contratoMemento);
    }
}
