using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCardápio
{
    class Program
    {
        static void Main(string[] args)
        {

            ItemMenu cafe = new Bebida("Café Expresso:", 2, 4, 6);
            Console.WriteLine(cafe.InformNome());
            Console.WriteLine(cafe.InformPreco());

            ItemMenu porcaoFritas = new Aperitivo("Batata Frita:", 10);
            Console.WriteLine(porcaoFritas.InformNome());
            Console.WriteLine(porcaoFritas.InformPreco());

            ItemMenu frangoPassarinho = new Aperitivo("Frango à passarinho:", 20);
            Console.WriteLine(frangoPassarinho.InformNome());
            Console.WriteLine(frangoPassarinho.InformPreco());
            Console.ReadLine();
        }
    }
}
