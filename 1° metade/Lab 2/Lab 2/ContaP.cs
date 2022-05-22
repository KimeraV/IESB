using System;

namespace Lab2
{
    public class ContaP : Cliente
    {
        public ContaP(string nome, string numeroID, float saldo) : base(nome, numeroID, saldo)
        {

        }

        public override void Saque(float montante)
        {   
            float taxa = montante * 0.020f;
            base.Saque(montante - taxa);
        }

        public override void Transferencia(Cliente receptor, float montante)
        {
            float taxa = montante * 0.015f;
            base.Transferencia(receptor, montante - taxa);
        }
    }
}
