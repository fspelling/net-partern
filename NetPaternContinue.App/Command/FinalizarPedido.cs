using System;

namespace NetPaternContinue.App.Command
{
    public class FinalizarPedido : ICommand
    {
        private Pedido _pedido;

        public FinalizarPedido(Pedido pedido) => _pedido = pedido;

        public void Execute()
        {
            Console.WriteLine($"Finalizando o pedido para o cliente {_pedido.Cliente}");
            _pedido.Finalizar();
        }
    }
}