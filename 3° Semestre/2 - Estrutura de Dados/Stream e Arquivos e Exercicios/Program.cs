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
            //!Implementar um programa crie o arquivo “frutas.txt” em um diretório definido e acrescente o conteúdo:
            /*
            !maçã
            !pêra
            !uva
            !tomate
            !melância
            */

            //*Criar arquivo sem stream e escrevendo sem stream
            string[] frutas = { "maçã", "pêra", "uva", "tomate", "melância" };
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

            //!Exercício 2 aula 4
            //!Implemente um programa que registre em um arquivo “contatos.csv” os dados inseridos pelo usuário: Nome, Data de nascimento e Telefone.


            Stream arquivo = File.Create("contatos.csv");
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("Nome,Data de Nascimento,Telefone");
                sw.WriteLine("Bob Nelson,24/10/1950,99655-5628");
                sw.WriteLine("Testolfo Rocha,30/05/1960,99905-7892");
            }

            //!Fim do exercicio

            //!Exercicio 3 aula 4
            //!Crie o arquivo “pontuacao.csv” com o seguinte conteúdo referente à pontuação dos jogadores em um jogo online.
            //!Leia o arquivo, e identifique o jogador com maior pontuação. 
                        
            int maxPontos = 0;

            Stream arquivo = File.Create("pontuacao.csv");
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("Nome,Pontos");
                sw.WriteLine("Bob Nelson,5628");
                sw.WriteLine("Testolfo Rocha,7892");
                sw.WriteLine("Cláudio Castelo, 6655");
                sw.WriteLine("Mário Armário, 5109");
            }

            string[] jogadores = File.ReadAllLines(@"pontuacao.csv");
            for (int i = 1; i < jogadores.Length; i++)
            {
                string[] dados = jogadores[i].Split(',');
                int pontuacao = int.Parse(dados[1]);
                Console.WriteLine($"nome: {dados[0]} pontuação: {dados[1]}");
                if(pontuacao > maxPontos)
                {
                    maxPontos = pontuacao;
                }
            }
            Console.WriteLine(maxPontos);

            //!Fim do exercicio

            //!Exercicio 4 aula 4
            //!Implemente um programa que registre as opções de lanche escolhidas por um usuário, bem como o horário que se deu tal escolha. 
            //!Para o programa, considerar que são 3 tipos de lanches possíveis, identificados como “LancheA”, “LancheB” e “LancheC” e o usuário deve inserir seu nome.


            EscolherPedido();

            void EscolherPedido()
            {
                string data = DateTime.Now.ToString(); //funções de data
                string nomeDoUsuario;
                string texto;
                int escolhido = 0;

                Console.WriteLine("Digite 1 para escolher o LancheA\nDigite 2 para escolher o LancheB\nDigite 3 para escolher o LancheC");
                try
                {
                    escolhido = int.Parse(Console.ReadLine());  
                }
                catch (System.FormatException) //exception pra se colocar texto no lugar dos números
                {
                    Console.WriteLine("Digite um número");
                    EscolherPedido();
                    throw;
                }
                
                switch (escolhido)
                {
                    case 1:
                        Console.WriteLine("Digite o seu nome");
                        nomeDoUsuario = Console.ReadLine();

                        texto = $"{nomeDoUsuario},LancheA,{data}\n";
                        File.AppendAllText("Registro.csv", texto);
                        break;

                    case 2:
                        Console.WriteLine("Digite o seu nome");
                        nomeDoUsuario = Console.ReadLine();

                        texto = $"{nomeDoUsuario},LancheB,{data}\n";
                        File.AppendAllText("Registro.csv", texto);
                        break;

                    case 3:
                        Console.WriteLine("Digite o seu nome");
                        nomeDoUsuario = Console.ReadLine();

                        texto = $"{nomeDoUsuario},LancheC,{data}\n";
                        File.AppendAllText("Registro.csv", texto);
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        EscolherPedido();
                        break;
                }
            }

             //!Fim do exercicio
        }

    }
}
