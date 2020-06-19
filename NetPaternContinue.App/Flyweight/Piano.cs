using System;
using System.Collections.Generic;
using System.Linq;

namespace NetPaternContinue.App.Flyweight
{
    public static class Piano
    {
        public static void Tocar(IList<INota> notas) => 
            notas.ToList().ForEach(n => Console.Beep(n.Frequencia, 300));
    }
}
