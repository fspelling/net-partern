using System;

namespace NetPaternContinue.App.Command
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public Status Status { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
            Status = Status.Novo;
        }

        public void Pagar() => Status = Status.Pago;

        public void Finalizar()
        {
            Status = Status.Entregue;
            DataFinalizacao = DateTime.UtcNow;
        }
    }

    public enum Status
    {
        Novo,
        Processado,
        Pago,
        ItemSeparado,
        Entregue
    }
}
