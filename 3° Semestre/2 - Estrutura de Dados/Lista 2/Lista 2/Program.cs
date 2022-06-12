using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 2 Lista 2

            List<int> listaDeValores = new List<int>() { 59, 103, 48, 33, 51, 38, 79, 1, 235, 121, 223, 161 };

            Node n1 = new Node("n1");
            Node n2 = new Node("n2");
            Node n3 = new Node("n3");
            Node n4 = new Node("n4");
            Node n5 = new Node("n5");
            Node n6 = new Node("n6");
            Node n7 = new Node("n7", n1);
            Node n8 = new Node("n8", n3, n2);
            Node n9 = new Node("n9", n5, n4);
            Node n10 = new Node("n10", n9, n8);
            Node n11 = new Node("n11", n7, n6);
            Node n12 = new Node("n12", n10, n11);

            ArvoreTeste arvore = new ArvoreTeste(n12);

            arvore.PreOrder(arvore.Raiz, listaDeValores);
            Console.WriteLine("------------------------------");
            arvore.InOrder(arvore.Raiz);
            Console.WriteLine("------------------------------");
            arvore.ArvoreCount();
            Console.ReadKey();
        }
    }
}
