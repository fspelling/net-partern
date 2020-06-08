using System.Collections.Generic;

namespace NetPatern.Extras.Decorator
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void Adicionar(Item item) => Itens.Add(item);
    }
}
