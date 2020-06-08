using System;
using System.Collections.Generic;
using System.Linq;

namespace NetPatern.App.Fiscal
{
    public class NotaFiscalBuilder
    {
        private double _valorBruto;
        private double _imposto;
        private string _razaoSocial;
        private string _cnpj;
        private string _observacao;
        private DateTime _dataEmissao = DateTime.UtcNow;
        private IList<ItemNota> _itens = new List<ItemNota>();
        private readonly NotaFiscalSubject _subject = new NotaFiscalSubject();

        public NotaFiscalBuilder(params INotaFiscalObserver[] observers) => _subject.Subscribe(observers);

        public NotaFiscalBuilder FromRazaoSocial(string razaoSocial)
        {
            _razaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder FromCnpj(string cnpj)
        {
            _cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder FromObservacao(string obs)
        {
            _observacao = obs;
            return this;
        }

        public NotaFiscalBuilder FromObservacao(DateTime data)
        {
            _dataEmissao = data;
            return this;
        }

        public NotaFiscalBuilder Add(ItemNota itemNota)
        {
            _itens.Add(itemNota);
            _valorBruto += itemNota.Valor;
            _imposto = _valorBruto * 0.05;

            return this;
        }

        public NotaFiscal Build()
        {
            var notaFiscal = new NotaFiscal(_razaoSocial, _cnpj, _dataEmissao, _valorBruto, _imposto, _itens, _observacao);
            _subject.Notify(notaFiscal);

            return notaFiscal;
        }
    }
}
