using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCardápio
{
    class Bebida : ItemMenu
    {
        double precoP;
        double precoM;
        double precoG;

        public Bebida(string nome, double precoP, double precoM, double precoG):base(nome)
        {
            this.precoP = precoP;
            this.precoM = precoM;
            this.precoG = precoG;
        }

        public double PrecoP
        {
            get
            {
                return precoP;
            }

        }

        public double PrecoM
        {
            get
            {
                return precoM;
            }

        }

        public double PrecoG
        {
            get
            {
                return precoG;
            }

        }

        public override string InformPreco()
        {

            return($"Tamanho Pequeno: {precoP.ToString("C")} \n" +
                   $"Tamanho Médio: {precoM.ToString("C")} \n" +
                   $"Tamanho Grande: {precoG.ToString("C")} \n");
        }
    }
}
