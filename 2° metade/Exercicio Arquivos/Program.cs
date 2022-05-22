using System;
using System.IO;
using static System.IO.Directory;
using static System.IO.File;

namespace Exercicio_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //!Exercicio 1 slides Aula 4

            //*Criar arquivo sem stream e escrevendo sem stream
            string[] frutas = { "maçã", "pêra", "nuva", "tomate", "melancia" };
            //File.Create(@"Diretorio definido/frutas.txt"); cria um arquivo novo e não escreve nada
            File.AppendAllLines(@"Diretorio definido/frutas.txt", frutas); //cria um arquivo se não houver e adiciona + linhas sempre no final do arquivo existente

            //!Fim do exercicio

            //*Criar pasta (usando o static nos Using lá em cima)
            /*Directory.*/
            CreateDirectory(@"Diretorio definido\a");
            String nomeArquivo = @"Diretorio definido\a\meuArquivo.txt";

            //*Criar arquivo com stream
            Stream arquivo = File.Create(nomeArquivo);

            //*Escrevendo dentro do arquivo usando stream 
            //para criar sempre uso uma variavel tipo Stream, para escrever "arquivo" pode ser o caminho desejado ou a variavel tipo Stream do arquivo
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.Write("Lorem,Ipsum,Dolor,Sit,Amet\nSexo,Gay,Na,Rave,de,Gay");
            }
            Console.ReadKey();

            //*Renomeando arquivo
            //File.Move pode ser para mover para outro caminho também
            File.Move(@"Diretorio definido\a\meuArquivo.txt", @"Diretorio definido\a\aaaaaaaa.txt");

            //*Lendo arquivo sem stream
            //String[] nomeDoArray = File.ReadAllLines(@"") --- pega cada linha do arquivo e passa para um array
            //cada linha vira um item no array
            String[] linhasDoArquivo = File.ReadAllLines(@"Diretorio definido\a\aaaaaaaa.txt");
            foreach (string linha in linhasDoArquivo) //lendo cada linha do arquivo
            {
                //pegando cada linha e separando cada item pela virgula (',') entre eles e transformando cada separação em um item de um novo array
                string[] palavras = linha.Split(','); //criou o array palavras que pega os itens separados
                foreach (string palavraSeparada in palavras)
                {
                    Console.WriteLine(palavraSeparada); //escrevendo na tela cada item (palavra separadada) do array palavras
                }
            }

            //*Ler uma linha só usando stream
            using (StreamReader sr = new StreamReader(@"Diretorio definido\a\aaaaaaaa.txt"))
            {
                Console.WriteLine("lendo uma linha com Stream");
                Console.WriteLine(sr.ReadLine()); //não usar Read pq da numero 
            }

            //*ler todas as linhas usando stream
            using (StreamReader sr = new StreamReader(@"Diretorio definido\a\aaaaaaaa.txt"))
            {
                Console.WriteLine("lendo todas as linhas com Stream");
                Console.WriteLine(sr.ReadToEnd());
            }

            
        }

    }
}
