namespace NetPaternContinue.App.Memento
{
    public class ContratoMemento
    {
        public Contrato Contrato { get; private set; }

        public ContratoMemento(Contrato contrato) => Contrato = contrato;
    }
}
