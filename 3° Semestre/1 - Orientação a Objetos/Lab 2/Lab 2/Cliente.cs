using System.Diagnostics;
using System;

namespace Lab2
{
    public abstract class Cliente
    {
        public string Nome { get; }
        public string NumeroID { get; }
        public float Saldo { get; private set; }

        protected Cliente(string nome, string numeroID, float saldo)
        {
            Nome = nome;
            NumeroID = numeroID;
            Saldo = saldo;
        }

        public virtual void Deposito(float montante)
        {
            if (montante <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Nome}: Depósito não realizado por: valor inválido");
                Console.ResetColor();
                return;
            }
            Saldo += montante;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Nome} depositou R${montante}");
            Console.ResetColor();
        }

        public virtual void Transferencia(Cliente receptor, float montante)
        {
            float saldoTemp = Saldo - montante;

            if (Saldo <= 0 || saldoTemp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Nome}: Transferência NEGADA por: saldo insuficiente ");
                Console.ResetColor();
                return;
            }

            Saldo -= montante;
            receptor.Saldo += montante;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Nome} transferiu R${montante} para {receptor.Nome}");
            Console.ResetColor();
        }

        public virtual void Saque(float montante)
        {
            float saldoTemp = Saldo - montante;

            if (Saldo <= 0 || saldoTemp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Nome}: saque NEGADO por: saldo insuficiente ");
                Console.ResetColor();
                return;
            }

            Saldo -= montante;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{Nome} sacou R${montante}");
            Console.ResetColor();

        }

        public void MostrarSaldo()
        {          
            Console.WriteLine($"{Nome}: Saldo: R${Saldo:N2}");
        }

    }
}
