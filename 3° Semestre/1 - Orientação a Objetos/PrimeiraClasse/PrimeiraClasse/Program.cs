using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorroBoni = new Cachorro();
            cachorroBoni.nome = "Boni";
            cachorroBoni.raca = "Maltez";
            cachorroBoni.idade = 2;
            cachorroBoni.peso = 3.5f;

            Cachorro cachorroJuly = new Cachorro();
            cachorroJuly.nome = "July";
            cachorroJuly.raca = "Fox Paulistinha";
            cachorroJuly.idade = 10;
            cachorroJuly.peso = 5;

            Cachorro[] cachorros = { cachorroBoni, cachorroJuly };
            
            foreach (Cachorro cachorro in cachorros)
            {
                Console.WriteLine($"Meu primeiro cachorro se chama {cachorro.nome}");
                Console.WriteLine($"Ele é da raça {cachorro.raca}");
                Console.WriteLine($"Tem {cachorro.idade} anos");
                Console.WriteLine($"E pesa {cachorro.peso}kg");
                Console.ReadKey();
            }

            cachorroBoni.Latir();
            cachorroBoni.AbanarRabo();
            cachorroJuly.Latir();
            cachorroJuly.AbanarRabo();
            Console.ReadKey();

        }
    }
}
