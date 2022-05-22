using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstática
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                PilhaEstatica minhaPilha = new PilhaEstatica(3);
                
                minhaPilha.Push(10);
                minhaPilha.Push(75);
                minhaPilha.Push(8);
                Console.WriteLine($"Número retirado:{minhaPilha.Pop()}");
                Console.WriteLine($"Número retirado:{minhaPilha.Pop()}");
                minhaPilha.Push(100);
                Console.WriteLine($"Número retirado:{minhaPilha.Pop()}");

            } catch(FullStackExeption fse)
            {
                Console.WriteLine(fse.Message);
            }
            
            Console.ReadLine();
        }
    }
}
