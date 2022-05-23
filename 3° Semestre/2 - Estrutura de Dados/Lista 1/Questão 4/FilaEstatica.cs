using System;

namespace Questão_4
{
    public class FilaEstatica
    {
        int[] fila;
        int lugarVago = -1;
        int primeiroLugar = 0;
        public FilaEstatica(int tamanho)
        {
            fila = new int[tamanho];
        }

        public void Enqueue(int item)
        {
            lugarVago++;
            if (lugarVago >= fila.Length)
            {
                Console.WriteLine("A fila está cheia");
                lugarVago--;
                return;
            }
            fila[lugarVago] = item;
        }

        public int Dequeue()
        {   
            int item = fila[primeiroLugar];
            primeiroLugar++;         
            if (primeiroLugar < 0 && primeiroLugar >= fila.Length)
            {
                Console.WriteLine("A fila está vazia");
                return -1;
            }            
            return item;
        }
    }
}
