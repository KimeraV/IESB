using System;
using System.IO;

namespace Questão_2
{
    public static class Program
    {
        public static void Main()
        {
            FilaDePacientes fila = new FilaDePacientes(5);

            string[] dadosDoArquivo = File.ReadAllLines("fila.txt");

            foreach (string paceinteBrunto in dadosDoArquivo)
            {
                string[] dadosDoPaceinte = paceinteBrunto.Split(',');

                fila.Enqueue(new Paciente(dadosDoPaceinte[0], dadosDoPaceinte[1]));
            }

            for (int i = 0; i < fila.Tamanho; i++)
            {
                Paciente paciente = fila.Dequeue();

                Console.WriteLine($"Nome: {paciente.Nome}\nEspecialidade: {paciente.Especialidade}");
                Console.WriteLine("******************");
            }
        }
    }
}