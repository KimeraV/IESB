using System.Collections.Generic;
using System;

namespace Questão_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERIFICADOR DE PALÍNDROMOS");
            Console.WriteLine("Insira uma palavra");
            string palavraAVerificar = Console.ReadLine();

            if (EPalindromo(palavraAVerificar))
            {
                Console.WriteLine($"A palavra: {palavraAVerificar} é um palíndromo");
            }
            else
            {
                Console.WriteLine($"A palavra: {palavraAVerificar} não é um palíndromo");
            }
        }

        static bool EPalindromo(string palavra)
        {
            Stack<char> pilhaDeLetras = new Stack<char>();
            string palavraInvertida = "";
            foreach (var letra in palavra)
            {
                pilhaDeLetras.Push(letra);
            }
            for (int i = 0; i < palavra.Length; i++)
            {
                palavraInvertida += pilhaDeLetras.Pop();
            }
            if (palavraInvertida == palavra)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
