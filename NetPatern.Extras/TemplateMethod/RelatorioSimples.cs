using System;
using System.Collections.Generic;

namespace NetPatern.Extras.TemplateMethod
{
    public class RelatorioSimples : TemplateRelatorio
    {
        public override void Cabecalho() => Console.WriteLine("Banco Test");

        public override void Corpo(List<ContaBancaria> contas) =>
            contas.ForEach(conta => Console.WriteLine($"Saldo: {conta.Saldo}, Nome: {conta.NomeTitular}"));

        public override void Rodape() => Console.WriteLine("Telefone Test");
    }
}
