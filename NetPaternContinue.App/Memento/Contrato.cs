using System;

namespace NetPaternContinue.App.Memento
{
    public class Contrato
    {
        private readonly HistoricoContrato _historicoMemento;

        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            _historicoMemento = new HistoricoContrato();
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avancar()
        {
            if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
        }

        public void SaveMemento() => 
            _historicoMemento.CreateMemento(new ContratoMemento(new Contrato(Data, Cliente, Tipo)));

        public Contrato RollbackMemento() => _historicoMemento.GetLast().Contrato;
    }
}
