using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Polimorfismo
{
    class Produto
    {
        private float preco;

        public Produto(float preco)
        {
            this.preco = preco;
        }

        public float Preco
        {
            get
            {
                return preco;
            }
        }

        public virtual string DescricaoINFO()
        {
            return "Item da loja";
        }

        public string PrecoINFO()
        {
            return Preco.ToString("C");
        }

    }
}
