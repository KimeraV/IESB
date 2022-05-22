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

            Carro meuGol = new Carro();

            meuGol.cor = "azul";
            meuGol.ano = 2008;
            meuGol.modelo = "Gol bola";
            meuGol.velAtual = 0f;
            meuGol.velMax = 200f;
            meuGol.ligado = false;

            Carro meuCelta = new Carro();

            meuCelta.cor = "preto";
            meuCelta.ano = 2010;
            meuCelta.modelo = "Celta Rebaixado";
            meuCelta.velAtual = 0f;
            meuCelta.velMax = 200f;
            meuCelta.ligado = false;

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

            Console.WriteLine($"É um {carroEsc.modelo}");
            Console.WriteLine($"Ele é do ano {carroEsc.ano}");
            Console.WriteLine($"Seu carro é {carroEsc.cor}");

            if (carroEsc.ligado == false)
            {
                Console.WriteLine($"Está desligado");
            }

            Console.WriteLine($"E está a  {carroEsc.velAtual}km/h");
            Console.WriteLine($"E pode chegar até  {carroEsc.velMax}km/h");

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
                                
                if(carroEsc.ligado == false)
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
