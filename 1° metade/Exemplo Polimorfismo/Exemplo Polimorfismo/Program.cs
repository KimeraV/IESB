using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoDigital jogoMHW = new JogoDigital("Capcom", "Monster Hunter World", "Playstation 4", 120.00f);
            JogoDigital jogoHalo = new JogoDigital("Microsoft", "Halo 5", "Xbox One", 100.00f);

            Livro livroMetropolis = new Livro("Metropolis", "Thea Von Harbour", 100.00f);
            Livro livroOIluminado = new Livro("O Iluminado", "Stephen King", 50.00f);


            Console.WriteLine("Catálogo da loja:");

            Console.WriteLine($"{jogoMHW.DescricaoINFO()}");
            Console.WriteLine($"Valor:{jogoMHW.PrecoINFO()}");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"{jogoHalo.DescricaoINFO()}");
            Console.WriteLine($"Valor:{jogoHalo.PrecoINFO()}");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"{livroMetropolis.DescricaoINFO()}");
            Console.WriteLine($"Valor:{livroMetropolis.PrecoINFO()}");

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"{livroOIluminado.DescricaoINFO()}");
            Console.WriteLine($"Valor:{livroOIluminado.PrecoINFO()}");

            Console.WriteLine("---------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
