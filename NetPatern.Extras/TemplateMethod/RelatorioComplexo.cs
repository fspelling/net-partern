using System;
using System.Collections.Generic;

namespace NetPatern.Extras.TemplateMethod
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        public override void Cabecalho() => Console.WriteLine("Banco Test, Endereco Test, Telefone Test");

        public override void Corpo(List<ContaBancaria> contas)
        {
            var props = typeof(ContaBancaria).GetProperties();
            var indice = 0;
            var result = string.Empty;

            foreach (var prop in props)
            {
                var nameConta = prop.Name;
                var valueConta = prop.GetValue(contas[indice]);

                result += $"{nameConta}: {valueConta}, ";
            }

            Console.WriteLine(result.Substring(0, result.LastIndexOf(",")));
        }

        public override void Rodape() => Console.WriteLine($"Email Test, Data {DateTime.UtcNow}");
    }
}
