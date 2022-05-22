using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Carro
    {
        private string cor;
        public string Cor 
        {
            get{return this.cor;}
        }
        private int ano;
        public int Ano 
        {
            get{return this.ano;}
        }
        private string modelo;
        public string Modelo 
        {
            get{return this.modelo;}
        }
        private float velAtual;
        public float VelAtual
        {
            get{return this.velAtual;}
        }
        private float velMax;
        public float VelMax
        {
            get{return this.velMax;}
        }
        private bool ligado;
        public bool Ligado
        {
            get{return this.ligado;}
        }

        public Carro(string _cor, int _ano, string _modelo)
        {
            cor = _cor;
            ano = _ano;
            modelo = _modelo;
            velAtual = 0f;
            velMax = 200f;
            ligado = false;
        }

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
