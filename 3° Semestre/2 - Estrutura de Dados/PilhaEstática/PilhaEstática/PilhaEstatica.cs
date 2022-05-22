using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstática
{
    class PilhaEstatica
    {
        const String FULL_STACK = "A pilha está cheia";
        const String EMPTY_STACK = "A pilha está vazia";

        int[] elementos;
        int topo;
        int qtElementos;

        public PilhaEstatica(int qtElementos)
        {
            this.elementos = new int[qtElementos];
            this.topo = -1;
            this.qtElementos = qtElementos;
        }

        public int[] Elementos
        {
            get
            {
                return elementos;
            }

        }

        public int Topo
        {
            get
            {
                return topo;
            }

        }

        public int QtElementos
        {
            get
            {
                return qtElementos;
            }

        }

        public void Push (int numero)
        {
            if (topo <= qtElementos - 1)
            {
               topo++;
               elementos[topo] = numero;
            }
            else
            {
                throw new FullStackExeption(FULL_STACK);
            }
           
        }

        public int Pop()
        {
            if (topo > -1)
            {
                int elemento = elementos[topo];
                topo--;
                return elemento;
            }
            else
            {
                throw new EmptyStackException(EMPTY_STACK);
            }
        }

        public int Peek()
        {
            if (topo > -1)
            {
                return elementos[topo];
            }
            else
            {
                throw new EmptyStackException(EMPTY_STACK);
            }
        }
    }
}
