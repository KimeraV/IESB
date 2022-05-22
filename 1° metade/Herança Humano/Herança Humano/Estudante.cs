using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_Humano
{
    class Estudante:Humano
    {
        private int notaFinal;
        public int NotaFinal
        {
            get
            {
                return notaFinal;
            }

            set
            {
                notaFinal = value;
            }
        }
        public Estudante(string primeiroNome, string ultimoNome,int notaFinal):base(primeiroNome, ultimoNome)
        {
            this.notaFinal = notaFinal;
        }

        
    }
}
