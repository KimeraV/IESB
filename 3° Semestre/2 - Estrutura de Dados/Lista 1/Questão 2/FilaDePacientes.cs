using System;

namespace Questão_2
{
    public class FilaDePacientes
    {
        Paciente[] fila;
        int lugarVago = -1;
        int primeiroLugar = 0;
        public int Tamanho { get; private set; }
        public FilaDePacientes(int tamanho)
        {
            fila = new string[tamanho];
            Tamanho = tamanho;
        }

        public void Enqueue(Paciente paciente)
        {
            lugarVago++;
            if (lugarVago >= fila.Length)
            {
                Console.WriteLine("A fila está cheia");
                lugarVago--;
                return;
            }
            fila[lugarVago] = paciente;
        }

        public Paciente Dequeue()
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