using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamca
{
    class Node
    {
        String dado;
        Node elo;

        public Node(string dado)
        {
            this.dado = dado;
            this.elo = null;
        }

        public string Dado
        {
            get
            {
                return dado;
            }

            set
            {
                dado = value;
            }
        }

        public Node Elo
        {
            get
            {
                return elo;
            }

            set
            {
                elo = value;
            }
        }
    }
}
