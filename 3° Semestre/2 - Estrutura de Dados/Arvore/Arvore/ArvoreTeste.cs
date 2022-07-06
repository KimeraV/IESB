using System;
using System.Collections.Generic;

namespace Arvore
{
    class ArvoreTeste
    {
        public Node Raiz { get; private set; }

        public ArvoreTeste(Node raiz)
        {
            Raiz = raiz;
        }

        public Node PreFixado(Node no)
        {
            Console.WriteLine(no.Nome);

            if(no.Esquerda == null && no.Direita == null)
            {
                return no;
            }
            return PreFixado(no.Esquerda);
        }
    }
}
