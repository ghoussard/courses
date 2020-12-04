using System;
using System.Collections.Generic;
using System.Text;

namespace Banque
{
    class CompteADecouvertAutorisé : Compte
    {
        private int _decouvertAutorisé;

        public int DecouvertAutorisé
        {
            get => _decouvertAutorisé;
            set => _decouvertAutorisé = value;
        }

        public CompteADecouvertAutorisé(int numéro, Client client, int decouvertAutorisé) : base(numéro, client)
        {
            _decouvertAutorisé = decouvertAutorisé;
        }

        public override void Retirer(int montant)
        {
            if (montant < 1)
            {
                throw new MontantInvalide();
            }

            int soldeAprèsRetrait = _solde - montant;

            if (soldeAprèsRetrait < -DecouvertAutorisé)
            {
                throw new MontantExcessif();
            }

            _solde = soldeAprèsRetrait;
        }
    }
}
