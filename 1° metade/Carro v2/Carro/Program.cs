using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroEsc = null;

            Carro meuGol = new Carro("azul", 2008, "Gol bola");

            Carro meuCelta = new Carro("azul", 2010, "Celta rebaixado");

            Console.WriteLine("Escolha um carro: ");
            Console.WriteLine("1 - Gol\n2 - Celta");

            string opcaoEsc =  Console.ReadLine();

            if (opcaoEsc == "1")
            {
                carroEsc = meuGol;
            }
            else
            {
                carroEsc = meuCelta;
            }

            Console.WriteLine($"É um {carroEsc.Modelo}");
            Console.WriteLine($"Ele é do ano {carroEsc.Ano}");
            Console.WriteLine($"Seu carro é {carroEsc.Cor}");

            if (carroEsc.Ligado == false)
            {
                Console.WriteLine($"Está desligado");
            }

            Console.WriteLine($"E está a  {carroEsc.VelAtual}km/h");
            Console.WriteLine($"E pode chegar até  {carroEsc.VelMax}km/h");

            Console.WriteLine($"Deseja ligar o carro?");
            string querLigar = Console.ReadLine();
            if (querLigar == "sim")
            {
                carroEsc.Ligar();
            }

            while (true)
            {
                string acel;
                Console.Write("1 - Acelerar\n2 - Frear\n");
                                
                if(carroEsc.Ligado == false)
                {
                    Console.Write("3 - Ligar o carro\n");
                }
                acel = Console.ReadLine();
                if (acel == "1")
                {
                    carroEsc.Acelerar();
                }
                else if (acel == "2")
                {
                    carroEsc.Frear();
                }
                else if (acel == "3")
                {
                    carroEsc.Ligar();
                }
                else
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
