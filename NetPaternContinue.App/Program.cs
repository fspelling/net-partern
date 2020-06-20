using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NetPaternContinue.App.Adapter;
using NetPaternContinue.App.Bridges;
using NetPaternContinue.App.Command;
using NetPaternContinue.App.Composite;
using NetPaternContinue.App.Facade_Singleton;
using NetPaternContinue.App.Factory;
using NetPaternContinue.App.Flyweight;
using NetPaternContinue.App.Interpreter;
using NetPaternContinue.App.Memento;
using NetPaternContinue.App.Visitor;

namespace NetPaternContinue.App
{
    public class Program
    {
        public static void Main(string[] args) => CompositeTest();

        private static void FactoryTest()
        {
            var con = new ConnectionFactory().GetConnection();
            Console.WriteLine("conexao criada...");
        }

        private static void FlyweightTest()
        {
            var notasFlyweight = new NotaMusicalFlyweight();
            var musica = new List<INota>
            {
                notasFlyweight.GetNota("do"),
                notasFlyweight.GetNota("re"),
                notasFlyweight.GetNota("mi"),
                notasFlyweight.GetNota("fa"),
                notasFlyweight.GetNota("fa"),
                notasFlyweight.GetNota("fa"),

                notasFlyweight.GetNota("do"),
                notasFlyweight.GetNota("re"),
                notasFlyweight.GetNota("do"),
                notasFlyweight.GetNota("re"),
                notasFlyweight.GetNota("re"),
                notasFlyweight.GetNota("re"),

                notasFlyweight.GetNota("do"),
                notasFlyweight.GetNota("sol"),
                notasFlyweight.GetNota("fa"),
                notasFlyweight.GetNota("mi"),
                notasFlyweight.GetNota("mi"),
                notasFlyweight.GetNota("mi"),

                notasFlyweight.GetNota("do"),
                notasFlyweight.GetNota("re"),
                notasFlyweight.GetNota("mi"),
                notasFlyweight.GetNota("fa"),
                notasFlyweight.GetNota("fa"),
                notasFlyweight.GetNota("fa")
            };

            Piano.Tocar(musica);
        }

        private static void MementoTest()
        {
            var contrato = new Contrato(DateTime.UtcNow, "test 1", TipoContrato.Novo);

            contrato.SaveMemento();
            Console.WriteLine($"Estado atual do contrato: {contrato.Tipo}");

            contrato.Avancar();
            contrato.SaveMemento();
            Console.WriteLine($"Estado atual do contrato: {contrato.Tipo}");

            contrato.Avancar();
            Console.WriteLine($"Estado atual do contrato: {contrato.Tipo}");

            var contratoRollback = contrato.RollbackMemento();
            contrato = contratoRollback;
            Console.WriteLine($"Estado atual do contrato apos rollback: {contrato.Tipo}");
        }

        private static void InterpreterTest()
        {
            var soma = new Soma(new Numero(10), new Numero(10));
            var subtracao = new Subtracao(new Numero(10), new Numero(10));
            var result = new Soma(soma, subtracao);

            Console.WriteLine(result.Interpretar());
        }

        private static void InterpreterExpressionTest()
        {
            var soma = Expression.Add(Expression.Constant(10), Expression.Constant(10));
            var interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            Console.WriteLine(interpreter());
        }

        private static void VisitorTest()
        {
            var soma = new Soma(new Numero(10), new Numero(10));
            var subtracao = new Subtracao(new Numero(10), new Numero(10));
            var result = new Soma(soma, subtracao);

            var impressoraVisitor = new ImpressoraPreVisitor();
            result.AceitarImpressaoVisitor(impressoraVisitor);
        }

        private static void BridgeTest()
        {
            var envio = new EnviadorSms();
            var mensagem = new MensagemCliente("victor");

            mensagem.Enviador = envio;
            mensagem.Enviar();
        }

        private static void CommandTest()
        {
            var fila = new FilaPedidos();
            var pedido1 = new Pedido("Cliente1", 10);
            var pedido2 = new Pedido("Cliente2", 10);

            fila.Add(new PagarPedido(pedido1));
            fila.Add(new PagarPedido(pedido2));

            fila.Add(new FinalizarPedido(pedido1));
            fila.Add(new FinalizarPedido(pedido2));

            fila.Process();
        }

        private static void AdapterTest()
        {
            var cliente = new Adapter.Cliente { Nome = "Client", Endereco = "Endereco", DataNascimento = DateTime.UtcNow };

            // Adaptar o objeto cliente em um xml, para esse xml do cliente ser gravado posteriormente
            var xml = GeradorXmlAdapter.GerarXml(cliente);
            Console.WriteLine(xml);
        }

        private static void FacadeAndSingletonTest()
        {
            var facade = EmpresaFacadeSingleton.GetInstance();
            facade.BuscaCliente("1234");
        }

        private static void CompositeTest()
        {
            var folha1 = new Folha("folha 1");
            var folha2 = new Folha("folha 2");

            var composite1 = new Composite.Composite("composite 1");
            var composite2 = new Composite.Composite("composite 2");

            composite1.Add(composite2);
            composite2.Add(folha1);
            composite2.Add(folha2);

            composite1.GetTexto();
            Console.WriteLine("-----------------------");
            composite2.GetTexto();
        }
    }
}