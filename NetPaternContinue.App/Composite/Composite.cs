using System.Collections.Generic;
using System.Linq;

namespace NetPaternContinue.App.Composite
{
    public class Composite : Element
    {
        private IList<Element> _elements = new List<Element>();

        public Composite(string texto) : base(texto) { }

        public void Add(Element element) => _elements.Add(element);

        public void Remove(Element element) => _elements.Remove(element);

        public override void GetTexto()
        {
            base.GetTexto();
            _elements.ToList().ForEach(element => element.GetTexto());
        }
    }
}
