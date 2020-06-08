using System.Collections.Generic;

namespace NetPatern.Extras.TemplateMethod
{
    public abstract class TemplateRelatorio
    {
        public void Imprimir(List<ContaBancaria> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }

        public abstract void Cabecalho();
        public abstract void Corpo(List<ContaBancaria> contas);
        public abstract void Rodape();
    }
}
