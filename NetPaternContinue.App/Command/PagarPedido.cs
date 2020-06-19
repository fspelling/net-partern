using System;

namespace NetPaternContinue.App.Command
{
    public class PagarPedido : ICommand
    {
        private Pedido _pedido;

        public PagarPedido(Pedido pedido) => _pedido = pedido;

        public void Execute()
        {
            Console.WriteLine($"Pagando o pedido para o cliente {_pedido.Cliente}");
            _pedido.Pagar();
        }
    }
}