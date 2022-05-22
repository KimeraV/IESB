using System.Collections.Generic;
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaC bob = new ContaC("Bob Nelson", "123456-6", 0f);
            ContaP test = new ContaP("Testolfo Rocha", "71717-1", 0f);
            ContaC lisa = new ContaC("Lisa Leite", "65432-1", 0f);
            
            //Console.WriteLine("CONTAS:");
            bob.Deposito(5000.00f);
            bob.MostrarSaldo();

            lisa.Deposito(2000.00f);
            lisa.MostrarSaldo();

            test.Deposito(1500.00f);
            test.MostrarSaldo();

            bob.Transferencia(test, 600.00f);

            lisa.Saque(250.00f);
            lisa.Transferencia(test, 400.00f);

            test.Transferencia(bob, 1000.00f);

            bob.Saque(900.00f);
            bob.Transferencia(lisa, 1500.00f);

            test.Transferencia(lisa, 1200.00f);

            bob.Saque(2000.00f);

            lisa.Deposito(100.00f);

            test.Transferencia(bob, 700.00f);

            bob.MostrarSaldo();
            lisa.MostrarSaldo();
            test.MostrarSaldo();
            
            Console.Beep();

        }
    }
}
