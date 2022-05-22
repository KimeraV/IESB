using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Cachorro
    {
        //Atributos

        public string nome;
        public string raca;
        public int idade;
        public float peso;

        //Métodos

        public void Latir()
        {
            Console.WriteLine($"{nome}: AU AU");
        }
        public void AbanarRabo()
        {
            Console.WriteLine($"{nome}: *abanando o rabo*");
        }
    }
}
