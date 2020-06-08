using NetPatern.App.Fiscal;
using NetPatern.App.Imposto;
using NetPatern.App.Strategy;
using NetPatern.App.Strategy.Imposto;
using NetPatern.App.Strategy.Investimento;
using System;

namespace NetPatern.App
{
    public class Program
    {
        public static void Main(string[] args) => ObserverTest();

        private static void StrategyImpostoTest()
        {
            var orcamento = new Orcamento(10);
            var calculador = new CalculadorImposto();

            Console.WriteLine("Calculando imposto icms...");
            calculador.CalcularImposto(orcamento, new Icms());

            Console.WriteLine("Calculando imposto iss...");
            calculador.CalcularImposto(orcamento, new Iss());

            Console.WriteLine("Calculando imposto iccc...");
            calculador.CalcularImposto(orcamento, new Iccc());

            Console.ReadLine();
        }

        private static void StrategyInvestimentoTest()
        {
            var investimento = new InvestimentoBancario(10);
            var calculador = new CalculadorInvestimento();

            Console.WriteLine("Calculando investimento moderado...");
            calculador.CalcularInvestimento(investimento, new Moderado());

            Console.WriteLine("Calculando investimento conservador...");
            calculador.CalcularInvestimento(investimento, new Conservador());

            Console.WriteLine("Calculando investimento arrojado...");
            calculador.CalcularInvestimento(investimento, new Arrojado());

            Console.ReadLine();
        }

        private static void ChainResponsabilityDescontoTest()
        {
            var orcamento = new Orcamento(10);
            orcamento.Adicionar(new Item("Test 1", 10));
            orcamento.Adicionar(new Item("Test 2", 10));

            var calculador = new CalculadorDesconto();

            Console.WriteLine("Calculando descontos...");
            var desconto = calculador.Calcular(orcamento);

            Console.WriteLine($"desconto = {desconto}");
            Console.ReadLine();
        }

        private static void TemplateMethodImpostoTest()
        {
            var orcamento = new Orcamento(10);
            var calculador = new CalculadorImposto();

            Console.WriteLine("Calculando imposto icpp...");
            calculador.CalcularImposto(orcamento, new Icpp());

            Console.WriteLine("Calculando imposto iksv...");
            calculador.CalcularImposto(orcamento, new Iksv());

            Console.ReadLine();
        }

        private static void DecoratorImpostoTest()
        {
            var orcamento = new Orcamento(10);
            var calculador = new CalculadorImposto();

            Console.WriteLine("Calculando imposto icms com iss...");
            calculador.CalcularImposto(orcamento, new Icms(new Iss()));

            Console.ReadLine();
        }

        private static void DecoratorImpostoNovoTest()
        {
            var orcamento = new Extras.Decorator.Orcamento(10);
            var calculador = new Extras.Decorator.CalculadorImposto();

            Console.WriteLine("Calculando imposto icms com imposto alto...");
            calculador.CalcularImposto(orcamento, new Extras.Decorator.ImpostoAlto(new Extras.Decorator.Icms()));

            Console.ReadLine();
        }

        private static void DecoratorFiltroTest()
        {
            var orcamento = new Extras.Decorator.Orcamento(10);
            var calculador = new Extras.Decorator.CalculadorImposto();

            Console.WriteLine("Calculando imposto icms com imposto alto...");
            calculador.CalcularImposto(orcamento, new Extras.Decorator.ImpostoAlto(new Extras.Decorator.Icms()));

            Console.ReadLine();
        }

        private static void StateTest()
        {
            var orcamento = new Orcamento(20);
            orcamento.AplicarDescontoExtra();
            Console.WriteLine($"Calculando desconto extra em aprovacao... {orcamento.Valor}");

            orcamento.Aprovar();
            orcamento.AplicarDescontoExtra();
            Console.WriteLine($"Calculando desconto extra aprovado... {orcamento.Valor}");
        }

        private static void BuilderTest()
        {
            var notafiscal = new NotaFiscalBuilder()
                                    .FromCnpj("12341234")
                                    .FromRazaoSocial("Test")
                                    .FromObservacao("Test")
                                    .Add(new ItemNota("test 1", 10)).Add(new ItemNota("test 2", 10))
                                    .Build();

            Console.WriteLine($"nota fiscal cnpj... {notafiscal.Cnpj}");
        }

        private static void ObserverTest() =>
            new NotaFiscalBuilder(new EnvioEmail(), new EnvioSms(), new NotaFiscalRepository(), new ImpressaoNota(4))
                                   .FromCnpj("12341234")
                                   .FromRazaoSocial("Test")
                                   .FromObservacao("Test")
                                   .Add(new ItemNota("test 1", 10)).Add(new ItemNota("test 2", 10))
                                   .Build();
    }
}
