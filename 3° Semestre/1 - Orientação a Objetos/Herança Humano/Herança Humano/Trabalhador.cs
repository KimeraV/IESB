using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_Humano
{
    class Trabalhador : Humano
    {
        private float salario;
        private float horasTrabalhadas;

        public float Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public float HorasTrabalhadas
        {
            get
            {
                return horasTrabalhadas;
            }

            set
            {
                horasTrabalhadas = value;
            }
        }

        public Trabalhador(string primeiroNome, string ultimoNome, float salario, float horasTrabalhadas):base(primeiroNome, ultimoNome)
        {
            this.salario = salario;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public float ValorPorHora()
        {
            if (horasTrabalhadas != 0)
            {
                return salario / horasTrabalhadas;
            }
            else
            {
                return 0;
            }
        }

    }
}
