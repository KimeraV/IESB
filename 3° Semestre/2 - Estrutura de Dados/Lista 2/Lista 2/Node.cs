using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Node
    {
        public string Nome { get; private set; }
        public int Valor { get; private set; }
        public Node Esquerda { get; private set; }
        public Node Direita { get; private set; }

        public Node(string nome, Node esquerda = null, Node direita = null)
        {
            Nome = nome;
            Esquerda = esquerda;
            Direita = direita;
        }

        public void SetValor(int novoValor) => Valor = novoValor;
    }
}
