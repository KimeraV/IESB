using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioEsc = null;

            Usuario bob = new Usuario();

            bob.nome = "Bob Nelson";
            bob.idade = 37;
            bob.altura = 1.70f;
            bob.peso = 78f;

            Usuario testolfo = new Usuario();

            testolfo.nome = "Testolfo Rocha";
            testolfo.idade = 43;
            testolfo.altura = 1.65f;
            testolfo.peso = 60f;

            Usuario lisa = new Usuario();

            lisa.nome = "Lisa Leite";
            lisa.idade = 22;
            lisa.altura = 1.72f;
            lisa.peso = 92f;

            Console.WriteLine("Selecione o usuário: ");
            Console.WriteLine("1 - Bob Nelson\n2 - Testolfo Rocha\n3 - Lisa Leite");

            string opcaoEsc = Console.ReadLine();

            if (opcaoEsc == "1")
            {
                usuarioEsc = bob;
            }
            else if (opcaoEsc == "2")
            {
                usuarioEsc = testolfo;
            }
            else if (opcaoEsc == "3")
            {
                usuarioEsc = lisa;
            }
            else
            {
                Console.WriteLine("Selecione uma opção válida");
                return;
            }

            Console.WriteLine($"NOME: {usuarioEsc.nome}");
            Console.WriteLine($"IDADE: {usuarioEsc.idade}");
            Console.WriteLine($"ALTURA: {usuarioEsc.altura}");
            Console.WriteLine($"PESO: {usuarioEsc.peso}");

            usuarioEsc.calcIMC();
                
            

            Console.ReadKey();

        }
    }
}
