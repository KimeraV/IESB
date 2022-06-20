using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class ArvoreTeste
    {
        int index = 0;
        public Node Raiz { get; private set; }

        public ArvoreTeste(Node raiz)
        {
            Raiz = raiz;
        }


        public void PreOrder(Node no, List<string> listaDeValores)
        {
            if (no == null)
            {
                return; 
            }

            no.SetValor(listaDeValores[index]);
            Console.WriteLine(no.Valor);
            index++;

            PreOrder(no.Esquerda, listaDeValores);
            PreOrder(no.Direita, listaDeValores);
        }

        public void InOrder(Node no)
        {
            if (no == null)
            {
                return; 
            }

            InOrder(no.Esquerda);
            Console.WriteLine(no.Nome + " " + no.Valor);
            InOrder(no.Direita);
        }

        public void ArvoreCount()
        {
            Console.WriteLine(index);

        }
    }
}