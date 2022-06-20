using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
public static class Program
{
    public static void Main()
    {
        char[] simbolos = { ',', '“', '.', '”', ' ', '-' };
        string[] texto = File.ReadAllLines(@"texto.txt")[0].ToLower().Split(simbolos);  

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


    }
}

