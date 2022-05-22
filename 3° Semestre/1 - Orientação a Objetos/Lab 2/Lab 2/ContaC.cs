using System;

namespace Lab2
{
    public class ContaC : Cliente
    {
        public ContaC(string nome, string numeroID, float saldo) : base(nome, numeroID, saldo)
        {

        }

        public override void Saque(float montante)
        {   
            float taxa = montante * 0.037f;
            base.Saque(montante - taxa);
        }

        public override void Transferencia(Cliente receptor, float montante)
        {
            float taxa = montante * 0.010f;
            base.Transferencia(receptor, montante - taxa);
        }
    }
}
