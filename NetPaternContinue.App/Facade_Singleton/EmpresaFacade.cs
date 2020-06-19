using System;

namespace NetPaternContinue.App.Facade_Singleton
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(String cpf)
        {
            return new ClienteDao().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }

    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }

    internal class Tipo
    {
        internal static object Boleto;
    }

    public class Cobranca
    {
        private object boleto;
        private Fatura fatura;

        public Cobranca(object boleto, Fatura fatura)
        {
            this.boleto = boleto;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }

    public class Fatura
    {
        private Cliente cliente;
        private double valor;

        public Fatura(Cliente cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
        }
    }

    internal class ClienteDao
    {
        public ClienteDao()
        {
        }

        internal Cliente BuscaPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }

    public class Cliente
    {
    }
}
