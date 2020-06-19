using System.Collections.Generic;

namespace NetPaternContinue.App.Flyweight
{
    public class NotaMusicalFlyweight
    {
        private IDictionary<string, INota> _notas = new Dictionary<string, INota>
        {
            { "do", new Do() },
            { "fa", new Fa() },
            { "la", new La() },
            { "mi", new Mi() },
            { "re", new Re() },
            { "si", new Si() },
            { "sol", new Sol() }
        };

        public INota GetNota(string keyNota) => _notas[keyNota];
    }
}
