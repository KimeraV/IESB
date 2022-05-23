using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCardápio
{
    abstract class ItemMenu
    {
        string nome;

        public ItemMenu(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public abstract string InformPreco();
        public virtual string InformNome()
        {
            return nome;
        }
    }
}
