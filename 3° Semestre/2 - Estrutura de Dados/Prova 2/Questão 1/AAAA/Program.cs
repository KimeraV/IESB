using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] simbolos = { ',', '“', '.', '”', ' ', '-' };
            string[] texto = File.ReadAllLines(@"C:\Users\2014070036\Documents\GitHub\IESB\3° Semestre\2 - Estrutura de Dados\AAAA\AAAA\texto.txt")[0].ToLower().Split(simbolos);

            Dictionary<string, int> listaDePalavras = new Dictionary<string, int>();
            foreach (var palavra in texto)
            {
                if (listaDePalavras.ContainsKey(palavra))
                {
                    listaDePalavras[palavra] += 1;
                    continue;
                }
                for (int o = 0; o < palavra.Length; o++)
                {
                    if (palavra[o] == ',' || palavra[o] == '“' || palavra[o] == '”' || palavra[o] == '.')
                    {
                        palavra.Remove(o);
                    }
                }
                if (palavra == String.Empty)
                {
                    continue;
                }
                listaDePalavras.Add(palavra, 1);
            }
            foreach (var item in listaDePalavras)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.ReadKey();
        }

        
    }
}
