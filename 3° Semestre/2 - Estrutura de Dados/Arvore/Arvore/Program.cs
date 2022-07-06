using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            Node d = new Node("D");
            Node e = new Node("E");
            Node g = new Node("G");
            Node b = new Node("B", d, e);
            Node f = new Node("F", direita: g);
            Node c = new Node("C", f);
            Node a = new Node("A", b, c);

            ArvoreTeste arvore = new ArvoreTeste(a);
            arvore.PreFixado(arvore.Raiz);

            Console.ReadKey();
        }
    }
}
