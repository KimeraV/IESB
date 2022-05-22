using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float altura;
        public float peso;

        public float calcIMC()
        {
            float imc = peso / (altura * altura);
            return imc;

            Console.WriteLine($"IMC: {imc}");

        }
        
    }
}
