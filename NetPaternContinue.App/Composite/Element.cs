using System;

namespace NetPaternContinue.App.Composite
{
    public abstract class Element : IElement
    {
        protected string _texto;

        public Element(string texto) => _texto = texto;

        public virtual void GetTexto() => Console.WriteLine(_texto);
    }
}
