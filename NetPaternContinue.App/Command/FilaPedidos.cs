using System.Collections.Generic;
using System.Linq;

namespace NetPaternContinue.App.Command
{
    public class FilaPedidos
    {
        private IList<ICommand> _fila = new List<ICommand>();

        public void Add(ICommand command) => _fila.Add(command);

        public void Process() => _fila.ToList().ForEach(command => command.Execute());
    }
}
