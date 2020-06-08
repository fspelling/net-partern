namespace NetPatern.App.Fiscal
{
    public class ItemNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
