using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCardápio
{
    class Aperitivo : ItemMenu
    {
        double precoPorcao;

        public Aperitivo(string nome, double precoPorcao):base(nome)
        {
            this.precoPorcao = precoPorcao;
        }

        public double PrecoPorcao
        {
            get
            {
                return precoPorcao;
            }

        }

        public override string InformPreco()
        {

            return ($"Preço da porção: {precoPorcao.ToString("C")}");

        }
    }
}
