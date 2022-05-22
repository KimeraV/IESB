using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_Humano
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humanoTeste = new Humano("Bob", "Nelson");
            Console.WriteLine(humanoTeste.informNomeCompleto());
            Console.ReadLine();

            Estudante estudanteTeste = new Estudante("Testolfo", "Rocha", 8);
            estudanteTeste.primeiroNome = "Testolfo";
            estudanteTeste.ultimoNome = "Rocha";
            Console.WriteLine(estudanteTeste.informNomeCompleto());
            Console.WriteLine($"{estudanteTeste.informNomeCompleto()} Tirou a nota: {estudanteTeste.NotaFinal}");
            Console.ReadLine();

            Trabalhador trabalhadorTeste = new Trabalhador("Guei", "Zao", 5000, 160);
            trabalhadorTeste.primeiroNome = "Guei";
            trabalhadorTeste.ultimoNome = "Zao";
            Console.WriteLine(trabalhadorTeste.informNomeCompleto());
            Console.WriteLine($"{trabalhadorTeste.informNomeCompleto()} recebe por hora R${trabalhadorTeste.ValorPorHora()} trabalhando {trabalhadorTeste.HorasTrabalhadas} horas por dia e tem um salário de R${trabalhadorTeste.Salario},00");
            Console.ReadLine();
        }
    }
}
