using System;

namespace Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaEstatica fila = new FilaEstatica(4);
            fila.Enqueue(35);
            fila.Enqueue(6);
            fila.Enqueue(21);
            fila.Enqueue(78);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Dequeue());

        }
    }
}
