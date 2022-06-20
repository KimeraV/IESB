using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questão 2 Lista 2

            List<string> listaDeValores = new List<string>() { "Acre", "Bahia", "Ceará", "Goiás", "Paraná", "Roraima", "Santa Catarina", "Sergipe", "Tocantins" };

            Node n1 = new Node("n1");
            Node n2 = new Node("n2");
            Node n3 = new Node("n3");
            Node n4 = new Node("n4");
            Node n5 = new Node("n5");
            Node n6 = new Node("n6", n2, n1);
            Node n7 = new Node("n7", n4, n3);
            Node n8 = new Node("n8", n6, n5);
            Node n9 = new Node("n9", n8, n7);

            ArvoreTeste arvore = new ArvoreTeste(n9);

            arvore.PreOrder(arvore.Raiz, listaDeValores);
            Console.ReadKey();
        }
    }
}