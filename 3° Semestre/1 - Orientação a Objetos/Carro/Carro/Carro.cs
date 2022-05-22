using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Carro
    {
        public string cor;
        public int ano;
        public string modelo;
        public float velAtual;
        public float velMax;
        public bool ligado;

        public void Ligar()
        {
            ligado = true;
            Console.WriteLine($"{modelo}: Está ligado");
        }
        public void Acelerar()
        {
            if (!ligado)
            {
                Console.WriteLine($"{modelo}: está desligado, ligue o carro para acelerar");
                return;
            }
            if (velAtual != velMax)
            {
                velAtual += 20f;
            }
            Console.WriteLine($"{modelo}: velocidade atual: {velAtual}km/h");
            if (velAtual == velMax)
            {
                Console.WriteLine($"{modelo}: alcançou sua velocidade máxima ");
            }
        }
        public void Frear()
        {
            if (!ligado)
            {
                Console.WriteLine($"{modelo}: está desligado, ligue o carro para frear");
                return;
            }
            if (velAtual <= 0)
            {
                Console.WriteLine($"{modelo}: está parado");
                return;
            }
            if (velAtual != 0)
            {
                velAtual -= 20f;
            }
            Console.WriteLine($"{modelo}: velocidade atual: {velAtual}km/h");
        }
    }
}
